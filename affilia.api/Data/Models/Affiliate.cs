namespace Affilia.Api.Data.Models
{
    public class Affiliate
    {
        public string? Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Level? Level { get; set; }
        public string? Gender { get; set; }
        public FederalLicense? FederalLicense { get; set; }
        public PersonalInformation? PersonalInfo { get; set; }
        public ICollection<Link>? Relationships { get; set; }
    }

    public class Link
    {
        public string Href { get; set; } = string.Empty;
        public string Type { get; set; } = string.Empty;
    }
}