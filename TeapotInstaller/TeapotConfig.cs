using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeapotInstaller
{
    public partial class TeapotConfig : MetroForm
    {
        IDevice CurDevice;
        IniFile MyIni;

        public TeapotConfig(IDevice device)
        {
            InitializeComponent();
            this.CurDevice = device;

            this.MyIni = new IniFile($"{Definitions.STR_TEMPPATHDAT}\\Teapot.ini");
        }

        private void TeapotConfig_Load(object sender, EventArgs e)
        {
            try
            {
                CurDevice.Handle.ReceiveFile($"{Definitions.STR_TEMPPATHDAT}\\Teapot.ini", $"{Definitions.STR_HDD}Teapot.ini");
                cbNoKVMode.Checked = bool.Parse(MyIni.Read("NoKVMode", "Settings"));
                cbUseNandKV.Checked = bool.Parse(MyIni.Read("UseNandKV", "Settings"));

            }
            catch (Exception ex)
            {
                MessageBox.Show("No launch connfig (launch.ini) located: \n" + ex.Message);
            }
        }

        private void metroLabel4_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void tbPlugin5_Click(object sender, EventArgs e)
        {

        }

        private void tbPlugin4_Click(object sender, EventArgs e)
        {

        }

        private void tbPlugin3_Click(object sender, EventArgs e)
        {

        }

        private void tbPlugin2_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel7_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel6_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel5_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel3_Click(object sender, EventArgs e)
        {

        }

        private void tbPlugin1_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
