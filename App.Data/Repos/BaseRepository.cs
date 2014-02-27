using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Data.Repos
{
    public class BaseRepository
    {
        private MVCExampleEntities _dataContext;

        public MVCExampleEntities DataContext
        {
            get
            {
                if (_dataContext == null)
                {
                    _dataContext = new MVCExampleEntities();
                }

                return _dataContext;
            }
        }
    }
}
