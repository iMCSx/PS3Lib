namespace CCAPI_Demo
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupConnect = new System.Windows.Forms.GroupBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.BoxIP = new System.Windows.Forms.TextBox();
            this.lblIP = new System.Windows.Forms.Label();
            this.groupProc = new System.Windows.Forms.GroupBox();
            this.lblValue = new System.Windows.Forms.Label();
            this.lblOffset = new System.Windows.Forms.Label();
            this.btnSetMem = new System.Windows.Forms.Button();
            this.BoxValue = new System.Windows.Forms.TextBox();
            this.BoxOffset = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.comboProcs = new System.Windows.Forms.ComboBox();
            this.lblProcs = new System.Windows.Forms.Label();
            this.groupCID = new System.Windows.Forms.GroupBox();
            this.btnCID = new System.Windows.Forms.Button();
            this.BoxCID = new System.Windows.Forms.TextBox();
            this.groupInfo = new System.Windows.Forms.GroupBox();
            this.lblRSX = new System.Windows.Forms.Label();
            this.lblCELL = new System.Windows.Forms.Label();
            this.lblLV2 = new System.Windows.Forms.Label();
            this.lblFW = new System.Windows.Forms.Label();
            this.lblR = new System.Windows.Forms.Label();
            this.lblC = new System.Windows.Forms.Label();
            this.lblLV = new System.Windows.Forms.Label();
            this.lblF = new System.Windows.Forms.Label();
            this.groupLedColor = new System.Windows.Forms.GroupBox();
            this.radioRed = new System.Windows.Forms.RadioButton();
            this.radioGreen = new System.Windows.Forms.RadioButton();
            this.groupLedMode = new System.Windows.Forms.GroupBox();
            this.radioBlink = new System.Windows.Forms.RadioButton();
            this.radioOff = new System.Windows.Forms.RadioButton();
            this.radioOn = new System.Windows.Forms.RadioButton();
            this.groupBuzz = new System.Windows.Forms.GroupBox();
            this.comboBuzzer = new System.Windows.Forms.ComboBox();
            this.btnBuzzer = new System.Windows.Forms.Button();
            this.btnLed = new System.Windows.Forms.Button();
            this.groupNotify = new System.Windows.Forms.GroupBox();
            this.btnNotify = new System.Windows.Forms.Button();
            this.BoxNotify = new System.Windows.Forms.TextBox();
            this.groupDefaultProc = new System.Windows.Forms.GroupBox();
            this.btnAttach = new System.Windows.Forms.Button();
            this.btnDefProc = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDialog = new System.Windows.Forms.Button();
            this.groupConnect.SuspendLayout();
            this.groupProc.SuspendLayout();
            this.groupCID.SuspendLayout();
            this.groupInfo.SuspendLayout();
            this.groupLedColor.SuspendLayout();
            this.groupLedMode.SuspendLayout();
            this.groupBuzz.SuspendLayout();
            this.groupNotify.SuspendLayout();
            this.groupDefaultProc.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupConnect
            // 
            this.groupConnect.Controls.Add(this.btnConnect);
            this.groupConnect.Controls.Add(this.BoxIP);
            this.groupConnect.Controls.Add(this.lblIP);
            this.groupConnect.Location = new System.Drawing.Point(14, 8);
            this.groupConnect.Name = "groupConnect";
            this.groupConnect.Size = new System.Drawing.Size(355, 51);
            this.groupConnect.TabIndex = 0;
            this.groupConnect.TabStop = false;
            this.groupConnect.Text = "Connection v1";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(258, 17);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 2;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // BoxIP
            // 
            this.BoxIP.Location = new System.Drawing.Point(74, 19);
            this.BoxIP.Name = "BoxIP";
            this.BoxIP.Size = new System.Drawing.Size(178, 20);
            this.BoxIP.TabIndex = 1;
            this.BoxIP.Text = "192.168.1.13";
            // 
            // lblIP
            // 
            this.lblIP.AutoSize = true;
            this.lblIP.Location = new System.Drawing.Point(22, 22);
            this.lblIP.Name = "lblIP";
            this.lblIP.Size = new System.Drawing.Size(46, 13);
            this.lblIP.TabIndex = 0;
            this.lblIP.Text = "PS3 IP :";
            // 
            // groupProc
            // 
            this.groupProc.Controls.Add(this.lblValue);
            this.groupProc.Controls.Add(this.lblOffset);
            this.groupProc.Controls.Add(this.btnSetMem);
            this.groupProc.Controls.Add(this.BoxValue);
            this.groupProc.Controls.Add(this.BoxOffset);
            this.groupProc.Controls.Add(this.btnRefresh);
            this.groupProc.Controls.Add(this.comboProcs);
            this.groupProc.Controls.Add(this.lblProcs);
            this.groupProc.Location = new System.Drawing.Point(14, 142);
            this.groupProc.Name = "groupProc";
            this.groupProc.Size = new System.Drawing.Size(355, 104);
            this.groupProc.TabIndex = 1;
            this.groupProc.TabStop = false;
            this.groupProc.Text = "Processes";
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.Location = new System.Drawing.Point(36, 79);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(40, 13);
            this.lblValue.TabIndex = 7;
            this.lblValue.Text = "Value :";
            // 
            // lblOffset
            // 
            this.lblOffset.AutoSize = true;
            this.lblOffset.Location = new System.Drawing.Point(35, 53);
            this.lblOffset.Name = "lblOffset";
            this.lblOffset.Size = new System.Drawing.Size(41, 13);
            this.lblOffset.TabIndex = 6;
            this.lblOffset.Text = "Offset :\r\n";
            // 
            // btnSetMem
            // 
            this.btnSetMem.Location = new System.Drawing.Point(182, 50);
            this.btnSetMem.Name = "btnSetMem";
            this.btnSetMem.Size = new System.Drawing.Size(82, 46);
            this.btnSetMem.TabIndex = 5;
            this.btnSetMem.Text = "SET";
            this.btnSetMem.UseVisualStyleBackColor = true;
            this.btnSetMem.Click += new System.EventHandler(this.btnSetMem_Click);
            // 
            // BoxValue
            // 
            this.BoxValue.Location = new System.Drawing.Point(82, 76);
            this.BoxValue.Name = "BoxValue";
            this.BoxValue.Size = new System.Drawing.Size(94, 20);
            this.BoxValue.TabIndex = 4;
            // 
            // BoxOffset
            // 
            this.BoxOffset.Location = new System.Drawing.Point(82, 50);
            this.BoxOffset.Name = "BoxOffset";
            this.BoxOffset.Size = new System.Drawing.Size(94, 20);
            this.BoxOffset.TabIndex = 3;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(270, 21);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(71, 23);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // comboProcs
            // 
            this.comboProcs.FormattingEnabled = true;
            this.comboProcs.Location = new System.Drawing.Point(82, 23);
            this.comboProcs.Name = "comboProcs";
            this.comboProcs.Size = new System.Drawing.Size(182, 21);
            this.comboProcs.TabIndex = 1;
            // 
            // lblProcs
            // 
            this.lblProcs.AutoSize = true;
            this.lblProcs.Location = new System.Drawing.Point(14, 26);
            this.lblProcs.Name = "lblProcs";
            this.lblProcs.Size = new System.Drawing.Size(62, 13);
            this.lblProcs.TabIndex = 0;
            this.lblProcs.Text = "Processes :";
            // 
            // groupCID
            // 
            this.groupCID.Controls.Add(this.btnCID);
            this.groupCID.Controls.Add(this.BoxCID);
            this.groupCID.Location = new System.Drawing.Point(14, 252);
            this.groupCID.Name = "groupCID";
            this.groupCID.Size = new System.Drawing.Size(355, 50);
            this.groupCID.TabIndex = 2;
            this.groupCID.TabStop = false;
            this.groupCID.Text = "Set Console ID";
            // 
            // btnCID
            // 
            this.btnCID.Location = new System.Drawing.Point(265, 17);
            this.btnCID.Name = "btnCID";
            this.btnCID.Size = new System.Drawing.Size(75, 23);
            this.btnCID.TabIndex = 4;
            this.btnCID.Text = "SET";
            this.btnCID.UseVisualStyleBackColor = true;
            this.btnCID.Click += new System.EventHandler(this.btnCID_Click);
            // 
            // BoxCID
            // 
            this.BoxCID.Location = new System.Drawing.Point(16, 19);
            this.BoxCID.Name = "BoxCID";
            this.BoxCID.Size = new System.Drawing.Size(243, 20);
            this.BoxCID.TabIndex = 3;
            // 
            // groupInfo
            // 
            this.groupInfo.Controls.Add(this.lblRSX);
            this.groupInfo.Controls.Add(this.lblCELL);
            this.groupInfo.Controls.Add(this.lblLV2);
            this.groupInfo.Controls.Add(this.lblFW);
            this.groupInfo.Controls.Add(this.lblR);
            this.groupInfo.Controls.Add(this.lblC);
            this.groupInfo.Controls.Add(this.lblLV);
            this.groupInfo.Controls.Add(this.lblF);
            this.groupInfo.Location = new System.Drawing.Point(388, 12);
            this.groupInfo.Name = "groupInfo";
            this.groupInfo.Size = new System.Drawing.Size(147, 152);
            this.groupInfo.TabIndex = 3;
            this.groupInfo.TabStop = false;
            this.groupInfo.Text = "Console Information :";
            // 
            // lblRSX
            // 
            this.lblRSX.AutoSize = true;
            this.lblRSX.Location = new System.Drawing.Point(97, 100);
            this.lblRSX.Name = "lblRSX";
            this.lblRSX.Size = new System.Drawing.Size(13, 13);
            this.lblRSX.TabIndex = 8;
            this.lblRSX.Text = "?";
            // 
            // lblCELL
            // 
            this.lblCELL.AutoSize = true;
            this.lblCELL.Location = new System.Drawing.Point(101, 80);
            this.lblCELL.Name = "lblCELL";
            this.lblCELL.Size = new System.Drawing.Size(13, 13);
            this.lblCELL.TabIndex = 7;
            this.lblCELL.Text = "?";
            // 
            // lblLV2
            // 
            this.lblLV2.AutoSize = true;
            this.lblLV2.Location = new System.Drawing.Point(91, 60);
            this.lblLV2.Name = "lblLV2";
            this.lblLV2.Size = new System.Drawing.Size(13, 13);
            this.lblLV2.TabIndex = 6;
            this.lblLV2.Text = "?";
            // 
            // lblFW
            // 
            this.lblFW.AutoSize = true;
            this.lblFW.Location = new System.Drawing.Point(87, 40);
            this.lblFW.Name = "lblFW";
            this.lblFW.Size = new System.Drawing.Size(13, 13);
            this.lblFW.TabIndex = 5;
            this.lblFW.Text = "?";
            // 
            // lblR
            // 
            this.lblR.AutoSize = true;
            this.lblR.Location = new System.Drawing.Point(26, 100);
            this.lblR.Name = "lblR";
            this.lblR.Size = new System.Drawing.Size(65, 13);
            this.lblR.TabIndex = 4;
            this.lblR.Text = "RSX Temp :";
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.Location = new System.Drawing.Point(26, 80);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(69, 13);
            this.lblC.TabIndex = 3;
            this.lblC.Text = "CELL Temp :";
            // 
            // lblLV
            // 
            this.lblLV.AutoSize = true;
            this.lblLV.Location = new System.Drawing.Point(26, 60);
            this.lblLV.Name = "lblLV";
            this.lblLV.Size = new System.Drawing.Size(59, 13);
            this.lblLV.TabIndex = 2;
            this.lblLV.Text = "LV2 Type :";
            // 
            // lblF
            // 
            this.lblF.AutoSize = true;
            this.lblF.Location = new System.Drawing.Point(26, 40);
            this.lblF.Name = "lblF";
            this.lblF.Size = new System.Drawing.Size(55, 13);
            this.lblF.TabIndex = 1;
            this.lblF.Text = "Firmware :";
            // 
            // groupLedColor
            // 
            this.groupLedColor.Controls.Add(this.radioRed);
            this.groupLedColor.Controls.Add(this.radioGreen);
            this.groupLedColor.Location = new System.Drawing.Point(390, 179);
            this.groupLedColor.Name = "groupLedColor";
            this.groupLedColor.Size = new System.Drawing.Size(145, 75);
            this.groupLedColor.TabIndex = 4;
            this.groupLedColor.TabStop = false;
            this.groupLedColor.Text = "Color Led";
            // 
            // radioRed
            // 
            this.radioRed.AutoSize = true;
            this.radioRed.Location = new System.Drawing.Point(16, 43);
            this.radioRed.Name = "radioRed";
            this.radioRed.Size = new System.Drawing.Size(45, 17);
            this.radioRed.TabIndex = 1;
            this.radioRed.Text = "Red";
            this.radioRed.UseVisualStyleBackColor = true;
            this.radioRed.CheckedChanged += new System.EventHandler(this.radioRed_CheckedChanged);
            // 
            // radioGreen
            // 
            this.radioGreen.AutoSize = true;
            this.radioGreen.Checked = true;
            this.radioGreen.Location = new System.Drawing.Point(16, 24);
            this.radioGreen.Name = "radioGreen";
            this.radioGreen.Size = new System.Drawing.Size(54, 17);
            this.radioGreen.TabIndex = 0;
            this.radioGreen.TabStop = true;
            this.radioGreen.Text = "Green\r\n";
            this.radioGreen.UseVisualStyleBackColor = true;
            this.radioGreen.CheckedChanged += new System.EventHandler(this.radioGreen_CheckedChanged);
            // 
            // groupLedMode
            // 
            this.groupLedMode.Controls.Add(this.radioBlink);
            this.groupLedMode.Controls.Add(this.radioOff);
            this.groupLedMode.Controls.Add(this.radioOn);
            this.groupLedMode.Location = new System.Drawing.Point(388, 263);
            this.groupLedMode.Name = "groupLedMode";
            this.groupLedMode.Size = new System.Drawing.Size(147, 95);
            this.groupLedMode.TabIndex = 5;
            this.groupLedMode.TabStop = false;
            this.groupLedMode.Text = "Mode Led";
            // 
            // radioBlink
            // 
            this.radioBlink.AutoSize = true;
            this.radioBlink.Location = new System.Drawing.Point(18, 63);
            this.radioBlink.Name = "radioBlink";
            this.radioBlink.Size = new System.Drawing.Size(48, 17);
            this.radioBlink.TabIndex = 4;
            this.radioBlink.Text = "Blink";
            this.radioBlink.UseVisualStyleBackColor = true;
            this.radioBlink.CheckedChanged += new System.EventHandler(this.radioBlink_CheckedChanged);
            // 
            // radioOff
            // 
            this.radioOff.AutoSize = true;
            this.radioOff.Location = new System.Drawing.Point(18, 42);
            this.radioOff.Name = "radioOff";
            this.radioOff.Size = new System.Drawing.Size(39, 17);
            this.radioOff.TabIndex = 3;
            this.radioOff.Text = "Off";
            this.radioOff.UseVisualStyleBackColor = true;
            this.radioOff.CheckedChanged += new System.EventHandler(this.radioOff_CheckedChanged);
            // 
            // radioOn
            // 
            this.radioOn.AutoSize = true;
            this.radioOn.Checked = true;
            this.radioOn.Location = new System.Drawing.Point(18, 21);
            this.radioOn.Name = "radioOn";
            this.radioOn.Size = new System.Drawing.Size(39, 17);
            this.radioOn.TabIndex = 2;
            this.radioOn.TabStop = true;
            this.radioOn.Text = "On";
            this.radioOn.UseVisualStyleBackColor = true;
            this.radioOn.CheckedChanged += new System.EventHandler(this.radioOn_CheckedChanged);
            // 
            // groupBuzz
            // 
            this.groupBuzz.Controls.Add(this.comboBuzzer);
            this.groupBuzz.Controls.Add(this.btnBuzzer);
            this.groupBuzz.Location = new System.Drawing.Point(14, 308);
            this.groupBuzz.Name = "groupBuzz";
            this.groupBuzz.Size = new System.Drawing.Size(355, 50);
            this.groupBuzz.TabIndex = 5;
            this.groupBuzz.TabStop = false;
            this.groupBuzz.Text = "Ring Buzzer";
            // 
            // comboBuzzer
            // 
            this.comboBuzzer.FormattingEnabled = true;
            this.comboBuzzer.Items.AddRange(new object[] {
            "Continuous",
            "Single",
            "Double",
            "Triple"});
            this.comboBuzzer.Location = new System.Drawing.Point(16, 20);
            this.comboBuzzer.Name = "comboBuzzer";
            this.comboBuzzer.Size = new System.Drawing.Size(160, 21);
            this.comboBuzzer.TabIndex = 5;
            // 
            // btnBuzzer
            // 
            this.btnBuzzer.Location = new System.Drawing.Point(182, 18);
            this.btnBuzzer.Name = "btnBuzzer";
            this.btnBuzzer.Size = new System.Drawing.Size(158, 23);
            this.btnBuzzer.TabIndex = 4;
            this.btnBuzzer.Text = "SET";
            this.btnBuzzer.UseVisualStyleBackColor = true;
            this.btnBuzzer.Click += new System.EventHandler(this.btnBuzzer_Click);
            // 
            // btnLed
            // 
            this.btnLed.Location = new System.Drawing.Point(388, 376);
            this.btnLed.Name = "btnLed";
            this.btnLed.Size = new System.Drawing.Size(147, 26);
            this.btnLed.TabIndex = 6;
            this.btnLed.Text = "SET Led";
            this.btnLed.UseVisualStyleBackColor = true;
            this.btnLed.Click += new System.EventHandler(this.btnLed_Click);
            // 
            // groupNotify
            // 
            this.groupNotify.Controls.Add(this.btnNotify);
            this.groupNotify.Controls.Add(this.BoxNotify);
            this.groupNotify.Location = new System.Drawing.Point(14, 361);
            this.groupNotify.Name = "groupNotify";
            this.groupNotify.Size = new System.Drawing.Size(355, 50);
            this.groupNotify.TabIndex = 5;
            this.groupNotify.TabStop = false;
            this.groupNotify.Text = "Set Notify";
            // 
            // btnNotify
            // 
            this.btnNotify.Location = new System.Drawing.Point(265, 17);
            this.btnNotify.Name = "btnNotify";
            this.btnNotify.Size = new System.Drawing.Size(75, 23);
            this.btnNotify.TabIndex = 4;
            this.btnNotify.Text = "SET";
            this.btnNotify.UseVisualStyleBackColor = true;
            this.btnNotify.Click += new System.EventHandler(this.btnNotify_Click);
            // 
            // BoxNotify
            // 
            this.BoxNotify.Location = new System.Drawing.Point(25, 19);
            this.BoxNotify.Name = "BoxNotify";
            this.BoxNotify.Size = new System.Drawing.Size(234, 20);
            this.BoxNotify.TabIndex = 3;
            // 
            // groupDefaultProc
            // 
            this.groupDefaultProc.Controls.Add(this.btnAttach);
            this.groupDefaultProc.Controls.Add(this.btnDefProc);
            this.groupDefaultProc.Location = new System.Drawing.Point(14, 420);
            this.groupDefaultProc.Name = "groupDefaultProc";
            this.groupDefaultProc.Size = new System.Drawing.Size(521, 61);
            this.groupDefaultProc.TabIndex = 6;
            this.groupDefaultProc.TabStop = false;
            this.groupDefaultProc.Text = "Set Memory On Default Process (GAME)";
            // 
            // btnAttach
            // 
            this.btnAttach.Location = new System.Drawing.Point(16, 22);
            this.btnAttach.Name = "btnAttach";
            this.btnAttach.Size = new System.Drawing.Size(236, 23);
            this.btnAttach.TabIndex = 5;
            this.btnAttach.Text = "Attach Default Process Game !";
            this.btnAttach.UseVisualStyleBackColor = true;
            this.btnAttach.Click += new System.EventHandler(this.btnAttach_Click);
            // 
            // btnDefProc
            // 
            this.btnDefProc.Location = new System.Drawing.Point(270, 22);
            this.btnDefProc.Name = "btnDefProc";
            this.btnDefProc.Size = new System.Drawing.Size(236, 23);
            this.btnDefProc.TabIndex = 4;
            this.btnDefProc.Text = "SET";
            this.btnDefProc.UseVisualStyleBackColor = true;
            this.btnDefProc.Click += new System.EventHandler(this.btnDefProc_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDialog);
            this.groupBox1.Location = new System.Drawing.Point(14, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(355, 51);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connection v2 (Dialog)";
            // 
            // btnDialog
            // 
            this.btnDialog.Location = new System.Drawing.Point(30, 18);
            this.btnDialog.Name = "btnDialog";
            this.btnDialog.Size = new System.Drawing.Size(295, 23);
            this.btnDialog.TabIndex = 2;
            this.btnDialog.Text = "Connect";
            this.btnDialog.UseVisualStyleBackColor = true;
            this.btnDialog.Click += new System.EventHandler(this.btnDialog_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 498);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupDefaultProc);
            this.Controls.Add(this.groupNotify);
            this.Controls.Add(this.btnLed);
            this.Controls.Add(this.groupBuzz);
            this.Controls.Add(this.groupLedMode);
            this.Controls.Add(this.groupLedColor);
            this.Controls.Add(this.groupInfo);
            this.Controls.Add(this.groupCID);
            this.Controls.Add(this.groupProc);
            this.Controls.Add(this.groupConnect);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(564, 537);
            this.MinimumSize = new System.Drawing.Size(564, 537);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Demo for use CCAPI with PS3Lib v4.5 - By iMCSx";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupConnect.ResumeLayout(false);
            this.groupConnect.PerformLayout();
            this.groupProc.ResumeLayout(false);
            this.groupProc.PerformLayout();
            this.groupCID.ResumeLayout(false);
            this.groupCID.PerformLayout();
            this.groupInfo.ResumeLayout(false);
            this.groupInfo.PerformLayout();
            this.groupLedColor.ResumeLayout(false);
            this.groupLedColor.PerformLayout();
            this.groupLedMode.ResumeLayout(false);
            this.groupLedMode.PerformLayout();
            this.groupBuzz.ResumeLayout(false);
            this.groupNotify.ResumeLayout(false);
            this.groupNotify.PerformLayout();
            this.groupDefaultProc.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupConnect;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox BoxIP;
        private System.Windows.Forms.Label lblIP;
        private System.Windows.Forms.GroupBox groupProc;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.Label lblOffset;
        private System.Windows.Forms.Button btnSetMem;
        private System.Windows.Forms.TextBox BoxValue;
        private System.Windows.Forms.TextBox BoxOffset;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ComboBox comboProcs;
        private System.Windows.Forms.Label lblProcs;
        private System.Windows.Forms.GroupBox groupCID;
        private System.Windows.Forms.Button btnCID;
        private System.Windows.Forms.TextBox BoxCID;
        private System.Windows.Forms.GroupBox groupInfo;
        private System.Windows.Forms.Label lblRSX;
        private System.Windows.Forms.Label lblCELL;
        private System.Windows.Forms.Label lblLV2;
        private System.Windows.Forms.Label lblFW;
        private System.Windows.Forms.Label lblR;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.Label lblLV;
        private System.Windows.Forms.Label lblF;
        private System.Windows.Forms.GroupBox groupLedColor;
        private System.Windows.Forms.RadioButton radioRed;
        private System.Windows.Forms.RadioButton radioGreen;
        private System.Windows.Forms.GroupBox groupLedMode;
        private System.Windows.Forms.RadioButton radioBlink;
        private System.Windows.Forms.RadioButton radioOff;
        private System.Windows.Forms.RadioButton radioOn;
        private System.Windows.Forms.GroupBox groupBuzz;
        private System.Windows.Forms.ComboBox comboBuzzer;
        private System.Windows.Forms.Button btnBuzzer;
        private System.Windows.Forms.Button btnLed;
        private System.Windows.Forms.GroupBox groupNotify;
        private System.Windows.Forms.Button btnNotify;
        private System.Windows.Forms.TextBox BoxNotify;
        private System.Windows.Forms.GroupBox groupDefaultProc;
        private System.Windows.Forms.Button btnAttach;
        private System.Windows.Forms.Button btnDefProc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDialog;
    }
}

