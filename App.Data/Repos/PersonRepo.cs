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
            var result = from u in context.People
                         join e in context.Emails on u.EmailId equals e.EmailId into x
                         from j in x.DefaultIfEmpty()
                         select new PersonDTO
                         {
                             Id = u.PersonId,
                             FirstName = u.FirstName,
                             LastName = u.LastName,
                             EmailAddress = (j.Address == null ? string.Empty : j.Address),
                         };

            return result.ToList();
        }
    }
}
