using Affilia.Api.Business.DTO;

namespace Affilia.Api.Data.Models
{
    public static class ParentExtensions
{
    public static ParentDto Map(this Parent parent)
    {
        if(parent == null) throw new ArgumentNullException(nameof(parent));
        if(string.IsNullOrWhiteSpace(parent.FirstName)) throw new InvalidDataException($"{nameof(parent.FirstName)} can't be null or empty string");
        if(string.IsNullOrWhiteSpace(parent.LastName)) throw new InvalidDataException($"{nameof(parent.LastName)} can't be null or empty string");
        if(string.IsNullOrWhiteSpace(parent.PhoneNumber)) throw new InvalidDataException($"{nameof(parent.PhoneNumber)} can't be null or empty string");

        return new ParentDto() 
        {
            FirstName = parent.FirstName,
            LastName = parent.LastName,
            PhoneNumber = parent.PhoneNumber
        };
    }
}
}
