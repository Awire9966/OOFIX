using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;

namespace CopyOOF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WebClient client = new WebClient();
            client.DownloadFile("http://awiresoftware.xyz/Roblox/ouch.ogg", client.DownloadString("http://awiresoftware.xyz/Roblox/RobloxDir.txt")+ @"\content\sounds\ouch.ogg");
         
        }
    }
}
