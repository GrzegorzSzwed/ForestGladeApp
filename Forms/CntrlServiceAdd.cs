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
    public partial class CntrlServiceAdd : UserControl
    {
        private string connectionString = @"Data Source=GSZWEDPC\SQLEXPRESS;Initial Catalog=WeddingManagmentDB;Integrated Security=True";
        public CntrlServiceAdd()
        {
            InitializeComponent();
        }

        #region Properties
        private string _name;
        private string _description;
        private string _category;
        private string _unit;
        private float  _prize;
        private float _availableDiscount;
        private int _criticalAmount;
        private int _availableAmount;
        private float _time;
        
        //private Image _image;

        //public Image Image
        //{
        //    get { return _image; }
        //    set { _image = value; }
        //}


        public float Time
        {
            get { return _time; }
            set { _time = value; }
        }


        public int AvaiableAmount
        {
            get { return _availableAmount; }
            set { _availableAmount = value; }
        }


        public int CriticalAmount
        {
            get { return _criticalAmount; }
            set { _criticalAmount = value; }
        }


        public float AvailableDiscount
        {
            get { return _availableDiscount; }
            set { _availableDiscount = value; }
        }

        public float  Prize
        {
            get { return _prize; }
            set { _prize = value; }
        }


        public string Unit
        {
            get { return _unit; }
            set { _unit = value; }
        }

        public string Category
        {
            get { return _category; }
            set { _category = value; }
        }


        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }


        public string ServiceName
        {
            get { return _name; }
            set { _name = value;}
        }

        #endregion

        #region Events

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            this.ServiceName = txtName.Text;
        }

        private void rtxtDescription_TextChanged(object sender, EventArgs e)
        {
            rtxtDescription.ScrollToCaret();
            rtxtDescription.Select(rtxtDescription.Text.Length, 0);
            this.Description = rtxtDescription.Text;
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Category = cmbCategory.Text;
        }

        private void cmbUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Unit = cmbUnit.Text;
        }

        private void txtPrize_TextChanged(object sender, EventArgs e)
        {
            this.Prize = Convert.ToSingle(txtPrize.Text);
        }

        private void txtAvailableDiscount_TextChanged(object sender, EventArgs e)
        {
            this.AvailableDiscount = Convert.ToSingle(txtAvailableDiscount.Text) / 100;
        }

        private void txtAvailableAmount_TextChanged(object sender, EventArgs e)
        {
            this.AvaiableAmount = Convert.ToInt16(txtAvailableAmount.Text);
        }

        private void txtCriticalAmount_TextChanged(object sender, EventArgs e)
        {
            this.CriticalAmount = Convert.ToInt16(txtCriticalAmount.Text);
        }

        private void txtTime_TextChanged(object sender, EventArgs e)
        {
            this.Time = Convert.ToSingle(txtTime.Text);
        }

        private void btnAddService_Click(object sender, EventArgs e)
        {
            if(_name!=string.Empty&&_category!=string.Empty&&_description!=string.Empty&&_unit!=string.Empty)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    var query = @"INSERT INTO ServiceTable (Name, Description, Category, Unit, Prize, AvailableDiscount, AvailableAmount, CriticalAmount, Time) VALUES (@name, @description, @category, @unit, @prize, @discount, @amount, @critical, @time)";
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@name", _name);
                        cmd.Parameters.AddWithValue("@description", _description);
                        cmd.Parameters.AddWithValue("@category", _category);
                        cmd.Parameters.AddWithValue("@unit", _unit);
                        cmd.Parameters.AddWithValue("@prize", _prize);
                        cmd.Parameters.AddWithValue("@discount", _availableDiscount);
                        cmd.Parameters.AddWithValue("@amount", _availableAmount);
                        cmd.Parameters.AddWithValue("@critical", _criticalAmount);
                        cmd.Parameters.AddWithValue("@time", _time);

                        connection.Open();
                        cmd.ExecuteNonQuery();
                        connection.Close();
                    }
                }
                btnAddService.BackColor = Color.Olive;
            }
            else
                btnAddService.BackColor = Color.Red;
        }
        #endregion
    }
}
