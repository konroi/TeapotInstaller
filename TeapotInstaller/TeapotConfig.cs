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
        private Downloader downloader = null;
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
            Setup();
        }

        private void UpdateConfigFile()
        {
            
            DialogResult msgResult = MessageBox.Show("Would you like to update it now?!", "Teapot Installer - You have an outdated Teapot.ini", MessageBoxButtons.YesNo);
            if (msgResult == DialogResult.Yes){
                downloader = new Downloader("Teapot.ini");
                if (downloader.S_SUCCESS){
                    CurDevice.Handle.SendFile($"{Definitions.STR_TEMPPATH}Teapot.ini", $"{Definitions.STR_HDD}Teapot.ini");
                    Setup();
                } else MessageBox.Show("Unable to reach TeapotLive web services. Please try again.");
            }else if (msgResult == DialogResult.No) this.BeginInvoke(new MethodInvoker(this.Close));
        }

        private void Setup()
        {
            try
            {
                rbYourKV.Checked = !rbNandKV.Checked && !rbNoKVMode.Checked;
                CurDevice.Handle.ReceiveFile($"{Definitions.STR_TEMPPATHDAT}\\Teapot.ini", $"{Definitions.STR_HDD}Teapot.ini");

                string ConfigVersion = MyIni.Read("ConfigVersion", "Diagnostic");
                if (string.IsNullOrEmpty(ConfigVersion) || ConfigVersion != "2.0.9")
                {
                    UpdateConfigFile();
                    try
                    {
                        this.Hide();
                    }
                    catch (Exception e) { }
                    return;
                }


                rbNoKVMode.Checked = bool.Parse(MyIni.Read("NoKVMode", "Settings"));
                rbNandKV.Checked = bool.Parse(MyIni.Read("UseNandKV", "Settings"));
                cbOffline.Checked = bool.Parse(MyIni.Read("Offline", "Settings"));
                cbUI.Checked = bool.Parse(MyIni.Read("CustomUI", "Settings"));
                cbStealthNetwork.Checked = bool.Parse(MyIni.Read("StealthNetwork", "settings"));
                cbEngine.Checked = bool.Parse(MyIni.Read("TeapotEngine", "Settings"));
                cbLegacyEngines.Checked = bool.Parse(MyIni.Read("LoadOldLegacyCheats", "Settings"));
                cbOnHost.Checked = bool.Parse(MyIni.Read("OnHostCheats", "Settings"));
                cbAchievementUnlocker.Checked = bool.Parse(MyIni.Read("UseAchievementUnlocker", "Settings"));

                cbBypassAW.Checked = bool.Parse(MyIni.Read("AdvancedWarfare", "Bypasses"));
                cbBypassGhosts.Checked = bool.Parse(MyIni.Read("Ghosts", "Bypasses"));
                cbBypassBo2.Checked = bool.Parse(MyIni.Read("Bo2", "Bypasses"));
                cbBypassBo3.Checked = bool.Parse(MyIni.Read("Bo3", "Bypasses"));

                decimal FanSpeed = decimal.Parse(MyIni.Read("Fanspeed", "Settings"));
                valFanSpeed.Value = FanSpeed < 50 ? 50 : FanSpeed;

            }
            catch (Exception ex){
                UpdateConfigFile();

            }
        }

        private void metroLabel4_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MyIni.Write("NoKVMode", " " + rbNoKVMode.Checked.ToString().ToLower(), "Settings");
            MyIni.Write("UseNandKV", " " + rbNandKV.Checked.ToString().ToLower(), "Settings");
            MyIni.Write("TeapotEngine", " " + cbEngine.Checked.ToString().ToLower(), "Settings");
            MyIni.Write("CustomUI", " " + cbUI.Checked.ToString().ToLower(), "Settings");
            MyIni.Write("StealthNetwork", " " + cbStealthNetwork.Checked.ToString().ToLower(), "Settings");
            MyIni.Write("Offline", " " + cbOffline.Checked.ToString().ToLower(), "Settings");
            MyIni.Write("Fanspeed", " " + valFanSpeed.Value.ToString().ToLower(), "Settings");
            MyIni.Write("LoadOldLegacyCheats", " " + cbLegacyEngines.Checked.ToString().ToLower(), "Settings");
            MyIni.Write("OnHostCheats", " " + cbOnHost.Checked.ToString().ToLower(), "Settings");
            MyIni.Write("UseAchievementUnlocker", " " + cbAchievementUnlocker.Checked.ToString().ToLower(), "Settings");

            MyIni.Write("AdvancedWarfare", " " + cbBypassAW.Checked.ToString().ToLower(), "Bypasses");
            MyIni.Write("Ghosts", " " + cbBypassGhosts.Checked.ToString().ToLower(), "Bypasses");
            MyIni.Write("Bo2", " " + cbBypassBo2.Checked.ToString().ToLower(), "Bypasses");
            MyIni.Write("Bo3", " " + cbBypassBo3.Checked.ToString().ToLower(), "Bypasses");

            CurDevice.Handle.SendFile($"{Definitions.STR_TEMPPATHDAT}\\Teapot.ini", $"{Definitions.STR_HDD}Teapot.ini");
            this.Close();
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

        private void lblfanspeed_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cbNoKVMode_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbEngine_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbOnHost_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbLegacyEngines_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbAchievementUnlocker_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
