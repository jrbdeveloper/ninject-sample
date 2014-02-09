using Core.DTOs;

namespace App.Core.Contracts.Domain
{
    public interface IFilterDO
    {
        FilterDTO GetByName(string name);
    }
}
