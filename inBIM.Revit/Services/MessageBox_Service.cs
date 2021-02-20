using Autodesk.Revit.UI;
using inBIM.Core.Contracts;
using inBIM.Revit.Contracts;

namespace inBIM.Revit.Services
{
    internal class MessageBox_Service : IMessageBoxService
    {
        public MessageBox_Service(IRevitClientInformation ClientInformation)
        {
            _clientinfo = ClientInformation;
        }

        public void Show(string title, string content)
        {
            TaskDialog.Show($"{Core.Extensions.Enum_Extensions<Core.Enums.Products>.GetDescription(_clientinfo.Product)} {Core.Extensions.Enum_Extensions<Core.Enums.Years>.GetDescription(_clientinfo.Year)} - {title}", content,TaskDialogCommonButtons.Ok);
        }

        private readonly IRevitClientInformation _clientinfo;
    }
}