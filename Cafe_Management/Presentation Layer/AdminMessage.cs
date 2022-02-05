using Cafe_Management.Data_Access_Layer;
using Message = Cafe_Management.Entities.Message;
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
    public partial class AdminMessage : Form
    {
        public AdminMessage()
        {
            InitializeComponent();
        }

        private void AdminMessage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void AdminMessage_Load(object sender, EventArgs e)
        {
            idd.Text = Login.pass;
            UpdateGridView();
        }
        void UpdateGridView()
        {
            MessageDataAccess messageDataAccess = new MessageDataAccess();
            adminMessageDataGridView1.DataSource = messageDataAccess.GetAdminMessage (idd.Text);


        }

        private void Backbutton_Click(object sender, EventArgs e)
        {
            EmployeePanel employeePanel = new EmployeePanel();
            employeePanel.Show();
            this.Hide();
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            if(adminIdtextBox.Text=="")
            {
                MessageBox.Show("Please enter user name to whom you want to send message");
            }
            else if(adminMessageRichTextBox1.Text=="")
            {
                MessageBox.Show("Please type message");
            }
            else
            {
                MessageDataAccess messageDataAccess1 = new MessageDataAccess();
                if(messageDataAccess1.MessageReceiverValidation(adminIdtextBox.Text))
                {
                    Message message = new Message();
                    message.Receiver = adminIdtextBox.Text;

                    message.Sender = idd.Text;
                    message.Messages = adminMessageRichTextBox1.Text;
                    MessageDataAccess messageDataAccess = new MessageDataAccess();
                    if (messageDataAccess.SentMessageToAdmin(message))
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
