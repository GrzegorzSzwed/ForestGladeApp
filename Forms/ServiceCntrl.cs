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

namespace ForestGladeApp.Forms
{
    public partial class ServiceCntrl : UserControl
    {
        private Service service;
        public bool add { get; set; }
        public ServiceCntrl(Service service)
        {
            InitializeComponent();
            this.service = service;

            ServiceName = service.name;
            Category = service.category;
        }

        private string _name;
        private string _category;

        #region Properties
        public string Category
        {
            get { return _category; }
            set { _category = value; lblCategory.Text = value; }
        }

        public string ServiceName
        {
            get { return _name; }
            set { _name = value; lblName.Text = value; }
        }
        #endregion


        private void TblLayout_MouseEnter(object sender, EventArgs e)
        {
            tblLayout.BackColor = Color.LightGray;
        }

        private void TblLayout_MouseLeave(object sender, EventArgs e)
        {
            tblLayout.BackColor = Color.White;
        }
    }
}
