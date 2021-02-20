using inBIM.Core.Enums;
using inBIM.Navisworks.Extensions;
using ANA = Autodesk.Navisworks.Api;

namespace inBIM.Navisworks.Helpers
{
    public struct Application_Helpers
    {
        public static Enums.Versions Version() => ANA.Application.Version.GetVersion();

        public static Years Year() => ANA.Application.Version.GetYear();

        public static bool IsAutomated => ANA.Application.IsAutomated;
    }
}