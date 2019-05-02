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
        //panels
        private List<Panel> dashboard;
        private List<Panel> UserPanels;
        private List<Panel> OrderPanels;
        private List<Panel> ServicePanels;

        //SQL connection
        private string connectionString = @"Data Source=GSZWEDPC\SQLEXPRESS;Initial Catalog=WeddingManagmentDB;Integrated Security=True";

        //objects
        private Employee employee;
        private Order order;
        private Customer customer;
        private string direction;
        private List<Service> services;
        #endregion

        #region Contructor
        public Dashboard(int id)
        {
            InitializeComponent();

            //init all panels
            InitMainMenuDashboard();//top menu of buttons managed in region BUTTONS
            InitDashboardPanels();//bring to front user panel
            InitUserPanels();//bring to front list of users
            InitServicePanels();
            InitOrderPanels();


            employee = new Employee(id);
            lblName.Text = employee.Name;
            lblSurname.Text = employee.Surname;
            lblPermission.Text = employee.GetPermission();

            direction = "ASC";
        }
        #endregion

        #region Panels
        private void InitDashboardPanels()
        {
            dashboard = new List<Panel>();
            dashboard.Add(pnlUser);
            dashboard.Add(pnlService);
            dashboard.Add(pnlOrder);
            dashboard[0].BringToFront();
        }
        private void InitUserPanels()
        {
            UserPanels = new List<Panel>();
            UserPanels.Add(pnlUser_pnlInterface);//main panel that consinst of below panels
            UserPanels.Add(pnlUser_pnlAddUser);
            UserPanels.Add(pnlUser_pnlListUsers);
            UserPanels[0].BringToFront();
            UserPanels[2].BringToFront();
        }
        private void InitServicePanels()
        {
            ServicePanels = new List<Panel>();
            ServicePanels.Add(pnlService_pnlAddService);
            ServicePanels.Add(pnlService_pnlListServices);
        }

        private void InitOrderPanels()
        {
            OrderPanels = new List<Panel>();
            OrderPanels.Add(pnlOrder_pnlAddOrder);
            OrderPanels.Add(pnlOrder_pnlListOrders);
        }

        private void ShowUserPanel()
        {
            dashboard[0].BringToFront();
            UserPanels[2].BringToFront();//list users
        }

        private void ShowOrderPanel()
        {
            dashboard[2].BringToFront();
            OrderPanels[0].BringToFront();//show add orders panel
        }

        private void ShowServicePanel()
        {
            dashboard[1].BringToFront();
            ServicePanels[0].BringToFront();//show add order panels
        }
        #endregion

        #region Buttons
        private void btnBack_Click(object sender, EventArgs e)
        {
            InitMainMenuDashboard();
        }
        private void btnUser_Click(object sender, EventArgs e)
        {
            flwBtnsDashboard.Controls.Clear();
            flwBtnsDashboard.Controls.Add(btnUser_NewUser);
            flwBtnsDashboard.Controls.Add(btnUser_ListUsers);
            flwBtnsDashboard.Controls.Add(btnBack);
            ShowUserPanel();
        }
        private void btnService_Click(object sender, EventArgs e)
        {
            flwBtnsDashboard.Controls.Clear();
            flwBtnsDashboard.Controls.Add(btnService_NewService);
            flwBtnsDashboard.Controls.Add(btnService_ListServices);
            flwBtnsDashboard.Controls.Add(btnBack);
            ShowServicePanel();
            //ClearAllFlowLayouts();
            //var permission = employee.GetPermission();
            //if (permission == "administrator" || permission == "moderator")
            //    DashboardPanels[0].BringToFront();
        }
        private void btnOrder_Click(object sender, EventArgs e)
        {
            flwBtnsDashboard.Controls.Clear();
            flwBtnsDashboard.Controls.Add(btnOrder_NewOrder);
            flwBtnsDashboard.Controls.Add(btnOrder_ListOrders);
            flwBtnsDashboard.Controls.Add(btnBack);
            ShowOrderPanel();
            //ClearAllFlowLayouts();
            //NewOrderPanels.Add(pnlAddOrderAddInformations);
            //NewOrderPanels.Add(pnlAddOrderPnlServices);
            //DashboardPanels[3].BringToFront();
            //NewOrderPanels[0].BringToFront();
        }

        //btns for users
        private void btnUser_NewUser_Click(object sender, EventArgs e)
        {

        }
        private void btnUser_ListUsers_Click(object sender, EventArgs e)
        { 
        }

        //btns for orders
        private void btnOrder_NewOrder_Click(object sender, EventArgs e)
        {

        }
        private void btnOrder_ListOrders_Click(object sender, EventArgs e)
        {

        }

        //btns for services
        private void btnService_ListServices_Click(object sender, EventArgs e)
        {
            ServicePanels[1].BringToFront();
            services = new List<Service>();
            flwServices.Controls.Clear();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var command = @"SELECT id FROM ServiceTable";
                SqlDataAdapter adapter = new SqlDataAdapter(command, connection);
                DataTable dataTable = new DataTable();
                connection.Close();
                adapter.Fill(dataTable);
                if (dataTable.Rows.Count > 0)
                {
                    foreach (DataRow row in dataTable.Rows)
                        services.Add(new Service(Convert.ToInt16(row[0])));
                }
                var amount = services.Count;
                CntrlService[] cntrls = new CntrlService[amount];
                for (int i = 0; i < cntrls.Length; i++)
                {
                    cntrls[i] = TransformServiceToCntrl(new CntrlService(employee.GetPermission()), services[i]);
                    cntrls[i].Width = flwServices.Width-50;
                }
                flwServices.Controls.AddRange(cntrls);
            }
        }
        private void btnService_NewService_Click(object sender, EventArgs e)
        {
            ServicePanels[0].BringToFront();
        }

        #region Buttons_Methods
        private void InitMainMenuDashboard()
        {
            flwBtnsDashboard.Controls.Clear();
            flwBtnsDashboard.Controls.Add(btnOrder);
            flwBtnsDashboard.Controls.Add(btnService);
            flwBtnsDashboard.Controls.Add(btnUser);
        }
        #endregion

        #endregion

        #region Methods
        //Transform Object Service to Cntrl
        private CntrlService TransformServiceToCntrl(CntrlService cntrl, Service service)
        {
            if (cntrl != null && service != null)
            {
                cntrl.Nazwa = service.GetName();
                cntrl.Kategoria = service.GetCategory();
                cntrl.Opis = service.Description;
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

        #region User



        #endregion

        //#region Services
        //Show Panel for adding order

        //Adds service to DB
        //private void btnServiceAdd_Click(object sender, EventArgs e)
        //{
        //    if (txtServiceName.Text != string.Empty && cmbServiceCategory.Text != string.Empty && cmbServiceUnit.Text != string.Empty && txtServicePrize.Text != string.Empty)
        //    {
        //        using (SqlConnection connection = new SqlConnection(@"Data Source=GSZWEDPC\SQLEXPRESS;Initial Catalog=WeddingManagmentDB;Integrated Security=True"))
        //        {
        //            var query = @"INSERT INTO ServiceTable (Name, Category, Unit, Prize, AvailableDiscount, AvailableAmount, CriticalAmount, Image, Time) VALUES (@param1,@param2,@param3,@param4,@param5,@param6,@param7, @param8,@param9)";
        //            using (SqlCommand cmd = new SqlCommand(query, connection))
        //            {

        //                cmd.Parameters.AddWithValue("@param1", txtServiceName.Text.ToLower());
        //                cmd.Parameters.AddWithValue("@param2", cmbServiceCategory.Text.ToLower());
        //                cmd.Parameters.AddWithValue("@param3", cmbServiceUnit.Text.ToLower());
        //                cmd.Parameters.AddWithValue("@param4", float.Parse(txtServicePrize.Text));
        //                if (txtServiceDiscount.Text != string.Empty)
        //                    cmd.Parameters.AddWithValue("@param5", float.Parse(txtServiceDiscount.Text));
        //                else
        //                    cmd.Parameters.AddWithValue("@param5", 0);

        //                if (txtServiceAvailableAmount.Text != string.Empty)
        //                    cmd.Parameters.AddWithValue("@param6", float.Parse(txtServiceAvailableAmount.Text));
        //                else
        //                    cmd.Parameters.AddWithValue("@param6", 0);

        //                if (txtServiceCriticalAmount.Text != string.Empty)
        //                    cmd.Parameters.AddWithValue("@param7", float.Parse(txtServiceCriticalAmount.Text));
        //                else
        //                    cmd.Parameters.AddWithValue("@param7", 0);

        //                cmd.Parameters.AddWithValue("@param8", (imageService.Image == null) ? (object)DBNull.Value : imageService.Image).SqlDbType = SqlDbType.Image;
        //                if(txtServiceTime.Text!=string.Empty)
        //                    cmd.Parameters.AddWithValue("@param9", float.Parse(txtServiceTime.Text));
        //                else
        //                    cmd.Parameters.AddWithValue("@param9", 0);

        //                connection.Open();
        //                cmd.ExecuteNonQuery();
        //                connection.Close();
        //            }
        //        }
        //        txtServiceAvailableAmount.Text = string.Empty;
        //        txtServiceCriticalAmount.Text = string.Empty;
        //        txtServiceDiscount.Text = string.Empty;
        //        txtServiceName.Text = string.Empty;
        //        txtServicePrize.Text = string.Empty;
        //        txtServiceTime.Text = string.Empty;
        //    }
        //    else
        //    {
        //        txtServiceName.Text = "Proszę wpisać nazwę";
        //        txtServicePrize.Text = "Proszę wpisać cenę";
        //        cmbServiceCategory.Text = "Nie wybrano kategorii";
        //        cmbServiceUnit.Text = "Nie wybrano jednostki";
        //    }

        //}
        //Show Flow layout with orders

        //Clear all unnecesarry panels
        //private void ClearAllFlowLayouts()
        //{
        //    if (flwServicesList.Controls.Count != 0)
        //        flwServicesList.Controls.Clear();
        //    if (flwListOrders.Controls.Count != 0)
        //        flwListOrders.Controls.Clear();
        //}
        ////Displays on labels chosen unit
        //private void cmbServiceUnit_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    var txt = cmbServiceUnit.Text;
        //    lblServiceUnit.Text = txt;
        //    lblServiceCriticalAmount.Text = txt;
        //}
        ////Transform Object Service to Cntrl
        //private CntrlService TransformServiceToCntrl(CntrlService cntrl, Service service)
        //{
        //    if (cntrl != null && service != null)
        //    {
        //        cntrl.Nazwa = service.GetName();
        //        cntrl.Kategoria = service.GetCategory();
        //        cntrl.Cena = service.GetPrize();
        //        cntrl.Kolor = Color.White;
        //        cntrl.Identyfikator = service.GetId();
        //        cntrl.StanProduktu = service.GetAmount();
        //        cntrl.StanKrytyczny = service.GetCriticalAmount();
        //        //dodac funkcje zmieniajaca kolor ilosci pozostalych uslug
        //        return cntrl;
        //    }
        //    else
        //        return null;
        //}
        //#endregion

        //#region Orders

        //#region Initial Informations
        ////Displays main panel for orders

        ////Displays a panel with basic information about the order
        //private void pnlAddOrderBtnNewCustomer_Click(object sender, EventArgs e)
        //{
        //    NewOrderPanels[0].BringToFront();
        //}
        ////Loading object of ORDER and creating DB of specific order


        //#endregion

        //#region Specific Services in Order
        ////Displays a panel with particular orders
        //private void pnlAddOrderBtnServices_Click(object sender, EventArgs e)
        //{
        //    NewOrderPanels[1].BringToFront();
        //    cmbOrderManagmentList.Text = "Wszystkie";
        //    if (order!=null)
        //    {
        //        AddControlsToListView(order);
        //        //AddControlsToChosenView(order);
        //    }
        //    else
        //        NewOrderPanels[0].BringToFront();
        //}
        //private void AddControlsToListView(Order order)
        //{
        //    if(flwOrderManagmentlistView.Controls.Count==0)
        //    {
        //        using (SqlConnection connection = new SqlConnection(@"Data Source=GSZWEDPC\SQLEXPRESS;Initial Catalog=WeddingManagmentDB;Integrated Security=True"))
        //        {
        //            connection.Open();
        //            var query = @"SELECT Name, Category, AvailableAmount FROM ServiceTable";
        //            SqlDataAdapter sqlData = new SqlDataAdapter(query, connection);
        //            connection.Close();
        //            DataTable table = new DataTable();
        //            sqlData.Fill(table);
        //            LoadFlwListView(table);
        //        }
        //    }
        //}
        //private void LoadFlwListView(DataTable table)
        //{
        //    var count = table.Rows.Count;
        //    int i = 0;
        //    CntrlServiceList[] cntrls = new CntrlServiceList[count];
        //    if (count > 0)
        //    {
        //        foreach (DataRow row in table.Rows)
        //        {
        //            cntrls[i] = new CntrlServiceList();
        //            ConvertRowToCntrl(cntrls[i++], row);
        //        }
        //        flwOrderManagmentlistView.Controls.AddRange(cntrls);
        //    }
        //}
        //private void AddControlsToChosenView(Order order)
        //{
        //    throw new NotImplementedException();
        //}
        //private void ConvertRowToCntrl(CntrlServiceList cntrlServiceList, DataRow row)
        //{
        //    cntrlServiceList.Nazwa = row[0].ToString();
        //    cntrlServiceList.Kategoria = row[1].ToString();
        //    cntrlServiceList.DostepnaIlosc = Convert.ToInt16(row[2]);
        //    cntrlServiceList.Status = false;
        //    cntrlServiceList.Width = flwOrderManagmentlistView.Width;
        //}
        //private void btnOrderManagmentRefresh_Click(object sender, EventArgs e)
        //{
        //    flwOrderManagmentlistView.Controls.Clear();
        //    if (direction == "ASC")
        //    {
        //        direction = "DESC";
        //        btnOrderManagmentDirection.BackColor = Color.DarkGray;
        //    }
        //    else
        //    {
        //        direction = "ASC";
        //        btnOrderManagmentDirection.BackColor = Color.White;
        //    }
        //    using (SqlConnection connection = new SqlConnection(@"Data Source=GSZWEDPC\SQLEXPRESS;Initial Catalog=WeddingManagmentDB;Integrated Security=True"))
        //    {
        //        connection.Open();
        //        var category = cmbOrderManagmentList.Text.ToString();
        //        string query;
        //        if (category != "Wszystkie" && category != string.Empty)
        //            query = @"SELECT Name, Category, AvailableAmount FROM ServiceTable WHERE Category = '" + category + "' ORDER BY Name " + direction;
        //        else
        //            query = @"SELECT Name, Category, AvailableAmount FROM ServiceTable ORDER BY Name " + direction;
        //        SqlDataAdapter sqlData = new SqlDataAdapter(query, connection);
        //        connection.Close();
        //        DataTable table = new DataTable();
        //        sqlData.Fill(table);
        //        LoadFlwListView(table);
        //    }
        //}
        //private void cmbOrderManagmentList_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    flwOrderManagmentlistView.Controls.Clear();
        //    using (SqlConnection connection = new SqlConnection(@"Data Source=GSZWEDPC\SQLEXPRESS;Initial Catalog=WeddingManagmentDB;Integrated Security=True"))
        //    {
        //        connection.Open();
        //        string query;
        //        if (cmbOrderManagmentList.Text.ToString() != "Wszystkie")
        //            query = @"SELECT Name, Category, AvailableAmount FROM ServiceTable WHERE Category = '" + cmbOrderManagmentList.Text.ToString() + "' ORDER BY Name " + direction;
        //        else
        //            query = @"SELECT Name, Category, AvailableAmount FROM ServiceTable ORDER BY Name " + direction;
        //        SqlDataAdapter sqlData = new SqlDataAdapter(query, connection);
        //        connection.Close();
        //        DataTable table = new DataTable();
        //        sqlData.Fill(table);
        //        LoadFlwListView(table);
        //    }
        //}

        //private void btnOrderManagmentChosen_Click(object sender, EventArgs e)
        //{
        //    foreach (CntrlServiceList cntrl in flwOrderManagmentlistView.Controls)
        //    {
        //        if (cntrl.Status)
        //        {
        //            flwOrderManagmentlistView.Controls.Remove(cntrl);
        //            flwOrderManagmentChosen.Controls.Add(cntrl);
        //        }
        //    }
        //}






        //#endregion

        //#endregion


    }
}
