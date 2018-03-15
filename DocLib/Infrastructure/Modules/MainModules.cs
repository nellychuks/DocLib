using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DocLib.Domain.Interface.Utilities;
using DocLib.Domain.Interface.Repositories;
using DocLib.Data.Entities;
using DocLib.Data.Utilities;
using DocLib.Data.Repositories;
using Ninject.Modules;
using System.Data.Entity;



namespace DocLib.Infrastructure.Modules
{
    public class MainModules : NinjectModule
    {
        public override void Load()
        {
            Bind<DbContext>().To<DataEntities>();
            Bind<IEncryption>().To<MD5Encryption>();
            Bind<IUserRepository>().To<UserRepository>();
        }
    }
}