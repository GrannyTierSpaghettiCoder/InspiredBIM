using inBIM.Core.Contracts;
using inBIM.Revit.Enums;

namespace inBIM.Revit.Contracts
{
    public interface IRevitClientInformation : IClientInformation
    {
        Versions Version { get; }
    }
}