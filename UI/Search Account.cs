using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BanglaBank.UI
{
    public partial class Search_Account : Form
    {
        public Search_Account()
        {
            InitializeComponent();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(searchTextBox.Text))
            {
                MessageBox.Show("Input Field Is Empty");
                return;
            }
            else
            {
                string search = searchTextBox.Text;
                string connectionString = @"Server = DESKTOP-A0CRMK0\SQLEXPRESS; Database= BanglaBank; Integrated Security = true";
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                string query = "select * from Account where AcNumber like '"+search+"%'";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query,connection);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                connection.Close();
                accountDataGridView.DataSource = dataTable;
            }
        }

        private void accountDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
