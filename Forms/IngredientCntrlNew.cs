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
            _nutriens["calories"] = 0;
            _nutriens["proteins"] = 0;
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
        #region Events
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
            if(txtPrize.Text != string.Empty && txtPrize.Text != "niepoprawny format")
            {
                var numbers = 0;
                var dots = 0;
                var other = 0;
                var prize = txtPrize.Text;
                foreach(var c in prize)
                {
                    if (Char.IsNumber(c))
                        numbers++;
                    else
                        if (Char.IsPunctuation(c))
                        dots++;
                    else
                        other++;
                }
                if(numbers == prize.Length || numbers == prize.Length - 1)
                {
                    try
                    {
                        Prize = Convert.ToDouble(prize);
                    }
                    catch
                    {
                        if (dots == 1)
                        {
                            prize = prize.Replace('.', ',');
                            Prize = Convert.ToDouble(prize);
                        }
                        else
                            txtPrize.Text = "nieprawidlowy format";
                    }
                }

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
                string protein = txtProtein.Text.Replace('.', ',');
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
                string fat = txtFat.Text.Replace('.', ',');
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
                string carbs = txtCarbs.Text.Replace('.', ',');
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
                try
                {
                    mongo.InsertRecord<Ingredient>("ingredients", ingredient);
                    btnNewIngredient.BackColor = Color.LightGreen;
                }
                catch
                {
                    MessageBox.Show("Produt o takiej samej nazwie istnieje w bazie");
                    btnNewIngredient.BackColor = Color.Red;
                }

            }
        }

        private void TxtCalories_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string calories = txtCalories.Text.Replace('.', ',');
                double amount = Convert.ToDouble(calories);
                if (amount <= 2000 && amount >= 0)
                    _nutriens["calories"] = Convert.ToDouble(amount);
                else
                    txtFat.Text = "Nielogiczne dane";
            }
            catch
            {
                txtFat.Text = "Zły format";
            }
        }

        private void TxtName_MouseClick(object sender, MouseEventArgs e)
        {
            txtName.Text = string.Empty;
        }

        private void TxtUnit_MouseClick(object sender, MouseEventArgs e)
        {
            txtUnit.Text = string.Empty;
        }

        private void TxtPrize_MouseClick(object sender, MouseEventArgs e)
        {
            txtPrize.Text = string.Empty;
        }

        private void TxtProtein_MouseClick(object sender, MouseEventArgs e)
        {
            txtProtein.Text = string.Empty;
        }

        private void TxtFat_MouseClick(object sender, MouseEventArgs e)
        {
            txtFat.Text = string.Empty;
        }

        private void TxtCarbs_MouseClick(object sender, MouseEventArgs e)
        {
            txtCarbs.Text = string.Empty;
        }


        private void TxtCalories_MouseClick(object sender, MouseEventArgs e)
        {
            txtCalories.Text = string.Empty;
        }

        #endregion


    }
}
