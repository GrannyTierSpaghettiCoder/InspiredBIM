using inBIM.Core.Enums;
using inBIM.Core.Models;
using inBIM.Revit.Contracts;
using inBIM.Revit.Enums;

namespace inBIM.Revit.Models
{
    public class RevitClientInformation_Model : ClientInformation_Model, IRevitClientInformation
    {
        public RevitClientInformation_Model(Years year, Versions version) : base(Products.REVIT, year)
        {
            Version = version;
        }

        public Versions Version { get; }
    }
}