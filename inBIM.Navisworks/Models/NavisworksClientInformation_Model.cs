using inBIM.Core.Enums;
using inBIM.Core.Models;
using inBIM.Navisworks.Contracts;

namespace inBIM.Navisworks.Models
{
    public class NavisworksClientInformation_Model : ClientInformation_Model, INavisworksClientInformation
    {
        public NavisworksClientInformation_Model(Years year, Enums.Versions version) : base(Products.NAVIS, year)
        {
            Version = version;
        }

        public Enums.Versions Version { get; }
    }
}