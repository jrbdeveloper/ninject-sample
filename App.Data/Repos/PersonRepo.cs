using App.Core.Contracts.Data;
using Core.DTOs;
using System.Collections.Generic;
using System.Linq;

namespace App.Data.Repos
{
    public class PersonRepo : BaseRepository, IPersonRepo
    {
        public List<PersonDTO> GetPeople()
        {
            var result = from p in DataContext.People
                         join e in DataContext.Emails on p.EmailId equals e.EmailId into email
                         join ph in DataContext.Phones on p.PhoneId equals ph.PhoneId into phone
                         from j in email.DefaultIfEmpty()
                         from ph in phone.DefaultIfEmpty()
                         select new PersonDTO
                         {
                             Id = p.PersonId,
                             FirstName = p.FirstName,
                             LastName = p.LastName,
                             Email = new EmailDTO
                             {
                                 Address = j.Address
                             },
                             Phone = new PhoneDTO
                             {
                                 AreaCode = ph.AreaCode,
                                 Prefix = ph.Prefix,
                                 Sufix = ph.Sufix
                             }
                         };

            return result.ToList();
        }

        public PersonDTO GetById(int Id)
        {
            var result = from p in DataContext.People
                         join e in DataContext.Emails on p.EmailId equals e.EmailId into email
                         join ph in DataContext.Phones on p.PhoneId equals ph.PhoneId into phone
                         join a in DataContext.Addresses on p.AddressId equals a.AddressId into addy
                         from j in email.DefaultIfEmpty()
                         from ph in phone.DefaultIfEmpty()
                         from address in addy.DefaultIfEmpty()
                         where p.PersonId == Id
                         select new PersonDTO
                         {
                             Id = p.PersonId,
                             FirstName = p.FirstName,
                             LastName = p.LastName,
                             Address = new AddressDTO
                             {
                                 AddressId = address.AddressId,
                                 City = address.City,
                                 State = address.State,
                                 Street1 = address.Street1,
                                 Street2 = address.Street2,
                                 ZipCode = address.ZipCode
                             },
                             Email = new EmailDTO
                             {
                                 EmailId = j.EmailId,
                                 Address = j.Address,

                             },
                             Phone = new PhoneDTO
                             {
                                 PhoneId = ph.PhoneId,
                                 AreaCode = ph.AreaCode,
                                 Prefix = ph.Prefix,
                                 Sufix = ph.Sufix
                             }
                         };

            return result.First();
        }
    }
}
