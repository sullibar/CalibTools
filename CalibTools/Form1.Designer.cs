namespace CalibTools
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatusCon = new System.Windows.Forms.ToolStripStatusLabel();
            this.boxMotor = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.boxAdresseIp = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnWriteSpd = new MaterialSkin.Controls.MaterialFlatButton();
            this.boxMesSpeed = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblMot1 = new System.Windows.Forms.Label();
            this.lblMot2 = new System.Windows.Forms.Label();
            this.lblMot3 = new System.Windows.Forms.Label();
            this.lblMot4 = new System.Windows.Forms.Label();
            this.lblMot5 = new System.Windows.Forms.Label();
            this.lblMot6 = new System.Windows.Forms.Label();
            this.lblMot7 = new System.Windows.Forms.Label();
            this.lblMot8 = new System.Windows.Forms.Label();
            this.lblMot9 = new System.Windows.Forms.Label();
            this.btnScan = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton2 = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnReset = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnForceCalib = new MaterialSkin.Controls.MaterialFlatButton();
            this.progressBarSpdF = new System.Windows.Forms.ProgressBar();
            this.btnForceOn = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnBump = new MaterialSkin.Controls.MaterialFlatButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.circIntMotor = new LiveCharts.WinForms.SolidGauge();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblSpeed = new MaterialSkin.Controls.MaterialLabel();
            this.circSpdMotor = new LiveCharts.WinForms.SolidGauge();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.White;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatusCon,
            this.boxMotor});
            this.statusStrip1.Location = new System.Drawing.Point(0, 770);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(638, 25);
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // lblStatusCon
            // 
            this.lblStatusCon.Name = "lblStatusCon";
            this.lblStatusCon.Size = new System.Drawing.Size(88, 20);
            this.lblStatusCon.Text = "Déconnecté";
            // 
            // boxMotor
            // 
            this.boxMotor.Name = "boxMotor";
            this.boxMotor.Size = new System.Drawing.Size(33, 20);
            this.boxMotor.Text = global::CalibTools.Properties.Settings.Default.Num_moteur;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 333;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // boxAdresseIp
            // 
            this.boxAdresseIp.BackColor = System.Drawing.Color.White;
            this.boxAdresseIp.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::CalibTools.Properties.Settings.Default, "Adresse_ip", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.boxAdresseIp.Depth = 0;
            this.boxAdresseIp.Hint = "";
            this.boxAdresseIp.Location = new System.Drawing.Point(256, 71);
            this.boxAdresseIp.MouseState = MaterialSkin.MouseState.HOVER;
            this.boxAdresseIp.Name = "boxAdresseIp";
            this.boxAdresseIp.PasswordChar = '\0';
            this.boxAdresseIp.SelectedText = "";
            this.boxAdresseIp.SelectionLength = 0;
            this.boxAdresseIp.SelectionStart = 0;
            this.boxAdresseIp.Size = new System.Drawing.Size(215, 28);
            this.boxAdresseIp.TabIndex = 33;
            this.boxAdresseIp.Text = global::CalibTools.Properties.Settings.Default.Adresse_ip;
            this.boxAdresseIp.UseSystemPasswordChar = false;
            // 
            // btnWriteSpd
            // 
            this.btnWriteSpd.AutoSize = true;
            this.btnWriteSpd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnWriteSpd.Depth = 0;
            this.btnWriteSpd.Location = new System.Drawing.Point(491, 148);
            this.btnWriteSpd.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnWriteSpd.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnWriteSpd.Name = "btnWriteSpd";
            this.btnWriteSpd.Primary = false;
            this.btnWriteSpd.Size = new System.Drawing.Size(32, 36);
            this.btnWriteSpd.TabIndex = 51;
            this.btnWriteSpd.Text = "=>";
            this.btnWriteSpd.UseVisualStyleBackColor = true;
            // 
            // boxMesSpeed
            // 
            this.boxMesSpeed.Depth = 0;
            this.boxMesSpeed.Hint = "";
            this.boxMesSpeed.Location = new System.Drawing.Point(256, 156);
            this.boxMesSpeed.MouseState = MaterialSkin.MouseState.HOVER;
            this.boxMesSpeed.Name = "boxMesSpeed";
            this.boxMesSpeed.PasswordChar = '\0';
            this.boxMesSpeed.SelectedText = "";
            this.boxMesSpeed.SelectionLength = 0;
            this.boxMesSpeed.SelectionStart = 0;
            this.boxMesSpeed.Size = new System.Drawing.Size(215, 28);
            this.boxMesSpeed.TabIndex = 50;
            this.boxMesSpeed.UseSystemPasswordChar = false;
            this.boxMesSpeed.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.boxMesSpeed_KeyPress);
            // 
            // lblMot1
            // 
            this.lblMot1.AutoSize = true;
            this.lblMot1.BackColor = System.Drawing.Color.White;
            this.lblMot1.Location = new System.Drawing.Point(24, 31);
            this.lblMot1.Name = "lblMot1";
            this.lblMot1.Size = new System.Drawing.Size(71, 17);
            this.lblMot1.TabIndex = 41;
            this.lblMot1.Text = "Moteur ok";
            // 
            // lblMot2
            // 
            this.lblMot2.AutoSize = true;
            this.lblMot2.BackColor = System.Drawing.Color.White;
            this.lblMot2.Location = new System.Drawing.Point(24, 48);
            this.lblMot2.Name = "lblMot2";
            this.lblMot2.Size = new System.Drawing.Size(118, 17);
            this.lblMot2.TabIndex = 42;
            this.lblMot2.Text = "Moteur is running";
            // 
            // lblMot3
            // 
            this.lblMot3.AutoSize = true;
            this.lblMot3.BackColor = System.Drawing.Color.White;
            this.lblMot3.Location = new System.Drawing.Point(24, 65);
            this.lblMot3.Name = "lblMot3";
            this.lblMot3.Size = new System.Drawing.Size(180, 17);
            this.lblMot3.TabIndex = 43;
            this.lblMot3.Text = "Moteur isolator switch open";
            // 
            // lblMot4
            // 
            this.lblMot4.AutoSize = true;
            this.lblMot4.BackColor = System.Drawing.Color.White;
            this.lblMot4.Location = new System.Drawing.Point(24, 82);
            this.lblMot4.Name = "lblMot4";
            this.lblMot4.Size = new System.Drawing.Size(90, 17);
            this.lblMot4.TabIndex = 44;
            this.lblMot4.Text = "Vfd is on bus";
            // 
            // lblMot5
            // 
            this.lblMot5.AutoSize = true;
            this.lblMot5.BackColor = System.Drawing.Color.White;
            this.lblMot5.Location = new System.Drawing.Point(24, 99);
            this.lblMot5.Name = "lblMot5";
            this.lblMot5.Size = new System.Drawing.Size(126, 17);
            this.lblMot5.TabIndex = 45;
            this.lblMot5.Text = "Power supply is on";
            // 
            // lblMot6
            // 
            this.lblMot6.AutoSize = true;
            this.lblMot6.BackColor = System.Drawing.Color.White;
            this.lblMot6.Location = new System.Drawing.Point(24, 116);
            this.lblMot6.Name = "lblMot6";
            this.lblMot6.Size = new System.Drawing.Size(117, 17);
            this.lblMot6.TabIndex = 46;
            this.lblMot6.Text = "Low limit reached";
            // 
            // lblMot7
            // 
            this.lblMot7.AutoSize = true;
            this.lblMot7.BackColor = System.Drawing.Color.White;
            this.lblMot7.Location = new System.Drawing.Point(24, 133);
            this.lblMot7.Name = "lblMot7";
            this.lblMot7.Size = new System.Drawing.Size(121, 17);
            this.lblMot7.TabIndex = 47;
            this.lblMot7.Text = "High limit reached";
            // 
            // lblMot8
            // 
            this.lblMot8.AutoSize = true;
            this.lblMot8.BackColor = System.Drawing.Color.White;
            this.lblMot8.Location = new System.Drawing.Point(24, 167);
            this.lblMot8.Name = "lblMot8";
            this.lblMot8.Size = new System.Drawing.Size(196, 17);
            this.lblMot8.TabIndex = 48;
            this.lblMot8.Text = "Motor isolator switch calculate";
            this.lblMot8.Visible = false;
            // 
            // lblMot9
            // 
            this.lblMot9.AutoSize = true;
            this.lblMot9.BackColor = System.Drawing.Color.White;
            this.lblMot9.Location = new System.Drawing.Point(24, 150);
            this.lblMot9.Name = "lblMot9";
            this.lblMot9.Size = new System.Drawing.Size(171, 17);
            this.lblMot9.TabIndex = 49;
            this.lblMot9.Text = "Emergency stop activated";
            // 
            // btnScan
            // 
            this.btnScan.AutoSize = true;
            this.btnScan.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnScan.Depth = 0;
            this.btnScan.Location = new System.Drawing.Point(256, 108);
            this.btnScan.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnScan.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnScan.Name = "btnScan";
            this.btnScan.Primary = false;
            this.btnScan.Size = new System.Drawing.Size(128, 36);
            this.btnScan.TabIndex = 60;
            this.btnScan.Text = "Scan DB diag";
            this.btnScan.UseVisualStyleBackColor = true;
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // materialFlatButton2
            // 
            this.materialFlatButton2.AutoSize = true;
            this.materialFlatButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton2.Depth = 0;
            this.materialFlatButton2.Location = new System.Drawing.Point(299, 165);
            this.materialFlatButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton2.Name = "materialFlatButton2";
            this.materialFlatButton2.Primary = false;
            this.materialFlatButton2.Size = new System.Drawing.Size(23, 36);
            this.materialFlatButton2.TabIndex = 59;
            this.materialFlatButton2.Text = "+";
            this.materialFlatButton2.UseVisualStyleBackColor = true;
            this.materialFlatButton2.Click += new System.EventHandler(this.materialFlatButton2_Click);
            // 
            // btnReset
            // 
            this.btnReset.AutoSize = true;
            this.btnReset.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnReset.Depth = 0;
            this.btnReset.Location = new System.Drawing.Point(228, 73);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnReset.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnReset.Name = "btnReset";
            this.btnReset.Primary = false;
            this.btnReset.Size = new System.Drawing.Size(64, 36);
            this.btnReset.TabIndex = 56;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Location = new System.Drawing.Point(7, 165);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(19, 36);
            this.materialFlatButton1.TabIndex = 58;
            this.materialFlatButton1.Text = "-";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            this.materialFlatButton1.Click += new System.EventHandler(this.materialFlatButton1_Click);
            // 
            // btnForceCalib
            // 
            this.btnForceCalib.AutoSize = true;
            this.btnForceCalib.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnForceCalib.Depth = 0;
            this.btnForceCalib.Location = new System.Drawing.Point(228, 25);
            this.btnForceCalib.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnForceCalib.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnForceCalib.Name = "btnForceCalib";
            this.btnForceCalib.Primary = false;
            this.btnForceCalib.Size = new System.Drawing.Size(179, 36);
            this.btnForceCalib.TabIndex = 55;
            this.btnForceCalib.Text = "Force calibration";
            this.btnForceCalib.UseVisualStyleBackColor = true;
            this.btnForceCalib.Click += new System.EventHandler(this.btnForceCalib_Click);
            // 
            // progressBarSpdF
            // 
            this.progressBarSpdF.Location = new System.Drawing.Point(7, 133);
            this.progressBarSpdF.MarqueeAnimationSpeed = 0;
            this.progressBarSpdF.Name = "progressBarSpdF";
            this.progressBarSpdF.Size = new System.Drawing.Size(311, 23);
            this.progressBarSpdF.TabIndex = 57;
            this.progressBarSpdF.Value = 50;
            // 
            // btnForceOn
            // 
            this.btnForceOn.AutoSize = true;
            this.btnForceOn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnForceOn.Depth = 0;
            this.btnForceOn.Location = new System.Drawing.Point(7, 73);
            this.btnForceOn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnForceOn.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnForceOn.Name = "btnForceOn";
            this.btnForceOn.Primary = false;
            this.btnForceOn.Size = new System.Drawing.Size(94, 36);
            this.btnForceOn.TabIndex = 54;
            this.btnForceOn.Text = "Force on";
            this.btnForceOn.UseVisualStyleBackColor = true;
            this.btnForceOn.Click += new System.EventHandler(this.btnForceOn_Click);
            // 
            // btnBump
            // 
            this.btnBump.AutoSize = true;
            this.btnBump.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBump.Depth = 0;
            this.btnBump.Location = new System.Drawing.Point(7, 25);
            this.btnBump.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnBump.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBump.Name = "btnBump";
            this.btnBump.Primary = false;
            this.btnBump.Size = new System.Drawing.Size(61, 36);
            this.btnBump.TabIndex = 53;
            this.btnBump.Text = "Bump";
            this.btnBump.UseVisualStyleBackColor = true;
            this.btnBump.Click += new System.EventHandler(this.btnBump_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(256, 31);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(215, 24);
            this.comboBox1.TabIndex = 61;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // circIntMotor
            // 
            this.circIntMotor.BackColor = System.Drawing.Color.White;
            this.circIntMotor.Location = new System.Drawing.Point(46, 87);
            this.circIntMotor.Name = "circIntMotor";
            this.circIntMotor.Size = new System.Drawing.Size(202, 134);
            this.circIntMotor.TabIndex = 62;
            this.circIntMotor.Text = "solidGauge1";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.materialLabel1);
            this.groupBox1.Controls.Add(this.circIntMotor);
            this.groupBox1.Location = new System.Drawing.Point(319, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 241);
            this.groupBox1.TabIndex = 63;
            this.groupBox1.TabStop = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(91, 34);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(126, 24);
            this.materialLabel1.TabIndex = 63;
            this.materialLabel1.Text = "Intensité en %";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.lblSpeed);
            this.groupBox2.Controls.Add(this.circSpdMotor);
            this.groupBox2.Location = new System.Drawing.Point(13, 81);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(300, 241);
            this.groupBox2.TabIndex = 64;
            this.groupBox2.TabStop = false;
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.Depth = 0;
            this.lblSpeed.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblSpeed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblSpeed.Location = new System.Drawing.Point(68, 34);
            this.lblSpeed.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(160, 24);
            this.lblSpeed.TabIndex = 63;
            this.lblSpeed.Text = "Vitesse en m/min";
            // 
            // circSpdMotor
            // 
            this.circSpdMotor.BackColor = System.Drawing.Color.White;
            this.circSpdMotor.Location = new System.Drawing.Point(46, 87);
            this.circSpdMotor.Name = "circSpdMotor";
            this.circSpdMotor.Size = new System.Drawing.Size(202, 134);
            this.circSpdMotor.TabIndex = 62;
            this.circSpdMotor.Text = "solidGauge1";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.lblMot1);
            this.groupBox3.Controls.Add(this.lblMot9);
            this.groupBox3.Controls.Add(this.lblMot8);
            this.groupBox3.Controls.Add(this.lblMot7);
            this.groupBox3.Controls.Add(this.btnWriteSpd);
            this.groupBox3.Controls.Add(this.btnScan);
            this.groupBox3.Controls.Add(this.boxMesSpeed);
            this.groupBox3.Controls.Add(this.comboBox1);
            this.groupBox3.Controls.Add(this.lblMot6);
            this.groupBox3.Controls.Add(this.lblMot5);
            this.groupBox3.Controls.Add(this.boxAdresseIp);
            this.groupBox3.Controls.Add(this.lblMot4);
            this.groupBox3.Controls.Add(this.lblMot3);
            this.groupBox3.Controls.Add(this.lblMot2);
            this.groupBox3.Location = new System.Drawing.Point(13, 328);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(606, 209);
            this.groupBox3.TabIndex = 65;
            this.groupBox3.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.White;
            this.groupBox4.Controls.Add(this.btnBump);
            this.groupBox4.Controls.Add(this.btnForceOn);
            this.groupBox4.Controls.Add(this.btnForceCalib);
            this.groupBox4.Controls.Add(this.btnReset);
            this.groupBox4.Controls.Add(this.progressBarSpdF);
            this.groupBox4.Controls.Add(this.materialFlatButton2);
            this.groupBox4.Controls.Add(this.materialFlatButton1);
            this.groupBox4.Location = new System.Drawing.Point(13, 539);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(606, 219);
            this.groupBox4.TabIndex = 66;
            this.groupBox4.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(638, 795);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.Main_SizeChanged);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatusCon;
        private System.Windows.Forms.Timer timer;
        private MaterialSkin.Controls.MaterialSingleLineTextField boxAdresseIp;
        private MaterialSkin.Controls.MaterialFlatButton btnWriteSpd;
        private MaterialSkin.Controls.MaterialSingleLineTextField boxMesSpeed;
        private System.Windows.Forms.Label lblMot1;
        private System.Windows.Forms.Label lblMot2;
        private System.Windows.Forms.Label lblMot3;
        private System.Windows.Forms.Label lblMot4;
        private System.Windows.Forms.Label lblMot5;
        private System.Windows.Forms.Label lblMot6;
        private System.Windows.Forms.Label lblMot7;
        private System.Windows.Forms.Label lblMot8;
        private System.Windows.Forms.Label lblMot9;
        private MaterialSkin.Controls.MaterialFlatButton btnScan;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton2;
        private MaterialSkin.Controls.MaterialFlatButton btnReset;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private MaterialSkin.Controls.MaterialFlatButton btnForceCalib;
        private System.Windows.Forms.ProgressBar progressBarSpdF;
        private MaterialSkin.Controls.MaterialFlatButton btnForceOn;
        private MaterialSkin.Controls.MaterialFlatButton btnBump;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ToolStripStatusLabel boxMotor;
        private LiveCharts.WinForms.SolidGauge circIntMotor;
        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private MaterialSkin.Controls.MaterialLabel lblSpeed;
        private LiveCharts.WinForms.SolidGauge circSpdMotor;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}

