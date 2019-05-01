using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ForestGladeApp.Classess;
using System.Data.SqlClient;

namespace ForestGladeApp.Forms
{
    public partial class Dashboard : Form
    {
        #region Valuables
        private Employee employee;
        private List<Panel> DashboardPanels;
        private List<Panel> NewOrderPanels;
        private Order order;
        private Customer customer;
        private string direction;
        #endregion

        #region Contructor
        public Dashboard(int id)
        {
            InitializeComponent();
            employee = new Employee(id);
            lblName.Text = employee.Name;
            lblSurname.Text = employee.Surname;
            lblPermission.Text = employee.GetPermission();
            DashboardPanels = new List<Panel>();
            NewOrderPanels = new List<Panel>();

            direction = "ASC";

            DashboardPanels.Add(pnlMainMiddle); //add service by mod 
            DashboardPanels.Add(pnlListOrders); //lists all orders
            DashboardPanels.Add(pnlServicesList); //lists all services
            DashboardPanels.Add(pnlAddOrder); //add order
            DashboardPanels[1].BringToFront();
        }

        #endregion

        #region User
        private void btnHideUser_Click(object sender, EventArgs e)
        {
            if (pnlMainLeft.Visible == true)
                pnlMainLeft.Visible = false;
            else
                pnlMainLeft.Visible = true;
        }
        private void btnShowFlw_Click(object sender, EventArgs e)
        {
            ClearAllFlowLayouts();
            DashboardPanels[1].BringToFront();
        }
        #endregion

        #region Services
        //Show Panel for adding order
        private void btnAddService_Click(object sender, EventArgs e)
        {
            ClearAllFlowLayouts();
            var permission = employee.GetPermission();
            if (permission == "administrator" || permission == "moderator")
                DashboardPanels[0].BringToFront();
        }
        //Adds service to DB
        private void btnServiceAdd_Click(object sender, EventArgs e)
        {
            if (txtServiceName.Text != string.Empty && cmbServiceCategory.Text != string.Empty && cmbServiceUnit.Text != string.Empty && txtServicePrize.Text != string.Empty)
            {
                using (SqlConnection connection = new SqlConnection(@"Data Source=GSZWEDPC\SQLEXPRESS;Initial Catalog=WeddingManagmentDB;Integrated Security=True"))
                {
                    var query = @"INSERT INTO ServiceTable (Name, Category, Unit, Prize, AvailableDiscount, AvailableAmount, CriticalAmount, Image, Time) VALUES (@param1,@param2,@param3,@param4,@param5,@param6,@param7, @param8,@param9)";
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {

                        cmd.Parameters.AddWithValue("@param1", txtServiceName.Text.ToLower());
                        cmd.Parameters.AddWithValue("@param2", cmbServiceCategory.Text.ToLower());
                        cmd.Parameters.AddWithValue("@param3", cmbServiceUnit.Text.ToLower());
                        cmd.Parameters.AddWithValue("@param4", float.Parse(txtServicePrize.Text));
                        if (txtServiceDiscount.Text != string.Empty)
                            cmd.Parameters.AddWithValue("@param5", float.Parse(txtServiceDiscount.Text));
                        else
                            cmd.Parameters.AddWithValue("@param5", 0);

                        if (txtServiceAvailableAmount.Text != string.Empty)
                            cmd.Parameters.AddWithValue("@param6", float.Parse(txtServiceAvailableAmount.Text));
                        else
                            cmd.Parameters.AddWithValue("@param6", 0);

                        if (txtServiceCriticalAmount.Text != string.Empty)
                            cmd.Parameters.AddWithValue("@param7", float.Parse(txtServiceCriticalAmount.Text));
                        else
                            cmd.Parameters.AddWithValue("@param7", 0);

                        cmd.Parameters.AddWithValue("@param8", (imageService.Image == null) ? (object)DBNull.Value : imageService.Image).SqlDbType = SqlDbType.Image;
                        if(txtServiceTime.Text!=string.Empty)
                            cmd.Parameters.AddWithValue("@param9", float.Parse(txtServiceTime.Text));
                        else
                            cmd.Parameters.AddWithValue("@param9", 0);

                        connection.Open();
                        cmd.ExecuteNonQuery();
                        connection.Close();
                    }
                }
                txtServiceAvailableAmount.Text = string.Empty;
                txtServiceCriticalAmount.Text = string.Empty;
                txtServiceDiscount.Text = string.Empty;
                txtServiceName.Text = string.Empty;
                txtServicePrize.Text = string.Empty;
                txtServiceTime.Text = string.Empty;
            }
            else
            {
                txtServiceName.Text = "Proszę wpisać nazwę";
                txtServicePrize.Text = "Proszę wpisać cenę";
                cmbServiceCategory.Text = "Nie wybrano kategorii";
                cmbServiceUnit.Text = "Nie wybrano jednostki";
            }

        }
        //Show Flow layout with orders
        private void btnServiceFind_Click(object sender, EventArgs e)
        {
            var services = new List<Service>();
            flwServicesList.Controls.Clear();

                using (SqlConnection connection = new SqlConnection(@"Data Source=GSZWEDPC\SQLEXPRESS;Initial Catalog=WeddingManagmentDB;Integrated Security=True"))
                {
                    connection.Open();
                    var command = @"SELECT Name FROM ServiceTable";
                    SqlDataAdapter adapter = new SqlDataAdapter(command, connection);
                    DataTable dataTable = new DataTable();
                    connection.Close();
                    adapter.Fill(dataTable);
                    if (dataTable.Rows.Count > 0)
                    {
                        foreach (DataRow row in dataTable.Rows)
                            services.Add(new Service((string)row[0]));
                    }
                }

            var amount = services.Count;
            CntrlService[] cntrls = new CntrlService[amount];
            for (int i = 0; i < cntrls.Length; i++)
            {
                cntrls[i] = TransformServiceToCntrl(new CntrlService(employee.GetPermission()), services[i]);
            }
            flwServicesList.Controls.AddRange(cntrls);
            DashboardPanels[2].BringToFront();
        }
        //Clear all unnecesarry panels
        private void ClearAllFlowLayouts()
        {
            if (flwServicesList.Controls.Count != 0)
                flwServicesList.Controls.Clear();
            if (flwListOrders.Controls.Count != 0)
                flwListOrders.Controls.Clear();
        }
        //Displays on labels chosen unit
        private void cmbServiceUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            var txt = cmbServiceUnit.Text;
            lblServiceUnit.Text = txt;
            lblServiceCriticalAmount.Text = txt;
        }
        //Transform Object Service to Cntrl
        private CntrlService TransformServiceToCntrl(CntrlService cntrl, Service service)
        {
            if (cntrl != null && service != null)
            {
                cntrl.Nazwa = service.GetName();
                cntrl.Kategoria = service.GetCategory();
                cntrl.Cena = service.GetPrize();
                cntrl.Kolor = Color.White;
                cntrl.Identyfikator = service.GetId();
                cntrl.StanProduktu = service.GetAmount();
                cntrl.StanKrytyczny = service.GetCriticalAmount();
                //dodac funkcje zmieniajaca kolor ilosci pozostalych uslug
                return cntrl;
            }
            else
                return null;
        }
        #endregion

        #region Orders

        #region Initial Informations
        //Displays main panel for orders
        private void btnNewOrder_Click(object sender, EventArgs e)
        {
            ClearAllFlowLayouts();
            NewOrderPanels.Add(pnlAddOrderAddInformations);
            NewOrderPanels.Add(pnlAddOrderPnlServices);
            DashboardPanels[3].BringToFront();
            NewOrderPanels[0].BringToFront();
        }
        //Displays a panel with basic information about the order
        private void pnlAddOrderBtnNewCustomer_Click(object sender, EventArgs e)
        {
            NewOrderPanels[0].BringToFront();
        }
        //Loading object of ORDER and creating DB of specific order
        private void AddOrderBtnAddOrder_Click(object sender, EventArgs e)
        {
            CntrlUser cntrlUser = pnlAddUserCntrlCustomer;
            OrderCalendar cntrlCalendar = pnlAddUserCntrlCalendar;
            customer = new Customer(cntrlUser.Imie, cntrlUser.Nazwisko, cntrlUser.Mail, cntrlUser.Telofon);
            customer.Id = cntrlUser.GetId();
            order = new Order(employee, customer, cntrlCalendar.Kategoria);
            order.StartZamowienia = cntrlCalendar.Zalozenie;
            order.KoniecZamowienia = cntrlCalendar.KoniecZamowienia;
            order.AddOrderToDB();
            pnlAddOrderBtnNewCustomer.BackColor = Color.Teal;
        }

        #endregion

        #region Specific Services in Order
        //Displays a panel with particular orders
        private void pnlAddOrderBtnServices_Click(object sender, EventArgs e)
        {
            NewOrderPanels[1].BringToFront();
            cmbOrderManagmentList.Text = "Wszystkie";
            if (order!=null)
            {
                AddControlsToListView(order);
                //AddControlsToChosenView(order);
            }
            else
                NewOrderPanels[0].BringToFront();
        }
        private void AddControlsToListView(Order order)
        {
            if(flwOrderManagmentlistView.Controls.Count==0)
            {
                using (SqlConnection connection = new SqlConnection(@"Data Source=GSZWEDPC\SQLEXPRESS;Initial Catalog=WeddingManagmentDB;Integrated Security=True"))
                {
                    connection.Open();
                    var query = @"SELECT Name, Category, AvailableAmount FROM ServiceTable";
                    SqlDataAdapter sqlData = new SqlDataAdapter(query, connection);
                    connection.Close();
                    DataTable table = new DataTable();
                    sqlData.Fill(table);
                    LoadFlwListView(table);
                }
            }
        }
        private void LoadFlwListView(DataTable table)
        {
            var count = table.Rows.Count;
            int i = 0;
            CntrlServiceList[] cntrls = new CntrlServiceList[count];
            if (count > 0)
            {
                foreach (DataRow row in table.Rows)
                {
                    cntrls[i] = new CntrlServiceList();
                    ConvertRowToCntrl(cntrls[i++], row);
                }
                flwOrderManagmentlistView.Controls.AddRange(cntrls);
            }
        }
        private void AddControlsToChosenView(Order order)
        {
            throw new NotImplementedException();
        }
        private void ConvertRowToCntrl(CntrlServiceList cntrlServiceList, DataRow row)
        {
            cntrlServiceList.Nazwa = row[0].ToString();
            cntrlServiceList.Kategoria = row[1].ToString();
            cntrlServiceList.DostepnaIlosc = Convert.ToInt16(row[2]);
            cntrlServiceList.Status = false;
            cntrlServiceList.Width = flwOrderManagmentlistView.Width;
        }
        private void btnOrderManagmentRefresh_Click(object sender, EventArgs e)
        {
            flwOrderManagmentlistView.Controls.Clear();
            if (direction == "ASC")
            {
                direction = "DESC";
                btnOrderManagmentDirection.BackColor = Color.DarkGray;
            }
            else
            {
                direction = "ASC";
                btnOrderManagmentDirection.BackColor = Color.White;
            }
            using (SqlConnection connection = new SqlConnection(@"Data Source=GSZWEDPC\SQLEXPRESS;Initial Catalog=WeddingManagmentDB;Integrated Security=True"))
            {
                connection.Open();
                var category = cmbOrderManagmentList.Text.ToString();
                string query;
                if (category != "Wszystkie" && category != string.Empty)
                    query = @"SELECT Name, Category, AvailableAmount FROM ServiceTable WHERE Category = '" + category + "' ORDER BY Name " + direction;
                else
                    query = @"SELECT Name, Category, AvailableAmount FROM ServiceTable ORDER BY Name " + direction;
                SqlDataAdapter sqlData = new SqlDataAdapter(query, connection);
                connection.Close();
                DataTable table = new DataTable();
                sqlData.Fill(table);
                LoadFlwListView(table);
            }
        }
        private void cmbOrderManagmentList_SelectedIndexChanged(object sender, EventArgs e)
        {
            flwOrderManagmentlistView.Controls.Clear();
            using (SqlConnection connection = new SqlConnection(@"Data Source=GSZWEDPC\SQLEXPRESS;Initial Catalog=WeddingManagmentDB;Integrated Security=True"))
            {
                connection.Open();
                string query;
                if (cmbOrderManagmentList.Text.ToString() != "Wszystkie")
                    query = @"SELECT Name, Category, AvailableAmount FROM ServiceTable WHERE Category = '" + cmbOrderManagmentList.Text.ToString() + "' ORDER BY Name " + direction;
                else
                    query = @"SELECT Name, Category, AvailableAmount FROM ServiceTable ORDER BY Name " + direction;
                SqlDataAdapter sqlData = new SqlDataAdapter(query, connection);
                connection.Close();
                DataTable table = new DataTable();
                sqlData.Fill(table);
                LoadFlwListView(table);
            }
        }

        private void btnOrderManagmentChosen_Click(object sender, EventArgs e)
        {
            foreach (CntrlServiceList cntrl in flwOrderManagmentlistView.Controls)
            {
                if (cntrl.Status)
                {
                    flwOrderManagmentlistView.Controls.Remove(cntrl);
                    flwOrderManagmentChosen.Controls.Add(cntrl);
                }
            }
        }

        #endregion

        #endregion
    }
}
