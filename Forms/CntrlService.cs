using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ForestGladeApp.Classess;
using System.Data.SqlClient;

namespace ForestGladeApp.Forms
{
    public partial class CntrlService : UserControl
    {
        private List<Panel> servicePanels;
        private bool edit;
        public CntrlService(string permission)
        {
            _permission = permission;
            InitializeComponent();
            if (_permission == "pracownik")
                this.btnEditService.Hide();
            else
                this.btnEditService.Show();
            servicePanels = new List<Panel>();
            servicePanels.Add(cntrlPnlServiceView);
            servicePanels.Add(cntrlPnlServiceEdit);
            servicePanels[0].BringToFront();
            edit = false; //user interface OFF
        }

        #region Properties
        private float _prize;
        private string _name;
        private string _category;
        private Color _backgroundColor;
        private int _id;
        private string _permission;
        private int _availableAmount;
        private int _criticalAmount;

        public int StanKrytyczny
        {
            get { return _criticalAmount; }
            set { _criticalAmount = value; }
        }


        public int StanProduktu
        {
            get { return _availableAmount; }
            set { _availableAmount = value; cntrlServiceAvailableAmount.Text = value.ToString(); }
        }


        public string Pozwolenie
        {
            get { return _permission; }
            set { _permission = value; }
        }


        public int Identyfikator
        {
            get { return _id; }
            set { _id = value; }
        }


        [Category("Custom Props")]
        public Color Kolor
        {
            get { return _backgroundColor; }
            set { _backgroundColor = value; cntrlPnlServiceView.BackColor = value; }
        }


        [Category("Custom Props")]
        public float Cena
        {
            get { return _prize; }
            set { _prize = value; cntrlServiceLblPrize.Text = value.ToString(); }
        }


        [Category("Custom Props")]
        public string Nazwa
        {
            get { return _name; }
            set { _name = value; cntrlServiceLblName.Text = value; }
        }


        [Category("Custom Props")]
        public string Kategoria
        {
            get { return _category; }
            set { _category = value; cntrlServiceLblCategory.Text = value; }
        }

        #endregion

        private void btnEditService_Click(object sender, EventArgs e)
        {
            ChangeState();
            servicePanels[GetCurrentPanel()].BringToFront();
            if(edit == true)
            {
                using (SqlConnection connection = new SqlConnection(@"Data Source=GSZWEDPC\SQLEXPRESS;Initial Catalog=WeddingManagmentDB;Integrated Security=True"))
                {
                    connection.Open();
                    var command = @"SELECT Name, Category, Unit, Prize, AvailableDiscount, AvailableAmount, CriticalAmount FROM ServiceTable WHERE id ='" + this._id + "'";
                    SqlDataAdapter adapter = new SqlDataAdapter(command, connection);
                    DataTable dataTable = new DataTable();
                    connection.Close();
                    adapter.Fill(dataTable);
                    if (dataTable.Rows.Count == 1)
                    {
                        DataRow row = dataTable.Rows[0];
                        cntrlTxtName.Text = row[0].ToString();
                        cntrlTxtCategory.Text = row[1].ToString();
                        cntrlTxtUnit.Text = row[2].ToString();
                        cntrlTxtPrize.Text = Convert.ToString(row[3]);
                        cntrlTxtDiscount.Text = Convert.ToString(row[4]);
                        cntrlTxtCurrent.Text = Convert.ToString(row[5]);
                        cntrlTxtCritical.Text = Convert.ToString(row[6]);
                    }
                }
            }
        }

        private int GetCurrentPanel()
        {
            if (edit == true)
                return 1;
            else
                return 0;
        }

        private void ChangeState()
        {
            if (edit == true)
                edit = false;
            else
                edit = true;
        }

        private void cntrlServicePnlEditService_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(@"Data Source=GSZWEDPC\SQLEXPRESS;Initial Catalog=WeddingManagmentDB;Integrated Security=True"))
            {
                var query = @"UPDATE ServiceTable SET Name = @param1, Category = @param2, Unit = @param3, Prize = @param4, AvailableDiscount = @param5, AvailableAmount = @param6, CriticalAmount = @param7 WHERE id = @param8";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@param1", cntrlTxtName.Text);
                    cmd.Parameters.AddWithValue("@param2", cntrlTxtCategory.Text);
                    cmd.Parameters.AddWithValue("@param3", cntrlTxtUnit.Text);
                    cmd.Parameters.AddWithValue("@param4", float.Parse(cntrlTxtPrize.Text));
                    cmd.Parameters.AddWithValue("@param5", float.Parse(cntrlTxtDiscount.Text) / 100);
                    cmd.Parameters.AddWithValue("@param6", int.Parse(cntrlTxtCurrent.Text));
                    cmd.Parameters.AddWithValue("@param7", int.Parse(cntrlTxtCritical.Text));
                    cmd.Parameters.AddWithValue("@param8", this._id);

                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();

                }
                var command = @"SELECT Name, Category, Prize, AvailableAmount, CriticalAmount FROM ServiceTable WHERE id ='" + this._id + "'";
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(command, connection);
                DataTable dataTable = new DataTable();
                connection.Close();
                adapter.Fill(dataTable);
                if (dataTable.Rows.Count == 1)
                {
                    DataRow row = dataTable.Rows[0];
                    this.Nazwa = row[0].ToString();
                    this.Kategoria = row[1].ToString();
                    this.Cena = Convert.ToSingle(row[2]);
                    this.StanProduktu = (int)row[3];
                    this.StanKrytyczny = (int)row[4];
                    this.Kolor = Color.White;
                }
            }
            ChangeState();
            servicePanels[GetCurrentPanel()].BringToFront();
        }

        private void cntrlPnlServiceView_MouseEnter(object sender, EventArgs e)
        {
            this.Kolor = Color.Silver;
        }

        private void cntrlPnlServiceView_MouseLeave(object sender, EventArgs e)
        {
            this.Kolor = Color.White;
        }
    }
}
