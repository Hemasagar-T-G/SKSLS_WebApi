namespace SKSLS_WebApi.Dto
{
    public class TransactionDto
    {
        public string UserId { get; set; }
        public string TransactionType { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
    }
}
