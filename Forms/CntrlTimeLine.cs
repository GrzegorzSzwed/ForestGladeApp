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
    public partial class CntrlTimeLine : UserControl
    {
        public CntrlTimeLine()
        {
            InitializeComponent();
            _todelete = false;
            Hour = "GG";
            Minute = "MM";
        }

        private bool _todelete;
        private string _hour;
        private string _minute;
        private string _range;


        public string Minute
        {
            get { return _minute; }
            set { _minute = value; txtMinute.Text = value; }
        }


        public string Hour
        {
            get { return _hour; }
            set { _hour = value; txtHour.Text = value; }
        }


        public string Range
        {
            get { return _range; }
            set { _range = value; txtName.Text = value; }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            this.Range = txtName.Text.ToString();
        }

        private void txtHour_TextChanged(object sender, EventArgs e)
        {
            this.Hour = txtHour.Text.ToString();
        }

        private void txtMinute_TextChanged(object sender, EventArgs e)
        {
            this.Minute = txtMinute.Text.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (!_todelete)
                btnClose.BackColor = Color.Silver;
            else
                btnClose.BackColor = Color.White;

            _todelete ^= true;
        }

        public bool ifToDelete()
        {
            return _todelete;
        }
    }
}
