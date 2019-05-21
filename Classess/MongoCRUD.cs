using MongoDB;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;

namespace ForestGladeApp.Classess
{
    public class MongoCRUD
    {
        private IMongoDatabase db;

        public MongoCRUD(string database)
        {
            var client = new MongoClient();
            db = client.GetDatabase(database);
        }

        public void UpsertRecord<T>(string table, Guid id, T record)
        {
            var collection = db.GetCollection<T>(table);

            var result = collection.ReplaceOne(
                new BsonDocument("id", id),
                record,
                new UpdateOptions { IsUpsert = true });
        }

        public void DeleteRecord<T>(string table, Guid id)
        {
            var collection = db.GetCollection<T>(table);
            var filter = Builders<T>.Filter.Eq("id", id);

            collection.DeleteOne(filter);
        }

        public T LoadRecordByLoginAndPassword<T>(string login, string password)
        {
            var collection = db.GetCollection<T>("peaple");
            
            var builder = Builders<T>.Filter;
            var filter = builder.Eq("login", login) & builder.Eq("password", password);

            return collection.Find(filter).FirstOrDefault();
        }

        public void InsertRecord<T>(string table, T record)
        {
            var collection = db.GetCollection<T>(table);
            try
            {
                collection.InsertOne(record);
            }
            catch(Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.ToString());
            }
        }

        public List<T> LoadRecordsByCategory<T>(string table, string category)
        {
            var collection = db.GetCollection<T>(table);

            var filter = "{ category : '" + category + "'}";

            return collection.Find(filter).ToList();
        }

        public List<T> LoadRecords<T>(string table)
        {
            var collection = db.GetCollection<T>(table);

            return collection.Find(new BsonDocument()).ToList();
        }

        public T LoadRecordById<T>(string table, Guid id)
        {
            var collection = db.GetCollection<T>(table);
            var filter = "{ id : '" + id + "'}";

            return collection.Find(filter).First();
        }

        public T LoadRecordByName<T>(string table, string name)
        {
            var collection = db.GetCollection<T>(table);
            var filter = "{ name : '" + name + "'}";

            return collection.Find(filter).First();
        }

    }
}
