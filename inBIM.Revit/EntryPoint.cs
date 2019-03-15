using Autodesk.Revit.UI;
using inBIM.Core.Components;
using inBIM.Revit.Contracts;
using Microsoft.Practices.Unity;

namespace inBIM.Revit
{
    public class EntryPoint : IExternalApplication
    {
        public static UIControlledApplication UIApp { get; private set; }
        public static IClientRVT Client { get; private set; }

        public Result OnShutdown(UIControlledApplication application)
        {
            return Result.Succeeded;
        }

        public Result OnStartup(UIControlledApplication application)
        {
            UIApp = application;

            Core.Helpers.Dependancy_Helpers.LoadDependancies();

            var bootstrapper = new Bootstrapper_Model();
            bootstrapper.InitializeRVT(application);

            Client = bootstrapper.Container.Resolve<IClientRVT>();
            Client.Load(application);

            return Result.Succeeded;
        }
    }
}