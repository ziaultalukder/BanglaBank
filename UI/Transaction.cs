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
    public partial class Transaction : Form
    {
        public Transaction()
        {
            InitializeComponent();
        }

        private void depositButton_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            string acNum = accountNumberTextBox.Text;
            double ammount = Convert.ToDouble(ammountTextBox.Text);
            string message = customer.Deposit(ammount,acNum);
            MessageBox.Show(message);
        }

        private void withdrawButton_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            string acNum = accountNumberTextBox.Text;
            double ammount = Convert.ToDouble(ammountTextBox.Text);
            string message = customer.Withdraw(ammount, acNum);
            MessageBox.Show(message);
        }
    }
}
