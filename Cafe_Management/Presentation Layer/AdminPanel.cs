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
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void AdminPanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void employeeInfoButton_Click(object sender, EventArgs e)
        {
            ManageEmployee manageEmployee = new ManageEmployee();
            manageEmployee.Show();
            this.Hide();
        }

        private void productInfoButton_Click(object sender, EventArgs e)
        {
            ProductDashboard productDashboard = new ProductDashboard();
            productDashboard.Show();
            this.Hide();
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void customerInfoButton_Click(object sender, EventArgs e)
        {
            ManageCustomer manageCustomer = new ManageCustomer();
            manageCustomer.Show();
            this.Hide();
        }

        

        private void inboxButton_Click(object sender, EventArgs e)
        {
            EmployeeMessage employeemessage = new EmployeeMessage();
            employeemessage.Show();
            this.Hide();
        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {
            
           Login login = new Login();
         
            usernameLabel.Text += Login.pass;

        }

       
    }
}
