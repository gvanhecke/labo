using Affilia.Api.Data.Models;

namespace Affilia.Api.Business.DTO
{
    public class ParentDto
    {
        public string FirstName { get; init;}
        public string LastName {get; init;}
        public string PhoneNumber {get; init;}

        // private ParentDto(string firstName, string lastName, string phoneNumber)
        // {
        //     FirstName = firstName;
        //     LastName = lastName;
        //     PhoneNumber = phoneNumber;
        // }

        public static ParentDto Map(Parent parent)
        {
            if(parent==null) throw new ArgumentNullException(nameof(parent));
            if(string.IsNullOrWhiteSpace(parent.FirstName)) throw new InvalidDataException();
            if(string.IsNullOrWhiteSpace(parent.LastName)) throw new InvalidDataException();
            if(string.IsNullOrWhiteSpace(parent.PhoneNumber)) throw new InvalidDataException();


            var result = new ParentDto() 
            {
                FirstName = parent.FirstName,
                LastName = parent.LastName,
                PhoneNumber = parent.PhoneNumber
            };
            return result;
        }
    }
}