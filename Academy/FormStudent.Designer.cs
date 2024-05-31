namespace Academy
{
    partial class FormStudent
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelMiddleName = new System.Windows.Forms.Label();
            this.richTextBoxLastName = new System.Windows.Forms.RichTextBox();
            this.richTextBoxFirstName = new System.Windows.Forms.RichTextBox();
            this.richTextBoxMiddleName = new System.Windows.Forms.RichTextBox();
            this.label = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.tableLayoutPanelStudent = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.comboBoxGroup = new System.Windows.Forms.ComboBox();
            this.labelDirection = new System.Windows.Forms.Label();
            this.labelGroup = new System.Windows.Forms.Label();
            this.comboBoxDirection = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.richTextBoxPhone = new System.Windows.Forms.RichTextBox();
            this.richTextBoxEmail = new System.Windows.Forms.RichTextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.pictureBoxPhoto = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanelStudent.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // labelLastName
            // 
            this.labelLastName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(99, 9);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(59, 13);
            this.labelLastName.TabIndex = 0;
            this.labelLastName.Text = "Фамилия:";
            this.labelLastName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelFirstName
            // 
            this.labelFirstName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(126, 41);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(32, 13);
            this.labelFirstName.TabIndex = 1;
            this.labelFirstName.Text = "Имя:";
            this.labelFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelMiddleName
            // 
            this.labelMiddleName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelMiddleName.AutoSize = true;
            this.labelMiddleName.Location = new System.Drawing.Point(98, 73);
            this.labelMiddleName.Name = "labelMiddleName";
            this.labelMiddleName.Size = new System.Drawing.Size(60, 13);
            this.labelMiddleName.TabIndex = 2;
            this.labelMiddleName.Text = "Отчество: ";
            this.labelMiddleName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // richTextBoxLastName
            // 
            this.richTextBoxLastName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.richTextBoxLastName.Location = new System.Drawing.Point(164, 6);
            this.richTextBoxLastName.MaxLength = 128;
            this.richTextBoxLastName.Multiline = false;
            this.richTextBoxLastName.Name = "richTextBoxLastName";
            this.richTextBoxLastName.Size = new System.Drawing.Size(236, 19);
            this.richTextBoxLastName.TabIndex = 3;
            this.richTextBoxLastName.Text = "";
            // 
            // richTextBoxFirstName
            // 
            this.richTextBoxFirstName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.richTextBoxFirstName.Location = new System.Drawing.Point(164, 38);
            this.richTextBoxFirstName.MaxLength = 128;
            this.richTextBoxFirstName.Multiline = false;
            this.richTextBoxFirstName.Name = "richTextBoxFirstName";
            this.richTextBoxFirstName.Size = new System.Drawing.Size(236, 19);
            this.richTextBoxFirstName.TabIndex = 4;
            this.richTextBoxFirstName.Text = "";
            // 
            // richTextBoxMiddleName
            // 
            this.richTextBoxMiddleName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.richTextBoxMiddleName.Location = new System.Drawing.Point(164, 70);
            this.richTextBoxMiddleName.MaxLength = 128;
            this.richTextBoxMiddleName.Name = "richTextBoxMiddleName";
            this.richTextBoxMiddleName.Size = new System.Drawing.Size(236, 19);
            this.richTextBoxMiddleName.TabIndex = 5;
            this.richTextBoxMiddleName.Text = "";
            // 
            // label
            // 
            this.label.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(69, 106);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(89, 13);
            this.label.TabIndex = 6;
            this.label.Text = "Дата рождения:";
            this.label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePicker1.Location = new System.Drawing.Point(186, 103);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(191, 20);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // tableLayoutPanelStudent
            // 
            this.tableLayoutPanelStudent.ColumnCount = 2;
            this.tableLayoutPanelStudent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanelStudent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanelStudent.Controls.Add(this.labelLastName, 0, 0);
            this.tableLayoutPanelStudent.Controls.Add(this.dateTimePicker1, 1, 3);
            this.tableLayoutPanelStudent.Controls.Add(this.richTextBoxLastName, 1, 0);
            this.tableLayoutPanelStudent.Controls.Add(this.label, 0, 3);
            this.tableLayoutPanelStudent.Controls.Add(this.richTextBoxMiddleName, 1, 2);
            this.tableLayoutPanelStudent.Controls.Add(this.richTextBoxFirstName, 1, 1);
            this.tableLayoutPanelStudent.Controls.Add(this.labelMiddleName, 0, 2);
            this.tableLayoutPanelStudent.Controls.Add(this.labelFirstName, 0, 1);
            this.tableLayoutPanelStudent.Location = new System.Drawing.Point(12, 13);
            this.tableLayoutPanelStudent.Name = "tableLayoutPanelStudent";
            this.tableLayoutPanelStudent.RowCount = 4;
            this.tableLayoutPanelStudent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelStudent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelStudent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelStudent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelStudent.Size = new System.Drawing.Size(403, 130);
            this.tableLayoutPanelStudent.TabIndex = 8;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.Controls.Add(this.comboBoxGroup, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelDirection, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelGroup, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.comboBoxDirection, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 214);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(403, 67);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // comboBoxGroup
            // 
            this.comboBoxGroup.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.comboBoxGroup.FormattingEnabled = true;
            this.comboBoxGroup.Location = new System.Drawing.Point(164, 6);
            this.comboBoxGroup.Name = "comboBoxGroup";
            this.comboBoxGroup.Size = new System.Drawing.Size(236, 21);
            this.comboBoxGroup.TabIndex = 10;
            // 
            // labelDirection
            // 
            this.labelDirection.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelDirection.AutoSize = true;
            this.labelDirection.Location = new System.Drawing.Point(31, 10);
            this.labelDirection.Name = "labelDirection";
            this.labelDirection.Size = new System.Drawing.Size(127, 13);
            this.labelDirection.TabIndex = 10;
            this.labelDirection.Text = "Направление обучения:";
            // 
            // labelGroup
            // 
            this.labelGroup.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelGroup.AutoSize = true;
            this.labelGroup.Location = new System.Drawing.Point(113, 43);
            this.labelGroup.Name = "labelGroup";
            this.labelGroup.Size = new System.Drawing.Size(45, 13);
            this.labelGroup.TabIndex = 10;
            this.labelGroup.Text = "Группа:";
            // 
            // comboBoxDirection
            // 
            this.comboBoxDirection.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.comboBoxDirection.FormattingEnabled = true;
            this.comboBoxDirection.Location = new System.Drawing.Point(164, 39);
            this.comboBoxDirection.Name = "comboBoxDirection";
            this.comboBoxDirection.Size = new System.Drawing.Size(236, 21);
            this.comboBoxDirection.TabIndex = 10;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel2.Controls.Add(this.richTextBoxPhone, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.richTextBoxEmail, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.labelEmail, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.labelPhone, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 149);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(400, 59);
            this.tableLayoutPanel2.TabIndex = 10;
            // 
            // richTextBoxPhone
            // 
            this.richTextBoxPhone.Location = new System.Drawing.Point(163, 32);
            this.richTextBoxPhone.MaxLength = 17;
            this.richTextBoxPhone.Multiline = false;
            this.richTextBoxPhone.Name = "richTextBoxPhone";
            this.richTextBoxPhone.Size = new System.Drawing.Size(234, 24);
            this.richTextBoxPhone.TabIndex = 11;
            this.richTextBoxPhone.Text = "";
            this.richTextBoxPhone.WordWrap = false;
            // 
            // richTextBoxEmail
            // 
            this.richTextBoxEmail.Location = new System.Drawing.Point(163, 3);
            this.richTextBoxEmail.MaxLength = 256;
            this.richTextBoxEmail.Multiline = false;
            this.richTextBoxEmail.Name = "richTextBoxEmail";
            this.richTextBoxEmail.Size = new System.Drawing.Size(234, 23);
            this.richTextBoxEmail.TabIndex = 11;
            this.richTextBoxEmail.Text = "";
            this.richTextBoxEmail.WordWrap = false;
            // 
            // labelEmail
            // 
            this.labelEmail.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(119, 8);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(38, 13);
            this.labelEmail.TabIndex = 11;
            this.labelEmail.Text = "E-mail:";
            // 
            // labelPhone
            // 
            this.labelPhone.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new System.Drawing.Point(102, 37);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(55, 13);
            this.labelPhone.TabIndex = 12;
            this.labelPhone.Text = "Телефон:";
            // 
            // buttonSave
            // 
            this.buttonSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonSave.Location = new System.Drawing.Point(431, 252);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 12;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(512, 253);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 13;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Location = new System.Drawing.Point(512, 220);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(75, 23);
            this.buttonBrowse.TabIndex = 14;
            this.buttonBrowse.Text = "Обзор";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            // 
            // pictureBoxPhoto
            // 
            this.pictureBoxPhoto.BackgroundImage = global::Academy.Properties.Resources._2;
            this.pictureBoxPhoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxPhoto.Location = new System.Drawing.Point(439, 19);
            this.pictureBoxPhoto.Name = "pictureBoxPhoto";
            this.pictureBoxPhoto.Size = new System.Drawing.Size(130, 180);
            this.pictureBoxPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPhoto.TabIndex = 11;
            this.pictureBoxPhoto.TabStop = false;
            // 
            // FormStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 287);
            this.Controls.Add(this.buttonBrowse);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.pictureBoxPhoto);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tableLayoutPanelStudent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormStudent";
            this.Text = "Студент";
            this.tableLayoutPanelStudent.ResumeLayout(false);
            this.tableLayoutPanelStudent.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labelMiddleName;
        private System.Windows.Forms.RichTextBox richTextBoxLastName;
        private System.Windows.Forms.RichTextBox richTextBoxFirstName;
        private System.Windows.Forms.RichTextBox richTextBoxMiddleName;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelStudent;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelDirection;
        private System.Windows.Forms.Label labelGroup;
        private System.Windows.Forms.ComboBox comboBoxGroup;
        private System.Windows.Forms.ComboBox comboBoxDirection;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.RichTextBox richTextBoxPhone;
        private System.Windows.Forms.RichTextBox richTextBoxEmail;
        private System.Windows.Forms.PictureBox pictureBoxPhoto;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonBrowse;
    }
}