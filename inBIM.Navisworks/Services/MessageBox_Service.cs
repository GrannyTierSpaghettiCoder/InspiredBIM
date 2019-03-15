using inBIM.Core.Contracts;
using inBIM.Navisworks.Contracts;
using System.Windows.Forms;

namespace inBIM.Navisworks.Services
{
    internal class MessageBox_Service : IMessageBoxService
    {
        public MessageBox_Service(INavisworksClientInformation ClientInformation)
        {
            _clientinfo = ClientInformation;
        }

        private readonly INavisworksClientInformation _clientinfo;

        public void Show(string title, string content)
        {
            MessageBox.Show(Autodesk.Navisworks.Api.Application.Gui.MainWindow, content, $"{Core.Extensions.Enum_Extensions<Core.Enums.Products>.GetDescription(_clientinfo.Product)} {Core.Extensions.Enum_Extensions<Core.Enums.Years>.GetDescription(_clientinfo.Year)} - {title}", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}