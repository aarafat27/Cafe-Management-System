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
    public partial class ManageCustomer : Form
    {
        public ManageCustomer()
        {
            InitializeComponent();
        }

        private void Customer_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void ManageCustomer_Load(object sender, EventArgs e)
        {
            UpdateGridView();
        }
        void UpdateGridView()
        {
            CustomerDataAccess userDataAccess = new CustomerDataAccess();
            listOfCustomersGridView.DataSource = userDataAccess.GetCustomer();
        }

        private void searchCustomerNameTextBox_TextChanged(object sender, EventArgs e)
        {
            CustomerDataAccess customerDataAccess = new CustomerDataAccess();
            if (searchCustomerNameTextBox.Text != "")
            {
                searchCustomerGridView.DataSource = customerDataAccess.GetCustomerByName(searchCustomerNameTextBox.Text);
            }
            else
            {
                searchCustomerGridView.DataSource = "";
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            AdminPanel adminPanel = new AdminPanel();
            adminPanel.Show();
            this.Hide();
        }
    }
}
