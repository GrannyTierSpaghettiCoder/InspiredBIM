using Autodesk.Revit.UI;
using inBIM.Core.Contracts;

namespace inBIM.Revit.Contracts
{
    public interface IClientRVT : IClient
    {
        void Load(UIControlledApplication uiapp);
    }
}