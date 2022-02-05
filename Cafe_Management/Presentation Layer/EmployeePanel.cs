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
    public partial class EmployeePanel : Form
    {
        public EmployeePanel()
        {
            InitializeComponent();
        }

        private void EmployeePanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void EmployeePanel_Load(object sender, EventArgs e)
        {
            Login login = new Login();
            
            usernameLabel.Text += Login.pass;
        }

        private void inboxButton_Click(object sender, EventArgs e)
        {
            AdminMessage adminMessage = new AdminMessage();
            adminMessage.Show();
            this.Hide();
        }

        private void billGenerateButton_Click(object sender, EventArgs e)
        {
            BillPanel billPanel = new BillPanel();
            billPanel.Show();
            this.Hide();
        }
    }
}
