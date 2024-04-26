﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Police_DB321
{
    public partial class MainForm : Form
    {
        string connectionString;
        SqlConnection connection;
        SqlDataAdapter adapter;
        SqlCommandBuilder builder;
        DataSet set;
        public MainForm()
        {
            InitializeComponent();
            buttonAlterViolation.Enabled = false;

            connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            connection = new SqlConnection(connectionString);
            set = new DataSet();
            LoadViolations();
        }
        void LoadViolations()
        {
            string query = "SELECT * FROM Violations";
            adapter = new SqlDataAdapter(query, connection);
            builder = new SqlCommandBuilder(adapter);
            adapter.Fill(set, "Violations");
            dataGridViewViolations.DataSource = set.Tables[0];
            
            query = "SELECT * FROM ResponsibilityTypes";
            builder.DataAdapter.SelectCommand.CommandText = query; 
            adapter.Fill(set, "ResponsibilityTypes");
            comboBoxViolationType.Items.Add("Все типы");
            for (int i = 0; i < set.Tables[1].Rows.Count; i++) 
            {
                comboBoxViolationType.Items.Add(set.Tables[1].Rows[i].ItemArray[1].ToString());
            }
            comboBoxViolationType.SelectedIndex = 0;

            builder.DataAdapter.SelectCommand.CommandText = "SELECT * FROM ViolationsResponsibilitiesRelation";
            adapter.Fill(set, " ViolationsResponsibilitiesRelation");
        }


        private void buttonAddViolation_Click(object sender, EventArgs e)
        {
            adapter.Update(set, "Violations");
        }

        private void comboBoxViolationType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxViolationType.SelectedIndex == 0)
            {
                dataGridViewViolations.DataSource = set.Tables[0];
            }
            else
            {
                //                string filter = $@" ViolationsResponsibilitiesRelation.violation = Violations.violation_id
                //AND  ViolationsResponsibilitiesRelation.responsibility = ResponsibilityTypes.type_id
                //AND  ResponsibilityTypes.type_id = {comboBoxViolationType.SelectedIndex}";
                //                DataRow[] results = set.Tables[0].Select(filter);
                //                dataGridViewViolations.DataSource = results;
                builder.DataAdapter.SelectCommand.CommandText = $@"
SELECT
 violation_description,
penalty,
duration
FROM Violations
JOIN ViolationsResponsibilitiesRelation ON (violation = violation_id)
WHERE responsibility = {comboBoxViolationType.SelectedIndex}";
                set.Tables["ViolationsByType"]?.Clear();
                adapter.Fill(set, "ViolationsByType");
                dataGridViewViolations.DataSource = set.Tables["ViolationsByType"];
               
            }
        }
    }
}
