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
using ForestGladeApp.Classess;

namespace ForestGladeApp.Forms
{
    public partial class CntrlOrder : UserControl
    {
        public CntrlOrder()
        {
            InitializeComponent();
        }

        private void btnSummary_Click(object sender, EventArgs e)
        {
            flwServicesList.Controls.Clear();
        }

        private void BtnNuptials_Click(object sender, EventArgs e)
        {
            flwServicesList.Controls.Clear();
            MongoCRUD mongo = new MongoCRUD("ForestGladeDB");
            var services = mongo.LoadRecords<Service>("services");
            foreach(var s in services)
            {
                ServiceCntrl cntrl = new ServiceCntrl(s);
                cntrl.Width = flwServicesList.Width - 20;
                flwServicesList.Controls.Add(cntrl);
            }
        }
    }
}
