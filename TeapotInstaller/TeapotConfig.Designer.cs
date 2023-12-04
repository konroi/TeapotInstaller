namespace TeapotInstaller
{
    partial class TeapotConfig
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
            this.btnCancel = new MetroFramework.Controls.MetroButton();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbUseNandKV = new MetroFramework.Controls.MetroCheckBox();
            this.cbNoKVMode = new MetroFramework.Controls.MetroCheckBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbUI = new MetroFramework.Controls.MetroCheckBox();
            this.cbOffline = new MetroFramework.Controls.MetroCheckBox();
            this.cbOnHost = new MetroFramework.Controls.MetroCheckBox();
            this.cbLegacyEngines = new MetroFramework.Controls.MetroCheckBox();
            this.cbEngine = new MetroFramework.Controls.MetroCheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbBypassBo2 = new MetroFramework.Controls.MetroCheckBox();
            this.cbBypassGhosts = new MetroFramework.Controls.MetroCheckBox();
            this.cbBypassBo3 = new MetroFramework.Controls.MetroCheckBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.valFanSpeed = new MetroFramework.Controls.MetroLabel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(93, 435);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 29;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseSelectable = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(12, 435);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 28;
            this.btnSave.Text = "Save";
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel3.BackColor = System.Drawing.Color.Black;
            this.metroLabel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.metroLabel3.Location = new System.Drawing.Point(-10, 37);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(340, 10);
            this.metroLabel3.TabIndex = 20;
            this.metroLabel3.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.metroLabel3.Click += new System.EventHandler(this.metroLabel3_Click);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.Location = new System.Drawing.Point(12, 13);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(229, 19);
            this.metroLabel4.TabIndex = 19;
            this.metroLabel4.Text = "Teapot Installer - Teapot Settings";
            this.metroLabel4.Click += new System.EventHandler(this.metroLabel4_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbUseNandKV);
            this.groupBox1.Controls.Add(this.cbNoKVMode);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(290, 67);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "KV Settings";
            // 
            // cbUseNandKV
            // 
            this.cbUseNandKV.AutoSize = true;
            this.cbUseNandKV.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.cbUseNandKV.FontWeight = MetroFramework.MetroCheckBoxWeight.Bold;
            this.cbUseNandKV.Location = new System.Drawing.Point(10, 44);
            this.cbUseNandKV.Name = "cbUseNandKV";
            this.cbUseNandKV.Size = new System.Drawing.Size(115, 19);
            this.cbUseNandKV.TabIndex = 32;
            this.cbUseNandKV.Text = "Use Name KV";
            this.cbUseNandKV.UseSelectable = true;
            // 
            // cbNoKVMode
            // 
            this.cbNoKVMode.AutoSize = true;
            this.cbNoKVMode.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.cbNoKVMode.FontWeight = MetroFramework.MetroCheckBoxWeight.Bold;
            this.cbNoKVMode.Location = new System.Drawing.Point(10, 19);
            this.cbNoKVMode.Name = "cbNoKVMode";
            this.cbNoKVMode.Size = new System.Drawing.Size(110, 19);
            this.cbNoKVMode.TabIndex = 31;
            this.cbNoKVMode.Text = "No KV Mode";
            this.cbNoKVMode.UseSelectable = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbUI);
            this.groupBox2.Controls.Add(this.cbOffline);
            this.groupBox2.Controls.Add(this.cbOnHost);
            this.groupBox2.Controls.Add(this.cbLegacyEngines);
            this.groupBox2.Controls.Add(this.cbEngine);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 136);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(290, 145);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Teapot / Engine Settings";
            // 
            // cbUI
            // 
            this.cbUI.AutoSize = true;
            this.cbUI.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.cbUI.FontWeight = MetroFramework.MetroCheckBoxWeight.Bold;
            this.cbUI.Location = new System.Drawing.Point(11, 44);
            this.cbUI.Name = "cbUI";
            this.cbUI.Size = new System.Drawing.Size(138, 19);
            this.cbUI.TabIndex = 35;
            this.cbUI.Text = "Custom Interface";
            this.cbUI.UseSelectable = true;
            // 
            // cbOffline
            // 
            this.cbOffline.AutoSize = true;
            this.cbOffline.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.cbOffline.FontWeight = MetroFramework.MetroCheckBoxWeight.Bold;
            this.cbOffline.Location = new System.Drawing.Point(11, 19);
            this.cbOffline.Name = "cbOffline";
            this.cbOffline.Size = new System.Drawing.Size(113, 19);
            this.cbOffline.TabIndex = 34;
            this.cbOffline.Text = "Offline Mode";
            this.cbOffline.UseSelectable = true;
            // 
            // cbOnHost
            // 
            this.cbOnHost.AutoSize = true;
            this.cbOnHost.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.cbOnHost.FontWeight = MetroFramework.MetroCheckBoxWeight.Bold;
            this.cbOnHost.Location = new System.Drawing.Point(11, 119);
            this.cbOnHost.Name = "cbOnHost";
            this.cbOnHost.Size = new System.Drawing.Size(128, 19);
            this.cbOnHost.TabIndex = 33;
            this.cbOnHost.Text = "On-Host Menus";
            this.cbOnHost.UseSelectable = true;
            // 
            // cbLegacyEngines
            // 
            this.cbLegacyEngines.AutoSize = true;
            this.cbLegacyEngines.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.cbLegacyEngines.FontWeight = MetroFramework.MetroCheckBoxWeight.Bold;
            this.cbLegacyEngines.Location = new System.Drawing.Point(11, 94);
            this.cbLegacyEngines.Name = "cbLegacyEngines";
            this.cbLegacyEngines.Size = new System.Drawing.Size(126, 19);
            this.cbLegacyEngines.TabIndex = 32;
            this.cbLegacyEngines.Text = "Legacy Engines";
            this.cbLegacyEngines.UseSelectable = true;
            // 
            // cbEngine
            // 
            this.cbEngine.AutoSize = true;
            this.cbEngine.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.cbEngine.FontWeight = MetroFramework.MetroCheckBoxWeight.Bold;
            this.cbEngine.Location = new System.Drawing.Point(11, 69);
            this.cbEngine.Name = "cbEngine";
            this.cbEngine.Size = new System.Drawing.Size(119, 19);
            this.cbEngine.TabIndex = 31;
            this.cbEngine.Text = "Teapot Engine";
            this.cbEngine.UseSelectable = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbBypassBo2);
            this.groupBox3.Controls.Add(this.cbBypassGhosts);
            this.groupBox3.Controls.Add(this.cbBypassBo3);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(13, 287);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(290, 93);
            this.groupBox3.TabIndex = 36;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Bypasses";
            // 
            // cbBypassBo2
            // 
            this.cbBypassBo2.AutoSize = true;
            this.cbBypassBo2.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.cbBypassBo2.FontWeight = MetroFramework.MetroCheckBoxWeight.Bold;
            this.cbBypassBo2.Location = new System.Drawing.Point(11, 44);
            this.cbBypassBo2.Name = "cbBypassBo2";
            this.cbBypassBo2.Size = new System.Drawing.Size(85, 19);
            this.cbBypassBo2.TabIndex = 35;
            this.cbBypassBo2.Text = "COD Bo2";
            this.cbBypassBo2.UseSelectable = true;
            // 
            // cbBypassGhosts
            // 
            this.cbBypassGhosts.AutoSize = true;
            this.cbBypassGhosts.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.cbBypassGhosts.FontWeight = MetroFramework.MetroCheckBoxWeight.Bold;
            this.cbBypassGhosts.Location = new System.Drawing.Point(11, 19);
            this.cbBypassGhosts.Name = "cbBypassGhosts";
            this.cbBypassGhosts.Size = new System.Drawing.Size(103, 19);
            this.cbBypassGhosts.TabIndex = 34;
            this.cbBypassGhosts.Text = "COD Ghosts";
            this.cbBypassGhosts.UseSelectable = true;
            // 
            // cbBypassBo3
            // 
            this.cbBypassBo3.AutoSize = true;
            this.cbBypassBo3.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.cbBypassBo3.FontWeight = MetroFramework.MetroCheckBoxWeight.Bold;
            this.cbBypassBo3.Location = new System.Drawing.Point(11, 69);
            this.cbBypassBo3.Name = "cbBypassBo3";
            this.cbBypassBo3.Size = new System.Drawing.Size(85, 19);
            this.cbBypassBo3.TabIndex = 31;
            this.cbBypassBo3.Text = "COD Bo3";
            this.cbBypassBo3.UseSelectable = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(90, 395);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(52, 20);
            this.numericUpDown1.TabIndex = 37;
            this.numericUpDown1.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // valFanSpeed
            // 
            this.valFanSpeed.AutoSize = true;
            this.valFanSpeed.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.valFanSpeed.Location = new System.Drawing.Point(13, 393);
            this.valFanSpeed.Name = "valFanSpeed";
            this.valFanSpeed.Size = new System.Drawing.Size(78, 19);
            this.valFanSpeed.TabIndex = 38;
            this.valFanSpeed.Text = "Fan Speed";
            // 
            // TeapotConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(317, 467);
            this.Controls.Add(this.valFanSpeed);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel4);
            this.MinimumSize = new System.Drawing.Size(317, 399);
            this.Name = "TeapotConfig";
            this.Text = "                                                                                 " +
    "                                                ";
            this.Load += new System.EventHandler(this.TeapotConfig_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnCancel;
        private MetroFramework.Controls.MetroButton btnSave;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroCheckBox cbNoKVMode;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private MetroFramework.Controls.MetroCheckBox cbUseNandKV;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroCheckBox cbOffline;
        private MetroFramework.Controls.MetroCheckBox cbOnHost;
        private MetroFramework.Controls.MetroCheckBox cbLegacyEngines;
        private MetroFramework.Controls.MetroCheckBox cbEngine;
        private MetroFramework.Controls.MetroCheckBox cbUI;
        private System.Windows.Forms.GroupBox groupBox3;
        private MetroFramework.Controls.MetroCheckBox cbBypassBo2;
        private MetroFramework.Controls.MetroCheckBox cbBypassGhosts;
        private MetroFramework.Controls.MetroCheckBox cbBypassBo3;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private MetroFramework.Controls.MetroLabel valFanSpeed;
    }
}