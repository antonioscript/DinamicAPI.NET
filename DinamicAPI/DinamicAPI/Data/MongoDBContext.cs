﻿using MongoDB.Driver;

namespace DinamicAPI.Data;
public class MongoDBContext
{
    private readonly IMongoDatabase _database;
    public MongoDBContext(string connectionString, string databaseName)
    {
        var client = new MongoClient(connectionString);
        _database = client.GetDatabase(databaseName);
    }

    public IMongoDatabase GetDatabase() => _database;
}