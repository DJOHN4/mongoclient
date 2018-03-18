using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoClientTool
{
    public static class DBManager
    {
        private static string connectionString = ConfigurationManager.AppSettings["mongoDB"].ToString();
        public static string DatabaseName { get { return _dbName; } set { _dbName = value; } }

        private static IMongoClient _client = null;
        private static IMongoDatabase _db = null;
        private static string _dbName = "TRADEBOT";

        public static IMongoClient Client
        {
            get
            {
                if (_client == null)
                {
                    _client = new MongoClient(connectionString);
                }

                return _client;
            }
        }

        public static IMongoDatabase DB
        {
            get
            {
                if (_db == null)
                    _db = DBManager.Client.GetDatabase(DBManager.DatabaseName);
                return _db;
            }
        }

        public static IMongoCollection<T> GetCollection<T>() where T : Entity
        {
            return DBManager.DB.GetCollection<T>(typeof(T).Name);
        }

        public static IEnumerable<T> GetEntityList<T>(FilterDefinition<T> query) where T : Entity
        {
            var collection = DBManager.DB.GetCollection<T>(typeof(T).Name);
            return collection.Find<T>(query).ToList();
        }

        public static T GetEntity<T>(FilterDefinition<T> query) where T : Entity
        {
            var collection = DBManager.DB.GetCollection<T>(typeof(T).Name);
            return collection.Find<T>(query).SingleOrDefault<T>();
        }

        public static bool InsertEntity<T>(T entity) where T : Entity
        {
            GetCollection<T>().InsertOne(entity);
            return true;
        }
        public static bool UpdateEntity<T>(UpdateDefinition<T> updateInfo, FilterDefinition<T> query) where T : Entity
        {
            GetCollection<T>().UpdateOne(query, updateInfo);
            return true;
        }
    }
}
