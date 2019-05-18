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
    public partial class IngredientCntrlNew : UserControl
    {
        private Ingredient ingredient;
        public IngredientCntrlNew()
        {
            InitializeComponent();
            txtName.Text = "Nazwa";
            txtUnit.Text = "Jednostka";
            txtPrize.Text = "Cena [zł]";
            _alergic = new List<string>();
            _nutriens = new Dictionary<string, double>();
            _nutriens["protein"] = 0;
            _nutriens["fat"] = 0;
            _nutriens["carbohydrates"] = 0;
        }
        private string _name;
        private string _unit;
        private double _prize;
        private List<string> _alergic;
        private Dictionary<string, double> _nutriens;

        public double Prize
        {
            get { return _prize; }
            set { _prize = value; }
        }


        public string Unit
        {
            get { return _unit; }
            set { _unit = value; }
        }


        public string IngredientName
        {
            get { return _name; }
            set { _name = value; }
        }

        private void TxtName_TextChanged(object sender, EventArgs e)
        {
            IngredientName = txtName.Text; 
        }

        private void TxtUnit_TextChanged(object sender, EventArgs e)
        {
            Unit = txtUnit.Text;
        }

        private void TxtPrize_TextChanged(object sender, EventArgs e)
        {
            string prize = txtPrize.Text.Replace(',', '.');
            try
            {
                Prize = Convert.ToDouble(prize);
            }
            catch
            {
                txtPrize.Text = "Niepoprawny format";
            }

        }

        private void CbAlegrens_SelectedIndexChanged(object sender, EventArgs e)
        {
            _alergic.Clear();
            var enumerator = cbAlegrens.CheckedItems.GetEnumerator();
            while(enumerator.MoveNext())
            {
                var current = enumerator.Current;
                _alergic.Add(current.ToString());
            }
        }

        private void TxtProtein_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string protein = txtProtein.Text.Replace(',', '.');
                double amount = Convert.ToDouble(protein);
                if (amount <= 100 && amount >= 0)
                    _nutriens["proteins"] = Convert.ToDouble(amount);
                else
                    txtProtein.Text = "Nielogiczne dane";
            }
            catch
            {
                txtProtein.Text = "Zły format";
            }
        }

        private void TxtFat_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string fat = txtFat.Text.Replace(',', '.');
                double amount = Convert.ToDouble(fat);
                if (amount <= 100 && amount >= 0)
                    _nutriens["fat"] = Convert.ToDouble(amount);
                else
                    txtFat.Text = "Nielogiczne dane";
            }
            catch
            {
                txtFat.Text = "Zły format";
            }
        }

        private void TxtCarbs_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string carbs = txtCarbs.Text.Replace(',', '.');
                double amount = Convert.ToDouble(carbs);
                if (amount <= 100 && amount >= 0)
                    _nutriens["carbohydrates"] = Convert.ToDouble(amount);
                else
                    txtCarbs.Text = "Nielogiczne dane";
            }
            catch
            {
                txtCarbs.Text = "Zły format";
            }
        }

        private void BtnNewIngredient_Click(object sender, EventArgs e)
        {
            MongoCRUD mongo = new MongoCRUD("ForestGladeDB");
            if(this.IngredientName!=string.Empty&&this.Unit!=string.Empty&&this.Prize!=0)
            {
                if(ingredient==null)
                    ingredient = new Ingredient(this.IngredientName, this.Unit, this.Prize);
                if (_alergic.Count != 0)
                    ingredient.alergic = _alergic;

                    ingredient.nutriens = _nutriens;
                    ingredient.AddToDb(mongo);
            }
        }
    }
}
