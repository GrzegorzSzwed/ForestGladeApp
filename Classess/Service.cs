using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;

namespace ForestGladeApp.Classess
{
    class Service
    {
        private int id;
        private string Name;
        private string Category;
        private string Unit;
        private float Prize;
        private float AvailableDiscount;
        private int AvailableAmount;
        private int CriticalAmount;
        //private Image Image;
        //private float Time;
        public Service(string name)
        {
            using (SqlConnection connection = new SqlConnection(@"Data Source=GSZWEDPC\SQLEXPRESS;Initial Catalog=WeddingManagmentDB;Integrated Security=True"))
            {
                var query = @"SELECT Category, Unit, Prize, AvailableDiscount, id, AvailableAmount, CriticalAmount FROM ServiceTable WHERE Name = '" + name + "'" ;
                connection.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                connection.Close();
                DataTable tab = new DataTable();
                dataAdapter.Fill(tab);
                if(tab.Rows.Count > 0)
                {
                    DataRow row = tab.Rows[0];
                    this.Category = (string)row[0];
                    this.Unit = (string)row[1];
                    this.Prize = Convert.ToSingle(row[2]);
                    this.AvailableDiscount = Convert.ToSingle(row[3]);
                    this.id = Convert.ToInt16(row[4]);
                    this.AvailableAmount = Convert.ToInt16(row[5]);
                    this.CriticalAmount = Convert.ToInt16(row[6]);
                    this.Name = name;
                }
            }
        }

        public string GetName()
        {
            return this.Name;
        }
        public string GetCategory()
        {
            return this.Category;
        }
        public float GetPrize()
        {
            return this.Prize;
        }
        public int GetId()
        {
            return this.id;
        }

        public int GetAmount()
        {
            return this.AvailableAmount;
        }

        public int GetCriticalAmount()
        {
            return this.CriticalAmount;
        }
    }
}
