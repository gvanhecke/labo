namespace Affilia.Api.Data.Models
{
    public class PersonalInformation
    {
        public Address? HomeAddress { get; set; }

        public ICollection<Parent>? Parents {get; set;}
    }
}