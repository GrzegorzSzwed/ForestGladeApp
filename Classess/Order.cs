using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ForestGladeApp.Classess
{
    class Order
    {
        #region Valuables
        private string Category;
        private Employee employee;
        private Customer customer;
        private DateTime InitDate;
        private DateTime StartDate;
        private DateTime StopDate;
        private float TotalPrize;
        private float AlreadyPaid;
        private string Status;
        private string ServicesTable;
        private List<Order> orders;
        #endregion  

        #region Contstruktor
        public Order(Employee employeeOrder, Customer customerOrder, string category)
        {
            this.InitDate = DateTime.Now;
            this.customer = customerOrder;
            this.employee = employeeOrder;
            this.Kategoria = category;
            InitOrderTable();
            orders = new List<Order>();
        }
        private void InitOrderTable()
        {
            this.ServicesTable = this.InitDate.Year.ToString() + this.InitDate.Month.ToString() + this.InitDate.Day.ToString() + this.Category.ToLower() + customer.Id.ToString() + employee.Id.ToString(); //YYYYMMDD_category_ID_ID
            using (SqlConnection connection = new SqlConnection(@"Data Source=GSZWEDPC\SQLEXPRESS;Initial Catalog=WeddingManagmentDB;Integrated Security=True"))
            {
                connection.Open();
                var query = string.Format(@"CREATE TABLE ""{0}"" (id int NOT NULL, IdService int NOT NULL, Count float NOT NULL, Prize float NOT NULL, ChosenDiscount float NOT NULL, PRIMARY KEY (id));",this.ServicesTable);
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.ExecuteNonQuery();
                }
                connection.Close();
            }
        }
        public Order(Employee employeeOrder, Customer customerOrder, string category, DateTime stop) :this(employeeOrder, customerOrder, category)
        {
            this.KoniecZamowienia = stop;
        }
        public Order(Employee employeeOrder, Customer customerOrder, string category, DateTime start, DateTime stop) : this(employeeOrder, customerOrder, category, stop)
        {
            this.StartZamowienia = start;
        }
        #endregion

        #region Methods
        public void AddOrderToDB()
        {
            using (SqlConnection connection = new SqlConnection(@"Data Source=GSZWEDPC\SQLEXPRESS;Initial Catalog=WeddingManagmentDB;Integrated Security=True"))
            {
                var query = @"INSERT INTO OrderTable (Category, EmployeeId, CustomerId, InitDate, BeginningDate, EndDate, ServicesTable) VALUES (@param1,@param2,@param3,@param4,@param5,@param6,@param7)";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@param1", this.Kategoria);
                    cmd.Parameters.AddWithValue("@param2", this.customer.Id);
                    cmd.Parameters.AddWithValue("@param3", this.employee.Id);
                    cmd.Parameters.AddWithValue("@param4", this.InitDate);
                    cmd.Parameters.AddWithValue("@param5", this.DzienZalozenia);
                    cmd.Parameters.AddWithValue("@param6", this.KoniecZamowienia);
                    cmd.Parameters.AddWithValue("@param7", this.ServicesTable);

                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }
        #endregion

        #region Properties
        public Customer Klient
        {
            get { return customer; }
            set { customer = value; }
        }
        public DateTime StartZamowienia
        {
            get { return StartDate; }
            set { StartDate = value; }
        }
        public Employee Pracownik
        {
            get { return employee; }
            set { employee = value; }
        }
        public List<Order> ListaUslug
        {
            get { return orders; }
            set { orders = value; }
        }
        public DateTime DzienZalozenia
        {
            get { return InitDate; }
            set { InitDate = value; }
        }
        public DateTime KoniecZamowienia
        {
            get { return StopDate; }
            set { StopDate = value; }
        }
        public string Kategoria
        {
            get { return Category; }
            set { Category = value; }
        }
        #endregion


    }
}
