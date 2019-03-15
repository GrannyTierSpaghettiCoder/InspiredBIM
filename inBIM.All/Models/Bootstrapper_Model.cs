using inBIM.Core.Contracts;
using inBIM.Core.Models;
using Microsoft.Practices.Unity;
using Prism.Logging;


#if ACAD

using inBIM.AutoCAD.Contracts;
using inBIM.AutoCAD.Helpers;
using inBIM.AutoCAD.Models;
using inBIM.AutoCAD.Services;
using inBIM.AutoCAD;

#elif NAVIS

using inBIM.Navisworks.Contracts;
using inBIM.Navisworks.Helpers;
using inBIM.Navisworks.Models;
using inBIM.Navisworks.Services;
using inBIM.Navisworks;

#elif REVIT

using Autodesk.Revit.UI;
using inBIM.Revit.Contracts;
using inBIM.Revit.Extensions;
using inBIM.Revit.Models;
using inBIM.Revit.Services;
using inBIM.Revit;

#endif

namespace inBIM.Core.Components
{
    internal class Bootstrapper_Model : IBootstrapper
    {
        public IUnityContainer Container { get; private set; }

        public void Initialize()
        {
            var boot = new Bootstrapper();
            boot.Run();

            if (boot.Container == null) return;

            Container = boot.Container;

            IApplicationAuthor author = new ApplicationAuthor_Model("Ben de Vries", "ben.devries@aurecongroup.com");
            Container.RegisterInstance(author);

#if ACAD
            IClientInformation appclient = new ClientInformation_Model(Application_Helpers.Product(), Application_Helpers.Year());

            IAutoCADClientInformation acadclient = new AutoCADClientInformation_Model(appclient, Application_Helpers.Version());
            Container.RegisterInstance(acadclient, new ContainerControlledLifetimeManager());

            Container.RegisterType<IClient, Client>();
            Container.RegisterType<IMessageBoxService, MessageBox_Service>();

#elif NAVIS

            IClientInformation appclient = new ClientInformation_Model(Core.Enums.Products.NAVIS, Application_Helpers.Year());

            INavisworksClientInformation acadclient = new NavisworksClientInformation_Model(Application_Helpers.Year(), Application_Helpers.Version());
            Container.RegisterInstance(acadclient, new ContainerControlledLifetimeManager());

            Container.RegisterType<IClient, Client>();
            Container.RegisterType<IMessageBoxService, MessageBox_Service>();

#endif
        }

#if REVIT

        public void InitializeRVT(UIControlledApplication uiapp)
        {
            if (uiapp == null) throw new System.ArgumentNullException(nameof(uiapp));

            Initialize();

            IClientInformation appclient = new ClientInformation_Model(Core.Enums.Products.REVIT, uiapp.GetYear());

            IRevitClientInformation revitclient = new RevitClientInformation_Model(uiapp.GetYear(), uiapp.GetProduct());
            Container.RegisterInstance(revitclient, new ContainerControlledLifetimeManager());

            Container.RegisterType<IClientRVT, Client>();
            Container.RegisterType<IMessageBoxService, MessageBox_Service>();

        }

#endif

    }
}