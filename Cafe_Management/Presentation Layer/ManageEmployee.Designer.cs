
namespace Cafe_Management.Presentation_Layer
{
    partial class ManageEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageEmployee));
            this.addEmployeeButton = new System.Windows.Forms.Button();
            this.updateInfoButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listOfEmployeesGridView = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.updateBirthDateTextBox = new System.Windows.Forms.TextBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.updateUserTypeComboBox = new System.Windows.Forms.ComboBox();
            this.updateGenderComboBox = new System.Windows.Forms.ComboBox();
            this.updateNameTextBox = new System.Windows.Forms.TextBox();
            this.updateUsernameTextBox = new System.Windows.Forms.TextBox();
            this.updateEmailTextBox = new System.Windows.Forms.TextBox();
            this.updatePasswoedTextBox = new System.Windows.Forms.TextBox();
            this.updatePhoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.updateEmployeeIdTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.searchEmployeeNameTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.searchEmployeeGridView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listOfEmployeesGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchEmployeeGridView)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // addEmployeeButton
            // 
            this.addEmployeeButton.BackColor = System.Drawing.Color.White;
            this.addEmployeeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addEmployeeButton.BackgroundImage")));
            this.addEmployeeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.addEmployeeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEmployeeButton.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.addEmployeeButton.Location = new System.Drawing.Point(120, 99);
            this.addEmployeeButton.Name = "addEmployeeButton";
            this.addEmployeeButton.Size = new System.Drawing.Size(105, 48);
            this.addEmployeeButton.TabIndex = 0;
            this.addEmployeeButton.UseVisualStyleBackColor = false;
            this.addEmployeeButton.Click += new System.EventHandler(this.addEmployeeButton_Click);
            // 
            // updateInfoButton
            // 
            this.updateInfoButton.BackColor = System.Drawing.Color.Silver;
            this.updateInfoButton.ForeColor = System.Drawing.Color.Black;
            this.updateInfoButton.Location = new System.Drawing.Point(59, 388);
            this.updateInfoButton.Name = "updateInfoButton";
            this.updateInfoButton.Size = new System.Drawing.Size(95, 35);
            this.updateInfoButton.TabIndex = 4;
            this.updateInfoButton.Text = "Update";
            this.updateInfoButton.UseVisualStyleBackColor = false;
            this.updateInfoButton.Click += new System.EventHandler(this.updateInfoButton_Click);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.SystemColors.HighlightText;
            this.backButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backButton.BackgroundImage")));
            this.backButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.backButton.Location = new System.Drawing.Point(1025, 638);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(70, 32);
            this.backButton.TabIndex = 5;
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listOfEmployeesGridView);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(505, 99);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(590, 248);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "List of Employees";
            // 
            // listOfEmployeesGridView
            // 
            this.listOfEmployeesGridView.AllowUserToAddRows = false;
            this.listOfEmployeesGridView.AllowUserToDeleteRows = false;
            this.listOfEmployeesGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.listOfEmployeesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listOfEmployeesGridView.Location = new System.Drawing.Point(29, 42);
            this.listOfEmployeesGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listOfEmployeesGridView.Name = "listOfEmployeesGridView";
            this.listOfEmployeesGridView.ReadOnly = true;
            this.listOfEmployeesGridView.RowHeadersWidth = 62;
            this.listOfEmployeesGridView.Size = new System.Drawing.Size(522, 173);
            this.listOfEmployeesGridView.TabIndex = 0;
            this.listOfEmployeesGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listOfEmployeesGridView_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.updateBirthDateTextBox);
            this.groupBox2.Controls.Add(this.deleteButton);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.updateUserTypeComboBox);
            this.groupBox2.Controls.Add(this.updateGenderComboBox);
            this.groupBox2.Controls.Add(this.updateNameTextBox);
            this.groupBox2.Controls.Add(this.updateInfoButton);
            this.groupBox2.Controls.Add(this.updateUsernameTextBox);
            this.groupBox2.Controls.Add(this.updateEmailTextBox);
            this.groupBox2.Controls.Add(this.updatePasswoedTextBox);
            this.groupBox2.Controls.Add(this.updatePhoneNumberTextBox);
            this.groupBox2.Controls.Add(this.updateEmployeeIdTextBox);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.groupBox2.Location = new System.Drawing.Point(37, 200);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(371, 441);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Update Employee Data";
            // 
            // updateBirthDateTextBox
            // 
            this.updateBirthDateTextBox.Location = new System.Drawing.Point(146, 164);
            this.updateBirthDateTextBox.Name = "updateBirthDateTextBox";
            this.updateBirthDateTextBox.Size = new System.Drawing.Size(130, 30);
            this.updateBirthDateTextBox.TabIndex = 18;
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.Silver;
            this.deleteButton.ForeColor = System.Drawing.Color.Crimson;
            this.deleteButton.Location = new System.Drawing.Point(217, 389);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(91, 34);
            this.deleteButton.TabIndex = 12;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(35, 164);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 20);
            this.label9.TabIndex = 17;
            this.label9.Text = "Birth Date";
            // 
            // updateUserTypeComboBox
            // 
            this.updateUserTypeComboBox.FormattingEnabled = true;
            this.updateUserTypeComboBox.Items.AddRange(new object[] {
            "admin",
            "employee"});
            this.updateUserTypeComboBox.Location = new System.Drawing.Point(146, 296);
            this.updateUserTypeComboBox.Name = "updateUserTypeComboBox";
            this.updateUserTypeComboBox.Size = new System.Drawing.Size(130, 33);
            this.updateUserTypeComboBox.TabIndex = 16;
            // 
            // updateGenderComboBox
            // 
            this.updateGenderComboBox.FormattingEnabled = true;
            this.updateGenderComboBox.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.updateGenderComboBox.Location = new System.Drawing.Point(146, 262);
            this.updateGenderComboBox.Name = "updateGenderComboBox";
            this.updateGenderComboBox.Size = new System.Drawing.Size(130, 33);
            this.updateGenderComboBox.TabIndex = 15;
            // 
            // updateNameTextBox
            // 
            this.updateNameTextBox.Location = new System.Drawing.Point(146, 84);
            this.updateNameTextBox.Name = "updateNameTextBox";
            this.updateNameTextBox.Size = new System.Drawing.Size(130, 30);
            this.updateNameTextBox.TabIndex = 14;
            // 
            // updateUsernameTextBox
            // 
            this.updateUsernameTextBox.Location = new System.Drawing.Point(146, 127);
            this.updateUsernameTextBox.Name = "updateUsernameTextBox";
            this.updateUsernameTextBox.Size = new System.Drawing.Size(130, 30);
            this.updateUsernameTextBox.TabIndex = 13;
            // 
            // updateEmailTextBox
            // 
            this.updateEmailTextBox.Location = new System.Drawing.Point(146, 196);
            this.updateEmailTextBox.Name = "updateEmailTextBox";
            this.updateEmailTextBox.Size = new System.Drawing.Size(130, 30);
            this.updateEmailTextBox.TabIndex = 12;
            // 
            // updatePasswoedTextBox
            // 
            this.updatePasswoedTextBox.Location = new System.Drawing.Point(146, 337);
            this.updatePasswoedTextBox.Name = "updatePasswoedTextBox";
            this.updatePasswoedTextBox.Size = new System.Drawing.Size(130, 30);
            this.updatePasswoedTextBox.TabIndex = 11;
            // 
            // updatePhoneNumberTextBox
            // 
            this.updatePhoneNumberTextBox.Location = new System.Drawing.Point(146, 230);
            this.updatePhoneNumberTextBox.Name = "updatePhoneNumberTextBox";
            this.updatePhoneNumberTextBox.Size = new System.Drawing.Size(130, 30);
            this.updatePhoneNumberTextBox.TabIndex = 9;
            // 
            // updateEmployeeIdTextBox
            // 
            this.updateEmployeeIdTextBox.Enabled = false;
            this.updateEmployeeIdTextBox.Location = new System.Drawing.Point(146, 45);
            this.updateEmployeeIdTextBox.Name = "updateEmployeeIdTextBox";
            this.updateEmployeeIdTextBox.Size = new System.Drawing.Size(130, 30);
            this.updateEmployeeIdTextBox.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(43, 343);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Password";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(40, 304);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "User Type";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(55, 262);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Gender";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(6, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Phone Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(55, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(35, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(70, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(21, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee ID";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.searchEmployeeNameTextBox);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.searchEmployeeGridView);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(505, 357);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox5.Size = new System.Drawing.Size(590, 237);
            this.groupBox5.TabIndex = 13;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Search Employee";
            // 
            // searchEmployeeNameTextBox
            // 
            this.searchEmployeeNameTextBox.Location = new System.Drawing.Point(299, 48);
            this.searchEmployeeNameTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchEmployeeNameTextBox.Name = "searchEmployeeNameTextBox";
            this.searchEmployeeNameTextBox.Size = new System.Drawing.Size(172, 30);
            this.searchEmployeeNameTextBox.TabIndex = 13;
            this.searchEmployeeNameTextBox.TextChanged += new System.EventHandler(this.searchEmployeeNameTextBox_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(73, 54);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(138, 20);
            this.label11.TabIndex = 12;
            this.label11.Text = "Employee Name";
            // 
            // searchEmployeeGridView
            // 
            this.searchEmployeeGridView.AllowUserToAddRows = false;
            this.searchEmployeeGridView.AllowUserToDeleteRows = false;
            this.searchEmployeeGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.searchEmployeeGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchEmployeeGridView.Location = new System.Drawing.Point(29, 84);
            this.searchEmployeeGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchEmployeeGridView.Name = "searchEmployeeGridView";
            this.searchEmployeeGridView.ReadOnly = true;
            this.searchEmployeeGridView.RowHeadersWidth = 62;
            this.searchEmployeeGridView.Size = new System.Drawing.Size(499, 136);
            this.searchEmployeeGridView.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1158, 85);
            this.panel1.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label10.Location = new System.Drawing.Point(253, 7);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(594, 64);
            this.label10.TabIndex = 0;
            this.label10.Text = "Employee Information";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label12.Location = new System.Drawing.Point(1036, 673);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 20);
            this.label12.TabIndex = 15;
            this.label12.Text = "Back";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label13.Location = new System.Drawing.Point(116, 150);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(124, 20);
            this.label13.TabIndex = 16;
            this.label13.Text = "Add Employee";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(971, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(123, 67);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // ManageEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1161, 705);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.addEmployeeButton);
            this.Name = "ManageEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Employee_FormClosing);
            this.Load += new System.EventHandler(this.ManageEmployee_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listOfEmployeesGridView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchEmployeeGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addEmployeeButton;
        private System.Windows.Forms.Button updateInfoButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView listOfEmployeesGridView;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox updateUserTypeComboBox;
        private System.Windows.Forms.ComboBox updateGenderComboBox;
        private System.Windows.Forms.TextBox updateNameTextBox;
        private System.Windows.Forms.TextBox updateUsernameTextBox;
        private System.Windows.Forms.TextBox updateEmailTextBox;
        private System.Windows.Forms.TextBox updatePasswoedTextBox;
        private System.Windows.Forms.TextBox updatePhoneNumberTextBox;
        private System.Windows.Forms.TextBox updateEmployeeIdTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox updateBirthDateTextBox;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox searchEmployeeNameTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView searchEmployeeGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}