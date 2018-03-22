using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB.Driver;

namespace Arquitetura.MongoDB
{
    public class MongoWrapper
    {
        public static MongoDatabase GetDatabase()
        {
            // Create server settings to pass connection string, timeout, etc.
            MongoServerSettings settings = new MongoServerSettings();
            settings.Server = new MongoServerAddress("localhost", 27017);
            // Create server object to communicate with our server
            MongoServer server = new MongoServer(settings);
            // Get our database instance to reach collections and data
            var database = server.GetDatabase("gpv_teste");

            return database;
        }
    }
}