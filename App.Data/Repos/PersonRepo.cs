using App.Core.Contracts.Data;
using Core.DTOs;
using System.Collections.Generic;
using System.Linq;

namespace App.Data.Repos
{
    public class PersonRepo : IPersonRepo
    {
        private MVCExampleEntities context;

        public PersonRepo()
        {
            context = new MVCExampleEntities();
        }

        public List<PersonDTO> GetPeople()
        {
            var result = from p in context.People
                         join e in context.Emails on p.EmailId equals e.EmailId into email
                         join ph in context.Phones on p.PhoneId equals ph.PhoneId into phone
                         from j in email.DefaultIfEmpty()
                         from ph in phone.DefaultIfEmpty()
                         select new PersonDTO
                         {
                             Id = p.PersonId,
                             FirstName = p.FirstName,
                             LastName = p.LastName,
                             EmailAddress = (j.Address == null ? string.Empty : j.Address),
                             Phone = new PhoneDTO
                             {
                                 AreaCode = ph.AreaCode,
                                 Prefix = ph.Prefix,
                                 Sufix = ph.Sufix
                             }
                         };

            return result.ToList();
        }
    }
}
