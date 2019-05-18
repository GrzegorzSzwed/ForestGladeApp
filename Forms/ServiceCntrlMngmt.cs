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
        public ServiceCntrlMngmt()
        {
            InitializeComponent();
        }

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

            MongoCRUD mongo = new MongoCRUD("ForestGladeDB");
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

        }
    }
}
