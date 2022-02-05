using Cafe_Management.Data_Access_Layer;
using Cafe_Management.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Message = Cafe_Management.Entities.Message;

namespace Cafe_Management.Presentation_Layer
{
    public partial class EmployeeMessage : Form
    {
        public EmployeeMessage()
        {
            InitializeComponent();
        }

        private void Message_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Message_Load(object sender, EventArgs e)
        {
            idd.Text = Login.pass;
            UpdateGridView();        }

        void UpdateGridView()
        {
            MessageDataAccess messageDataAccess = new MessageDataAccess();
            employeeMessageDataGridView1.DataSource = messageDataAccess.GetEmployeeMessage(idd.Text);
           
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            AdminPanel adminPanel = new AdminPanel();
            adminPanel.Show();
            this.Hide();
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            if (employeeIdtextBox.Text == "")
            {
                MessageBox.Show("Please enter username to whom you want to send message");
            }
            else if (employeeMessageRichTextBox.Text == "")
            {
                MessageBox.Show("Please type message");
            }
            else
            {
                MessageDataAccess messageDataAccess1 = new MessageDataAccess();
                if (messageDataAccess1.MessageReceiverValidation(employeeIdtextBox.Text))
                {
                    Message message = new Message();
                    message.Receiver = employeeIdtextBox.Text;

                    message.Sender = idd.Text;
                    message.Messages = employeeMessageRichTextBox.Text;
                    MessageDataAccess messageDataAccess = new MessageDataAccess();
                    if (messageDataAccess.SentMessageToEmployee(message))
                    {
                        MessageBox.Show("Message Sent");
                    }
                }
                else
                {
                    MessageBox.Show("There is no valid user");
                }

            }
           
           

        }
        
        





    }
}
