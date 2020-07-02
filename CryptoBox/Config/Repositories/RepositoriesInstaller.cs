using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using CryptoBox.Core.Repositories;
using CryptoBox.Interfaces.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Controllers;

namespace CryptoBox.Config.RepositoriesConfig
{
    public class RepositoriesInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {

            container.Register(Classes.FromThisAssembly()
                                  .BasedOn<IHttpController>()
                                  .LifestylePerWebRequest());

            container.Register(
                Component.For<ICryptoQuotesRepository>().ImplementedBy<CryptoQuotesRepository>()
            );

            container.Register(
                Component.For<ICryptoCompareRepository>().ImplementedBy<CryptoCompareRepository>()
            );
            
        }
    }
}