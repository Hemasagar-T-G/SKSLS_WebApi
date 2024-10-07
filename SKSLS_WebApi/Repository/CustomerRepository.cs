using SKSLS_WebApi.Model;
using MongoDB.Driver;
using Microsoft.Extensions.Options;

namespace SKSLS_WebApi.Repository
{
    public class CustomerRepository
    {
        private readonly IMongoCollection<Customer> _customers;

        public CustomerRepository(IMongoDatabase database, IOptions<DatabaseSettings> settings)
        {
            var collectionName = settings.Value.Collections["Customer"];
            _customers = database.GetCollection<Customer>(collectionName);
        }


        public async Task<List<Customer>> GetAllCustomers()
        {
            return await _customers.Find(c => true).ToListAsync();
        }

        public async Task<Customer> GetCustomerById(string customerId)
        {
            return await _customers.Find(c => c.Id == new ObjectId(customerId)).FirstOrDefaultAsync();
        }

        public async Task AddCustomer(Customer customer)
        {
            await _customers.InsertOneAsync(customer);
        }
    }
}
