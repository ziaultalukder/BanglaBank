using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace BanglaBank.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }
        public double Balance { get; set; }
        public DateTime DateTime { get; set; }
        public string AcNumber  { get; set; }

        public string CreateCustomerAccount(Customer customer)
        {
            string msg = "";
            if (customer.AcNumber.Length <= 6)
            {
                msg = "Account Number Must Be 6 Character";
                return msg;
            }

            if (IsAccountNumberExist(customer.AcNumber))
            {
                msg = "Account Number Already Exist!";
                return msg;
            }
            
            if (IsNumberExist(customer.Mobile))
            {
                msg = "Mobile Number Already Exist!";
                return msg;
            }
            string connectionString = @"Server = DESKTOP-A0CRMK0\SQLEXPRESS; Database= BanglaBank; Integrated Security = true";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string query = "insert into Account(Name,Mobile,Email,Address,Gender,Date,Balance,AcNumber) " +
                           "values ('"+customer.CustomerName+"','"+customer.Mobile+"','"+customer.Email+"','"+customer.Address+"','"+customer.Gender+"','"+customer.DateTime+"','"+customer.Balance+"','"+customer.AcNumber+"')";

            

            SqlCommand command = new SqlCommand(query,connection);
            int rowAffected = command.ExecuteNonQuery();
            connection.Close();
            if (rowAffected > 0)
            {
                msg = "Account Save Successfully";
            }
            else
            {
                msg = "Account Save Faild";
            }
            return msg;
        }
        
    private bool IsAccountNumberExist(string accountNo) 
        {
            string connectionString = @"Server = DESKTOP-A0CRMK0\SQLEXPRESS; Database= BanglaBank; Integrated Security = true";
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "SELECT count(*) FROM Account WHERE AcNumber = '" +accountNo+ "'";
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            int AcNumber = (int)command.ExecuteScalar();
            connection.Close();
            return AcNumber > 0;
        }

        private bool IsNumberExist(string mobile)
        {
            string connectionString = @"Server = DESKTOP-A0CRMK0\SQLEXPRESS; Database= BanglaBank; Integrated Security = true";
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "SELECT count(*) FROM Account WHERE Mobile = '"+mobile+"'";
            connection.Open();
            SqlCommand command = new SqlCommand(query,connection);
            int MobileNumber =(int)command.ExecuteScalar();
            connection.Close();
            return MobileNumber > 0;
        }

        public string Deposit(double ammount,string acNum)
        {
            string msg = "";
            Balance = Balance + ammount;
            string connectionString = @"Server = DESKTOP-A0CRMK0\SQLEXPRESS; Database= BanglaBank; Integrated Security = true";
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "UPDATE Account SET Balance += '"+Balance+"' WHERE AcNumber = '"+acNum+"'";
            
            SqlCommand command = new SqlCommand(query,connection);
            connection.Open();
            int rowAffected = command.ExecuteNonQuery();
            connection.Close();
            if (rowAffected > 0)
            {
                msg = ammount + " Taka Deposited Sucessfully";
            }
            else
            {
                msg = "Deposited Faild";
            }
            return msg;
        }

        public string Withdraw(double ammount, string acNum)
        {
            string msg = "";
            Balance = Balance + ammount;
            string connectionString = @"Server = DESKTOP-A0CRMK0\SQLEXPRESS; Database= BanglaBank; Integrated Security = true";
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "UPDATE Account SET Balance -= '" + Balance + "' WHERE AcNumber = '" + acNum + "'";

            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            int rowAffected = command.ExecuteNonQuery();
            connection.Close();
            if (rowAffected > 0)
            {
                msg = ammount + " Taka Withdraw Sucessfully";
            }
            else
            {
                msg = "Deposited Faild";
            }
            return msg;
        }
    }
}
