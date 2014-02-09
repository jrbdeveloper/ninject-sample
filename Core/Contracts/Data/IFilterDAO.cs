using Core.DTOs;

namespace App.Core.Contracts.Data
{
    public interface IFilterDAO
    {
        FilterDTO GetByName(string name);
    }
}
