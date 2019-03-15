using Autodesk.Revit.UI;
using inBIM.Core.Constants;
using inBIM.Core.Contracts;
using inBIM.Core.Models;
using inBIM.Revit.Contracts;
using inBIM.Revit.Models;
using Microsoft.Practices.Unity;
using Prism.Events;
using Prism.Logging;
using Streamliner.Revit.Client.Providers;
using System;
using System.Reflection;

namespace inBIM.Revit
{
    internal class Client : UI.ViewModel.Client, IClientRVT
    {
        public Client(IUnityContainer container, IEventAggregator eventaggregator, ILoggerFacade logger) : base(container, eventaggregator, logger)
        {
        }

        public static UIControlledApplication _uiapp;

        public override IApplicationInfo GetAppInfo()
        {
            return new ApplicationInfo_Model(Assembly.GetExecutingAssembly(), Container.Resolve<IApplicationAuthor>());
        }

        public override IClientTheme GetClientTheme()
        {
            return new RevitClientTheme_Model(Container.Resolve<IRevitClientInformation>());
        }

        public void Load(UIControlledApplication uiapp)
        {
            _uiapp = uiapp;
            Load();
        }

        public override void SetupUI()
        {
            var dPid = new DockablePaneId(new Guid(AppConstants.APP_ID));
            if (!DockablePane.PaneIsRegistered(dPid))
            {
                DockPane_Provider dataprovider = new DockPane_Provider();
                _uiapp.RegisterDockablePane(dPid, AppConstants.APP_NAME, dataprovider as IDockablePaneProvider);
            }
        }
    }
}