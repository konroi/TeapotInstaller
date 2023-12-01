using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XDevkit;

namespace TeapotInstaller {
    public partial class IDeviceMananger
    {
        List<string> XDeviceNameList = new List<string>();

        IXboxConsole XConsole;

        public async Task<int> EstablishConnectionAsync(string DeviceName = "")
        {
            IXboxManager XMananger = new XboxManager();

            string device = string.IsNullOrEmpty(DeviceName) ? XMananger.DefaultConsole : DeviceName;
            XConsole = XMananger.OpenConsole(device);

            try
            {
                await Task.Run(() => XConsole.FindConsole(1, 0));
                return 0;
            }
            catch (Exception Ex)
            {
                return Ex.HResult;
            }
        }

        public async Task
            DeviceAsync(string DeviceName = "")
        {
            int status = await this.EstablishConnectionAsync(DeviceName);
            Console.WriteLine("Connection Status: 0x" + status.ToString("X8"));
        }
    }
}
