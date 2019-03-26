using inBIM.Core.Contracts;
using inBIM.Core.Models;
using inBIM.Navisworks.Contracts;
using inBIM.Navisworks.Models;
using Microsoft.Practices.Unity;
using Prism.Events;
using Prism.Logging;
using System.Reflection;

namespace inBIM.Navisworks
{
    internal class Client : UI.ViewModel.Client
    {
        public Client(IUnityContainer container, IEventAggregator eventaggregator, ILoggerFacade logger) : base(container, eventaggregator, logger)
        {
        }

        public override IApplicationInfo GetAppInfo()
        {
            return new ApplicationInfo_Model(Assembly.GetExecutingAssembly(), Container.Resolve<IApplicationAuthor>());
        }

        public override IClientTheme GetClientTheme()
        {
            return new NavisworksClientTheme_Model(Container.Resolve<INavisworksClientInformation>());
        }

        public override void SetupUI()
        {
            // Not required for navisworks
        }
    }
}