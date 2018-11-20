using System;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using FullFledgeExcelProject.Models;
namespace FullFledgeExcelProject.Data
{
    public class BookContext
    {
        private readonly IMongoDatabase _database = null;

        public BookContext(IOptions<Settings> settings)
        {
            var client = new MongoClient(settings.Value.ConnectionString);
            if (client != null)
                _database = client.GetDatabase(settings.Value.Database);
        }
        public IMongoCollection<Book> Books
        {
            get
            {
                return _database.GetCollection<Book>("Books");
            }
        }
    }
}
