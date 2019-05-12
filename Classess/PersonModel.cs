using System.Data.SqlClient;
using System.Data;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace ForestGladeApp.Classess
{
    public class PersonModel
    {
        [BsonId]
        public Guid id { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string login { get; set; }
        public string password { get; set; }
        public string permission { get; set; }
        public PersonModel()
        {

        }
        public PersonModel(string login, string password, string name, string surname, string permission)
        {
            this.login = login;
            this.password = password;
            this.permission = permission;
        }
    }
}
