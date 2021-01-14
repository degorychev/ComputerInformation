using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompInfoConsole
{
    class Program
    {
        static INIManager config = new INIManager("config.ini");
        static void Main(string[] args)
        {
            string db_server = config.Read("server", "db");
            string db_user = config.Read("user", "db");
            string db_pass = config.Read("pass", "db");
            string db_database = config.Read("database", "db");

            dbworker dbw = new dbworker(db_server, db_user, db_pass, db_database);
            Console.WriteLine("testing connectino to database...");
            if(!dbw.online())
            {
                Console.ReadLine();
                return;
            }
            Console.WriteLine("database online");
            Console.Write("Введите инвентарный номер: ");
            string invent_no = Console.ReadLine();
            Console.Write("Введите кабинет, в котором расположен компьютер: ");
            string kabinet = Console.ReadLine();
            Console.Write("Введите номер компьютера в кабинете: ");
            string n_pc = Console.ReadLine();

            Console.WriteLine("Collecting information... сan take a few seconds");

            var cpu = loader.loadCPU();
            var dev = loader.loadDevices();
            var DD = loader.loadDiskDrive();
            var GC = loader.loadGraphicCard();
            var MB = loader.loadMotherBoard();
            var Net = loader.loadNetwork();
            var RAM = loader.loadRAM();
            var RAM2 = loader.loadRAM2();
            var OS = loader.loadOS();
            var SOFT = loader.loadSoftWare();
                        
            bool createTables = config.Read("createtable", "program") == "1";
            if(createTables)
            {
                dbw.CreateTableComp();
                dbw.CreateTable(cpu, "CPU", "CPU_");
                dbw.CreateTable(dev, "dev", "dev_");
                dbw.CreateTable(DD, "DD", "DD_");
                dbw.CreateTable(GC, "GC", "GC_");
                dbw.CreateTable(MB, "MB", "MB_");
                dbw.CreateTable(Net, "Net", "Net_");
                dbw.CreateTable(RAM, "RAM", "RAM_");
                dbw.CreateTable(RAM2, "RAM2", "RAM2_");
                dbw.CreateTable(OS, "OS", "OS_");
                dbw.CreateTable(SOFT, "SOFT", "SOFT_");
            }

            var num = dbw.UploadComp(invent_no, kabinet, n_pc);
            Console.Write("Upload CPU info...");
            dbw.upload(cpu, "CPU", "CPU_", num);
            Console.WriteLine("ok");
            Console.Write("Upload Devices info...");
            dbw.upload(dev, "dev", "dev_", num);
            Console.WriteLine("ok");
            Console.Write("Upload DiskDrive info...");
            dbw.upload(DD, "DD", "DD_", num);
            Console.WriteLine("ok");
            Console.Write("Upload GraphicCards info...");
            dbw.upload(GC, "GC", "GC_", num);
            Console.WriteLine("ok");
            Console.Write("Upload MotherBoard info...");
            dbw.upload(MB, "MB", "MB_", num);
            Console.WriteLine("ok");
            Console.Write("Upload NetworkInterface info...");
            dbw.upload(Net, "Net", "Net_", num);
            Console.WriteLine("ok");
            Console.Write("Upload RAM info...");
            dbw.upload(RAM, "RAM", "RAM_", num);
            Console.WriteLine("ok");
            Console.Write("Upload RAM2 info...");
            dbw.upload(RAM2, "RAM2", "RAM2_", num);
            Console.WriteLine("ok");
            Console.Write("Upload OS info...");
            dbw.upload(OS, "OS", "OS_", num);
            Console.WriteLine("ok");
            Console.Write("Upload SOFT info...");
            dbw.upload(SOFT, "SOFT", "SOFT_", num);
            Console.WriteLine("ok");
            Console.WriteLine("All done. Please press any key");
            Console.ReadLine();
        }
    }
}
