namespace CalibTools
{
    using MaterialSkin;
    using Sharp7;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Drawing;
    using System.IO;
    using System.Threading;
    using System.Windows.Forms;

    public partial class Main : MaterialSkin.Controls.MaterialForm
    {
        public static List<bool> _arStateMotor = new List<bool>();
        public static double _dintMotor;
        public static double _dspdFMotor;
        public static double _dspdMotor;
        public static bool _statusConnection;
        public static BackgroundWorker bwChart = new BackgroundWorker();
        public static BackgroundWorker bwScanner = new BackgroundWorker();
        public static BackgroundWorker bwWork = new BackgroundWorker();
        public static S7Client Client = new S7Client();
        public static List<string> listDbsDiag = new List<string>();
        private static bool bCheckAllDbsDiag;

        private static bool bWriteBump;
        private static bool bWriteCalibSpeed;
        private static bool bWriteForceCalib;
        private static bool bWriteForceOn;
        private static bool bWriteMesSpeed;
        private static bool bWriteReset;
        private static string intMotor;
        private static int numDB;
        private static string spdMotor;

        private double[] intensityArray = new double[120];

        // Charts
        private double[] spdArray = new double[120];
        public Main()
        {
            InitializeComponent();

            // Create a material theme manager and add the form to manage (this)
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            // Configure color schema
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Green400, Primary.Green500,
                Primary.Green500, Accent.LightGreen200,
                TextShade.WHITE
            );

            // Initialisation de la tâche de fond (travail)
            bwWork.WorkerReportsProgress = true;
            bwWork.WorkerSupportsCancellation = true;
            bwWork.DoWork += new DoWorkEventHandler(bwWork_DoWork);
            bwWork.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bwWork_RunWorkerCompleted);

            // Initialisation de la tâche de fond (chart)
            bwChart.WorkerReportsProgress = true;
            bwChart.WorkerSupportsCancellation = true;
            bwChart.DoWork += new DoWorkEventHandler(bwChart_DoWork);
            bwChart.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bwChart_RunWorkerCompleted);

            // Initialisation de la tâche de fond (scan Dbs diag)
            bwScanner.WorkerReportsProgress = true;
            bwScanner.WorkerSupportsCancellation = true;
            bwScanner.DoWork += new DoWorkEventHandler(bwScanner_DoWork);
            bwScanner.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bwScanner_RunWorkerCompleted);

            // Initialise gauge
            circIntMotor.Uses360Mode = true;
            circIntMotor.From = 0;
            circIntMotor.To = 100;
            circIntMotor.Value = 0;
        }

        private void boxCalibSpeed_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void boxMesSpeed_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void boxMotor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnBump_Click(object sender, EventArgs e)
        {
            bWriteBump = true;
            numDB = Int32.Parse("1" + boxMotor.Text);
        }

        private void btnForceCalib_Click(object sender, EventArgs e)
        {
            bWriteForceCalib = true;
        }

        private void btnForceOn_Click(object sender, EventArgs e)
        {
            bWriteForceOn = true;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            bWriteReset = true;
        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            bCheckAllDbsDiag = true;
        }

        private void btnWriteSpd_Click(object sender, EventArgs e)
        {
            bWriteMesSpeed = true;
        }

        private void bwChart_DoWork(object sender, DoWorkEventArgs e)
        {
            
            // Charts
            spdArray[spdArray.Length - 1] = Math.Round(_dspdMotor, 0);
            Array.Copy(spdArray, 1, spdArray, 0, spdArray.Length - 1);

            //intensityArray[intensityArray.Length - 1] = Math.Round(_dintMotor, 0);
            //Array.Copy(intensityArray, 1, intensityArray, 0, intensityArray.Length - 1);

            Thread.Sleep(1000);
        }

        private void bwChart_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
           
            UpdateCpuChart();
            //spdChart.Series[0].LegendText = spdMotor;
            bwChart.RunWorkerAsync();
        }

        private void bwScanner_DoWork(object sender, DoWorkEventArgs e)
        {
            if (_statusConnection)
            {
                // Check all Dbs diag
                if (bCheckAllDbsDiag)
                {
                    listDbsDiag.Clear();
                    for (int i = 100; i < 500; i++)
                    {
                        int dbToRead = i + 1000;
                        int result = Fonctions.CheckDbsDiag(dbToRead);

                        if (result == 0)
                            listDbsDiag.Add("DB" + dbToRead.ToString() + " Moteur n°" + i.ToString());
                    }
                }
            }
        }

        private void bwScanner_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (bCheckAllDbsDiag)
            {
                bCheckAllDbsDiag = false;
                comboBox1.Items.Clear();
                for (int i = 0; i < listDbsDiag.Count; i++)
                {
                    comboBox1.Items.Add(listDbsDiag[i]);
                }

                Fonctions.WriteListDbs(listDbsDiag);
            }
        }

        private void bwWork_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            var res = -1;

            bool CheckCon = Fonctions.CheckCon();
            if (CheckCon == true)
                _statusConnection = true;
            else
                _statusConnection = false;

            if (!_statusConnection)
                res = Client.ConnectTo(boxAdresseIp.Text, 0, 2);

            if (_statusConnection)
            {
                // Lecture dans PLC
                numDB = Int32.Parse("1" + boxMotor.Text);
                _arStateMotor.Clear();
                Fonctions.StateMotor(numDB);
                spdMotor = _dspdMotor.ToString("0.00") + "m/min";
                intMotor = _dintMotor.ToString("00");

                // Ecriture dans PLC
                if (bWriteReset)
                {
                    bWriteReset = false;
                    Fonctions.Reset();
                }

                if (bWriteBump)
                {
                    bWriteBump = false;
                    Fonctions.Bump(numDB);
                }

                if (bWriteForceOn)
                {
                    bWriteForceOn = false;
                    Fonctions.ForceOn(numDB);
                }

                if (bWriteForceCalib)
                {
                    bWriteForceCalib = false;
                    Fonctions.ForceCalib(numDB);
                }

                if (bWriteCalibSpeed)
                {
                    bWriteCalibSpeed = false;
                    Fonctions.WriteCalibSpeed(numDB, progressBarSpdF.Value * 100);
                }

                if (bWriteMesSpeed)
                {
                    bWriteMesSpeed = false;
                    Double dtemp = Fonctions.StrToDouble(boxMesSpeed.Text, '.', 100);
                    Fonctions.WriteMesSpeed(numDB, dtemp);
                }
            }
        }

        private void bwWork_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            // Status connexion
            if (_statusConnection)
                lblStatusCon.Text = "Connecté";
            else
                lblStatusCon.Text = "Déconnecté";

            if (_statusConnection)
            {
                if (_arStateMotor[0])
                {
                    lblMot1.Text = "Motor is OK";
                    lblMot1.ForeColor = System.Drawing.Color.Green;
                }
                else
                {
                    lblMot1.Text = "Motor is not OK";
                    lblMot1.ForeColor = System.Drawing.Color.Red;
                }

                if (_arStateMotor[1])
                {
                    lblMot2.Text = "Motor is running";
                    lblMot2.ForeColor = System.Drawing.Color.Green;
                }
                else
                {
                    lblMot2.Text = "Motor is not running";
                    lblMot2.ForeColor = System.Drawing.Color.Red;
                }

                if (_arStateMotor[2])
                {
                    lblMot3.Text = "Motor isolator switch open";
                    lblMot3.ForeColor = System.Drawing.Color.Red;
                }
                else
                {
                    lblMot3.Text = "Motor isolator switch close";
                    lblMot3.ForeColor = System.Drawing.Color.Green;
                }

                if (_arStateMotor[3])
                {
                    lblMot4.Text = "VFD is on bus";
                    lblMot4.ForeColor = System.Drawing.Color.Green;
                }
                else
                {
                    lblMot4.Text = "VFD is not on bus";
                    lblMot4.ForeColor = System.Drawing.Color.Red;
                }

                if (_arStateMotor[4])
                {
                    lblMot5.Text = "Power supply is On";
                    lblMot5.ForeColor = System.Drawing.Color.Green;
                }
                else
                {
                    lblMot5.Text = "Power supply is Off";
                    lblMot5.ForeColor = System.Drawing.Color.Red;
                }

                if (_arStateMotor[5])
                {
                    lblMot6.Text = "Low limit reached";
                    lblMot6.ForeColor = System.Drawing.Color.Green;
                }
                else
                {
                    lblMot6.Text = "Low limit reached";
                    lblMot6.ForeColor = System.Drawing.Color.Red;
                }

                if (_arStateMotor[6])
                {
                    lblMot7.Text = "High limit reached";
                    lblMot7.ForeColor = System.Drawing.Color.Green;
                }
                else
                {
                    lblMot7.Text = "High limit reached";
                    lblMot7.ForeColor = System.Drawing.Color.Red;
                }

                if (_arStateMotor[7])
                {
                    lblMot8.Text = "Motor isolator switch calculate by current check";
                    lblMot8.ForeColor = System.Drawing.Color.Green;
                }
                else
                {
                    lblMot8.Text = "Motor isolator switch calculate by current check";
                    lblMot8.ForeColor = System.Drawing.Color.Red;
                }

                if (_arStateMotor[8])
                {
                    lblMot9.Text = "Emergency stop";
                    lblMot9.ForeColor = System.Drawing.Color.Red;
                }
                else
                {
                    lblMot9.Text = "Emergency stop";
                    lblMot9.ForeColor = System.Drawing.Color.Green;
                }

                // Etat moteur
                progressBarSpdF.Value = (int)_dspdFMotor;


                //circIntMotor2.Text = intMotor;
                //int temp = Int32.Parse(intMotor);
                //if (temp < 101 && temp > 0)
                //    circIntMotor2.Value = Int32.Parse(intMotor);

                int temp = Int32.Parse(intMotor);
                if (temp < 101 && temp > 0)
                    circIntMotor.Value = Int32.Parse(intMotor);
            }

            if (!_statusConnection)
            {
                lblMot1.ForeColor = System.Drawing.Color.Black;
                lblMot2.ForeColor = System.Drawing.Color.Black;
                lblMot3.ForeColor = System.Drawing.Color.Black;
                lblMot4.ForeColor = System.Drawing.Color.Black;
                lblMot5.ForeColor = System.Drawing.Color.Black;
                lblMot6.ForeColor = System.Drawing.Color.Black;
                lblMot7.ForeColor = System.Drawing.Color.Black;
                lblMot8.ForeColor = System.Drawing.Color.Black;
                lblMot9.ForeColor = System.Drawing.Color.Black;
            }

            
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                //MessageBox.Show(listBox1.SelectedItem.ToString());
                string s = comboBox1.SelectedItem.ToString();
                string[] words = s.Split('°');
                boxMotor.Text = words[1];
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Chargement de l'index
            string dir = Application.StartupPath + "\\indexDbs.txt";
            if (File.Exists(dir))
            {
                System.IO.StreamReader sr = new System.IO.StreamReader(dir);

                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    //listBox1.Items.Add(line);
                    comboBox1.Items.Add(line);
                }

                sr.Close();
            }

            bwChart.RunWorkerAsync();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Arrêt de la tâche de fond
            //cpuThread.Abort();
            timer.Enabled = false;

            // Disconnect from CPU
            Client.Disconnect();

            // Sauvegarde des valeurs
            Properties.Settings.Default.Save();
        }

        private void Main_SizeChanged(object sender, EventArgs e)
        {
            //spdChart.Width = this.Width - (listBox1.Width + listBox1.Margin.Left + 5);
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            progressBarSpdF.Value = progressBarSpdF.Value - 10;
            bWriteCalibSpeed = true;
        }

        private void materialFlatButton2_Click(object sender, EventArgs e)
        {
            progressBarSpdF.Value = progressBarSpdF.Value + 10;
            bWriteCalibSpeed = true;
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            bool threadActif = bwWork.IsBusy;

            if (!threadActif)
                bwWork.RunWorkerAsync();
        }

        private void UpdateCpuChart()
        {
            

            for (int i = 0; i < spdArray.Length - 1; ++i)
            {
                spdChart.Series["Series1"].Points.AddY(spdArray[i]);
            }

            spdChart.Series["Series1"].Points.Clear();
            spdChart.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
            spdChart.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;
            spdChart.BackColor = Color.Transparent;
            spdChart.Series[0].IsVisibleInLegend = true;
            spdChart.ChartAreas[0].BackColor = Color.Transparent;
            //spdChart.ChartAreas["ChartArea1"].AxisX.LabelStyle.Enabled = false;
            //spdChart.ChartAreas["ChartArea1"].AxisY.LabelStyle.Enabled = false;
            //spdChart.ChartAreas[0].AxisX.LineColor = spdChart.BackColor;
            //spdChart.ChartAreas[0].AxisY.LineColor = spdChart.BackColor;
            //spdChart.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            //spdChart.ChartAreas[0].AxisX.MinorGrid.Enabled = false;
            //spdChart.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            //spdChart.ChartAreas[0].AxisY.MinorGrid.Enabled = false;
            spdChart.ChartAreas[0].AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            spdChart.ChartAreas[0].AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            //spdChart.Series[0].LegendText = spdMotor;

            //intChart.Series["Series1"].Points.Clear();
            //intChart.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
            //intChart.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;
            //intChart.BackColor = Color.Transparent;
            //intChart.Series[0].IsVisibleInLegend = true;
            //intChart.ChartAreas[0].BackColor = Color.Transparent;

            //for (int i = 0; i < intensityArray.Length - 1; ++i)
            //{
            //    intChart.Series["Series1"].Points.AddY(intensityArray[i]);
            //}
        }
    }
}