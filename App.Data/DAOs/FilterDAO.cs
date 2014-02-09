using App.Core.Contracts.Data;
using Core.DTOs;

namespace App.Data.DAOs
{
    public class FilterDAO : IFilterDAO
    {
        public FilterDTO GetByName(string name)
        {
            var new_filter = new FilterDTO
            {
                Id = 1,
                Name = "Test Filter"
            };

            return new_filter;
        }
    }
}
