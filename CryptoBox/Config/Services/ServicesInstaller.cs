using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using CryptoBox.Core.Services;
using CryptoBox.Interfaces.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Controllers;

namespace CryptoBox.Config.ServicesConfig
{
    public class ServicesInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {

            container.Register(Classes.FromThisAssembly()
                                  .BasedOn<IHttpController>()
                                  .LifestylePerWebRequest());

                 container.Register(
                     Component.For<ICryptoQuotesService>().ImplementedBy<CryptoQuotesService>()
                 );
        }
    }
}