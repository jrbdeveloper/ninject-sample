using App.Core.Contracts.Data;
using Core.DTOs;
using System.Collections.Generic;

namespace App.Data.DAOs
{
    public class PersonDAO : IPersonDAO
    {
        public List<PersonDTO> GetAddressBook()
        {
            //var people = new List<PersonDTO>();

            //people.Add(new PersonDTO
            //{
            //    PersonId = 1,
            //    FirstName = "John",
            //    LastName = "Doe",
            //    EmailAddress = "jdoe@email.net",

            //    Address = new AddressDTO
            //    {
            //        Street1 = "1234 Main Street",
            //        City = "Somewhere",
            //        State = "ID",
            //        ZipCode = "12345"
            //    },

            //    Phone = new PhoneDTO
            //    {
            //        AreaCode = 123,
            //        Prefix = 456,
            //        Sufix = 7890
            //    }
            //});

            //people.Add(new PersonDTO
            //{
            //    Id = 2,
            //    FirstName = "Jane",
            //    LastName = "Doe",
            //    EmailAddress = "janeDoe@email.net",

            //    Address = new AddressDTO
            //    {
            //        Street1 = "4321 Mystery Lane",
            //        City = "Yourtown",
            //        State = "OH",
            //        ZipCode = "74632"
            //    },

            //    Phone = new PhoneDTO
            //    {
            //        AreaCode = 321,
            //        Prefix = 654,
            //        Sufix = 0987
            //    }
            //});

            //return people;
            return new List<PersonDTO>();
        }
    }
}
