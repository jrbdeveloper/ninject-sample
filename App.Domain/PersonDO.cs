using App.Core.Contracts.Data;
using App.Core.Contracts.Domain;
using Core.DTOs;
using System.Collections.Generic;

namespace App.Domain
{
    public class PersonDO : IPersonDO
    {
        #region Member Variables
        private readonly IPersonDAO _personDAO;
        private readonly IPersonRepo _personRepo;
        #endregion

        #region Constructor
        public PersonDO(IPersonDAO personDAO, IPersonRepo personRepo)
        {
            _personDAO = personDAO;
            _personRepo = personRepo;
        }
        #endregion

        #region Public Methods
        public List<PersonDTO> GetAddressBook()
        {
            return _personDAO.GetAddressBook();
        }

        public List<PersonDTO> GetAddressBookFromRepo()
        {
            return _personRepo.GetPeople();
        }
        #endregion
    }
}
