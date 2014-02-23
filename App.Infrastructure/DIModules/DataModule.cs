using App.Core.Contracts.Data;
using App.Data.DAOs;
using App.Data.Repos;
using Ninject.Modules;

namespace App.Infrastructure.DIModules
{
    public class DataModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IPersonDAO>().To<PersonDAO>();
            Bind<IPersonRepo>().To<PersonRepo>();
        }
    }
}
