using Core.DTOs;
using System.Collections.Generic;

namespace App.Core.Contracts.Data
{
    public interface IPersonDAO
    {
        List<PersonDTO> GetAddressBook();
    }
}
