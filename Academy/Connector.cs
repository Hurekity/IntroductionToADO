﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy
{
    internal class Connector
    {
        string connectionString;
        SqlConnection connection;
        SqlDataReader reader;
       public DataTable DataTable { get; set; }

        public Connector()
        {
            connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            connection = new SqlConnection(connectionString);

        }
        public DataTable LoadColumnFromTable(string column, string table, string condition=null)
        {
            connection.Open();
            string query = $@"SELECT {column} FROM {table}";
            if (condition != null )
            {
                query += $" WHERE {condition}";
            }
            Console.WriteLine("       CONNECTOR:");
            Console.WriteLine( query );
            Console.WriteLine( "---------------------------" );
            SqlCommand command = new SqlCommand(query, connection);
            reader = command.ExecuteReader();
            DataTable = new DataTable();
            for (int i=0; i<reader.FieldCount; i++)DataTable.Columns.Add(reader.GetName(i));
            while (reader.Read()) 
            {
                DataRow row = DataTable.NewRow();
                for (int i=0; i<reader.FieldCount; i++) row[i] = reader[i];
                DataTable.Rows.Add(row);
            }
            connection.Close();
            return DataTable;
        }
    }
}
