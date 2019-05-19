using System;
using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;

namespace ForestGladeApp.Classess
{
    public class Ingredient
    {
        //by ingredient I understand the most basic element of food, that cannot be divided in the shop (except of weight units)
        [BsonId]
        public Guid id { get; set; }
        public string name { get; set; }
        public string unit { get; set; }
        public double prize { get; set; }
        public Dictionary<string, double> nutriens { get; set; }

        public List<string> alergic { get; set; }

        public Ingredient(string name, string unit, double prize)
        {
            this.name = name;
            this.unit = unit;
            this.prize = prize;
        }

        public Ingredient(string name, string unit, double prize, double calories, double proteinContent, double fatContent, double carbsContent) : this(name, unit, prize)
        {
            nutriens = new Dictionary<string, double>(4);
            nutriens.Add("calories", calories);
            nutriens.Add("proteins", proteinContent);
            nutriens.Add("fat", fatContent);
            nutriens.Add("carbohydrates", carbsContent);
        }

        public Ingredient(string name, string unit, double prize, double calories, double proteinContent, double fatContent, double carbsContent, List<string> alergic):this(name,unit,prize, calories, proteinContent,fatContent,carbsContent)
        {
            if(alergic.Count!=0)
                this.alergic = new List<string>(alergic);
        }

        public void UpdateDB(MongoCRUD mongo)
        {
            Ingredient ing = mongo.LoadRecordByName<Ingredient>("ingredient", this.name);
            mongo.UpsertRecord("ingrediens", ing.id, this);
        }
    }
}
