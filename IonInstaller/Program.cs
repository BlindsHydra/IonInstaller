using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;

namespace IonInstaller
{
    class Program
    {
        static void Main(string[] args)
        {
            string title = "IonInstaller";
            Console.Title = title;
            Console.WriteLine("* [0] Windows 11 ++21996.1.210529-1541.co_release_CLIENT_CONSUMER_x64FRE_en-us.iso");
            Console.WriteLine("* [1] Windows 11 (Mirror Link) ++21996.1.210529-1541.co_release_CLIENT_CONSUMER_x64FRE_en-us.iso");
            Console.WriteLine("\n\nTotal Builds: 2");
            Console.Write("Enter Build Version: ");
            string option = Console.ReadLine();
            if (option == "0")
            {
                Console.WriteLine("* Opening download.");
                Process.Start("https://drive.google.com/file/d/1xVu5u-CRByOnHNP4INFLykHKJ0Wx2Agx/view");
                Console.WriteLine("* Press download and use rufus to convert it.");
                Thread.Sleep(1400);
                Console.Write("* Thank you for using IonInstaller! Goodbye!\n[Closing in 5 Seconds.]");
                Thread.Sleep(5000);
                Environment.Exit(0);
            }
            if (option == "1") 
            {
                Console.WriteLine("* Opening download.");
                Console.WriteLine("[!] Warning, This Mirror link is slow and may take time to load.");
                Process.Start("https://my.hidrive.com/lnk/OmChxNS0#file");
                Console.WriteLine("* Press download and use rufus to convert it.");
                Thread.Sleep(1400);
                Console.Write("* Thank you for using IonInstaller! Goodbye!\n[Closing in 5 Seconds.]");
                Thread.Sleep(5000);
                Environment.Exit(0);
            }
            Thread.Sleep(-1);
        }
    }
}
