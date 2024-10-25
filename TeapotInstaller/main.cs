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
using System.IO;
using System.IO.Compression;
using System.Threading;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TeapotInstaller
{
    public partial class Form1 : MetroForm
    {
        Thread RebootEvent;
        List<IDevice> Devices = new List<IDevice>();
        Downloader downloader;
        IDevice CurDevice;
        public int SelectedDeviceIndex;
        string Default_Console;
        public int ConnectionStatus = Definitions.CONNECTION_NOCONNECT;

        public Form1()
        {
            InitializeComponent();
            ToggleButtons(false);
            UpdateDeviceList();

            cbSelConsole.SelectedIndex = 0;
        }

        private bool UpdateStatus(int status)
        {
            ConnectionStatus = status;
            switch (status)
            {
                case Definitions.CONNECTION_PROGRESS:
                    SetStatuses2($"Connecting... [{CurDevice.Name}]", "Not Connected", Color.Orange, Color.Red);
                    ToggleButtons(false);
                    break;
                case Definitions.CONNECTION_CONNECTED:
                    SetStatuses2($"Connected [{CurDevice.Name}]", "Connected", Color.Green, Color.Green);
                    ToggleButtons(true);
                    return false;
                case Definitions.CONNECTION_FAILED:
                    SetStatuses2(string.Format($"Connection to [{CurDevice.Name}] FAILED!"), "Not Connected", Color.Red, Color.Red);
                    ToggleButtons(false);
                    break;
                case Definitions.CONNECTION_REBOOTING:
                    SetStatuses2(string.Format("Awaiting reboot... [{0}]", CurDevice.Name), "Rebooting", Color.Orange, Color.Green);
                    ToggleButtons(false);
                    break;
            }
            return true;
        }

        private void StatusChangeEvent()
        {
                while (true)
                {
                if (!UpdateStatus(ConnectionStatus)) return;
                    Thread.Sleep(1000);
                }
            }

        private void ToggleButtons(bool state)
        {
            Invoke((MethodInvoker)delegate
            {
                btn_install.Enabled = state;
                btn_repair.Enabled = state;
                //btnSetKVB.Enabled = state;
                btnPlugins.Enabled = state;
                btnReboot.Enabled = state;
                btnTpConfig.Enabled = state;
            });
        }

        public void SetStatuses2(string status, string ConnectionStatus, Color color1, Color color2)
        {

            Invoke((MethodInvoker)delegate
            {
                lblStatus.Text = status;
                LblConnectionStatus.Text = ConnectionStatus;
                lblStatus.ForeColor = color1;
                LblConnectionStatus.ForeColor = color2;
            });
        }

        public async Task ConnectDevice(int DeviceIndex, bool waitingReboot = false)
        {
            CurDevice = Devices[SelectedDeviceIndex = DeviceIndex];
            if (!waitingReboot) UpdateStatus(Definitions.CONNECTION_PROGRESS);


            int result = await CurDevice.ConnectAsync();
            Console.WriteLine($"Status: {ConnectionStatus.ToString("X8")} || Name: {CurDevice.Name}");

            if (result == 0x00) UpdateStatus(Definitions.CONNECTION_CONNECTED);
            else if (!waitingReboot) UpdateStatus(Definitions.CONNECTION_FAILED);
        }

       private async void Form1_Load(object sender, EventArgs e)
       {
            Directory.CreateDirectory(Definitions.STR_TEMPPATH);
            Directory.CreateDirectory($"{Definitions.STR_TEMPPATH}Dat\\");
            Console.WriteLine($"Temp Path: {Definitions.STR_TEMPPATH}");

            for (int i = 0; i < cbSelConsole.Items.Count; i++)
            {
                if (cbSelConsole.Items[i].ToString() == Default_Console)
                {
                    cbSelConsole.SelectedIndex = i;
                   await ConnectDevice(cbSelConsole.SelectedIndex - 1);
                }
            }
        }

        private void UpdateDeviceList()
        {
            cbSelConsole.Items.Clear();

            cbSelConsole.Items.Add("Select Device..");

            foreach (string DeviceName in new XboxManager().Consoles)
            {
                cbSelConsole.Items.Add(DeviceName);
                Devices.Add(new IDevice(DeviceName));
            }
        }

        private void Install(){
            downloader = new Downloader();
            if (downloader.S_SUCCESS != true){
                DialogResult msgResult = MessageBox.Show("Teapot Installer - Unable to download files", $"Installation FAILED!\n\nException: {downloader.Ex.Message}", MessageBoxButtons.AbortRetryIgnore);
                lblStatus.Text = string.Format("Error downloading files! Restart App!");
                lblStatus.ForeColor = Color.Red;

                if (msgResult == DialogResult.Ignore) return;
                if (msgResult == DialogResult.Abort) return;
                if (msgResult == DialogResult.Retry) Install();
                return;
            }

            foreach (string file in downloader.FilesPreset){
                CurDevice.Handle.SendFile($"{Definitions.STR_TEMPPATH}{file}", $"{Definitions.STR_HDD}{file}");
            }

            MessageBox.Show("Your Console Will Now Reboot!");
            Reboot();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics drLine = e.Graphics;
            Pen p = new Pen(Color.Black, 20);
            drLine.DrawLine(p, 50, 50, 200, 200);
            drLine.Dispose();
        }

        private async void cbSelConsole_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSelConsole.SelectedIndex > 0)
            {
                await ConnectDevice(cbSelConsole.SelectedIndex - 1);
            }
        }

        private void lblStatusHolder_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void btn_install_Click(object sender, EventArgs e)
        {
            Install();
        }

        private void btn_repair_Click(object sender, EventArgs e)
        {
            Install();
        }

        private void btnReboot_Click(object sender, EventArgs e)
        {
            Reboot();
        }

        private void btnPlugins_click(object sender, EventArgs e)
        {
            new PluginMananger(CurDevice).Show();
        }

        private void btnTpConfig_Click(object sender, EventArgs e)
        {
            new TeapotConfig(CurDevice).Show();
        }

        public async void Reboot()
        {
            ConnectionStatus = Definitions.CONNECTION_REBOOTING;
            CurDevice.Handle.Reboot(null, null, null, XboxRebootFlags.Cold);

            new Thread(() => StatusChangeEvent()).Start();
            for (int i = 0; i < 30; i++)
            {
                Thread.Sleep(2000);
                await ConnectDevice(SelectedDeviceIndex, true);
                if (ConnectionStatus == Definitions.CONNECTION_CONNECTED)
                {
                    return;
                }
            }
            }
        }
}
