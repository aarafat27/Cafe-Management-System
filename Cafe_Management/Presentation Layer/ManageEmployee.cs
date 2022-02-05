using Cafe_Management.Data_Access_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe_Management.Presentation_Layer
{
    public partial class ManageEmployee : Form
    {
        public ManageEmployee()
        {
            InitializeComponent();
        }

        private void Employee_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void addEmployeeButton_Click(object sender, EventArgs e)
        {
            UserRegistration userRegistration = new UserRegistration();
            userRegistration.Show();
            this.Hide();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            AdminPanel adminPanel = new AdminPanel();
            adminPanel.Show();
            this.Hide();
        }

        private void ManageEmployee_Load(object sender, EventArgs e)
        {
            UpdateGridView();

        }

        void UpdateGridView()
        {
            UserDataAccess userDataAccess = new UserDataAccess();
            listOfEmployeesGridView.DataSource = userDataAccess.GetEmployee();
        }

        private void listOfEmployeesGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           

            updateEmployeeIdTextBox.Text = listOfEmployeesGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            updateNameTextBox.Text = listOfEmployeesGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            updateUsernameTextBox.Text = listOfEmployeesGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
            updateBirthDateTextBox.Text= listOfEmployeesGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
            updateEmailTextBox.Text = listOfEmployeesGridView.Rows[e.RowIndex].Cells[4].Value.ToString();  
            updatePhoneNumberTextBox.Text = listOfEmployeesGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
            updateGenderComboBox.Text = listOfEmployeesGridView.Rows[e.RowIndex].Cells[6].Value.ToString();
            updateUserTypeComboBox.Text = listOfEmployeesGridView.Rows[e.RowIndex].Cells[7].Value.ToString();
            updatePasswoedTextBox.Text = listOfEmployeesGridView.Rows[e.RowIndex].Cells[8].Value.ToString();
            //deleteEmployeeIdTextBox.Text = listOfEmployeesGridView.Rows[e.RowIndex].Cells[0].Value.ToString();


        }

        void ClearFields()
        {
            updateEmployeeIdTextBox.Text = string.Empty;
            updateNameTextBox.Text = string.Empty;
            updateUsernameTextBox.Text = string.Empty;
            updateBirthDateTextBox.Text = string.Empty;
            updateEmailTextBox.Text = string.Empty;
            updatePhoneNumberTextBox.Text = string.Empty;
            updateGenderComboBox.Text = string.Empty;
            updateUserTypeComboBox.Text = string.Empty;
            updatePasswoedTextBox.Text = string.Empty;
           // deleteEmployeeIdTextBox.Text = string.Empty;

            // deleteProductIdTextBox.Text = string.Empty;

        }
        private void updateInfoButton_Click(object sender, EventArgs e)
        {
            UserDataAccess userDataAccess = new UserDataAccess();
            if (userDataAccess.UpdateEmployee(Convert.ToInt32(updateEmployeeIdTextBox.Text), updateNameTextBox.Text, updateUsernameTextBox.Text, updateEmailTextBox.Text, updatePhoneNumberTextBox.Text, updateGenderComboBox.Text, updateUserTypeComboBox.Text, updatePasswoedTextBox.Text))
            {
                MessageBox.Show("Employee Data updated");
                UpdateGridView();
                ClearFields();
            }
            else
            {
                MessageBox.Show("Error in updating");
               ClearFields();
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
           
            UserDataAccess userDataAccess = new UserDataAccess();
            if(updateEmployeeIdTextBox.Text=="")
            {
                MessageBox.Show("Please Select Employee ");
            }
            else
            {
                if (userDataAccess.DeleteEmployee(Convert.ToInt32(updateEmployeeIdTextBox.Text)))
                {
                    MessageBox.Show("Employee deleted");
                    UpdateGridView();
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("Error in deleting");
                    ClearFields();
                }
            }
            
        }

        private void searchEmployeeNameTextBox_TextChanged(object sender, EventArgs e)
        {
            UserDataAccess userDataAccess = new UserDataAccess();
            if(searchEmployeeNameTextBox.Text!="")
            {
                searchEmployeeGridView.DataSource = userDataAccess.GetEmployeeByName(searchEmployeeNameTextBox.Text);
            }
            else
            {
                searchEmployeeGridView.DataSource = "";
            }
        }
    }
}

