using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace SKSLS_WebApi.Model
{
    public class Customer
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public string CustomerName { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
    }
}
