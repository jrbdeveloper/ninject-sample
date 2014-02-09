
namespace Core.DTOs
{
    public class PersonDTO
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string EmailAddress { get; set; }

        public AddressDTO Address { get; set; }

        public PhoneDTO Phone { get; set; }
    }
}
