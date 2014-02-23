using System.Collections.Generic;
using System.Linq;
using App.Core;
using Core.DTOs;

namespace App.Core.Contracts.Data
{
    public interface IPersonRepo
    {
        List<PersonDTO> GetPeople();
    }
}
