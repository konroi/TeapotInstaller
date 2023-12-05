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
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbNoKVMode = new MetroFramework.Controls.MetroRadioButton();
            this.rbNandKV = new MetroFramework.Controls.MetroRadioButton();
            this.rbYourKV = new MetroFramework.Controls.MetroRadioButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbUI = new MetroFramework.Controls.MetroCheckBox();
            this.cbOffline = new MetroFramework.Controls.MetroCheckBox();
            this.cbOnHost = new MetroFramework.Controls.MetroCheckBox();
            this.cbLegacyEngines = new MetroFramework.Controls.MetroCheckBox();
            this.cbEngine = new MetroFramework.Controls.MetroCheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbBypassAW = new MetroFramework.Controls.MetroCheckBox();
            this.cbBypassBo2 = new MetroFramework.Controls.MetroCheckBox();
            this.cbBypassGhosts = new MetroFramework.Controls.MetroCheckBox();
            this.cbBypassBo3 = new MetroFramework.Controls.MetroCheckBox();
            this.valFanSpeed = new System.Windows.Forms.NumericUpDown();
            this.lblfanspeed = new MetroFramework.Controls.MetroLabel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.valFanSpeed)).BeginInit();
            this.SuspendLayout();
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
            this.metroLabel4.Size = new System.Drawing.Size(112, 19);
            this.metroLabel4.TabIndex = 19;
            this.metroLabel4.Text = "Teapot Settings";
            this.metroLabel4.Click += new System.EventHandler(this.metroLabel4_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbNoKVMode);
            this.groupBox1.Controls.Add(this.rbNandKV);
            this.groupBox1.Controls.Add(this.rbYourKV);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(290, 97);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "KV Settings";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rbNoKVMode
            // 
            this.rbNoKVMode.AutoSize = true;
            this.rbNoKVMode.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.rbNoKVMode.FontWeight = MetroFramework.MetroCheckBoxWeight.Bold;
            this.rbNoKVMode.Location = new System.Drawing.Point(11, 19);
            this.rbNoKVMode.Name = "rbNoKVMode";
            this.rbNoKVMode.Size = new System.Drawing.Size(110, 19);
            this.rbNoKVMode.TabIndex = 44;
            this.rbNoKVMode.Text = "No KV Mode";
            this.rbNoKVMode.UseSelectable = true;
            // 
            // rbNandKV
            // 
            this.rbNandKV.AutoSize = true;
            this.rbNandKV.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.rbNandKV.FontWeight = MetroFramework.MetroCheckBoxWeight.Bold;
            this.rbNandKV.Location = new System.Drawing.Point(10, 44);
            this.rbNandKV.Name = "rbNandKV";
            this.rbNandKV.Size = new System.Drawing.Size(111, 19);
            this.rbNandKV.TabIndex = 43;
            this.rbNandKV.Text = "Use Nand KV";
            this.rbNandKV.UseSelectable = true;
            // 
            // rbYourKV
            // 
            this.rbYourKV.AutoSize = true;
            this.rbYourKV.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.rbYourKV.FontWeight = MetroFramework.MetroCheckBoxWeight.Bold;
            this.rbYourKV.Location = new System.Drawing.Point(11, 69);
            this.rbYourKV.Name = "rbYourKV";
            this.rbYourKV.Size = new System.Drawing.Size(106, 19);
            this.rbYourKV.TabIndex = 42;
            this.rbYourKV.Text = "Use Your KV";
            this.rbYourKV.UseSelectable = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbUI);
            this.groupBox2.Controls.Add(this.cbOffline);
            this.groupBox2.Controls.Add(this.cbOnHost);
            this.groupBox2.Controls.Add(this.cbLegacyEngines);
            this.groupBox2.Controls.Add(this.cbEngine);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 153);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(290, 145);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Teapot / Engine Settings";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
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
            this.groupBox3.Controls.Add(this.cbBypassAW);
            this.groupBox3.Controls.Add(this.cbBypassBo2);
            this.groupBox3.Controls.Add(this.cbBypassGhosts);
            this.groupBox3.Controls.Add(this.cbBypassBo3);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 304);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(290, 119);
            this.groupBox3.TabIndex = 36;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Bypasses";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // cbBypassAW
            // 
            this.cbBypassAW.AutoSize = true;
            this.cbBypassAW.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.cbBypassAW.FontWeight = MetroFramework.MetroCheckBoxWeight.Bold;
            this.cbBypassAW.Location = new System.Drawing.Point(10, 19);
            this.cbBypassAW.Name = "cbBypassAW";
            this.cbBypassAW.Size = new System.Drawing.Size(184, 19);
            this.cbBypassAW.TabIndex = 36;
            this.cbBypassAW.Text = "COD Advanced Warfare";
            this.cbBypassAW.UseSelectable = true;
            // 
            // cbBypassBo2
            // 
            this.cbBypassBo2.AutoSize = true;
            this.cbBypassBo2.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.cbBypassBo2.FontWeight = MetroFramework.MetroCheckBoxWeight.Bold;
            this.cbBypassBo2.Location = new System.Drawing.Point(10, 69);
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
            this.cbBypassGhosts.Location = new System.Drawing.Point(10, 44);
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
            this.cbBypassBo3.Location = new System.Drawing.Point(10, 94);
            this.cbBypassBo3.Name = "cbBypassBo3";
            this.cbBypassBo3.Size = new System.Drawing.Size(85, 19);
            this.cbBypassBo3.TabIndex = 31;
            this.cbBypassBo3.Text = "COD Bo3";
            this.cbBypassBo3.UseSelectable = true;
            // 
            // valFanSpeed
            // 
            this.valFanSpeed.Location = new System.Drawing.Point(93, 436);
            this.valFanSpeed.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.valFanSpeed.Name = "valFanSpeed";
            this.valFanSpeed.Size = new System.Drawing.Size(52, 20);
            this.valFanSpeed.TabIndex = 37;
            this.valFanSpeed.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.valFanSpeed.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // lblfanspeed
            // 
            this.lblfanspeed.AutoSize = true;
            this.lblfanspeed.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblfanspeed.Location = new System.Drawing.Point(12, 435);
            this.lblfanspeed.Name = "lblfanspeed";
            this.lblfanspeed.Size = new System.Drawing.Size(82, 19);
            this.lblfanspeed.TabIndex = 38;
            this.lblfanspeed.Text = "Fan Speed:";
            this.lblfanspeed.Click += new System.EventHandler(this.lblfanspeed_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Location = new System.Drawing.Point(13, 473);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(59, 23);
            this.btnSave.TabIndex = 40;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Location = new System.Drawing.Point(78, 473);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(59, 23);
            this.btnCancel.TabIndex = 41;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // TeapotConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(317, 512);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblfanspeed);
            this.Controls.Add(this.valFanSpeed);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel4);
            this.MaximumSize = new System.Drawing.Size(317, 512);
            this.MinimumSize = new System.Drawing.Size(317, 512);
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
            ((System.ComponentModel.ISupportInitialize)(this.valFanSpeed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
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
        private System.Windows.Forms.NumericUpDown valFanSpeed;
        private MetroFramework.Controls.MetroLabel lblfanspeed;
        private MetroFramework.Controls.MetroCheckBox cbBypassAW;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private MetroFramework.Controls.MetroRadioButton rbYourKV;
        private MetroFramework.Controls.MetroRadioButton rbNoKVMode;
        private MetroFramework.Controls.MetroRadioButton rbNandKV;
    }
}