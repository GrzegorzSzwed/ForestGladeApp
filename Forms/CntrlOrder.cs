using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using ForestGladeApp.Classess;

namespace ForestGladeApp.Forms
{
    public partial class CntrlOrder : UserControl
    {
        private List<Button> _chaptersWedding;
        private MongoCRUD mongo = new MongoCRUD("ForestGladeDB");
        public CntrlOrder()
        {
            InitializeComponent();
            _chaptersWedding = new List<Button>();
            flwChapters.Controls.Clear();
            flwListServices.Controls.Clear();
        }

        private void LoadChaptersWedding()
        {
            _chaptersWedding.Add(btnWeddingNuptials);
            _chaptersWedding.Add(btnWeddingLunch);
            _chaptersWedding.Add(btnWeddingTapas);
            _chaptersWedding.Add(btnWeddingFirstSupper);
            _chaptersWedding.Add(btnWeddingSecondSupper);
            _chaptersWedding.Add(btnWeddingThirdSupper);
            _chaptersWedding.Add(btnWeddingDrinks);
            _chaptersWedding.Add(btnWeddingOther);
        }

        private void CmbCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            string category = cmbCategories.Text;
            switch(category)
            {
                case "Wesele":
                    LoadWedding();
                    break;
                case "Restauracja":
                    LoadRestaurant();
                    break;
                case "Spa":
                    LoadSpa();
                    break;
                case "Grill":
                    LoadGrill();
                    break;
                default:
                    break;
            }
        }

        private void LoadGrill()
        {
            throw new NotImplementedException();
        }

        private void LoadSpa()
        {
            throw new NotImplementedException();
        }

        private void LoadRestaurant()
        {
            throw new NotImplementedException();
        }

        private void LoadWedding()
        {
            LoadChaptersWedding();
            foreach (var chapter in _chaptersWedding)
                flwChapters.Controls.Add(chapter);
        }

        private void BtnWeddingLunch_Click(object sender, EventArgs e)
        {
            var services = mongo.LoadRecordsByCategory<Service>("services", "obiad");

            foreach (var service in services)
                flwListServices.Controls.Add(new ServiceCntrl(service));
        }
    }
}
