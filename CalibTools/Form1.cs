namespace CalibTools
{
    using Snap7;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Drawing;
    using System.Threading;
    using System.Windows.Forms;
    using MaterialSkin;
    using MaterialSkin.Controls;

    public partial class Main : MaterialSkin.Controls.MaterialForm
    {
        public static List<bool> _arStateMotor = new List<bool>();
        public static bool _statusConnection;

        public static BackgroundWorker bwDisplay = new BackgroundWorker();
        public static BackgroundWorker bwWork = new BackgroundWorker();
        public static S7Client Client = new S7Client();
        public static List<string> listDbsDiag = new List<string>();
        private static bool bCheckAllDbsDiag;

        private static bool bWriteBump;
        private static bool bWriteCalibSpeed;
        private static bool bWriteForceOn;
        private static bool bWriteMesSpeed;
        private static bool bWriteReset;
        private static double dintMotor;
        private static double dspdMotor;
        private static int numDB;

        private static string spdMotor;

        // Charts
        private double[] cpuArray = new double[60];
        private double[] intensityArray = new double[60];

        public Main()
        {
            InitializeComponent();

            // Create a material theme manager and add the form to manage (this)
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            // Configure color schema
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue400, Primary.Blue500,
                Primary.Blue500, Accent.LightBlue200,
                TextShade.WHITE
            );

            // Initialisation de la tâche de fond (travail)
            bwWork.WorkerReportsProgress = true;
            bwWork.WorkerSupportsCancellation = true;
            bwWork.DoWork += new DoWorkEventHandler(bwWork_DoWork);
            bwWork.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bwWork_RunWorkerCompleted);
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
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
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

        private void button6_Click(object sender, EventArgs e)
        {
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
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
                spdMotor = Fonctions.SpeedMotor(numDB).ToString("0.00") + " M/min";
                dspdMotor = Fonctions.SpeedMotor(numDB);
                dintMotor = Fonctions.IntensityMotor(numDB) / 10;

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

                if (bWriteCalibSpeed)
                {
                    bWriteCalibSpeed = false;
                    Fonctions.WriteCalibSpeed(numDB, Int32.Parse(boxCalibSpeed.Text));
                }

                if (bWriteMesSpeed)
                {
                    bWriteMesSpeed = false;
                    //float temp = (float) Convert.ToDouble(boxMesSpeed.Text);
                    Double monSalaire = Fonctions.StrToDouble(boxMesSpeed.Text, '.', 100);
                    //string s = string.Format("{0:G}", value);
                    //float.Parse(boxMesSpeed.Text)
                    Fonctions.WriteMesSpeed(numDB, monSalaire);
                }

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

            // Charts
            cpuArray[cpuArray.Length - 1] = Math.Round(dspdMotor, 0);
            Array.Copy(cpuArray, 1, cpuArray, 0, cpuArray.Length - 1);

            intensityArray[intensityArray.Length - 1] = Math.Round(dintMotor, 0);
            Array.Copy(intensityArray, 1, intensityArray, 0, intensityArray.Length - 1);
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

                if (bCheckAllDbsDiag)
                {
                    bCheckAllDbsDiag = false;
                    listBox1.Items.Clear();
                    for (int i = 0; i < listDbsDiag.Count; i++)
                    {
                        listBox1.Items.Add(listDbsDiag[i]);
                    }

                    Fonctions.WriteListDbs(listDbsDiag);
                }

                // Vitesse moteur
                lblSpeed.Text = "Vitesse:" + spdMotor;

                
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

            // Charts
            if (cpuChart.IsHandleCreated)
            {
                Invoke((MethodInvoker)delegate { UpdateCpuChart(); });
            }
            else
            {
                //......
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //bwDisplay.RunWorkerAsync();

            // Chargement de l'index
            string dir = Application.StartupPath + "\\indexDbs.txt";
            System.IO.StreamReader sr = new System.IO.StreamReader(dir);

            string line;
            while ((line = sr.ReadLine()) != null)
            {
                listBox1.Items.Add(line);
            }

            sr.Close();
        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                //MessageBox.Show(listBox1.SelectedItem.ToString());
                string s = listBox1.SelectedItem.ToString();
                string[] words = s.Split('°');
                boxMotor.Text = words[1];
            }
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

        private void timer_Tick(object sender, EventArgs e)
        {
            bool threadActif = bwWork.IsBusy;

            if (!threadActif)
                bwWork.RunWorkerAsync();
        }

        private void UpdateCpuChart()
        {
            cpuChart.Series["Series1"].Points.Clear();
            cpuChart.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
            cpuChart.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;
            cpuChart.BackColor = Color.Transparent;
            cpuChart.Series[0].IsVisibleInLegend = false;
            cpuChart.ChartAreas[0].BackColor = Color.Transparent;

            for (int i = 0; i < cpuArray.Length - 1; ++i)
            {
                cpuChart.Series["Series1"].Points.AddY(cpuArray[i]);
            }

            chart2.Series["Series1"].Points.Clear();
            chart2.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
            chart2.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;
            chart2.BackColor = Color.Transparent;
            chart2.Series[0].IsVisibleInLegend = false;
            chart2.ChartAreas[0].BackColor = Color.Transparent;

            for (int i = 0; i < intensityArray.Length - 1; ++i)
            {
                chart2.Series["Series1"].Points.AddY(intensityArray[i]);
            }
        }

        private void btnBump_Click(object sender, EventArgs e)
        {
            bWriteBump = true;
            numDB = Int32.Parse("1" + boxMotor.Text);
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
    }
}