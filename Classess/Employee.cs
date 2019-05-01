using System.Data.SqlClient;
using System.Data;

namespace ForestGladeApp.Classess
{
    public class Employee : Customer
    {
        private string Permission;
        public Employee(int id) : base ()
        {
            using (SqlConnection connection = new SqlConnection(@"Data Source=GSZWEDPC\SQLEXPRESS;Initial Catalog=WeddingManagmentDB;Integrated Security=True"))
            {
                connection.Open();
                var command = @"SELECT Name, Surname, Mail, Permission FROM PeapleTable WHERE id = '" + id + "'";
                SqlDataAdapter adapter = new SqlDataAdapter(command, connection);
                DataTable dataTable = new DataTable();
                connection.Close();
                adapter.Fill(dataTable);
                if (dataTable.Rows.Count == 1)
                {
                    DataRow row = dataTable.Rows[0];
                    this.Id = id;
                    this.Name = (string)row[0];
                    this.Surname = (string)row[1];
                    this.Mail = (string)row[2];
                    this.Permission = (string)row[3];
                }
            }
        }

        public string GetPermission()
        {
            return this.Permission;
        }
    }
}
