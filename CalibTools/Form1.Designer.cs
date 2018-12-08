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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.lblMot1 = new System.Windows.Forms.Label();
            this.lblMot2 = new System.Windows.Forms.Label();
            this.lblMot3 = new System.Windows.Forms.Label();
            this.lblMot4 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatusCon = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.button5 = new System.Windows.Forms.Button();
            this.lblMot5 = new System.Windows.Forms.Label();
            this.lblMot6 = new System.Windows.Forms.Label();
            this.lblMot7 = new System.Windows.Forms.Label();
            this.lblMot8 = new System.Windows.Forms.Label();
            this.lblMot9 = new System.Windows.Forms.Label();
            this.boxMotor = new System.Windows.Forms.TextBox();
            this.boxAdresseIp = new System.Windows.Forms.TextBox();
            this.boxMesSpeed = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.boxCalibSpeed = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cpuChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button8 = new System.Windows.Forms.Button();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cpuChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(869, 567);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adresse ip";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(869, 612);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Moteur";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(696, 595);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Bump";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(696, 624);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(154, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Force On";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(696, 653);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(154, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Force calibration";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // lblMot1
            // 
            this.lblMot1.AutoSize = true;
            this.lblMot1.Location = new System.Drawing.Point(447, 567);
            this.lblMot1.Name = "lblMot1";
            this.lblMot1.Size = new System.Drawing.Size(71, 17);
            this.lblMot1.TabIndex = 7;
            this.lblMot1.Text = "Moteur ok";
            // 
            // lblMot2
            // 
            this.lblMot2.AutoSize = true;
            this.lblMot2.Location = new System.Drawing.Point(447, 584);
            this.lblMot2.Name = "lblMot2";
            this.lblMot2.Size = new System.Drawing.Size(118, 17);
            this.lblMot2.TabIndex = 8;
            this.lblMot2.Text = "Moteur is running";
            // 
            // lblMot3
            // 
            this.lblMot3.AutoSize = true;
            this.lblMot3.Location = new System.Drawing.Point(447, 601);
            this.lblMot3.Name = "lblMot3";
            this.lblMot3.Size = new System.Drawing.Size(180, 17);
            this.lblMot3.TabIndex = 9;
            this.lblMot3.Text = "Moteur isolator switch open";
            // 
            // lblMot4
            // 
            this.lblMot4.AutoSize = true;
            this.lblMot4.Location = new System.Drawing.Point(447, 618);
            this.lblMot4.Name = "lblMot4";
            this.lblMot4.Size = new System.Drawing.Size(90, 17);
            this.lblMot4.TabIndex = 10;
            this.lblMot4.Text = "Vfd is on bus";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatusCon});
            this.statusStrip1.Location = new System.Drawing.Point(0, 731);
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
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(696, 686);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(154, 23);
            this.button5.TabIndex = 13;
            this.button5.Text = "Reset";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // lblMot5
            // 
            this.lblMot5.AutoSize = true;
            this.lblMot5.Location = new System.Drawing.Point(447, 635);
            this.lblMot5.Name = "lblMot5";
            this.lblMot5.Size = new System.Drawing.Size(126, 17);
            this.lblMot5.TabIndex = 14;
            this.lblMot5.Text = "Power supply is on";
            // 
            // lblMot6
            // 
            this.lblMot6.AutoSize = true;
            this.lblMot6.Location = new System.Drawing.Point(447, 652);
            this.lblMot6.Name = "lblMot6";
            this.lblMot6.Size = new System.Drawing.Size(117, 17);
            this.lblMot6.TabIndex = 15;
            this.lblMot6.Text = "Low limit reached";
            // 
            // lblMot7
            // 
            this.lblMot7.AutoSize = true;
            this.lblMot7.Location = new System.Drawing.Point(447, 669);
            this.lblMot7.Name = "lblMot7";
            this.lblMot7.Size = new System.Drawing.Size(121, 17);
            this.lblMot7.TabIndex = 16;
            this.lblMot7.Text = "High limit reached";
            // 
            // lblMot8
            // 
            this.lblMot8.AutoSize = true;
            this.lblMot8.Location = new System.Drawing.Point(447, 686);
            this.lblMot8.Name = "lblMot8";
            this.lblMot8.Size = new System.Drawing.Size(196, 17);
            this.lblMot8.TabIndex = 17;
            this.lblMot8.Text = "Motor isolator switch calculate";
            this.lblMot8.Visible = false;
            // 
            // lblMot9
            // 
            this.lblMot9.AutoSize = true;
            this.lblMot9.Location = new System.Drawing.Point(447, 703);
            this.lblMot9.Name = "lblMot9";
            this.lblMot9.Size = new System.Drawing.Size(171, 17);
            this.lblMot9.TabIndex = 18;
            this.lblMot9.Text = "Emergency stop activated";
            // 
            // boxMotor
            // 
            this.boxMotor.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::CalibTools.Properties.Settings.Default, "Num_moteur", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.boxMotor.Location = new System.Drawing.Point(872, 632);
            this.boxMotor.MaxLength = 3;
            this.boxMotor.Name = "boxMotor";
            this.boxMotor.Size = new System.Drawing.Size(100, 22);
            this.boxMotor.TabIndex = 3;
            this.boxMotor.Text = global::CalibTools.Properties.Settings.Default.Num_moteur;
            this.boxMotor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.boxMotor_KeyPress);
            // 
            // boxAdresseIp
            // 
            this.boxAdresseIp.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::CalibTools.Properties.Settings.Default, "Adresse_ip", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.boxAdresseIp.Location = new System.Drawing.Point(872, 587);
            this.boxAdresseIp.MaxLength = 15;
            this.boxAdresseIp.Name = "boxAdresseIp";
            this.boxAdresseIp.Size = new System.Drawing.Size(100, 22);
            this.boxAdresseIp.TabIndex = 1;
            this.boxAdresseIp.Text = global::CalibTools.Properties.Settings.Default.Adresse_ip;
            this.boxAdresseIp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.boxAdresseIp_KeyPress);
            // 
            // boxMesSpeed
            // 
            this.boxMesSpeed.Location = new System.Drawing.Point(989, 635);
            this.boxMesSpeed.MaxLength = 5;
            this.boxMesSpeed.Name = "boxMesSpeed";
            this.boxMesSpeed.Size = new System.Drawing.Size(100, 22);
            this.boxMesSpeed.TabIndex = 19;
            this.boxMesSpeed.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.boxMesSpeed_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(986, 615);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "Vitesse mesurée";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(986, 570);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 17);
            this.label4.TabIndex = 21;
            this.label4.Text = "Calibration setpoint";
            // 
            // boxCalibSpeed
            // 
            this.boxCalibSpeed.Location = new System.Drawing.Point(989, 590);
            this.boxCalibSpeed.MaxLength = 4;
            this.boxCalibSpeed.Name = "boxCalibSpeed";
            this.boxCalibSpeed.Size = new System.Drawing.Size(100, 22);
            this.boxCalibSpeed.TabIndex = 22;
            this.boxCalibSpeed.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.boxCalibSpeed_KeyPress);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1096, 590);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(32, 23);
            this.button4.TabIndex = 23;
            this.button4.Text = "=>";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(1096, 635);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(32, 23);
            this.button6.TabIndex = 24;
            this.button6.Text = "=>";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(696, 567);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(154, 23);
            this.button7.TabIndex = 26;
            this.button7.Text = "Scan db diag";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.Control;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(12, 20);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(239, 692);
            this.listBox1.TabIndex = 27;
            this.listBox1.Click += new System.EventHandler(this.listBox1_Click);
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(875, 659);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 29;
            this.label5.Text = "label5";
            // 
            // cpuChart
            // 
            this.cpuChart.BackColor = System.Drawing.SystemColors.Control;
            chartArea3.BackColor = System.Drawing.Color.Transparent;
            chartArea3.Name = "ChartArea1";
            this.cpuChart.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.cpuChart.Legends.Add(legend3);
            this.cpuChart.Location = new System.Drawing.Point(258, 20);
            this.cpuChart.Margin = new System.Windows.Forms.Padding(4);
            this.cpuChart.Name = "cpuChart";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Color = System.Drawing.Color.Red;
            series3.IsVisibleInLegend = false;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.cpuChart.Series.Add(series3);
            this.cpuChart.Size = new System.Drawing.Size(1079, 273);
            this.cpuChart.TabIndex = 30;
            this.cpuChart.Text = "chart1";
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(1165, 672);
            this.button8.Margin = new System.Windows.Forms.Padding(4);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(172, 55);
            this.button8.TabIndex = 31;
            this.button8.Text = "Start";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // chart2
            // 
            this.chart2.BackColor = System.Drawing.SystemColors.Control;
            chartArea4.BackColor = System.Drawing.Color.Transparent;
            chartArea4.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart2.Legends.Add(legend4);
            this.chart2.Location = new System.Drawing.Point(258, 277);
            this.chart2.Margin = new System.Windows.Forms.Padding(4);
            this.chart2.Name = "chart2";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Color = System.Drawing.Color.Red;
            series4.IsVisibleInLegend = false;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chart2.Series.Add(series4);
            this.chart2.Size = new System.Drawing.Size(1079, 273);
            this.chart2.TabIndex = 32;
            this.chart2.Text = "chart1";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(872, 696);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(256, 23);
            this.progressBar1.TabIndex = 33;
            this.progressBar1.Value = 30;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1350, 756);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.cpuChart);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.boxCalibSpeed);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.boxMesSpeed);
            this.Controls.Add(this.lblMot9);
            this.Controls.Add(this.lblMot8);
            this.Controls.Add(this.lblMot7);
            this.Controls.Add(this.lblMot6);
            this.Controls.Add(this.lblMot5);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.lblMot4);
            this.Controls.Add(this.lblMot3);
            this.Controls.Add(this.lblMot2);
            this.Controls.Add(this.lblMot1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.boxMotor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.boxAdresseIp);
            this.Controls.Add(this.label1);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cpuChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox boxAdresseIp;
        private System.Windows.Forms.TextBox boxMotor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lblMot1;
        private System.Windows.Forms.Label lblMot2;
        private System.Windows.Forms.Label lblMot3;
        private System.Windows.Forms.Label lblMot4;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatusCon;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label lblMot5;
        private System.Windows.Forms.Label lblMot6;
        private System.Windows.Forms.Label lblMot7;
        private System.Windows.Forms.Label lblMot8;
        private System.Windows.Forms.Label lblMot9;
        private System.Windows.Forms.TextBox boxMesSpeed;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox boxCalibSpeed;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataVisualization.Charting.Chart cpuChart;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

