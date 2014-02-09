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
        #endregion

        #region Constructor
        public PersonDO(IPersonDAO personDAO)
        {
            _personDAO = personDAO;
        }
        #endregion

        #region Public Methods
        public List<PersonDTO> GetAddressBook()
        {
            return _personDAO.GetAddressBook();
        }
        #endregion
    }
}
