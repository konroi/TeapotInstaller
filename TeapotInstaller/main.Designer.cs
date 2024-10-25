
namespace TeapotInstaller
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.lblLine = new System.Windows.Forms.Label();
            this.cbSelConsole = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.LblConnectionStatus = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnTpConfig = new System.Windows.Forms.Button();
            this.btnPlugins = new System.Windows.Forms.Button();
            this.btnReboot = new System.Windows.Forms.Button();
            this.btnSetKVB = new System.Windows.Forms.Button();
            this.btn_repair = new System.Windows.Forms.Button();
            this.btn_install = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(12, 13);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(228, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Teapot Tool and Installer - v2.0.0";
            this.metroLabel1.Click += new System.EventHandler(this.metroLabel1_Click);
            // 
            // lblLine
            // 
            this.lblLine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLine.AutoSize = true;
            this.lblLine.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLine.Location = new System.Drawing.Point(1, 32);
            this.lblLine.Name = "lblLine";
            this.lblLine.Size = new System.Drawing.Size(2, 15);
            this.lblLine.TabIndex = 1;
            // 
            // cbSelConsole
            // 
            this.cbSelConsole.FormattingEnabled = true;
            this.cbSelConsole.ItemHeight = 23;
            this.cbSelConsole.Items.AddRange(new object[] {
            "Select Console"});
            this.cbSelConsole.Location = new System.Drawing.Point(12, 50);
            this.cbSelConsole.Name = "cbSelConsole";
            this.cbSelConsole.Size = new System.Drawing.Size(130, 29);
            this.cbSelConsole.TabIndex = 2;
            this.cbSelConsole.UseSelectable = true;
            this.cbSelConsole.SelectedIndexChanged += new System.EventHandler(this.cbSelConsole_SelectedIndexChanged);
            // 
            // metroLabel2
            // 
            this.metroLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel2.BackColor = System.Drawing.Color.Black;
            this.metroLabel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.metroLabel2.Location = new System.Drawing.Point(-10, 37);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(429, 10);
            this.metroLabel2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label1.Location = new System.Drawing.Point(9, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Status:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(51, 177);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(92, 13);
            this.lblStatus.TabIndex = 8;
            this.lblStatus.Text = "Not Connected";
            // 
            // LblConnectionStatus
            // 
            this.LblConnectionStatus.AccessibleName = "";
            this.LblConnectionStatus.AutoSize = true;
            this.LblConnectionStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.45F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblConnectionStatus.Location = new System.Drawing.Point(148, 55);
            this.LblConnectionStatus.Name = "LblConnectionStatus";
            this.LblConnectionStatus.Size = new System.Drawing.Size(101, 15);
            this.LblConnectionStatus.TabIndex = 19;
            this.LblConnectionStatus.Text = "Not Connected";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::TeapotInstaller.Properties.Resources.Teapot;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(283, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 116);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // btnTpConfig
            // 
            this.btnTpConfig.BackgroundImage = global::TeapotInstaller.Properties.Resources.gear;
            this.btnTpConfig.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnTpConfig.Enabled = false;
            this.btnTpConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTpConfig.ForeColor = System.Drawing.Color.Black;
            this.btnTpConfig.Location = new System.Drawing.Point(148, 143);
            this.btnTpConfig.Name = "btnTpConfig";
            this.btnTpConfig.Size = new System.Drawing.Size(129, 23);
            this.btnTpConfig.TabIndex = 18;
            this.btnTpConfig.Text = "Teapot Config";
            this.btnTpConfig.UseVisualStyleBackColor = true;
            this.btnTpConfig.Click += new System.EventHandler(this.btnTpConfig_Click);
            // 
            // btnPlugins
            // 
            this.btnPlugins.BackgroundImage = global::TeapotInstaller.Properties.Resources.plugin;
            this.btnPlugins.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPlugins.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlugins.ForeColor = System.Drawing.Color.Black;
            this.btnPlugins.Location = new System.Drawing.Point(148, 114);
            this.btnPlugins.Name = "btnPlugins";
            this.btnPlugins.Size = new System.Drawing.Size(129, 23);
            this.btnPlugins.TabIndex = 17;
            this.btnPlugins.Text = "Edit Plugins";
            this.btnPlugins.UseVisualStyleBackColor = true;
            this.btnPlugins.Click += new System.EventHandler(this.btnPlugins_click);
            // 
            // btnReboot
            // 
            this.btnReboot.BackgroundImage = global::TeapotInstaller.Properties.Resources.restart;
            this.btnReboot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnReboot.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReboot.ForeColor = System.Drawing.Color.Black;
            this.btnReboot.Location = new System.Drawing.Point(148, 85);
            this.btnReboot.Name = "btnReboot";
            this.btnReboot.Size = new System.Drawing.Size(129, 23);
            this.btnReboot.TabIndex = 15;
            this.btnReboot.Text = "Reboot Device";
            this.btnReboot.UseVisualStyleBackColor = true;
            this.btnReboot.Click += new System.EventHandler(this.btnReboot_Click);
            // 
            // btnSetKVB
            // 
            this.btnSetKVB.BackgroundImage = global::TeapotInstaller.Properties.Resources.kv;
            this.btnSetKVB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSetKVB.Enabled = false;
            this.btnSetKVB.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetKVB.ForeColor = System.Drawing.Color.Black;
            this.btnSetKVB.Location = new System.Drawing.Point(13, 143);
            this.btnSetKVB.Name = "btnSetKVB";
            this.btnSetKVB.Size = new System.Drawing.Size(129, 23);
            this.btnSetKVB.TabIndex = 13;
            this.btnSetKVB.Text = "Set Keyvault";
            this.btnSetKVB.UseVisualStyleBackColor = true;
            // 
            // btn_repair
            // 
            this.btn_repair.BackgroundImage = global::TeapotInstaller.Properties.Resources.repair;
            this.btn_repair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_repair.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_repair.ForeColor = System.Drawing.Color.Black;
            this.btn_repair.Location = new System.Drawing.Point(13, 114);
            this.btn_repair.Name = "btn_repair";
            this.btn_repair.Size = new System.Drawing.Size(129, 23);
            this.btn_repair.TabIndex = 12;
            this.btn_repair.Text = "Repair Install";
            this.btn_repair.UseVisualStyleBackColor = true;
            this.btn_repair.Click += new System.EventHandler(this.btn_repair_Click);
            // 
            // btn_install
            // 
            this.btn_install.BackgroundImage = global::TeapotInstaller.Properties.Resources.install;
            this.btn_install.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_install.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_install.ForeColor = System.Drawing.Color.Black;
            this.btn_install.Location = new System.Drawing.Point(13, 85);
            this.btn_install.Name = "btn_install";
            this.btn_install.Size = new System.Drawing.Size(129, 23);
            this.btn_install.TabIndex = 11;
            this.btn_install.Text = "Install To Device";
            this.btn_install.UseVisualStyleBackColor = true;
            this.btn_install.Click += new System.EventHandler(this.btn_install_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 199);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LblConnectionStatus);
            this.Controls.Add(this.btnTpConfig);
            this.Controls.Add(this.btnPlugins);
            this.Controls.Add(this.btnReboot);
            this.Controls.Add(this.btnSetKVB);
            this.Controls.Add(this.btn_repair);
            this.Controls.Add(this.btn_install);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.cbSelConsole);
            this.Controls.Add(this.lblLine);
            this.Controls.Add(this.metroLabel1);
            this.ForeColor = System.Drawing.Color.Red;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(415, 199);
            this.MinimumSize = new System.Drawing.Size(415, 199);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.Label lblLine;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btn_install;
        private System.Windows.Forms.Button btn_repair;
        private System.Windows.Forms.Button btnSetKVB;
        private System.Windows.Forms.Button btnReboot;
        private System.Windows.Forms.Button btnPlugins;
        private System.Windows.Forms.Button btnTpConfig;
        private System.Windows.Forms.Label LblConnectionStatus;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBox1;
        public MetroFramework.Controls.MetroComboBox cbSelConsole;
    }
}

