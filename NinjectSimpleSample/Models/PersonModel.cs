using Core.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NinjectSimpleSample.Models
{
    public class PersonModel
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string EmailAddress { get; set; }

        public AddressDTO Address { get; set; }

        public PhoneDTO Phone { get; set; }
    }
}