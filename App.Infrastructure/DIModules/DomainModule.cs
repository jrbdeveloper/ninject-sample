using App.Core.Contracts.Domain;
using App.Domain;
using Ninject.Modules;

namespace App.Infrastructure.DIModules
{
    public class DomainModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IPersonDO>().To<PersonDO>();
        }
    }
}
