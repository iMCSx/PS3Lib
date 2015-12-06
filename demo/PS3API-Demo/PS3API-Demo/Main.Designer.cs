namespace PS3API_Demo
{
    partial class Main
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
            this.radioCC = new System.Windows.Forms.RadioButton();
            this.radioTM = new System.Windows.Forms.RadioButton();
            this.groupAttach = new System.Windows.Forms.GroupBox();
            this.btnAttach = new System.Windows.Forms.Button();
            this.groupMem = new System.Windows.Forms.GroupBox();
            this.btnSpeed = new System.Windows.Forms.Button();
            this.btnJump = new System.Windows.Forms.Button();
            this.btnReadRand = new System.Windows.Forms.Button();
            this.btnSetRand = new System.Windows.Forms.Button();
            this.groupArray = new System.Windows.Forms.GroupBox();
            this.btnReadArr = new System.Windows.Forms.Button();
            this.btnCrArr = new System.Windows.Forms.Button();
            this.groupConnect.SuspendLayout();
            this.groupAttach.SuspendLayout();
            this.groupMem.SuspendLayout();
            this.groupArray.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupConnect
            // 
            this.groupConnect.Controls.Add(this.btnConnect);
            this.groupConnect.Controls.Add(this.radioCC);
            this.groupConnect.Controls.Add(this.radioTM);
            this.groupConnect.Location = new System.Drawing.Point(15, 12);
            this.groupConnect.Name = "groupConnect";
            this.groupConnect.Size = new System.Drawing.Size(200, 100);
            this.groupConnect.TabIndex = 0;
            this.groupConnect.TabStop = false;
            this.groupConnect.Text = "Connection Panel ";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(32, 27);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(137, 28);
            this.btnConnect.TabIndex = 2;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // radioCC
            // 
            this.radioCC.AutoSize = true;
            this.radioCC.Location = new System.Drawing.Point(113, 64);
            this.radioCC.Name = "radioCC";
            this.radioCC.Size = new System.Drawing.Size(56, 17);
            this.radioCC.TabIndex = 1;
            this.radioCC.Text = "CCAPI\r\n";
            this.radioCC.UseVisualStyleBackColor = true;
            this.radioCC.CheckedChanged += new System.EventHandler(this.radioCC_CheckedChanged);
            // 
            // radioTM
            // 
            this.radioTM.AutoSize = true;
            this.radioTM.Checked = true;
            this.radioTM.Location = new System.Drawing.Point(32, 64);
            this.radioTM.Name = "radioTM";
            this.radioTM.Size = new System.Drawing.Size(58, 17);
            this.radioTM.TabIndex = 0;
            this.radioTM.TabStop = true;
            this.radioTM.Text = "TMAPI\r\n";
            this.radioTM.UseVisualStyleBackColor = true;
            this.radioTM.CheckedChanged += new System.EventHandler(this.radioTM_CheckedChanged);
            // 
            // groupAttach
            // 
            this.groupAttach.Controls.Add(this.btnAttach);
            this.groupAttach.Location = new System.Drawing.Point(231, 12);
            this.groupAttach.Name = "groupAttach";
            this.groupAttach.Size = new System.Drawing.Size(200, 100);
            this.groupAttach.TabIndex = 1;
            this.groupAttach.TabStop = false;
            this.groupAttach.Text = "Attach Process";
            // 
            // btnAttach
            // 
            this.btnAttach.Location = new System.Drawing.Point(32, 27);
            this.btnAttach.Name = "btnAttach";
            this.btnAttach.Size = new System.Drawing.Size(137, 54);
            this.btnAttach.TabIndex = 3;
            this.btnAttach.Text = "Attach Game Process";
            this.btnAttach.UseVisualStyleBackColor = true;
            this.btnAttach.Click += new System.EventHandler(this.btnAttach_Click);
            // 
            // groupMem
            // 
            this.groupMem.Controls.Add(this.btnSpeed);
            this.groupMem.Controls.Add(this.btnJump);
            this.groupMem.Controls.Add(this.btnReadRand);
            this.groupMem.Controls.Add(this.btnSetRand);
            this.groupMem.Location = new System.Drawing.Point(15, 118);
            this.groupMem.Name = "groupMem";
            this.groupMem.Size = new System.Drawing.Size(200, 138);
            this.groupMem.TabIndex = 2;
            this.groupMem.TabStop = false;
            this.groupMem.Text = "Memory";
            // 
            // btnSpeed
            // 
            this.btnSpeed.Location = new System.Drawing.Point(32, 106);
            this.btnSpeed.Name = "btnSpeed";
            this.btnSpeed.Size = new System.Drawing.Size(137, 23);
            this.btnSpeed.TabIndex = 3;
            this.btnSpeed.Text = "Set MW3 Speed\r\n\r\n";
            this.btnSpeed.UseVisualStyleBackColor = true;
            this.btnSpeed.Click += new System.EventHandler(this.btnSpeed_Click);
            // 
            // btnJump
            // 
            this.btnJump.Location = new System.Drawing.Point(32, 77);
            this.btnJump.Name = "btnJump";
            this.btnJump.Size = new System.Drawing.Size(137, 23);
            this.btnJump.TabIndex = 2;
            this.btnJump.Text = "Set MW3 Jump\r\n";
            this.btnJump.UseVisualStyleBackColor = true;
            this.btnJump.Click += new System.EventHandler(this.btnJump_Click);
            // 
            // btnReadRand
            // 
            this.btnReadRand.Location = new System.Drawing.Point(32, 48);
            this.btnReadRand.Name = "btnReadRand";
            this.btnReadRand.Size = new System.Drawing.Size(137, 23);
            this.btnReadRand.TabIndex = 1;
            this.btnReadRand.Text = "Read Random";
            this.btnReadRand.UseVisualStyleBackColor = true;
            this.btnReadRand.Click += new System.EventHandler(this.btnReadRand_Click);
            // 
            // btnSetRand
            // 
            this.btnSetRand.Location = new System.Drawing.Point(32, 19);
            this.btnSetRand.Name = "btnSetRand";
            this.btnSetRand.Size = new System.Drawing.Size(137, 23);
            this.btnSetRand.TabIndex = 0;
            this.btnSetRand.Text = "Set Random";
            this.btnSetRand.UseVisualStyleBackColor = true;
            this.btnSetRand.Click += new System.EventHandler(this.btnSetRand_Click);
            // 
            // groupArray
            // 
            this.groupArray.Controls.Add(this.btnReadArr);
            this.groupArray.Controls.Add(this.btnCrArr);
            this.groupArray.Location = new System.Drawing.Point(231, 118);
            this.groupArray.Name = "groupArray";
            this.groupArray.Size = new System.Drawing.Size(200, 138);
            this.groupArray.TabIndex = 3;
            this.groupArray.TabStop = false;
            this.groupArray.Text = "Create Array";
            // 
            // btnReadArr
            // 
            this.btnReadArr.Location = new System.Drawing.Point(27, 72);
            this.btnReadArr.Name = "btnReadArr";
            this.btnReadArr.Size = new System.Drawing.Size(147, 41);
            this.btnReadArr.TabIndex = 1;
            this.btnReadArr.Text = "Read from PS3";
            this.btnReadArr.UseVisualStyleBackColor = true;
            this.btnReadArr.Click += new System.EventHandler(this.btnReadArr_Click);
            // 
            // btnCrArr
            // 
            this.btnCrArr.Location = new System.Drawing.Point(27, 25);
            this.btnCrArr.Name = "btnCrArr";
            this.btnCrArr.Size = new System.Drawing.Size(147, 41);
            this.btnCrArr.TabIndex = 0;
            this.btnCrArr.Text = "Create + Set to PS3";
            this.btnCrArr.UseVisualStyleBackColor = true;
            this.btnCrArr.Click += new System.EventHandler(this.btnCrArr_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 267);
            this.Controls.Add(this.groupArray);
            this.Controls.Add(this.groupMem);
            this.Controls.Add(this.groupAttach);
            this.Controls.Add(this.groupConnect);
            this.MaximumSize = new System.Drawing.Size(463, 306);
            this.MinimumSize = new System.Drawing.Size(463, 306);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Demo for use PS3API with PS3Lib v4.5 - By iMCSx";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.groupConnect.ResumeLayout(false);
            this.groupConnect.PerformLayout();
            this.groupAttach.ResumeLayout(false);
            this.groupMem.ResumeLayout(false);
            this.groupArray.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupConnect;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.RadioButton radioCC;
        private System.Windows.Forms.RadioButton radioTM;
        private System.Windows.Forms.GroupBox groupAttach;
        private System.Windows.Forms.Button btnAttach;
        private System.Windows.Forms.GroupBox groupMem;
        private System.Windows.Forms.Button btnSpeed;
        private System.Windows.Forms.Button btnJump;
        private System.Windows.Forms.Button btnReadRand;
        private System.Windows.Forms.Button btnSetRand;
        private System.Windows.Forms.GroupBox groupArray;
        private System.Windows.Forms.Button btnReadArr;
        private System.Windows.Forms.Button btnCrArr;
    }
}

