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
    public partial class IngredientCntrl : UserControl
    {
        private Ingredient ingredient;
        public IngredientCntrl(Ingredient ingredient)
        {
            InitializeComponent();
            this.ingredient = ingredient;
            lblName.Text = this.ingredient.name;
            lblUnit.Text = this.ingredient.unit;
            txtCount.Text = string.Empty;
        }
        private double _amount;
        #region Properties
        public double Amount
        {
            get { return _amount; }
            set { _amount = value; }
        }
        public Ingredient GetIngredient()
        {
            return ingredient;
        }
        #endregion
        #region Events
        private void TblLayout_MouseEnter(object sender, EventArgs e)
        {
            tblLayout.BackColor = Color.LightGray;
            txtCount.Text = "ilość";
        }
        private void TblLayout_MouseLeave(object sender, EventArgs e)
        {
            tblLayout.BackColor = Color.White;
            txtCount.Text = string.Empty;
        }
        private void TxtCount_Click(object sender, EventArgs e)
        {
            txtCount.Text = string.Empty;
        }
        private void TxtCount_Leave(object sender, EventArgs e)
        {
            int numbers = 0;
            int other = 0;
            if(txtCount.Text != string.Empty && txtCount.Text != "Wrong type")
            {
                foreach (char c in txtCount.Text)
                {
                    if (!Char.IsWhiteSpace(c)&!Char.IsSeparator(c))
                    {
                            if (Char.IsNumber(c))
                                numbers++;
                            else
                                other++;
                    }
                }
                if (other != 0)
                    txtCount.Text = "Wrong type";
                else
                {
                    string count = txtCount.Text;
                    count.Replace(',', '.');
                    Amount = Convert.ToDouble(count);
                }
            }
        }
        #endregion
    }
}
