using App.Core.Contracts.Data;
using App.Core.Contracts.Domain;
using Core.DTOs;

namespace App.Domain
{
    public class FilterDO : IFilterDO
    {
        #region Member Variables
        private readonly IFilterDAO _filterDAO;
        #endregion

        #region Constructor
        public FilterDO(IFilterDAO filterDAO)
        {
            _filterDAO = filterDAO;
        }
        #endregion

        #region Public Methods
        public FilterDTO GetByName(string name)
        {
            return _filterDAO.GetByName(name);
        }
        #endregion
    }
}
