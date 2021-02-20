using inBIM.AutoCAD.Contracts;
using inBIM.AutoCAD.Models;
using inBIM.AutoCAD.Singleton;
using inBIM.Core.Contracts;
using inBIM.Core.Models;
using Microsoft.Practices.Unity;
using Prism.Events;
using Prism.Logging;
using System.Reflection;

namespace inBIM.AutoCAD
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
            return new AutoCADClientTheme_Model(Container.Resolve<IAutoCADClientInformation>());
        }

        public override void SetupUI()
        {
            PaletteSet.Current.WireUp();
        }
    }
}