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
            tbl.BringToFront();
            _toMove = false;
            _ifinList = true;
            _todelete = false;
        }

        public bool _toMove { get; set; }
        private string _name;
        private string _description;
        private Image _image;
        private int _id;
        private bool _ifinList;
        private bool _todelete;
        private int _width;

        public int WidthContrl
        {
            get { return _width; }
            set { _width = value; this.Width = value; pnlTimeLine.Width = value; }
        }


        public bool Delete
        {
            get { return _todelete; }
            set { _todelete = value; }
        }


        public bool InServicesList
        {
            get { return _ifinList; }
            set { _ifinList = value; btnAdd.Visible = value; lblDescription.Visible = value; pnlTimeLine.BringToFront(); this.Height = 30; }
        }


        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }

        public Image ImageService
        {
            get { return _image; }
            set { _image = value; picture.Image = value; }
        }

        public string Description
        {
            get { return _description; }
            set { _description = value; lblDescription.Text = value; }
        }

        public string NameService
        {
            get { return _name; }
            set { _name = value; lblName.Text = value; lblTimeLineName.Text = value; }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _toMove ^= true;
            if (_toMove)
                btnAdd.BackColor = Color.Orange;
            else
                btnAdd.BackColor = Color.White;
        }

        private void tbl_MouseEnter(object sender, EventArgs e)
        {
            tbl.BackColor = Color.LightGray;
        }

        private void tbl_MouseLeave(object sender, EventArgs e)
        {
            tbl.BackColor = Color.White;
        }

        private void pnlTimeLine_MouseEnter(object sender, EventArgs e)
        {
            pnlTimeLine.BackColor = Color.LightGray;
        }

        private void pnlTimeLine_MouseLeave(object sender, EventArgs e)
        {
            pnlTimeLine.BackColor = Color.White;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (Delete)
                btnClose.BackColor = Color.Silver;
            else
                btnClose.BackColor = Color.White;

            _todelete ^= true;
        }
    }
}
