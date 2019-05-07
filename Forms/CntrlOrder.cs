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
        private Order order;
        private string connectionString = @"Data Source=GSZWEDPC\SQLEXPRESS;Initial Catalog=WeddingManagmentDB;Integrated Security=True";
        public CntrlOrder()
        {
            InitializeComponent();
        }

        private void btnNuptials_Click(object sender, EventArgs e)
        {
            CntrlTimeLine cntrlTimeLine = new CntrlTimeLine();
            cntrlTimeLine.Range = "Ślub";
            cntrlTimeLine.Width = flwTimeLine.Width - 40;
            flwTimeLine.Controls.Add(cntrlTimeLine);
            AddControlsByCategory("[Wesele] Usługi");
        }

        private void AddControlsByCategory(string v)
        {


            flwServicesList.Controls.Clear();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                var query = "SELECT id, Name, Description FROM ServiceTable WHERE Category ='" + v + "'";
                connection.Open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, connection);
                connection.Close();
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                if (dataTable.Rows.Count != 0)
                {
                    foreach (DataRow row in dataTable.Rows)
                    {
                        CntrlServiceList cntrl = new CntrlServiceList();
                        FillServiceUsingRow(cntrl, row);
                        cntrl.WidthContrl = flwServicesList.Width - 40;
                        flwServicesList.Controls.Add(cntrl);
                    }
                }
            }
        }

        private void AddControlsByCategory(List<string> categories)
        {
            flwServicesList.Controls.Clear();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                foreach(string cat in categories)
                {
                    var query = "SELECT id, Name, Description FROM ServiceTable WHERE Category ='" + cat + "'";
                    connection.Open();
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, connection);
                    connection.Close();
                    DataTable dataTable = new DataTable();
                    sqlDataAdapter.Fill(dataTable);
                    if (dataTable.Rows.Count != 0)
                    {
                        foreach (DataRow row in dataTable.Rows)
                        {
                            CntrlServiceList cntrl = new CntrlServiceList();
                            FillServiceUsingRow(cntrl, row);
                            cntrl.Width = flwServicesList.Width - 40;
                            flwServicesList.Controls.Add(cntrl);
                        }
                    }
                }
            }
        }

        private void FillServiceUsingRow(CntrlServiceList cntrl, DataRow row)
        {
            cntrl.ID = Convert.ToInt16(row[0]);
            cntrl.NameService = row[1].ToString();
            cntrl.Description = row[2].ToString();
        }

        private void btnTrash_Click(object sender, EventArgs e)
        {
            if(flwTimeLine.Controls.Count!=0)
            {
                foreach (UserControl cntrl in flwTimeLine.Controls)
                {
                    if (cntrl.GetType() == typeof(CntrlTimeLine))
                    {
                        CntrlTimeLine cntrlTime = (CntrlTimeLine)cntrl;
                        if (cntrlTime.ifToDelete())
                            flwTimeLine.Controls.Remove(cntrlTime);
                    }
                    else
                    {
                        CntrlServiceList cntrlService = (CntrlServiceList)cntrl;
                        if (cntrlService.Delete)
                            flwTimeLine.Controls.Remove(cntrlService);
                    }
                }
            }
        }
        
        private void btnMigration_Click(object sender, EventArgs e)
        {
            if(flwServicesList.Controls.Count!=0)
            {
                foreach (CntrlServiceList cntrl in flwServicesList.Controls)
                {
                    if (cntrl._toMove)
                    {
                        cntrl.Width = flwTimeLine.Width - 40;
                        cntrl.InServicesList = false;
                        flwTimeLine.Controls.Add(cntrl);
                        flwServicesList.Controls.Remove(cntrl);
                    }
                }
            }
        }

        private void btnDinner_Click(object sender, EventArgs e)
        {
            CntrlTimeLine cntrlTimeLine = new CntrlTimeLine();
            cntrlTimeLine.Range = "Obiad";
            cntrlTimeLine.Width = flwTimeLine.Width - 40;
            flwTimeLine.Controls.Add(cntrlTimeLine);
            List<String> categories = new List<string>();
            categories.Add("[Wesele] Danie główne");
            categories.Add("[Wesele] Napoje");
            categories.Add("[Wesele] Zupa");
            AddControlsByCategory(categories);
        }

        private void btnDessert_Click(object sender, EventArgs e)
        {
            CntrlTimeLine cntrlTimeLine = new CntrlTimeLine();
            cntrlTimeLine.Range = "Deser";
            cntrlTimeLine.Width = flwTimeLine.Width - 40;
            flwTimeLine.Controls.Add(cntrlTimeLine);
            List<String> categories = new List<string>();
            categories.Add("[Wesele] Deser");
            categories.Add("[Wesele] Ciepłe napoje");
            AddControlsByCategory(categories);
        }

        private void btnTapas_Click(object sender, EventArgs e)
        {
            CntrlTimeLine cntrlTimeLine = new CntrlTimeLine();
            cntrlTimeLine.Range = "Zimna płyta";
            cntrlTimeLine.Width = flwTimeLine.Width - 40;
            flwTimeLine.Controls.Add(cntrlTimeLine);
            AddControlsByCategory("[Wesele] Zimna płyta");
        }

        private void btnSoup_Click(object sender, EventArgs e)
        {
            CntrlTimeLine cntrlTimeLine = new CntrlTimeLine();
            cntrlTimeLine.Range = "Kolacja";
            cntrlTimeLine.Width = flwTimeLine.Width - 40;
            flwTimeLine.Controls.Add(cntrlTimeLine);
            List<String> categories = new List<string>();
            categories.Add("[Wesele] Gorąca kolacja");
            categories.Add("[Wesele] Gorąca kolacja II");
            AddControlsByCategory(categories);
        }

        private void btnSupper_Click(object sender, EventArgs e)
        {
            CntrlTimeLine cntrlTimeLine = new CntrlTimeLine();
            cntrlTimeLine.Range = "Przekąska do tańca";
            cntrlTimeLine.Width = flwTimeLine.Width - 40;
            flwTimeLine.Controls.Add(cntrlTimeLine);
            List<String> categories = new List<string>();
            categories.Add("[Wesele] Gorąca kolacja");
            categories.Add("[Wesele] Gorąca kolacja II");
            AddControlsByCategory(categories);
        }

        private void btnGoodbyeDish_Click(object sender, EventArgs e)
        {
            CntrlTimeLine cntrlTimeLine = new CntrlTimeLine();
            cntrlTimeLine.Range = "Krokiecik";
            cntrlTimeLine.Width = flwTimeLine.Width - 40;
            flwTimeLine.Controls.Add(cntrlTimeLine);
            AddControlsByCategory("[Wesele] Gorąca kolacja III");
        }

        private void btnAdditionalServices_Click(object sender, EventArgs e)
        {
            CntrlTimeLine cntrlTimeLine = new CntrlTimeLine();
            cntrlTimeLine.Range = "Usługa";
            cntrlTimeLine.Width = flwTimeLine.Width - 40;
            flwTimeLine.Controls.Add(cntrlTimeLine);
            AddControlsByCategory("[Wesele] Usługi");
        }

        private void btnDrinks_Click(object sender, EventArgs e)
        {
            CntrlTimeLine cntrlTimeLine = new CntrlTimeLine();
            cntrlTimeLine.Range = "Napoje";
            cntrlTimeLine.Width = flwTimeLine.Width - 40;
            flwTimeLine.Controls.Add(cntrlTimeLine);
            List<String> categories = new List<string>();
            categories.Add("[Wesele] Ciepłe napoje");
            categories.Add("[Wesele] Napoje");
            AddControlsByCategory(categories);
        }

        private void btnSummary_Click(object sender, EventArgs e)
        {
            flwServicesList.Controls.Clear();
        }
    }
}
