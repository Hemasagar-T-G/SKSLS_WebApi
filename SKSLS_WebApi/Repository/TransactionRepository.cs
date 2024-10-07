using MongoDB.Driver;
using SKSLS_WebApi.Model;
using SKSLS_WebApi.Dto;
using Microsoft.Extensions.Options;

namespace SKSLS_WebApi.Repository
{
    public class TransactionRepository
    {
        private readonly IMongoCollection<Transaction> _transactions;

        public TransactionRepository(IMongoDatabase database, IOptions<DatabaseSettings> settings)
        {
            var collectionName = settings.Value.Collections["Transaction"];
            _transactions = database.GetCollection<Transaction>(collectionName);
        }

        public async Task<List<Transaction>> GetTransactionsByUserAndDate(string userId, DateTime date)
        {
            var filter = Builders<Transaction>.Filter.Where(t => t.UserId == userId && t.Date == date);
            return await _transactions.Find(filter).ToListAsync();
        }

        public async Task AddTransaction(Transaction transaction)
        {
            await _transactions.InsertOneAsync(transaction);
        }

        public async Task<List<Transaction>> GetTransactionsBetweenDates(string userId, DateTime startDate, DateTime endDate)
        {
            var filter = Builders<Transaction>.Filter.Where(t => t.UserId == userId && t.Date >= startDate && t.Date <= endDate);
            return await _transactions.Find(filter).ToListAsync();
        }
    }
}
