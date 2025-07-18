using Microsoft.Win32;
using OpenRGB.NET;
using System.Drawing;
using System.Security.Principal;

namespace Accent_Chooser
{
    public partial class Form1 : Form
    {
        private readonly OpenRgbClient client = new();
        private readonly WindowsIdentity? _current = WindowsIdentity.GetCurrent();

        public Form1()
        {
            InitializeComponent();

            userSID.Text = $"SID: {_current.User?.Value ?? ""}";

            client.Connect();
            Device[] devices = client.GetAllControllerData();

            deviceList.Items.AddRange(devices);
            deviceList.DisplayMember = "Name";

        }


        private void saveZonesButton_Click(object sender, EventArgs e)
        {
            if (deviceList.SelectedItem is not Device device)
            {
                MessageBox.Show("Seleccione un dispositivo");
                return;
            }

            if (zoneList.SelectedItem is not Zone zone)
            {
                MessageBox.Show("Seleccione una zona");
                return;
            }

            using (var key = Registry.CurrentUser.CreateSubKey(@"Software\Asra\AccentColor"))
            {
                key.SetValue("DeviceName", device.Name);
            }

            using (var key = Registry.CurrentUser.CreateSubKey(@"Software\Asra\AccentColor"))
            {
                key.SetValue("DeviceZone", zone.Name);
            }

            MessageBox.Show($"{zone.Name} de {device.Name} seleccionado", "Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void deviceList_TextChanged(object sender, EventArgs e)
        {
            if (deviceList.SelectedItem is not Device selected)
            {
                MessageBox.Show("Seleccione un dispositivo");
                return;
            }

            zoneList.Items.Clear();
            zoneList.Items.AddRange(selected.Zones);

            zoneList.DisplayMember = "Name";

        }

        private void userSID_Click(object sender, EventArgs e)
        {
            if(_current != null) Clipboard.SetText(_current.User?.Value ?? "");
        }
    }
}
