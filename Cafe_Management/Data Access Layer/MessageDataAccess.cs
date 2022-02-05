using Cafe_Management.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe_Management.Data_Access_Layer
{
    class MessageDataAccess:DataAccess
    {
        public bool MessageReceiverValidation(string username)
        {
            string sql = "SELECT * FROM Employees WHERE Username='" + username+ "'";
            SqlDataReader reader = this.GetData(sql);
            if (reader.HasRows)
            {
                return true;
            }
            else
                return false;
        }


        public List<Message> GetEmployeeMessage(string username)
        {
            string sql = "SELECT * FROM EmployeeMessages WHERE Receiver='" + username + "'";
            SqlDataReader reader = this.GetData(sql);
            List<Message> messages = new List<Message>();
            while (reader.Read())
            {

                Message message = new Message();
                message.Receiver = reader["Receiver"].ToString();
                message.Sender = reader["Sender"].ToString();
                message.Messages = reader["Message"].ToString();
                messages.Add(message);

            }
            return messages;
        }

        public List<Message> GetAdminMessage(string username)
        {
            string sql = "SELECT * FROM AdminMessages WHERE Receiver='" + username + "'";
            SqlDataReader reader = this.GetData(sql);
            List<Message> messages = new List<Message>();
            while (reader.Read())
            {

                Message message = new Message();
                message.Sender = reader["Sender"].ToString();
                message.Receiver = reader["Receiver"].ToString();
                message.Messages = reader["Message"].ToString();
                messages.Add(message);

            }
            return messages;
        }

        public bool SentMessageToEmployee(Message message)
        {
            string sql = "INSERT INTO AdminMessages(Receiver, Sender, Message) VALUES('" +message.Receiver + "','" + message.Sender+ "','" + message.Messages + "')";
            int result = this.ExecuteQuery(sql);
            if (result > 0)
                return true;
            else
                return false;
        }

        public bool SentMessageToAdmin(Message message)
        {
            string sql = "INSERT INTO EmployeeMessages(Receiver, Sender, Message) VALUES('" + message.Receiver + "','" + message.Sender + "','" + message.Messages + "')";
            int result = this.ExecuteQuery(sql);
            if (result > 0)
                return true;
            else
                return false;
        }

    }
}
