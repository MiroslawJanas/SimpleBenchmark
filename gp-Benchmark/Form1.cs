using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace gp_Benchmark
{
    public partial class Form1 : Form
    {
        int Ttime = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
         /*   Stopwatch sw = new Stopwatch();
            sw.Start();
            ProcessStartInfo startPP = new ProcessStartInfo("excel.exe");
            Process proc = Process.Start(startPP);
            sw.Stop();
            TimeSpan elapsedTime = sw.Elapsed;

            label1.Text = elapsedTime.ToString();*/
                        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            Stopwatch sw = new Stopwatch();
            sw.Start();
            ProcessStartInfo startPP = new ProcessStartInfo("excel.exe");
            startPP.WindowStyle = ProcessWindowStyle.Maximized;
            Process proc = Process.Start(startPP);


            if (startPP.WindowStyle == ProcessWindowStyle.Maximized)
            {

                proc.WaitForExit();
                proc.Close();
                
            


            sw.Stop();
              TimeSpan elapsedTime = sw.Elapsed;
              label1.Text = elapsedTime.ToString();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            ProcessStartInfo startPP = new ProcessStartInfo("powerpnt.exe");
            Process proc = Process.Start(startPP);
            sw.Stop();
            TimeSpan elapsedTime = sw.Elapsed;

            label1.Text = elapsedTime.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
           Stopwatch sw = new Stopwatch();
            sw.Start();
            ProcessStartInfo startPP = new ProcessStartInfo("chrome.exe");
            Process proc = Process.Start(startPP);
            sw.Stop();
            TimeSpan elapsedTime = sw.Elapsed;

            label1.Text = elapsedTime.ToString();
           

        }

        private void button5_Click(object sender, EventArgs e)
        {
            System.IO.Directory.CreateDirectory("c:\\test22\\");

            Stopwatch sw = new Stopwatch();
            sw.Start();
            if (pickBox.Text== "x10000")
            {
                for (int i = 1; i <= 10000; i++)
                {
                    System.IO.Directory.CreateDirectory("c:\\test22\\"+ i.ToString());
                    label1.Text = /*"Folders created: " + */i.ToString();
                }                
            }

            if (pickBox.Text == "x100000")
            {
                for (int i = 1; i <= 100000; i++)
                {
                    System.IO.Directory.CreateDirectory("c:\\test22\\" + i.ToString());
                    label1.Text = "Folders created: " + i.ToString();
                }
            }

            if (pickBox.Text == "x1000000")
            {
                for (int i = 1; i <= 1000000; i++)
                {
                    System.IO.Directory.CreateDirectory("c:\\test22\\" + i.ToString());
                    label1.Text = "Folders created: " + i.ToString();
                }
            }

            if (pickBox.Text == "x10000000")
            {
                for (int i = 1; i <= 10000000; i++)
                {
                    System.IO.Directory.CreateDirectory("c:\\test22\\" + i.ToString());
                    label1.Text = "Folders created: " + i.ToString();
                }
            }

            sw.Stop();
            TimeSpan elapsedTime = sw.Elapsed;

            label1.Text = elapsedTime.ToString();

        }
    }
}
