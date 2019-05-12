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

            lblName.Text = service.name;
            rtxtDescription.Text = service.description;
            pictureService.Image = service.image;
        }

        private void Cb_CheckedChanged(object sender, EventArgs e)
        {
            add = cb.Checked;
        }
    }
}
