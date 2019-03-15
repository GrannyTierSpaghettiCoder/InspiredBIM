using inBIM.Core.Contracts;

namespace inBIM.Navisworks.Contracts
{
    public interface INavisworksClientInformation : IClientInformation
    {
        Enums.Versions Version { get; }
    }
}