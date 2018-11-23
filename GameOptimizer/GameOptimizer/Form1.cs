using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Diagnostics;

namespace GameOptimizer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();




        public static string version = "2.0";
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        private void label1_Click(object sender, EventArgs e)
        {
            try
            {
                Application.Exit();
            }
            catch
            {
                MessageBox.Show("Error - Type close");
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Left)
                {
                    ReleaseCapture();
                    SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
                }
            }
            catch
            {

            }
        }
        
        

       
            
        


        

        private void Form1_Load(object sender, EventArgs e)
        {

            update();
            
            if (File.Exists(@"C:\ProgramData\PCOptimizer\explorerload.bat"))
            {
                File.Delete(@"C:\ProgramData\PCOptimizer\explorerload.bat");
            }

            if (File.Exists(@"C:\ProgramData\PCOptimizer\internetload.bat"))
            {
                File.Delete(@"C:\ProgramData\PCOptimizer\internetload.bat");
            }

            try
            {
                if (!Directory.Exists(@"C:\ProgramData\PCOptimizer"))
                {
                    Directory.CreateDirectory(@"C:\ProgramData\PCOptimizer");

                }
            }
            catch
            {
                MessageBox.Show("error - type xI26");
            }
            
        }

        

        public static void update()
        {
            try
            {
                WebClient wb = new WebClient();

                WebProxy wp = new WebProxy();
                wb.Proxy = wp;

                string verify = wb.DownloadString("http://pcoptimizer.ga/Version");
                

                if (!verify.Contains(version))
                {
                    MessageBox.Show("Updating!");
                    wb.DownloadFile("http://www.pcoptimizer.ga/PCOptimizer.rar", @"C:\ProgramData\PCOptimizer\PCOptimizerUpdate.rar");
                    wb.DownloadFile("http://www.pcoptimizer.ga/PCOptimizer.rar", @"C:\Users\" + Environment.UserName + @"\Desktop\PCOptimizerUpdate.rar");


                    System.Diagnostics.Process.Start(@"C:\ProgramData\PCOptimizer\PCOptimizerUpdate.rar");




                    string app_name = Application.StartupPath + "\\" + Application.ProductName + ".exe";
                    string bat_name = app_name + ".bat";

                    string bat = "@echo off\n"
                        + ":loop\n"
                        + "del \"" + app_name + "\"\n"
                        + "if Exist \"" + app_name + "\" GOTO loop\n"
                        + "del %0";

                    StreamWriter file = new StreamWriter(bat_name);
                    file.Write(bat);
                    file.Close();

                    Process bat_call = new Process();
                    bat_call.StartInfo.FileName = bat_name;
                    bat_call.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    bat_call.StartInfo.UseShellExecute = true;
                    bat_call.Start();

                    Environment.Exit(0);
                }

            }
            catch
            {

            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {


            
            

            dados1.BringToFront();
            
            

        }

        private void dados1_Load(object sender, EventArgs e)
        {

        }

        private void picHome_Click(object sender, EventArgs e)
        {
            
            initial1.BringToFront();
            
            
            
            

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            
            optimizer1.BringToFront();
            
            
            
        }
    }
    }

