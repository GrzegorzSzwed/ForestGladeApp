using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ForestGladeApp.Forms
{
    public partial class CntrlUser : UserControl
    {
        private bool edit;
        private int id = 0;

        public CntrlUser()
        {
            InitializeComponent();
            CntrlUserPnlEdit.Hide();
            edit = false;
            cntrlUserTxtName.Text = "Imię";
            CntrlUserTxtSurname.Text = "Nazwisko";
            CntrlUserTxtMail.Text = "Mail";
            CntrlUserTxtPhone.Text = "XXX-XXX-XXX";
            CntrlUserCmbPermission.Text = "Użytkownik";
        }

        public void FillLabels(int id)
        {
            using (SqlConnection connection = new SqlConnection(@"Data Source=GSZWEDPC\SQLEXPRESS;Initial Catalog=WeddingManagmentDB;Integrated Security=True"))
            {
                var query = @"SELECT Name, Surname, Mail, Phone, Permission FROM PeapleTable WHERE id = '" + id + "'";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable table = new DataTable();
                adapter.Fill(table);
                if(table.Rows.Count==1)
                {
                    DataRow row = table.Rows[0];
                    CntrlUserLblName.Text = row[0].ToString();
                    CntrlUserLblSurname.Text = row[1].ToString();
                    CntrlUserLblMail.Text = row[2].ToString();
                    CntrlUserLblPhone.Text = row[3].ToString();
                    CntrlUserLblPermission.Text = row[4].ToString();
                }
            }
        }

        #region Properties
        private string _name;
        private string _surname;
        private string _mail;
        private string _permission;
        private string _phone;

        public int GetId()
        {
            return id;
        }


        [Category("Custom Props")]
        public string Telofon
        {
            get { return _phone; }
            set { _phone = value; CntrlUserLblPhone.Text = value; }
        }

        [Category("Custom Props")]
        public string Uzytkownik
        {
            get { return _permission; }
            set { _permission = value; CntrlUserLblPermission.Text = value; }
        }
        [Category("Custom Props")]
        public string Mail
        {
            get { return _mail; }
            set { _mail = value; CntrlUserLblMail.Text = value;  }
        }
        [Category("Custom Props")]
        public string Nazwisko  
        {
            get { return _surname; }
            set { _surname = value; CntrlUserLblSurname.Text = value; }
        }
        [Category("Custom Props")]
        public string Imie
        {
            get { return _name; }
            set { _name = value; CntrlUserLblName.Text = value; }
        }


        #endregion

        private void ChangeState()
        {
            if (edit == false)
                edit = true;
            else
                edit = false;
        }

        private void CntrlUserBtnAddUser_Click(object sender, EventArgs e)
        {
            ChangeState();
            if (edit == true)
                CntrlUserPnlEdit.Show();
            else
                CntrlUserPnlEdit.Hide();
        }

        private void CntrlUserAddUser_Click(object sender, EventArgs e)
        {
            if (id == 0) //customer does not exist in database
            {
                using (SqlConnection connection = new SqlConnection(@"Data Source=GSZWEDPC\SQLEXPRESS;Initial Catalog=WeddingManagmentDB;Integrated Security=True"))
                {
                    connection.Open();
                    var query = @"INSERT INTO PeapleTable (Name, Surname, Mail, Phone, Permission) VALUES (@param1,@param2,@param3,@param4,@param5)";
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@param1", cntrlUserTxtName.Text.ToLower());
                        cmd.Parameters.AddWithValue("@param2", CntrlUserTxtSurname.Text.ToLower());
                        cmd.Parameters.AddWithValue("@param3", CntrlUserTxtMail.Text.ToLower());
                        cmd.Parameters.AddWithValue("@param4", CntrlUserTxtPhone.Text);
                        cmd.Parameters.AddWithValue("@param5", CntrlUserCmbPermission.Text.ToLower());

                        cmd.ExecuteNonQuery();
                    }

                    //get id of created person
                    query = @"SELECT id FROM PeapleTable WHERE Name = '" + cntrlUserTxtName.Text + "'AND Surname = '" + CntrlUserTxtSurname.Text + "'AND Mail = '" + CntrlUserTxtMail.Text + "'";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    if (table.Rows.Count == 1)
                    {
                        DataRow row = table.Rows[0];
                        id = (int)row[0];
                        FillLabels(id);
                    }
                    connection.Close();
                }
                //clear all the textboxes
                cntrlUserTxtName.Text = string.Empty;
                CntrlUserTxtSurname.Text = string.Empty;
                CntrlUserTxtMail.Text = string.Empty;
                CntrlUserTxtPhone.Text = string.Empty;
                CntrlUserCmbPermission.Text = string.Empty;
                ChangeState();
                CntrlUserPnlEdit.Hide();
            }
            else // customer edit
            {
                using (SqlConnection connection = new SqlConnection(@"Data Source=GSZWEDPC\SQLEXPRESS;Initial Catalog=WeddingManagmentDB;Integrated Security=True"))
                {
                    connection.Open();
                    var query = @"UPDATE PeapleTable SET Name = @param1, Surname = @param2, Mail = @param3, Phone = @param4, Permission = @param5 WHERE id = @param6";
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@param1", cntrlUserTxtName.Text.ToLower());
                        cmd.Parameters.AddWithValue("@param2", CntrlUserTxtSurname.Text.ToLower());
                        cmd.Parameters.AddWithValue("@param3", CntrlUserTxtMail.Text.ToLower());
                        cmd.Parameters.AddWithValue("@param4", CntrlUserTxtPhone.Text);
                        cmd.Parameters.AddWithValue("@param5", CntrlUserCmbPermission.Text.ToLower());
                        cmd.Parameters.AddWithValue("@param6", id);

                        cmd.ExecuteNonQuery();
                    }
                    connection.Close();
                    FillLabels(id);
                    cntrlUserTxtName.Text = string.Empty;
                    CntrlUserTxtSurname.Text = string.Empty;
                    CntrlUserTxtMail.Text = string.Empty;
                    CntrlUserTxtPhone.Text = string.Empty;
                    CntrlUserCmbPermission.Text = string.Empty;
                    ChangeState();
                    CntrlUserPnlEdit.Hide();
                }
            }
        }
    }
}
