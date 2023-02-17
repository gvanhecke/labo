namespace Affilia.Api.Data.Models
{
    public class Payment
    {
        public string? Id { get; set; }
        public DateTime ExecutionDate { get; set; }
        public string? Description { get; set; }
        public double Amount { get; set; }
        public Subscription? Subscription { get; set; }
    }
}