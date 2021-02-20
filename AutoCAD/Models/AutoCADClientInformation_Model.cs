using inBIM.AutoCAD.Contracts;
using inBIM.AutoCAD.Enums;
using inBIM.AutoCAD.Helpers;
using inBIM.Core.Contracts;
using inBIM.Core.Models;

namespace inBIM.AutoCAD.Models
{
    public class AutoCADClientInformation_Model : ClientInformation_Model, IAutoCADClientInformation
    {
        public AutoCADClientInformation_Model(IClientInformation clientInformation, Versions version) : base(clientInformation.Product, clientInformation.Year)
        {
            CurrentVersion = Registry_Helpers.GetCurrentVersion();
            Language = Application_Helpers.Language();
            Version = version;
        }

        public string CurrentVersion { get; }
        public string Language { get; }
        public Versions Version { get; }
    }
}