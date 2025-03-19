using System;
using System.Net.NetworkInformation;
using System.Windows.Forms;

namespace ToolApplication
{
    public partial class NetworkInfo : Form
    {
        public NetworkInfo()
        {
            InitializeComponent();
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink; #test
            DisplayNetworkInfo();
        }

        private void DisplayNetworkInfo()
        {
            try
            {
                string networkInfo = GetNetworkInformation();
                networkLabel.Text = networkInfo; 
            }
            catch (Exception ex)
            {
                networkLabel.Text = "Error: " + ex.Message;
            }
        }

        private string GetNetworkInformation()
        {
            string result = "Network Information:\n\n";

            foreach (NetworkInterface networkInterface in NetworkInterface.GetAllNetworkInterfaces())
            {
                result += "Interface: " + networkInterface.Name + "\n";
                result += "  Description: " + networkInterface.Description + "\n";
                result += "  Status: " + networkInterface.OperationalStatus + "\n";

                IPInterfaceProperties ipProperties = networkInterface.GetIPProperties();
                foreach (UnicastIPAddressInformation ipInfo in ipProperties.UnicastAddresses)
                {
                    if (ipInfo.Address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                    {
                        result += "  IP Address: " + ipInfo.Address.ToString() + "\n";
                    }
                }

                result += "  MAC Address: " + networkInterface.GetPhysicalAddress().ToString() + "\n\n";
            }

            return result;
        }
    }
}
