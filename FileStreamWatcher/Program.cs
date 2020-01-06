using System;
using System.IO;
using System.Security.Permissions;

namespace FileStreamWatcher
{
    class Program
    {
        static void Main(string[] args)
        {
            FileSystemWatcher FSW = new FileSystemWatcher();
            FSW.Created += FSW_Vytvoreno;
            FSW.Deleted += FSW_Smazano;
            FSW.Changed += FSW_Zmeneno;
            FSW.Renamed += FSW_Prejmenovano;
            FSW.Path = $@"Z:\";
            FSW.EnableRaisingEvents = true;
            Console.ReadLine();
            
        }

        private static void FSW_Prejmenovano(object sender, RenamedEventArgs e)
        {
            Console.WriteLine($"Soubor {e.OldName} byl přejmenován na {e.Name}!");
        }

        private static void FSW_Zmeneno(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine($"Soubor {e.Name} byl upraven!");
        }

        private static void FSW_Smazano(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine($"Soubor {e.Name} byl smazán!");
        }

        private static void FSW_Vytvoreno(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine($"Byl vytvořen nový soubor {e.Name}!");
        }
    }
    
}