using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random gg = new Random();
            Console.Write("Dies ist kein gestohlener Code.\nBitte drücken sie [Enter] um fortzufahren:");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Programm.exe searching");
            Console.WriteLine("File path found");
            for (int i = 1; i < 101; i++)
            {
                Console.WriteLine($"Programm.exe loaded: {i}%");
                int random = gg.Next(10, 70);
                Thread.Sleep(random);
            }
            Thread.Sleep(1000);
            Console.WriteLine("Programm.exe is succesfully loaded\nPlease press [enter] to start.");
            Console.ReadLine();
            Console.Clear();

            int lenghtOfProcess;
            Console.Write("How long should the program run:");
            try
            {
                lenghtOfProcess = int.Parse(Console.ReadLine());                
            }
            catch (Exception)
            {
                lenghtOfProcess = gg.Next(100, 100000);
            }

            for (int i = 0; i < lenghtOfProcess; i++)
            {
                Random r = new Random();
                int eins = r.Next(1, 8);

                if (eins == 1)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                }

                if (eins == 2)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }

                if (eins == 3)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }

                if (eins == 4)
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                }

                if (eins == 5)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }

                if (eins == 6)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                }

                if (eins == 7)
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                }

                if (eins == 1)
                {
                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                }

                if (eins == 2)
                {
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                }

                if (eins == 3)
                {
                    Console.BackgroundColor = ConsoleColor.Cyan;
                }

                if (eins == 4)
                {
                    Console.BackgroundColor = ConsoleColor.Yellow;
                }

                if (eins == 5)
                {
                    Console.BackgroundColor = ConsoleColor.Green;
                }

                if (eins == 6)
                {
                    Console.BackgroundColor = ConsoleColor.Magenta;
                }

                if (eins == 7)
                {
                    Console.BackgroundColor = ConsoleColor.Blue;
                }

                Console.Write("69");

                Random b = new Random();
                eins = b.Next(1, 8);

                if (eins == 1)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                }

                if (eins == 2)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }

                if (eins == 3)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }

                if (eins == 4)
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                }

                if (eins == 5)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }

                if (eins == 6)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                }

                if (eins == 7)
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                }

                if (eins == 1)
                {
                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                }

                if (eins == 2)
                {
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                }

                if (eins == 3)
                {
                    Console.BackgroundColor = ConsoleColor.Cyan;
                }

                if (eins == 4)
                {
                    Console.BackgroundColor = ConsoleColor.Yellow;
                }

                if (eins == 5)
                {
                    Console.BackgroundColor = ConsoleColor.Green;
                }

                if (eins == 6)
                {
                    Console.BackgroundColor = ConsoleColor.Magenta;
                }

                if (eins == 7)
                {
                    Console.BackgroundColor = ConsoleColor.Blue;
                }

                Console.Write("420");

                Random ffg = new Random();
                eins = ffg.Next(1, 8);

                if (eins == 1)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                }

                if (eins == 2)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }

                if (eins == 3)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }

                if (eins == 4)
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                }

                if (eins == 5)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }

                if (eins == 6)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                }

                if (eins == 7)
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                }

                if (eins == 1)
                {
                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                }

                if (eins == 2)
                {
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                }

                if (eins == 3)
                {
                    Console.BackgroundColor = ConsoleColor.Cyan;
                }

                if (eins == 4)
                {
                    Console.BackgroundColor = ConsoleColor.Yellow;
                }

                if (eins == 5)
                {
                    Console.BackgroundColor = ConsoleColor.Green;
                }

                if (eins == 6)
                {
                    Console.BackgroundColor = ConsoleColor.Magenta;
                }

                if (eins == 7)
                {
                    Console.BackgroundColor = ConsoleColor.Blue;
                }

                Console.Write("Never gona give you up!");
            }
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Gray;

            bool exithere = true;

            do
            {
                Console.WriteLine("\n============================================================");
                Console.WriteLine("\nWas wollen sie jetzt tun?");
                Console.WriteLine("------------------------------------------------------------");
                Console.WriteLine("Zurück zum CookieClicker:\t[back]\nNächstes Programm:\t\t[next]\nNichts machen:\t\t\t" +
                    "[not]\nEin Virus starten:\t\t[virus]\nProgramm schliessen:\t\t[exit]");
                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "back":

                        ProcessStartInfo processInfo = new ProcessStartInfo();
                        processInfo.FileName = @"..\..\..\..\Coockie Clicker Rip-Off\bin\Debug\net5.0-windows\Coockie Clicker Rip-Off.exe";
                        processInfo.ErrorDialog = true;
                        processInfo.UseShellExecute = false;
                        processInfo.RedirectStandardOutput = true;
                        processInfo.RedirectStandardError = true;
                        processInfo.WorkingDirectory = Path.GetDirectoryName(@"..\..\..\..\Coockie Clicker Rip-Off\bin\Debug\net5.0-windows\Coockie Clicker Rip-Off.exe");
                        Process.Start(processInfo);

                        exithere = false;
                        break;

                    case "next":
                        Console.WriteLine("Noch nicht bereit\nSorry:(");
                        break;

                    case "not":
                        while (true)
                        {
                            Console.ReadLine();
                        }

                    case "virus":
                        Thread.Sleep(5000);
                        while (true)
                        {
                            Thread.Sleep(100);
                            launchBrowser("");
                        }
                        break;

                    case "exit":
                        Environment.Exit(0);
                        break;

                    default:
                        break;
                }

            } while (exithere);


        }

        public static void launchBrowser(string url)
        {
            try
            {
                using (RegistryKey userChoiceKey = Registry.CurrentUser.OpenSubKey(@"Software\Clients\StartMenuInternet"))
                {
                    var first = userChoiceKey?.GetSubKeyNames().FirstOrDefault();
                    if (userChoiceKey == null || first == null) return;
                    var reg = userChoiceKey.OpenSubKey(first + @"\shell\open\command");
                    var prog = (string)reg?.GetValue(null);
                    if (prog == null) return;
                    Process.Start(new ProcessStartInfo(prog, url));
                }
            }
            catch (Exception)
            {

            }
        }
    }
}
