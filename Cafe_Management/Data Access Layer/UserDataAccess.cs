using Cafe_Management.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe_Management.Data_Access_Layer
{
    class UserDataAccess:DataAccess
    {
       


        public bool UserRegister(User user)
        {
            string sql = "INSERT INTO Employees(Name,Username,Password,Email,DateOfBirth,Gender,PhoneNumber,UserType) VALUES('" + user.Name + "','" + user.Username + "','" + user.Password + "','" + user.Email + "','" + user.DateOfBirth + "','" + user.Gender + "','" + user.PhoneNumber + "','"+user.UserType+"')";
            int result = this.ExecuteQuery(sql);
            if (result > 0)
                return true;
            else
                return false;
        }

        //public bool LoginValidation(string username, string password)
        //{
        //    string sql = "SELECT * FROM Employees WHERE Username='" + username + "' AND Password='" + password + "'";
        //    SqlDataReader reader = this.GetData(sql);
        //    if (reader.HasRows)
        //    {
        //        return true;
        //    }
        //    else
        //        return false;
        //}
        public string LoginValidation(string username, string password)
        {
            
            string sql = "SELECT * FROM Employees WHERE Username='" + username + "' AND Password='" + password + "'";
            SqlDataReader reader = this.GetData(sql);
            User user = new User();
            if (reader.HasRows)
            {
                reader.Read();
                
               
                return user.UserType = reader["UserType"].ToString();
               

            }
            else
            {
                return null;
            }
            
        }

        
       

        public List<User> GetEmployee()
        {
            string sql = "SELECT * FROM Employees";
            SqlDataReader reader = this.GetData(sql);
            List<User> users = new List<User>();
            while (reader.Read())
            {
                User user = new User();
                user.EmployeeId = (int)reader["EmployeeId"];
                user.Name = reader["Name"].ToString();
                user.Username = reader["Username"].ToString();
                user.DateOfBirth = reader["DateOfBirth"].ToString();
                user.Email = reader["Email"].ToString();
                user.PhoneNumber = reader["PhoneNumber"].ToString();
                user.Gender = reader["Gender"].ToString();
                user.UserType = reader["UserType"].ToString();
                user.Password = reader["Password"].ToString();


                //user.Username = Convert.ToDouble(reader["Price"]);
                users.Add(user);
                //  products.Add(product);
            }
            return users;
        }


        public bool UpdateEmployee( int employeeId,string name, string username, string email, string phoneNumber, string gender, string userType, string password )
        {
            string sql = "UPDATE Employees SET Name='" + name +"',Username='" + username + "',Email='" + email + "',PhoneNumber='" + phoneNumber +"',Gender='"+gender+"',UserType='"+userType+"',Password='"+password+ "' WHERE EmployeeId=" + employeeId;
            int result = this.ExecuteQuery(sql);
            if (result > 0)
                return true;
            else
                return false;
        }

        public bool DeleteEmployee(int employeeId)
        {
            string sql = "DELETE FROM Employees WHERE EmployeeId=" + employeeId;
            int result = this.ExecuteQuery(sql);
            if (result > 0)
                return true;
            else
                return false;
        }

        public List<User> GetEmployeeByName(string str)
        {
            string sql = "SELECT * FROM Employees WHERE Name LIKE '" + str + "%'";
            SqlDataReader reader = this.GetData(sql);
            List<User> users = new List<User>();
            while (reader.Read())
            {
                User user = new User();
                user.EmployeeId = (int)reader["EmployeeId"];
                user.Name = reader["Name"].ToString();
                user.Username = reader["Username"].ToString();
                user.DateOfBirth = reader["DateOfBirth"].ToString();
                user.Email = reader["Email"].ToString();
                user.PhoneNumber = reader["PhoneNumber"].ToString();
                user.Gender = reader["Gender"].ToString();
                user.UserType = reader["UserType"].ToString();
                user.Password = reader["Password"].ToString();
                users.Add(user);
            }
            return users;
        }
    }
}
