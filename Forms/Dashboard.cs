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
        private List<Panel> MainPanels;
        private List<Panel> ProgramPanels;

        private List<Panel> UserPanels;
        private List<Panel> OrderPanels;
        private List<Panel> ServicePanels;


        //objects
        private PersonModel employee;
        private Order order;
        private PersonModel customer;
        private List<Service> services;
        #endregion

        #region Contructor
        public Dashboard()
        {
            InitializeComponent();
            //init all panels
            InitMainPanels(new List<Panel>());
            InitProgramPanels(new List<Panel>());
        }
        #endregion

        #region Inits
        private void InitMainPanels(List<Panel> panels)
        {
            panels.Add(pnlInvitation);
            panels.Add(pnlProgram);
            panels.Add(pnlLogin);
            MainPanels = panels;
            MainPanels[0].BringToFront();
            flwTop.Controls.Clear();
            flwTop.Controls.Add(btnLogin);
        }
        private void InitFlws()
        {
            flwTop.Controls.Clear();
            flwTop.Controls.Add(btnLogout);
            flwOptions.Controls.Clear();
            flwOptions.Controls.Add(btnOrder);
            flwOptions.Controls.Add(btnService);
            flwOptions.Controls.Add(btnPeaple);
        }

        private void InitProgramPanels(List<Panel> list)
        {
            list.Add(pnlDefault);
            list.Add(pnlAddService);
            list.Add(pnlListServices);
            list.Add(pnlAddOrder);
            list.Add(pnlListOrders);
            list.Add(pnlAddEmployee);
            list.Add(pnlListEmployees);
            ProgramPanels = list;
            ProgramPanels[0].BringToFront();
        }
        #endregion

        #region Panels

        private void InitUserPanels()
        {
            UserPanels = new List<Panel>();
        }
        private void InitServicePanels()
        {
            ServicePanels = new List<Panel>();
        }

        private void InitOrderPanels()
        {
            OrderPanels = new List<Panel>();
        }

        #endregion

        #region Login
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            pnlLogin.Visible = true;
            MainPanels[2].BringToFront();
        }

        private void BtnLog_Click(object sender, EventArgs e)
        {
            MongoCRUD mongo = new MongoCRUD("ForestGladeDB");

            var user = mongo.LoadRecordByLoginAndPassword<PersonModel>(
                txtLogin.Text.ToString(), txtPassword.Text.ToString());

            if (user != null)
            {
                employee = user;
                MainPanels[1].BringToFront();
                txtLogin.Text = string.Empty;
                txtPassword.Text = string.Empty;
                InitFlws();

            }
            else
            {
                txtLogin.Text = string.Empty;
                txtPassword.Text = string.Empty;
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            MainPanels[0].BringToFront();
            pnlLogin.Visible = false;
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            MainPanels[0].BringToFront();
            employee = null;
            flwTop.Controls.Clear();
            flwOptions.Controls.Clear();
            flwTop.Controls.Add(btnLogin);
        }
        #endregion

        #region Buttons
        private void BtnHome_Click(object sender, EventArgs e)
        {
            flwOptions.Controls.Clear();
            flwOptions.Controls.Add(btnOrder);
            flwOptions.Controls.Add(btnService);
            flwOptions.Controls.Add(btnPeaple);

            ProgramPanels[0].BringToFront();
        }

        private void BtnOrder_Click(object sender, EventArgs e)
        {
            flwOptions.Controls.Clear();
            flwOptions.Controls.Add(btnOrder);
            flwOptions.Controls.Add(btnNewOrder);
            flwOptions.Controls.Add(btnListOrders);
            flwOptions.Controls.Add(btnHome);

            ProgramPanels[4].BringToFront();
        }

        private void BtnService_Click(object sender, EventArgs e)
        {
            flwOptions.Controls.Clear();
            flwOptions.Controls.Add(btnService);
            flwOptions.Controls.Add(btnNewService);
            flwOptions.Controls.Add(btnListServices);
            flwOptions.Controls.Add(btnHome);

            ProgramPanels[2].BringToFront();

            flwListServices.Controls.Clear();

            MongoCRUD mongo = new MongoCRUD("ForestGladeDB");
            var services = mongo.LoadRecords<Service>("services");
            foreach (var s in services)
            {
                var cntrl = new ServiceCntrl(s);
                flwListServices.Controls.Add(cntrl);
            }

        }

        private void BtnPeaple_Click(object sender, EventArgs e)
        {
            flwOptions.Controls.Clear();
            flwOptions.Controls.Add(btnPeaple);
            flwOptions.Controls.Add(btnNewEmployee);
            flwOptions.Controls.Add(btnListEmployees);
            flwOptions.Controls.Add(btnHome);

            ProgramPanels[6].BringToFront();
        }

        private void BtnOrder_MouseEnter(object sender, EventArgs e)
        {
            btnOrder.BackColor = Color.DimGray;
        }

        private void BtnOrder_MouseLeave(object sender, EventArgs e)
        {
            btnOrder.BackColor = Color.FromArgb(64, 64, 64);
        }

        private void BtnService_MouseEnter(object sender, EventArgs e)
        {
            btnService.BackColor = Color.DimGray;
        }

        private void BtnService_MouseLeave(object sender, EventArgs e)
        {
            btnService.BackColor = Color.FromArgb(64, 64, 64);
        }

        private void BtnPeaple_MouseEnter(object sender, EventArgs e)
        {
            btnPeaple.BackColor = Color.DimGray;
        }

        private void BtnPeaple_MouseLeave(object sender, EventArgs e)
        {
            btnPeaple.BackColor = Color.FromArgb(64, 64, 64);
        }

        private void BtnNewOrder_Click(object sender, EventArgs e)
        {
            ProgramPanels[3].BringToFront();
        }

        private void BtnNewService_Click(object sender, EventArgs e)
        {
            ProgramPanels[1].BringToFront();
        }

        private void BtnListOrders_Click(object sender, EventArgs e)
        {
            ProgramPanels[4].BringToFront();
        }

        private void BtnListServices_Click(object sender, EventArgs e)
        {
            ProgramPanels[2].BringToFront();

            flwListServices.Controls.Clear();

            MongoCRUD mongo = new MongoCRUD("ForestGladeDB");
            var services = mongo.LoadRecords<Service>("services");
            foreach (var s in services)
            {
                var cntrl = new ServiceCntrl(s);
                flwListServices.Controls.Add(cntrl);
            }
        }

        private void BtnNewEmployee_Click(object sender, EventArgs e)
        {
            ProgramPanels[5].BringToFront();
        }

        private void BtnListEmployees_Click(object sender, EventArgs e)
        {
            ProgramPanels[6].BringToFront();
        }

        #endregion
    }
}
