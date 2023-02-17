namespace Affilia.Api.Data.Models
{
    public class Address
    {
        public string? Id {get;set;}
        public string? Street { get; set; }
        public string? HouseNumber { get; set; }
        public string? PostalCode { get; set; }
        public string? City { get; set; }
        public string? Country { get; set; }
    }
}