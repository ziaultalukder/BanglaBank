using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BanglaBank.Models;

namespace BanglaBank.UI
{
    public partial class Create_Account : Form
    {
        Customer customer = new Customer();
        public Create_Account()
        {
            InitializeComponent();
        }

        private void createAccountButton_Click(object sender, EventArgs e)
        {
            customer.CustomerName = customerNameTextBox.Text;
            customer.Mobile = mobileTextBox.Text;
            customer.Email = emailTextBox.Text;
            customer.Address = addressTextBox.Text;
            customer.DateTime = accountDateTimePicker.Value;
            customer.AcNumber = acNumberTextBox.Text;
            customer.Gender = femaleRadioButton.Text;
            customer.Gender = maleRadioButton.Text;
            customer.Balance = 500;
            string message = customer.CreateCustomerAccount(customer);
            MessageBox.Show(message);
            createOpeningFieldClear();
        }

        private void createOpeningFieldClear()
        {
            customerNameTextBox.Clear();
            mobileTextBox.Clear();
            emailTextBox.Clear();
            addressTextBox.Clear();
            acNumberTextBox.Clear();
        }
    }
}
