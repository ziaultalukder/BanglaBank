using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BanglaBank.Models;
using BanglaBank.UI;

namespace BanglaBank
{
    public partial class BanglaBankUI : Form
    {
        public BanglaBankUI()
        {
            InitializeComponent();
        }

        private void accountButton_Click(object sender, EventArgs e)
        {
            Create_Account createAccount = new Create_Account();
            createAccount.Show();
        }

        private void transactionButton_Click(object sender, EventArgs e)
        {
            Transaction transaction = new Transaction();
            transaction.Show();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            Search_Account searchAccount = new Search_Account();
            searchAccount.Show();
        }
    }
}
