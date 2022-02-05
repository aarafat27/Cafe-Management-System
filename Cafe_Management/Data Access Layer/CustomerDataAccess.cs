using Cafe_Management.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe_Management.Data_Access_Layer
{
    class CustomerDataAccess : DataAccess
    {
        public List<Customer> GetCustomer()
        {
            string sql = "SELECT * FROM Customers";
            SqlDataReader reader = this.GetData(sql);
            List<Customer> customers = new List<Customer>();
            while (reader.Read())
            {

                Customer customer = new Customer();
                customer.PhoneNumber = reader["PhoneNumber"].ToString();
                customer.Name = reader["Name"].ToString();
                customers.Add(customer);

            }
            return customers;
        }

        public List<Customer> GetCustomerByName(string str)
        {
            string sql = "SELECT * FROM Customers WHERE Name LIKE '" + str + "%'";
            SqlDataReader reader = this.GetData(sql);
            List<Customer> customers = new List<Customer>();
            while (reader.Read())
            {
                Customer customer = new Customer();
                customer.PhoneNumber = reader["PhoneNumber"].ToString();
                customer.Name = reader["Name"].ToString();
                customers.Add(customer);
            }
            return customers;
        }

        public void AddCustomer(string customerName, string phoneNumber)
        {
            string sql = "INSERT INTO Customers(Name, PhoneNumber) VALUES('" + customerName + "','"+phoneNumber+"')";
            int result = this.ExecuteQuery(sql);
           
        }
    }
}
