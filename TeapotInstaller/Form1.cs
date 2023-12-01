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

namespace TeapotInstaller
{


    public partial class Form1 : MetroForm
    {
        List<IDevice> Devices = new List<IDevice>();
        Downloader downloader;
        IDevice CurDevice;
        int SelectedDeviceIndex;
        string Default_Console;
        bool IsConnected = false;

        public Form1()
        {
            InitializeComponent();

            ToggleButtons(false);

            UpdateDeviceList();
            cbSelConsole.SelectedIndex = 0;

            metroLabel2.AutoSize = false;  
        }

        private void UpdateStatusBar(string status)
        {
            lblStatus.Text = string.Format("Status: {0}", status);
        }

        private void ToggleButtons(bool state)
        {
            btn_install.Enabled = state;
            btn_repair.Enabled = state;
            btnSetKVB.Enabled = state;
        }


        private async void ConnectDevice(int DeviceIndex)
        {
            CurDevice = Devices[SelectedDeviceIndex = DeviceIndex];
            UpdateStatusBar(string.Format("Connecting... [{0}]", CurDevice.Name));
            ToggleButtons(false);

            int HResult = await CurDevice.ConnectAsync();
            Console.WriteLine("Status: " + HResult.ToString("X8") + " || Name: " + CurDevice.Name);

            if (HResult == 0)
            {
                IsConnected = true;

                CurDevice.Handle.DebugTarget.MemoryCacheEnabled = false;

                LblConnectionStatus.Text = "Connected";
                lblStatus.Text = string.Format("Connected [{0}]", CurDevice.Name);
                lblStatus.ForeColor = Color.Green;
                LblConnectionStatus.ForeColor = Color.Green;

                ToggleButtons(true);

                downloader = new Downloader();
                if(downloader.S_SUCCESS != true)
                {
                    MessageBox.Show("Teapot Installer - Unable to download files", $"Installation FAILED!\n\nException: {downloader.Ex.Message}", MessageBoxButtons.OK);
                    lblStatus.Text = string.Format("Error downloading files! Restart App!");
                    lblStatus.ForeColor = Color.Red;
                }

                Console.WriteLine(downloader.tempPath);

                var MyIni = new IniFile($"{downloader.tempPath}launch.ini");
                Console.WriteLine("cock " + MyIni.Read("Plugin1", "Plugins"));
            }
            else
            {
                Console.WriteLine("Exception: " + CurDevice.LastException.Message);
                LblConnectionStatus.Text = "Not Connected";
                lblStatus.Text = string.Format("Connection to [{0}] FAILED!", CurDevice.Name);
                lblStatus.ForeColor = Color.Red;
                LblConnectionStatus.ForeColor = Color.Red;
            }

        }




        private void Form1_Load(object sender, EventArgs e)
        {
            lblLine.MaximumSize = new Size(300, 3);
            lblLine.AutoSize = true;

            for (int i = 0; i < cbSelConsole.Items.Count; i++)
            {
                if (cbSelConsole.Items[i].ToString() == Default_Console)
                {
                    cbSelConsole.SelectedIndex = i;
                    ConnectDevice(cbSelConsole.SelectedIndex - 1);
                }
            }

            Console.WriteLine(Definitions.STR_TEMPPATH + "cock");
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

        private void Install()
        {
            foreach (string file in downloader.files)
            {
                CurDevice.Handle.SendFile($"{downloader.tempPath}{file}", $"{Definitions.STR_HDD}{file}");
            }
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

        private void cbSelConsole_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSelConsole.SelectedIndex > 0)
            {
                ConnectDevice(cbSelConsole.SelectedIndex - 1);
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
            CurDevice.Handle.Reboot(null, null, null, XboxRebootFlags.Cold);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new PluginMananger(CurDevice).Show();
        }
    }
}
