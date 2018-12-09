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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.label2 = new System.Windows.Forms.Label();
            this.lblMot1 = new System.Windows.Forms.Label();
            this.lblMot2 = new System.Windows.Forms.Label();
            this.lblMot3 = new System.Windows.Forms.Label();
            this.lblMot4 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatusCon = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.lblMot5 = new System.Windows.Forms.Label();
            this.lblMot6 = new System.Windows.Forms.Label();
            this.lblMot7 = new System.Windows.Forms.Label();
            this.lblMot8 = new System.Windows.Forms.Label();
            this.lblMot9 = new System.Windows.Forms.Label();
            this.boxMotor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.boxCalibSpeed = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.cpuChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.boxAdresseIp = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblSpeed = new MaterialSkin.Controls.MaterialLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.boxMesSpeed = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnScan = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton2 = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnReset = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton3 = new MaterialSkin.Controls.MaterialFlatButton();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnForceOn = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnBump = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnWriteSpd = new MaterialSkin.Controls.MaterialFlatButton();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cpuChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(935, 636);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Moteur";
            // 
            // lblMot1
            // 
            this.lblMot1.AutoSize = true;
            this.lblMot1.BackColor = System.Drawing.Color.White;
            this.lblMot1.Location = new System.Drawing.Point(16, 24);
            this.lblMot1.Name = "lblMot1";
            this.lblMot1.Size = new System.Drawing.Size(71, 17);
            this.lblMot1.TabIndex = 7;
            this.lblMot1.Text = "Moteur ok";
            // 
            // lblMot2
            // 
            this.lblMot2.AutoSize = true;
            this.lblMot2.BackColor = System.Drawing.Color.White;
            this.lblMot2.Location = new System.Drawing.Point(16, 41);
            this.lblMot2.Name = "lblMot2";
            this.lblMot2.Size = new System.Drawing.Size(118, 17);
            this.lblMot2.TabIndex = 8;
            this.lblMot2.Text = "Moteur is running";
            // 
            // lblMot3
            // 
            this.lblMot3.AutoSize = true;
            this.lblMot3.BackColor = System.Drawing.Color.White;
            this.lblMot3.Location = new System.Drawing.Point(16, 58);
            this.lblMot3.Name = "lblMot3";
            this.lblMot3.Size = new System.Drawing.Size(180, 17);
            this.lblMot3.TabIndex = 9;
            this.lblMot3.Text = "Moteur isolator switch open";
            // 
            // lblMot4
            // 
            this.lblMot4.AutoSize = true;
            this.lblMot4.BackColor = System.Drawing.Color.White;
            this.lblMot4.Location = new System.Drawing.Point(16, 75);
            this.lblMot4.Name = "lblMot4";
            this.lblMot4.Size = new System.Drawing.Size(90, 17);
            this.lblMot4.TabIndex = 10;
            this.lblMot4.Text = "Vfd is on bus";
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.White;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatusCon});
            this.statusStrip1.Location = new System.Drawing.Point(0, 976);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1350, 25);
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatusCon
            // 
            this.lblStatusCon.Name = "lblStatusCon";
            this.lblStatusCon.Size = new System.Drawing.Size(88, 20);
            this.lblStatusCon.Text = "Déconnecté";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 333;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // lblMot5
            // 
            this.lblMot5.AutoSize = true;
            this.lblMot5.BackColor = System.Drawing.Color.White;
            this.lblMot5.Location = new System.Drawing.Point(16, 92);
            this.lblMot5.Name = "lblMot5";
            this.lblMot5.Size = new System.Drawing.Size(126, 17);
            this.lblMot5.TabIndex = 14;
            this.lblMot5.Text = "Power supply is on";
            // 
            // lblMot6
            // 
            this.lblMot6.AutoSize = true;
            this.lblMot6.BackColor = System.Drawing.Color.White;
            this.lblMot6.Location = new System.Drawing.Point(16, 109);
            this.lblMot6.Name = "lblMot6";
            this.lblMot6.Size = new System.Drawing.Size(117, 17);
            this.lblMot6.TabIndex = 15;
            this.lblMot6.Text = "Low limit reached";
            // 
            // lblMot7
            // 
            this.lblMot7.AutoSize = true;
            this.lblMot7.BackColor = System.Drawing.Color.White;
            this.lblMot7.Location = new System.Drawing.Point(16, 126);
            this.lblMot7.Name = "lblMot7";
            this.lblMot7.Size = new System.Drawing.Size(121, 17);
            this.lblMot7.TabIndex = 16;
            this.lblMot7.Text = "High limit reached";
            // 
            // lblMot8
            // 
            this.lblMot8.AutoSize = true;
            this.lblMot8.BackColor = System.Drawing.Color.White;
            this.lblMot8.Location = new System.Drawing.Point(16, 160);
            this.lblMot8.Name = "lblMot8";
            this.lblMot8.Size = new System.Drawing.Size(196, 17);
            this.lblMot8.TabIndex = 17;
            this.lblMot8.Text = "Motor isolator switch calculate";
            this.lblMot8.Visible = false;
            // 
            // lblMot9
            // 
            this.lblMot9.AutoSize = true;
            this.lblMot9.BackColor = System.Drawing.Color.White;
            this.lblMot9.Location = new System.Drawing.Point(16, 143);
            this.lblMot9.Name = "lblMot9";
            this.lblMot9.Size = new System.Drawing.Size(171, 17);
            this.lblMot9.TabIndex = 18;
            this.lblMot9.Text = "Emergency stop activated";
            // 
            // boxMotor
            // 
            this.boxMotor.BackColor = System.Drawing.Color.White;
            this.boxMotor.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::CalibTools.Properties.Settings.Default, "Num_moteur", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.boxMotor.Location = new System.Drawing.Point(938, 656);
            this.boxMotor.MaxLength = 3;
            this.boxMotor.Name = "boxMotor";
            this.boxMotor.Size = new System.Drawing.Size(100, 22);
            this.boxMotor.TabIndex = 3;
            this.boxMotor.Text = global::CalibTools.Properties.Settings.Default.Num_moteur;
            this.boxMotor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.boxMotor_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(1093, 636);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 17);
            this.label4.TabIndex = 21;
            this.label4.Text = "Calibration setpoint";
            // 
            // boxCalibSpeed
            // 
            this.boxCalibSpeed.BackColor = System.Drawing.Color.White;
            this.boxCalibSpeed.Location = new System.Drawing.Point(1096, 656);
            this.boxCalibSpeed.MaxLength = 4;
            this.boxCalibSpeed.Name = "boxCalibSpeed";
            this.boxCalibSpeed.Size = new System.Drawing.Size(100, 22);
            this.boxCalibSpeed.TabIndex = 22;
            this.boxCalibSpeed.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.boxCalibSpeed_KeyPress);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(1203, 656);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(32, 23);
            this.button4.TabIndex = 23;
            this.button4.Text = "=>";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.White;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(12, 75);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(239, 900);
            this.listBox1.TabIndex = 27;
            this.listBox1.Click += new System.EventHandler(this.listBox1_Click);
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_Click);
            // 
            // cpuChart
            // 
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.cpuChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.cpuChart.Legends.Add(legend1);
            this.cpuChart.Location = new System.Drawing.Point(255, 75);
            this.cpuChart.Margin = new System.Windows.Forms.Padding(4);
            this.cpuChart.Name = "cpuChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Color = System.Drawing.Color.Red;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.cpuChart.Series.Add(series1);
            this.cpuChart.Size = new System.Drawing.Size(1082, 261);
            this.cpuChart.TabIndex = 30;
            this.cpuChart.Text = "chart1";
            // 
            // chart2
            // 
            chartArea2.BackColor = System.Drawing.Color.Transparent;
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(255, 343);
            this.chart2.Margin = new System.Windows.Forms.Padding(4);
            this.chart2.Name = "chart2";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Color = System.Drawing.Color.Red;
            series2.IsVisibleInLegend = false;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart2.Series.Add(series2);
            this.chart2.Size = new System.Drawing.Size(1079, 261);
            this.chart2.TabIndex = 32;
            this.chart2.Text = "chart1";
            // 
            // boxAdresseIp
            // 
            this.boxAdresseIp.BackColor = System.Drawing.Color.White;
            this.boxAdresseIp.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::CalibTools.Properties.Settings.Default, "Adresse_ip", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.boxAdresseIp.Depth = 0;
            this.boxAdresseIp.Hint = "";
            this.boxAdresseIp.Location = new System.Drawing.Point(1091, 758);
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
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.BackColor = System.Drawing.Color.White;
            this.lblSpeed.Depth = 0;
            this.lblSpeed.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblSpeed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblSpeed.Location = new System.Drawing.Point(297, 36);
            this.lblSpeed.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(78, 24);
            this.lblSpeed.TabIndex = 34;
            this.lblSpeed.Text = "Vitesse:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.btnWriteSpd);
            this.groupBox1.Controls.Add(this.boxMesSpeed);
            this.groupBox1.Controls.Add(this.materialLabel2);
            this.groupBox1.Controls.Add(this.lblMot1);
            this.groupBox1.Controls.Add(this.lblMot2);
            this.groupBox1.Controls.Add(this.lblSpeed);
            this.groupBox1.Controls.Add(this.lblMot3);
            this.groupBox1.Controls.Add(this.lblMot4);
            this.groupBox1.Controls.Add(this.lblMot5);
            this.groupBox1.Controls.Add(this.lblMot6);
            this.groupBox1.Controls.Add(this.lblMot7);
            this.groupBox1.Controls.Add(this.lblMot8);
            this.groupBox1.Controls.Add(this.lblMot9);
            this.groupBox1.Location = new System.Drawing.Point(257, 612);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(644, 195);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Etat du moteur";
            // 
            // boxMesSpeed
            // 
            this.boxMesSpeed.Depth = 0;
            this.boxMesSpeed.Hint = "Vitesse mesurée";
            this.boxMesSpeed.Location = new System.Drawing.Point(301, 119);
            this.boxMesSpeed.MouseState = MaterialSkin.MouseState.HOVER;
            this.boxMesSpeed.Name = "boxMesSpeed";
            this.boxMesSpeed.PasswordChar = '\0';
            this.boxMesSpeed.SelectedText = "";
            this.boxMesSpeed.SelectionLength = 0;
            this.boxMesSpeed.SelectionStart = 0;
            this.boxMesSpeed.Size = new System.Drawing.Size(186, 28);
            this.boxMesSpeed.TabIndex = 36;
            this.boxMesSpeed.UseSystemPasswordChar = false;
            this.boxMesSpeed.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.boxMesSpeed_KeyPress);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.BackColor = System.Drawing.Color.White;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(297, 60);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(87, 24);
            this.materialLabel2.TabIndex = 35;
            this.materialLabel2.Text = "Intensité:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox2.Controls.Add(this.btnScan);
            this.groupBox2.Controls.Add(this.materialFlatButton2);
            this.groupBox2.Controls.Add(this.btnReset);
            this.groupBox2.Controls.Add(this.materialFlatButton1);
            this.groupBox2.Controls.Add(this.materialFlatButton3);
            this.groupBox2.Controls.Add(this.progressBar1);
            this.groupBox2.Controls.Add(this.btnForceOn);
            this.groupBox2.Controls.Add(this.btnBump);
            this.groupBox2.Location = new System.Drawing.Point(257, 813);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1079, 160);
            this.groupBox2.TabIndex = 37;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Commandes";
            // 
            // btnScan
            // 
            this.btnScan.AutoSize = true;
            this.btnScan.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnScan.Depth = 0;
            this.btnScan.Location = new System.Drawing.Point(938, 33);
            this.btnScan.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnScan.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnScan.Name = "btnScan";
            this.btnScan.Primary = false;
            this.btnScan.Size = new System.Drawing.Size(128, 36);
            this.btnScan.TabIndex = 41;
            this.btnScan.Text = "Scan DB diag";
            this.btnScan.UseVisualStyleBackColor = true;
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // materialFlatButton2
            // 
            this.materialFlatButton2.AutoSize = true;
            this.materialFlatButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton2.Depth = 0;
            this.materialFlatButton2.Location = new System.Drawing.Point(813, 65);
            this.materialFlatButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton2.Name = "materialFlatButton2";
            this.materialFlatButton2.Primary = false;
            this.materialFlatButton2.Size = new System.Drawing.Size(23, 36);
            this.materialFlatButton2.TabIndex = 40;
            this.materialFlatButton2.Text = "+";
            this.materialFlatButton2.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.AutoSize = true;
            this.btnReset.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnReset.Depth = 0;
            this.btnReset.Location = new System.Drawing.Point(240, 81);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnReset.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnReset.Name = "btnReset";
            this.btnReset.Primary = false;
            this.btnReset.Size = new System.Drawing.Size(64, 36);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Location = new System.Drawing.Point(521, 65);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(19, 36);
            this.materialFlatButton1.TabIndex = 39;
            this.materialFlatButton1.Text = "-";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            // 
            // materialFlatButton3
            // 
            this.materialFlatButton3.AutoSize = true;
            this.materialFlatButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton3.Depth = 0;
            this.materialFlatButton3.Location = new System.Drawing.Point(240, 33);
            this.materialFlatButton3.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton3.Name = "materialFlatButton3";
            this.materialFlatButton3.Primary = false;
            this.materialFlatButton3.Size = new System.Drawing.Size(179, 36);
            this.materialFlatButton3.TabIndex = 2;
            this.materialFlatButton3.Text = "Force calibration";
            this.materialFlatButton3.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(521, 33);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(311, 23);
            this.progressBar1.TabIndex = 38;
            this.progressBar1.Value = 50;
            // 
            // btnForceOn
            // 
            this.btnForceOn.AutoSize = true;
            this.btnForceOn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnForceOn.Depth = 0;
            this.btnForceOn.Location = new System.Drawing.Point(19, 81);
            this.btnForceOn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnForceOn.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnForceOn.Name = "btnForceOn";
            this.btnForceOn.Primary = false;
            this.btnForceOn.Size = new System.Drawing.Size(94, 36);
            this.btnForceOn.TabIndex = 1;
            this.btnForceOn.Text = "Force on";
            this.btnForceOn.UseVisualStyleBackColor = true;
            this.btnForceOn.Click += new System.EventHandler(this.btnForceOn_Click);
            // 
            // btnBump
            // 
            this.btnBump.AutoSize = true;
            this.btnBump.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBump.Depth = 0;
            this.btnBump.Location = new System.Drawing.Point(19, 33);
            this.btnBump.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnBump.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBump.Name = "btnBump";
            this.btnBump.Primary = false;
            this.btnBump.Size = new System.Drawing.Size(61, 36);
            this.btnBump.TabIndex = 0;
            this.btnBump.Text = "Bump";
            this.btnBump.UseVisualStyleBackColor = true;
            this.btnBump.Click += new System.EventHandler(this.btnBump_Click);
            // 
            // btnWriteSpd
            // 
            this.btnWriteSpd.AutoSize = true;
            this.btnWriteSpd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnWriteSpd.Depth = 0;
            this.btnWriteSpd.Location = new System.Drawing.Point(508, 109);
            this.btnWriteSpd.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnWriteSpd.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnWriteSpd.Name = "btnWriteSpd";
            this.btnWriteSpd.Primary = false;
            this.btnWriteSpd.Size = new System.Drawing.Size(32, 36);
            this.btnWriteSpd.TabIndex = 37;
            this.btnWriteSpd.Text = "=>";
            this.btnWriteSpd.UseVisualStyleBackColor = true;
            this.btnWriteSpd.Click += new System.EventHandler(this.btnWriteSpd_Click);
            // 
            // Main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1350, 1001);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.boxAdresseIp);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.cpuChart);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.boxCalibSpeed);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.boxMotor);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cpuChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox boxMotor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMot1;
        private System.Windows.Forms.Label lblMot2;
        private System.Windows.Forms.Label lblMot3;
        private System.Windows.Forms.Label lblMot4;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatusCon;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label lblMot5;
        private System.Windows.Forms.Label lblMot6;
        private System.Windows.Forms.Label lblMot7;
        private System.Windows.Forms.Label lblMot8;
        private System.Windows.Forms.Label lblMot9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox boxCalibSpeed;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart cpuChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private MaterialSkin.Controls.MaterialSingleLineTextField boxAdresseIp;
        private MaterialSkin.Controls.MaterialLabel lblSpeed;
        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private MaterialSkin.Controls.MaterialFlatButton btnBump;
        private MaterialSkin.Controls.MaterialFlatButton btnReset;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton3;
        private MaterialSkin.Controls.MaterialFlatButton btnForceOn;
        private System.Windows.Forms.ProgressBar progressBar1;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton2;
        private MaterialSkin.Controls.MaterialFlatButton btnScan;
        private MaterialSkin.Controls.MaterialSingleLineTextField boxMesSpeed;
        private MaterialSkin.Controls.MaterialFlatButton btnWriteSpd;
    }
}

