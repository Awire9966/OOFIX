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
                client.DownloadFile("http://awiresoftware.xyz/Roblox/CopyOOF.exe", output);
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
