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
        IniFile MyIni;


        public PluginMananger(IDevice CurDevice)
        {
            InitializeComponent();
            this.CurDevice = CurDevice;
            this.MyIni = new IniFile($"{Definitions.STR_TEMPPATHDAT}\\launch.ini");
        }

        private void PluginMananger_Load(object sender, EventArgs e)
        {

            try
            {
                CurDevice.Handle.ReceiveFile($"{Definitions.STR_TEMPPATHDAT}\\launch.ini", $"{Definitions.STR_HDD}launch.ini");
                tbPlugin1.Text = MyIni.Read("Plugin1", "Plugins");
                tbPlugin2.Text = MyIni.Read("Plugin2", "Plugins");
                tbPlugin3.Text = MyIni.Read("Plugin3", "Plugins");
                tbPlugin4.Text = MyIni.Read("Plugin4", "Plugins");
                tbPlugin5.Text = MyIni.Read("Plugin5", "Plugins");
            }
            catch (Exception ex)
            {
                MessageBox.Show("No launch connfig (launch.ini) located: \n" + ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MyIni.Write("Plugin1", tbPlugin1.Text, "Plugins");
            MyIni.Write("Plugin2", tbPlugin2.Text, "Plugins");
            MyIni.Write("Plugin3", tbPlugin3.Text, "Plugins");
            MyIni.Write("Plugin4", tbPlugin4.Text, "Plugins");
            MyIni.Write("Plugin5", tbPlugin5.Text, "Plugins");

            CurDevice.Handle.SendFile($"{Definitions.STR_TEMPPATHDAT}\\launch.ini", $"{Definitions.STR_HDD}launch.ini");
            this.Close();
        }

        private void metroLabel7_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel4_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel3_Click(object sender, EventArgs e)
        {

        }

        private void tbPlugin1_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel5_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel6_Click(object sender, EventArgs e)
        {

        }

        private void tbPlugin2_Click(object sender, EventArgs e)
        {

        }

        private void tbPlugin3_Click(object sender, EventArgs e)
        {

        }

        private void tbPlugin4_Click(object sender, EventArgs e)
        {

        }

        private void tbPlugin5_Click(object sender, EventArgs e)
        {

        }
    }
}
