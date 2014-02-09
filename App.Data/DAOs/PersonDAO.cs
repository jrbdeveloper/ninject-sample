using App.Core.Contracts.Data;
using Core.DTOs;
using System.Collections.Generic;

namespace App.Data.DAOs
{
    public class PersonDAO : IPersonDAO
    {
        public List<PersonDTO> GetAddressBook()
        {
            var people = new List<PersonDTO>();

            people.Add(new PersonDTO
            {
                Id = 1,
                FirstName = "John",
                LastName = "Bales",
                EmailAddress = "johnbales@cox.net",

                Address = new AddressDTO
                {
                    Street1 = "9644 Seth Lane",
                    City = "Santee",
                    State = "CA",
                    ZipCode = "92071"
                },

                Phone = new PhoneDTO
                {
                    AreaCode = 619,
                    Prefix = 749,
                    Sufix = 2322
                }
            });

            people.Add(new PersonDTO
            {
                Id = 2,
                FirstName = "Michelle",
                LastName = "Bales",
                EmailAddress = "michelleis@cox.net",

                Address = new AddressDTO
                {
                    Street1 = "9644 Seth Lane",
                    City = "Santee",
                    State = "CA",
                    ZipCode = "92071"
                },

                Phone = new PhoneDTO
                {
                    AreaCode = 619,
                    Prefix = 749,
                    Sufix = 2322
                }
            });

            return people;
        }
    }
}
