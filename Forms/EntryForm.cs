using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ForestGladeApp.Forms;
using System.Data.SqlClient;

namespace ForestGladeApp.Forms
{
    public partial class EntryForm : Form
    {
        private Dashboard board;
        public EntryForm()
        {
            InitializeComponent();
            lblState.Text = string.Empty;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(@"Data Source=GSZWEDPC\SQLEXPRESS;Initial Catalog=WeddingManagmentDB;Integrated Security=True"))
            {
                connection.Open();
                lblState.Text = "logowanie w toku";
                var command = @"SELECT id FROM PeapleTable WHERE Login = '" + txtLogin.Text + "' and Password = '" + txtPassword.Text + "'";
                SqlDataAdapter adapter = new SqlDataAdapter(command, connection);
                DataTable dataTable = new DataTable();
                connection.Close();
                adapter.Fill(dataTable);
                if(dataTable.Rows.Count == 1)
                {
                    DataRow row = dataTable.Rows[0];
                    if ((int)row[0] > 0)
                    {
                        board = new Dashboard((int)row[0]);
                        this.Hide();
                        board.Show();
                    }
                        
                }
                else
                {
                    lblState.Text = "Użytkownik nie istnieje";
                    txtLogin.Text = string.Empty;
                    txtPassword.Text = string.Empty;
                }
            }
        }
    }
}
