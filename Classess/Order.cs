using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MongoDB.Bson.Serialization.Attributes;

namespace ForestGladeApp.Classess
{
    class Order
    {
        [BsonId]
        public Guid id { get; set; }
        public string category { get; set; }
        public double totalPrize { get; set; }
        public double alreadyPaid { get; set; }
        public PersonModel employee { get; set; }
        public PersonModel customer { get; set; }
        public DateTime EstablishedDate { get; set; }
        public DateTime BeginningDate { get; set; }
        public DateTime FinishDate { get; set; }
        public List<Service> services { get; set; }

        public Order(PersonModel employee, PersonModel customer, string category)
        {
            this.employee = employee;
            this.customer = customer;
            this.category = category;
        }
    }
}
