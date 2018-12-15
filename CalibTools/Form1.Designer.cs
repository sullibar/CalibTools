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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatusCon = new System.Windows.Forms.ToolStripStatusLabel();
            this.boxMotor = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.spdChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
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
            this.solidGauge1 = new LiveCharts.WinForms.SolidGauge();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.circIntMotor = new LiveCharts.WinForms.SolidGauge();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.solidGauge2 = new LiveCharts.WinForms.SolidGauge();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.solidGauge3 = new LiveCharts.WinForms.SolidGauge();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spdChart)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
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
            this.statusStrip1.Size = new System.Drawing.Size(1130, 25);
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
            // spdChart
            // 
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.spdChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.spdChart.Legends.Add(legend1);
            this.spdChart.Location = new System.Drawing.Point(13, 81);
            this.spdChart.Margin = new System.Windows.Forms.Padding(4);
            this.spdChart.Name = "spdChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Color = System.Drawing.Color.Red;
            series1.Legend = "Legend1";
            series1.LegendText = "1";
            series1.Name = "Series1";
            this.spdChart.Series.Add(series1);
            this.spdChart.Size = new System.Drawing.Size(1082, 159);
            this.spdChart.TabIndex = 30;
            this.spdChart.Text = "chart1";
            // 
            // boxAdresseIp
            // 
            this.boxAdresseIp.BackColor = System.Drawing.Color.White;
            this.boxAdresseIp.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::CalibTools.Properties.Settings.Default, "Adresse_ip", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.boxAdresseIp.Depth = 0;
            this.boxAdresseIp.Hint = "";
            this.boxAdresseIp.Location = new System.Drawing.Point(958, 485);
            this.boxAdresseIp.MouseState = MaterialSkin.MouseState.HOVER;
            this.boxAdresseIp.Name = "boxAdresseIp";
            this.boxAdresseIp.PasswordChar = '\0';
            this.boxAdresseIp.SelectedText = "";
            this.boxAdresseIp.SelectionLength = 0;
            this.boxAdresseIp.SelectionStart = 0;
            this.boxAdresseIp.Size = new System.Drawing.Size(144, 28);
            this.boxAdresseIp.TabIndex = 33;
            this.boxAdresseIp.Text = global::CalibTools.Properties.Settings.Default.Adresse_ip;
            this.boxAdresseIp.UseSystemPasswordChar = false;
            // 
            // btnWriteSpd
            // 
            this.btnWriteSpd.AutoSize = true;
            this.btnWriteSpd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnWriteSpd.Depth = 0;
            this.btnWriteSpd.Location = new System.Drawing.Point(529, 506);
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
            this.boxMesSpeed.Location = new System.Drawing.Point(322, 516);
            this.boxMesSpeed.MouseState = MaterialSkin.MouseState.HOVER;
            this.boxMesSpeed.Name = "boxMesSpeed";
            this.boxMesSpeed.PasswordChar = '\0';
            this.boxMesSpeed.SelectedText = "";
            this.boxMesSpeed.SelectionLength = 0;
            this.boxMesSpeed.SelectionStart = 0;
            this.boxMesSpeed.Size = new System.Drawing.Size(186, 28);
            this.boxMesSpeed.TabIndex = 50;
            this.boxMesSpeed.UseSystemPasswordChar = false;
            this.boxMesSpeed.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.boxMesSpeed_KeyPress);
            // 
            // lblMot1
            // 
            this.lblMot1.AutoSize = true;
            this.lblMot1.BackColor = System.Drawing.Color.White;
            this.lblMot1.Location = new System.Drawing.Point(37, 391);
            this.lblMot1.Name = "lblMot1";
            this.lblMot1.Size = new System.Drawing.Size(71, 17);
            this.lblMot1.TabIndex = 41;
            this.lblMot1.Text = "Moteur ok";
            // 
            // lblMot2
            // 
            this.lblMot2.AutoSize = true;
            this.lblMot2.BackColor = System.Drawing.Color.White;
            this.lblMot2.Location = new System.Drawing.Point(37, 408);
            this.lblMot2.Name = "lblMot2";
            this.lblMot2.Size = new System.Drawing.Size(118, 17);
            this.lblMot2.TabIndex = 42;
            this.lblMot2.Text = "Moteur is running";
            // 
            // lblMot3
            // 
            this.lblMot3.AutoSize = true;
            this.lblMot3.BackColor = System.Drawing.Color.White;
            this.lblMot3.Location = new System.Drawing.Point(37, 425);
            this.lblMot3.Name = "lblMot3";
            this.lblMot3.Size = new System.Drawing.Size(180, 17);
            this.lblMot3.TabIndex = 43;
            this.lblMot3.Text = "Moteur isolator switch open";
            // 
            // lblMot4
            // 
            this.lblMot4.AutoSize = true;
            this.lblMot4.BackColor = System.Drawing.Color.White;
            this.lblMot4.Location = new System.Drawing.Point(37, 442);
            this.lblMot4.Name = "lblMot4";
            this.lblMot4.Size = new System.Drawing.Size(90, 17);
            this.lblMot4.TabIndex = 44;
            this.lblMot4.Text = "Vfd is on bus";
            // 
            // lblMot5
            // 
            this.lblMot5.AutoSize = true;
            this.lblMot5.BackColor = System.Drawing.Color.White;
            this.lblMot5.Location = new System.Drawing.Point(37, 459);
            this.lblMot5.Name = "lblMot5";
            this.lblMot5.Size = new System.Drawing.Size(126, 17);
            this.lblMot5.TabIndex = 45;
            this.lblMot5.Text = "Power supply is on";
            // 
            // lblMot6
            // 
            this.lblMot6.AutoSize = true;
            this.lblMot6.BackColor = System.Drawing.Color.White;
            this.lblMot6.Location = new System.Drawing.Point(37, 476);
            this.lblMot6.Name = "lblMot6";
            this.lblMot6.Size = new System.Drawing.Size(117, 17);
            this.lblMot6.TabIndex = 46;
            this.lblMot6.Text = "Low limit reached";
            // 
            // lblMot7
            // 
            this.lblMot7.AutoSize = true;
            this.lblMot7.BackColor = System.Drawing.Color.White;
            this.lblMot7.Location = new System.Drawing.Point(37, 493);
            this.lblMot7.Name = "lblMot7";
            this.lblMot7.Size = new System.Drawing.Size(121, 17);
            this.lblMot7.TabIndex = 47;
            this.lblMot7.Text = "High limit reached";
            // 
            // lblMot8
            // 
            this.lblMot8.AutoSize = true;
            this.lblMot8.BackColor = System.Drawing.Color.White;
            this.lblMot8.Location = new System.Drawing.Point(37, 527);
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
            this.lblMot9.Location = new System.Drawing.Point(37, 510);
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
            this.btnScan.Location = new System.Drawing.Point(959, 661);
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
            this.materialFlatButton2.Location = new System.Drawing.Point(834, 693);
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
            this.btnReset.Location = new System.Drawing.Point(261, 709);
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
            this.materialFlatButton1.Location = new System.Drawing.Point(542, 693);
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
            this.btnForceCalib.Location = new System.Drawing.Point(261, 661);
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
            this.progressBarSpdF.Location = new System.Drawing.Point(542, 661);
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
            this.btnForceOn.Location = new System.Drawing.Point(40, 709);
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
            this.btnBump.Location = new System.Drawing.Point(40, 661);
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
            this.comboBox1.Location = new System.Drawing.Point(397, 599);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(215, 24);
            this.comboBox1.TabIndex = 61;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // solidGauge1
            // 
            this.solidGauge1.BackColor = System.Drawing.Color.White;
            this.solidGauge1.Location = new System.Drawing.Point(339, 376);
            this.solidGauge1.Name = "solidGauge1";
            this.solidGauge1.Size = new System.Drawing.Size(200, 100);
            this.solidGauge1.TabIndex = 63;
            this.solidGauge1.Text = "solidGauge1";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.Color.White;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(111, 32);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(82, 24);
            this.materialLabel1.TabIndex = 66;
            this.materialLabel1.Text = "Intensité";
            // 
            // circIntMotor
            // 
            this.circIntMotor.BackColor = System.Drawing.Color.White;
            this.circIntMotor.Location = new System.Drawing.Point(59, 74);
            this.circIntMotor.Name = "circIntMotor";
            this.circIntMotor.Size = new System.Drawing.Size(193, 133);
            this.circIntMotor.TabIndex = 65;
            this.circIntMotor.Text = "solidGauge1";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.materialLabel1);
            this.groupBox1.Controls.Add(this.circIntMotor);
            this.groupBox1.Location = new System.Drawing.Point(40, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(325, 248);
            this.groupBox1.TabIndex = 66;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.materialLabel2);
            this.groupBox2.Controls.Add(this.solidGauge2);
            this.groupBox2.Location = new System.Drawing.Point(397, 81);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(325, 248);
            this.groupBox2.TabIndex = 67;
            this.groupBox2.TabStop = false;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.BackColor = System.Drawing.Color.White;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(111, 32);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(82, 24);
            this.materialLabel2.TabIndex = 66;
            this.materialLabel2.Text = "Intensité";
            // 
            // solidGauge2
            // 
            this.solidGauge2.BackColor = System.Drawing.Color.White;
            this.solidGauge2.Location = new System.Drawing.Point(59, 74);
            this.solidGauge2.Name = "solidGauge2";
            this.solidGauge2.Size = new System.Drawing.Size(193, 133);
            this.solidGauge2.TabIndex = 65;
            this.solidGauge2.Text = "solidGauge1";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.materialLabel3);
            this.groupBox3.Controls.Add(this.solidGauge3);
            this.groupBox3.Location = new System.Drawing.Point(751, 81);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(325, 248);
            this.groupBox3.TabIndex = 68;
            this.groupBox3.TabStop = false;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.BackColor = System.Drawing.Color.White;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(111, 32);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(82, 24);
            this.materialLabel3.TabIndex = 66;
            this.materialLabel3.Text = "Intensité";
            // 
            // solidGauge3
            // 
            this.solidGauge3.BackColor = System.Drawing.Color.White;
            this.solidGauge3.Location = new System.Drawing.Point(59, 74);
            this.solidGauge3.Name = "solidGauge3";
            this.solidGauge3.Size = new System.Drawing.Size(193, 133);
            this.solidGauge3.TabIndex = 65;
            this.solidGauge3.Text = "solidGauge1";
            // 
            // Main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(1130, 795);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.solidGauge1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnScan);
            this.Controls.Add(this.materialFlatButton2);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.materialFlatButton1);
            this.Controls.Add(this.btnForceCalib);
            this.Controls.Add(this.progressBarSpdF);
            this.Controls.Add(this.btnForceOn);
            this.Controls.Add(this.btnBump);
            this.Controls.Add(this.btnWriteSpd);
            this.Controls.Add(this.boxMesSpeed);
            this.Controls.Add(this.lblMot1);
            this.Controls.Add(this.lblMot2);
            this.Controls.Add(this.lblMot3);
            this.Controls.Add(this.lblMot4);
            this.Controls.Add(this.lblMot5);
            this.Controls.Add(this.lblMot6);
            this.Controls.Add(this.lblMot7);
            this.Controls.Add(this.lblMot8);
            this.Controls.Add(this.lblMot9);
            this.Controls.Add(this.boxAdresseIp);
            this.Controls.Add(this.spdChart);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.Main_SizeChanged);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spdChart)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatusCon;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.DataVisualization.Charting.Chart spdChart;
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
        private LiveCharts.WinForms.SolidGauge solidGauge1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private LiveCharts.WinForms.SolidGauge circIntMotor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private LiveCharts.WinForms.SolidGauge solidGauge2;
        private System.Windows.Forms.GroupBox groupBox3;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private LiveCharts.WinForms.SolidGauge solidGauge3;
    }
}

