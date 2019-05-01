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
    public partial class OrderCalendar : UserControl
    {
        public OrderCalendar()
        {
            InitializeComponent();
            this.BackColor = Color.White;
        }

        #region Properties
        private Color _backcolor;
        private DateTime _initDate;
        private DateTime _endDate;
        private string _category;

        public string Kategoria
        {
            get { return _category; }
            set { _category = value; }
        }


        public DateTime KoniecZamowienia
        {
            get { return _endDate; }
            set { _endDate = value; }
        }

        public DateTime Zalozenie
        {
            get { return _initDate; }
            set { _initDate = value; }
        }


        public Color Kolor
        {
            get { return _backcolor; }
            set { _backcolor = value; this.BackColor = value; }
        }

        #endregion

        #region Methods

        private void OrderCalendar_MouseEnter(object sender, EventArgs e)
        {
            this.Kolor = Color.Silver;
        }

        private void OrderCalendar_MouseLeave(object sender, EventArgs e)
        {
            this.Kolor = Color.White;
        }

        private void CntrlOrderCalendarInitDate_DateSelected(object sender, DateRangeEventArgs e)
        {
            this.Zalozenie = CntrlOrderCalendarInitDate.SelectionEnd;
        }

        private void CntrlOrderCalendarEndDate_DateSelected(object sender, DateRangeEventArgs e)
        {
            this.KoniecZamowienia = CntrlOrderCalendarEndDate.SelectionEnd;
        }

        private void CntrlOrderCalendarCmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Kategoria = CntrlOrderCalendarCmbCategory.Text;
        }

        #endregion
    }
}
