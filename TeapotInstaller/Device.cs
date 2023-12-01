using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XDevkit;
using System.IO;

namespace TeapotInstaller
{
    public class IDevice
    {
        public XboxConsole Handle;
        public IXboxDebugTarget debugTarget = null;
        public string Name;
        public int HResult;
        public Exception LastException;

        private static XboxManager xboxManager = new XboxManager();

        public IDevice(string DeviceName)
        {
            this.Handle = null;
            this.Name = DeviceName;
            this.HResult = -1;
            this.LastException = null;
        }

        public async Task<int> ConnectAsync()
        {
            this.Handle = xboxManager.OpenConsole(this.Name);
            this.Handle.ConnectTimeout = 1;

            this.debugTarget = this.Handle.DebugTarget;
            //this.debugTarget.ConnectAsDebugger("XTool", XboxDebugConnectFlags.Force);

            try
            {
                await Task.Run(() => this.Handle.FindConsole(1, 0));
                this.HResult = 0;
            }
            catch (Exception Ex)
            {
                this.LastException = Ex;
                this.HResult = Ex.HResult;
            }
            return this.HResult;
        }

        public void LaunchTitle(string path)
        {
            Handle.Reboot(path, Path.GetDirectoryName(path), null, XboxRebootFlags.Title);
        }
    }
}
