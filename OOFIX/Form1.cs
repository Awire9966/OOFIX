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
using System.Diagnostics;
using System.Net;
namespace OOFIX
{
    public partial class Form1 : Form
    {
        bool installed;
        string output = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Microsoft\Windows\Start Menu\Programs\Startup\CopyOOF.exe";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            setvars();
            MessageBox.Show("Sadly, My website is being listed as spam on https://www.spamhaus.org/ . Within the coming months, OOFIX will be unsupported. I will be making a new program with tons of new features That will let you modify EVERYTHING. Stay tuned for that on my github (https://github.com/Awire9966). Thank you all who have supported this project", "NOTICE!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
            private void setvars()
        {
            installed = File.Exists(output);
            button2.Visible = installed;
            if (installed == true)
            {

                button1.Text = "Uninstall";
            }
            else if (installed == false)
            {
                button1.Text = "Install";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (installed == true)
            {
                File.Delete(output);
                Task.Delay(1000);
                setvars();
                    
            }
            else if(installed == false)
            {
                WebClient client = new WebClient();
                client.DownloadFile("https://raw.githubusercontent.com/Awire9966/OOFIX/main/CopyOOF/CopyOOF/bin/Debug/CopyOOF.exe", output);
                Process.Start(output);
                Task.Delay(1000);
                setvars();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start(output);
        }
    }
}
