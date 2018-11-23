using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace PCOptimizer
{
    public partial class Optimizer : UserControl
    {
        public Optimizer()
        {
            InitializeComponent();
        }
        static bool cookie = true;
        static bool file = true;
        static bool internet = true;
        public static int cookies = 0;
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            cookies++;
            if (cookies >= 2)
            {
                pictureBox1.Image = global::PCOptimizer.Properties.Resources.icons8_cookie_901;
                cookie = true;
                cookies=0;
            }
            else
            {
                pictureBox1.Image = global::PCOptimizer.Properties.Resources.cookiesfalse;
                cookie = false;
                
            }

        }
        public static int wifi = 0;

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            wifi++;
            if (wifi >= 2)
            {

                pictureBox2.Image = global::PCOptimizer.Properties.Resources.icons8_wi_fi_96;
                internet = true;
                wifi = 0;
            }
            else
            {
                pictureBox2.Image = global::PCOptimizer.Properties.Resources.wififalse;
                internet = false;
            }


        }
        public static int files = 0;
        private void pictureBox3_Click(object sender, EventArgs e)
        {

            files++;
            if (files >= 2)
            {
                
                file = true;
                pictureBox3.Image = global::PCOptimizer.Properties.Resources.icons8_document_96;
                files = 0;
            }
            else
            {
                file = false;
                pictureBox3.Image = global::PCOptimizer.Properties.Resources.documentfalse;
            }

        }
        int options = 0;
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            

            if (internet == true)
            {
                
                options++;
                
                connection();
            }
            if (file == true)
            {
                
                
                options++;
                
                explorerRestart();
                fClear();

            }

            if (cookie == true)
            {
                
                
                options++;
                
                cookiesClear();
            }
            if(options>= 1)
            {
                options = 0;
                MessageBox.Show("Optimized!");
                
            }
            else
            {
                cookies = 1;
                MessageBox.Show("Select an option");
                
            }
        }


        #region
        static void fClear()
        {
            string user = Environment.UserName;
            try
            {
                string[] fRecent = Directory.GetFiles(@"C:\Users\" + user + @"\Recent");
                string[] fRecent2 = Directory.GetFiles(@"C:\Users\" + user + @"\AppData\Roaming\Microsoft\Windows\Recent");

                foreach (string fRecFiles in fRecent)
                {
                    File.Delete(fRecFiles);

                }

                foreach (string fRecFiles2 in fRecent2)
                {

                    File.Delete(fRecFiles2);


                }

            }
            catch
            {
                
            }

            //lixeira
            try
            {
                string[] fRecent = Directory.GetFiles(@"C:\$Recycle.Bin\S-1-5-21-1683319501-923763647-4055174646-1003");
                

                foreach (string fRecFiles in fRecent)
                {
                    File.Delete(fRecFiles);

                }

            }
            catch
            {

            }


            try
            {
                string[] fPrefetch = Directory.GetFiles(@"C:\Windows\Prefetch");

                foreach (string fPrefFiles in fPrefetch)
                {
                    if (fPrefFiles.Contains(".pf"))
                    {
                        File.Delete(fPrefFiles);
                    }

                }
            }
            catch
            {
                MessageBox.Show("error - xI22");
            }
        }
        static void connection()
        {

            try
            {
                string bat_name = @"C:\ProgramData\PCOptimizer\internetload.bat";

                string bat = @"ipconfig /all";



                StreamWriter file = new StreamWriter(bat_name);
                file.Write(bat);
                file.Close();

                Process bat_call = new Process();
                bat_call.StartInfo.FileName = bat_name;
                bat_call.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                bat_call.StartInfo.UseShellExecute = true;
                bat_call.Start();


            }
            catch
            {
                //File.Delete(@"C:\ProgramData\PCOptimizer\explorerload.bat");
                MessageBox.Show("error - type xI27");
            }


        }
        public static void cookiesClear()
        {
            try
            {
                string[] pCookies = System.IO.Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.Cookies));
                foreach (string pCoFiles in pCookies)
                {
                    File.Delete(pCoFiles);

                }
            }
            catch
            {
                MessageBox.Show("error - xI23");
            }
        }
        static void explorerRestart()
        {

            try
            {
                string bat_name = @"C:\ProgramData\PCOptimizer\explorerload.bat";

                string bat = @"Taskkill /f /im explorer.exe"
                    + Environment.NewLine
                    + @"%systemroot%\sysnative\cmd.exe /c start /B explorer.exe"
                    + Environment.NewLine
                    + @"start explorer.exe";

                StreamWriter file = new StreamWriter(bat_name);
                file.Write(bat);
                file.Close();

                Process bat_call = new Process();
                bat_call.StartInfo.FileName = bat_name;
                bat_call.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                bat_call.StartInfo.UseShellExecute = true;
                bat_call.Start();


            }
            catch
            {
                //File.Delete(@"C:\ProgramData\PCOptimizer\explorerload.bat");
                MessageBox.Show("error - type xI25");
            }


        }
        #endregion
    }
}

