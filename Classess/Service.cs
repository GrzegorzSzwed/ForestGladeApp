using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using MongoDB.Bson.Serialization.Attributes;

namespace ForestGladeApp.Classess
{
    public class Service
    {
        [BsonId]
        public Guid id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string category { get; set; }
        public string unit { get; set; }
        public double prize { get; set; }
        public double discount { get; set; }
        public double amount { get; set; }
        public Image image { get; set; }

        public Dictionary<Ingredient, double> ingredients;

        public Service(string name, string category, string unit)
        {
            this.name = name;
            this.category = category;
            this.unit = unit;
        }

        public Service(string name, string category, string unit, Dictionary<Ingredient,double> ingredients):this(name,category, unit)
        {
            ingredients = new Dictionary<Ingredient, double>(ingredients);
        }
    }
}
