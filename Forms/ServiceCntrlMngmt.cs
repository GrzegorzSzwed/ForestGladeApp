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
    public partial class ServiceCntrlMngmt : UserControl
    {
        private Dictionary<string, double> _ingredients;
        private Service service;
        MongoCRUD mongo;
        public ServiceCntrlMngmt()
        {
            InitializeComponent();
            _ingredients = new Dictionary<string, double>();
            mongo = new MongoCRUD("ForestGladeDB");
        }

        private string _name;
        private string _category;
        private string _description;
        private string _unit;
        private double _prize;
        private double _availableAmount;
        private double _dicount;

        #region Properties
        public double Discount
        {
            get { return _dicount; }
            set { _dicount = value; txtDiscount.Text = value.ToString(); }
        }

        public double AvailableAmount
        {
            get { return _availableAmount; }
            set { _availableAmount = value; txtAmount.Text = value.ToString(); }
        }


        public double Prize
        {
            get { return _prize; }
            set { _prize = value; txtPrize.Text = value.ToString(); }
        }


        public string Unit
        {
            get { return _unit; }
            set { _unit = value; cmbUnit.Text = value; }
        }


        public string Description
        {
            get { return _description; }
            set { _description = value; rtxtDescription.Text = value; }
        }


        public string Category
        {
            get { return _category; }
            set { _category = value; cmbCategory.Text = value;  }
        }


        public string ServiceName
        {
            get { return _name; }
            set { _name = value; txtName.Text = value; }
        }
        #endregion

        #region Events
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (txtName.Text != string.Empty && cmbCategory.Text != string.Empty && cmbUnit.Text != string.Empty)
            {
                Service service = new Service(txtName.Text, cmbCategory.Text, cmbUnit.Text);
                service.prize = Convert.ToDouble(txtPrize.Text);
                service.description = rtxtDescription.Text;
                if (txtAmount.Text != string.Empty)
                    service.amount = Convert.ToDouble(txtAmount.Text);
                if (txtDiscount.Text != string.Empty)
                    service.discount = Convert.ToDouble(txtDiscount.Text);
                service.image = picture.Image;

                MongoCRUD mongo = new MongoCRUD("ForestGladeDB");
                mongo.InsertRecord("services", service);
                MessageBox.Show("Dodano nową usługę");

                txtAmount.Text = string.Empty;
                cmbCategory.Text = string.Empty;
                txtDiscount.Text = string.Empty;
                txtPrize.Text = string.Empty;
                cmbUnit.Text = string.Empty;
                rtxtDescription.Text = string.Empty;
            }
        }

        private void BtnNewIngredient_Click(object sender, EventArgs e)
        {
            flwIngredietns.Controls.Clear();

            var cntrl = new IngredientCntrlNew();
            flwIngredietns.Controls.Add(cntrl);
        }

        private void BtnListIngredients_Click(object sender, EventArgs e)
        {
            flwIngredietns.Controls.Clear();


            List<Ingredient> ingredients = new List<Ingredient>();
            ingredients = mongo.LoadRecords<Ingredient>("ingredients");
            IngredientCntrl[] cntrls = new IngredientCntrl[ingredients.Count];
            int index = 0;
            if(ingredients.Count!=0)
            {
                foreach (Ingredient ingrd in ingredients)
                    cntrls[index++] = new IngredientCntrl(ingrd);
            }

            flwIngredietns.Controls.AddRange(cntrls);
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            _ingredients.Clear();
            if(flwIngredietns.Controls.Count>1)
            {
                    string[] names = new string[flwIngredietns.Controls.Count];
                    IngredientCntrl[] unboxed = new IngredientCntrl[flwIngredietns.Controls.Count];
                    var i = 0;
                    foreach (var cntrl in flwIngredietns.Controls)
                    {
                        if (cntrl.GetType() == typeof(IngredientCntrl))
                        {
                            unboxed[i] = (IngredientCntrl)cntrl;
                            if (unboxed[i].Amount != 0)
                            {
                                names[i] = unboxed[i].GetIngredient().name;
                                _ingredients.Add(unboxed[i].GetIngredient().name, unboxed[i++].Amount);
                            }
                        }
                    }
                    listIngredients.DataSource = names;
            }
        }

        private void TxtName_MouseClick(object sender, MouseEventArgs e)
        {
            txtName.Text = string.Empty;
        }

        private void CmbCategory_MouseClick(object sender, MouseEventArgs e)
        {
            cmbCategory.Text = string.Empty;
        }

        private void CmbUnit_MouseClick(object sender, MouseEventArgs e)
        {
            cmbUnit.Text = string.Empty;
        }

        private void TxtPrize_MouseClick(object sender, MouseEventArgs e)
        {
            txtPrize.Text = string.Empty;
        }

        private void TxtAmount_MouseClick(object sender, MouseEventArgs e)
        {
            txtAmount.Text = string.Empty;
        }

        private void TxtDiscount_MouseClick(object sender, MouseEventArgs e)
        {
            txtDiscount.Text = string.Empty;
        }
        private void TxtName_TextChanged(object sender, EventArgs e)
        {
            ServiceName = txtName.Text;
        }

        private void CmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            Category = cmbCategory.Text;
        }

        private void RtxtDescription_TextChanged(object sender, EventArgs e)
        {
            Description = rtxtDescription.Text;
        }

        private void CmbUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            Unit = cmbUnit.Text;
        }

        private void TxtPrize_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Prize = Convert.ToDouble(txtPrize.Text);
            }
            catch
            {
                txtPrize.Text = string.Empty;
            }
        }

        private void TxtAmount_TextChanged(object sender, EventArgs e)
        {
            try
            {
                AvailableAmount = Convert.ToDouble(txtAmount.Text);
            }
            catch
            {
                txtAmount.Text = string.Empty;
            }
        }
        private void TxtDiscount_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Discount = Convert.ToDouble(txtDiscount.Text);
            }
            catch
            {
                txtDiscount.Text = string.Empty;
            }
        }
        private void BtnAdd_Click_1(object sender, EventArgs e)
        {
            if (ServiceName != string.Empty && Category != string.Empty && Unit != string.Empty)
            {
                CreateService();
                if (service != null)
                {
                    try
                    {
                        mongo.InsertRecord<Service>("services", service);
                        ClearControls();
                    }
                    catch
                    {
                        MessageBox.Show("Usługa istnieje już w bazie, sprecyzuj nazwę lub zaktualizuj usługę");
                    }
                }

            }
            else
                MessageBox.Show("Nazwa, Kategoria i Jednostka potrzebne do stworzenia usługi");
        }

        private void ClearControls()
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Methods
        public void CreateService()
        {
            service = new Service(ServiceName, Category, Unit);
            if(_ingredients.Count!=0)
            {
                service.SetIngredients(_ingredients);
                service.CountCostOfIngredients();
            }

            service.amount = AvailableAmount;
            service.description = Description;
            service.discount = Discount;
            service.prize = Prize;
        }
        #endregion
    }
}
