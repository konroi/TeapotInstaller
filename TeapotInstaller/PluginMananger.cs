using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using XDevkit;

namespace TeapotInstaller
{
    public partial class PluginMananger : MetroForm
    {
        IDevice CurDevice;

        public PluginMananger(IDevice CurDevice)
        {
            InitializeComponent();
            this.CurDevice = CurDevice;
        }

        private void PluginMananger_Load(object sender, EventArgs e)
        {

            //tbPlugin1 = CurDevice.Handle.SendFile($"{downloader.tempPath}{file}", $"{Definitions.STR_HDD}{file}");
        }

        private void metroLabel7_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel4_Click(object sender, EventArgs e)
        {

        }
    }
}
