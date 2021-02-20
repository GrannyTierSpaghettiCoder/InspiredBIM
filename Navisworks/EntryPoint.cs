using Autodesk.Navisworks.Api.Plugins;
using inBIM.Core.Components;
using inBIM.Core.Contracts;
using Microsoft.Practices.Unity;

namespace inBIM.Navisworks
{
    [Plugin("AWESOME_inBIM", "AWESOME")]
    public class EntryPoint : EventWatcherPlugin
    {
        public static IClient Client { get; private set; }

        public override void OnLoaded()
        {
            Core.Helpers.Dependancy_Helpers.LoadDependancies();

            var bootstrapper = new Bootstrapper_Model();
            bootstrapper.Initialize();

            Client = bootstrapper.Container.Resolve<IClient>();
            Client.Load();
        }

        public override void OnUnloading()
        {
        }
    }
}