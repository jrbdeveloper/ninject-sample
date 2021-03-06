﻿using Core.DTOs;
using System.Collections.Generic;

namespace App.Core.Contracts.Domain
{
    public interface IPersonDO
    {
        List<PersonDTO> GetAddressBook();
        List<PersonDTO> GetAddressBookFromRepo();
        PersonDTO GetById(int Id);
    }
}
