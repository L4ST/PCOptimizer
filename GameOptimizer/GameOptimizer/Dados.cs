using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;

namespace PCOptimizer
{
    public partial class Dados : UserControl
    {
        public Dados()
        {
            InitializeComponent();
        }

        private void Dados_Load(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
            

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            var cpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");
            int usage = (int)cpuCounter.NextValue();
            while (usage == 0 || usage > 80)
            {
                Thread.Sleep(250);
                usage = (int)cpuCounter.NextValue();
            }

            //memory
            var memory = 0.0;
            Process proc = Process.GetCurrentProcess();
            memory = Math.Round(proc.PrivateMemorySize64 / 1e+6, 2);
            proc.Dispose();


            

            String batterylife;
            
            int battery = (int)(SystemInformation.PowerStatus.BatteryLifePercent * 100);





            this.Invoke(new MethodInvoker(delegate

            {
                double total = 100;
                lblCPU.Text = "CPU USAGE: " + usage + "%";
                lblMEMORY.Text = "MEMORY AVALIABLE: " + memory + "%";
                lblBattery.Text = "BATTERY LIFE: " + battery + "%";

            }));
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
			//wait
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
			//wait
        }

        private void lblMEMORY_Click(object sender, EventArgs e)
        {
			//wait
        }
    }
}
