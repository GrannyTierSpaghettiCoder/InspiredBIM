using inBIM.AutoCAD.Enums;
using inBIM.Core.Contracts;

namespace inBIM.AutoCAD.Contracts
{
    public interface IAutoCADClientInformation : IClientInformation
    {
        string CurrentVersion { get; }
        string Language { get; }
        Versions Version { get; }
    }
}