using App.Core.Contracts.Data;
using App.Data.DAOs;
using Ninject.Modules;

namespace App.Infrastructure.DIModules
{
    public class DataModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IFilterDAO>().To<FilterDAO>();
            Bind<IPersonDAO>().To<PersonDAO>();
        }
    }
}
