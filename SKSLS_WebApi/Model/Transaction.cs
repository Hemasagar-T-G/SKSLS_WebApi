using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace SKSLS_WebApi.Model
{
    public class Transaction
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public string CustomerName { get; set; }

        public TransactionType TransactionType { get; set; }

        public decimal Amount { get; set; }

        public DateTime Date { get; set; }

        public string Description { get; set; }
    }
}
