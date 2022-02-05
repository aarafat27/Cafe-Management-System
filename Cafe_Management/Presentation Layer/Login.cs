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
    public partial class Login : Form
    {
        public static string pass;
        public Login()
        {
           
            InitializeComponent();
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

       
        
        private void loginButton_Click(object sender, EventArgs e)
        {
            if (usernameTextBox.Text == "" && passwordTextBox.Text == "")
            {
                MessageBox.Show("Username and password can not be empty");
            }
            else if (usernameTextBox.Text == "")
            {
                MessageBox.Show("Username can not be empty");
            }
            else if (passwordTextBox.Text == "")
            {
                MessageBox.Show("Password can not be empty");
            }
            else
            {
                pass = usernameTextBox.Text;               
                UserDataAccess userDataAccess = new UserDataAccess();
                string t = userDataAccess.LoginValidation(usernameTextBox.Text, passwordTextBox.Text);
                if (t=="admin")
                {
                    
                    AdminPanel adminPanel = new AdminPanel();
                    pass = usernameTextBox.Text;
                    adminPanel.Show();
                    this.Hide();
                }
                
               if  (t == "employee")
                {
                    EmployeePanel employeePanel = new EmployeePanel();
                    employeePanel.Show();
                    this.Hide();
                }
                else if (t ==null)
                {
                    MessageBox.Show("Incorrect username or password");
                }
            }
        }
    }
}
