using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForestGladeApp.Forms
{
    public partial class CntrlServiceList : UserControl
    {
        public CntrlServiceList()
        {
            InitializeComponent();
        }

        #region Properties
        private string _name;
        private string _category;
        private bool _status;
        private Color _backgroundColor;
        private int _count;

        public int DostepnaIlosc
        {
            get { return _count; }
            set { _count = value; CheckBCntrlServiceList.Text = value.ToString(); }
        }


        public Color KolorTla
        {
            get { return _backgroundColor; }
            set { _backgroundColor = value; pnlServiceCntrlServiceList.BackColor = value; }
        }


        public bool Status
        {
            get { return _status; }
            set { _status = value; CheckBCntrlServiceList.Checked = value; }
        }


        public string Kategoria
        {
            get { return _category; }
            set { _category = value; lblCategoryServiceList.Text = value; }
        }


        public string Nazwa
        {
            get { return _name; }
            set { _name = value; LblNameCntrlService.Text = value; }
        }

        #endregion

        #region Events
        private void pnlServiceCntrlServiceList_MouseEnter(object sender, EventArgs e)
        {
            this.KolorTla = Color.Silver;
        }

        private void pnlServiceCntrlServiceList_MouseLeave(object sender, EventArgs e)
        {
            this.KolorTla = Color.LightGray;
        }

        private void CheckBCntrlServiceList_CheckedChanged(object sender, EventArgs e)
        {
            this.Status = CheckBCntrlServiceList.Checked;
        }

        #endregion


    }
}
