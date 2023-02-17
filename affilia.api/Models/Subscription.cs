namespace Affilia.Api.Models
{
    public class Subscription
    {
        public string? Id { get; set; }
        public string? Type { get; set; }
        public Payment? Payment { get; set; }
    }
}