using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompInfoConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите инвентарный номер: ");
            string invent_no = Console.ReadLine();
            Console.Write("Введите кабинет, в котором расположен компьютер: ");
            string kabinet = Console.ReadLine();
            Console.Write("Введите номер компьютера в кабинете: ");
            string n_pc = Console.ReadLine();

            var cpu = loader.loadCPU();
            var dev = loader.loadDevices();
            var DD = loader.loadDiskDrive();
            var GC = loader.loadGraphicCard();
            var MB = loader.loadMotherBoard();
            var Net = loader.loadNetwork();
            var RAM = loader.loadRAM();
            var RAM2 = loader.loadRAM2();
            var soft = loader.loadSoftware();


            dbworker dbw = new dbworker();
            bool createTables = true;
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
                dbw.CreateTable(soft, "SOFT", "SOFT_");
            }

            var num = dbw.UploadComp(invent_no, kabinet, n_pc);
            dbw.upload(cpu, "CPU", "CPU_", num);
            dbw.upload(dev, "dev", "dev_", num);
            dbw.upload(DD, "DD", "DD_", num);
            dbw.upload(GC, "GC", "GC_", num);
            dbw.upload(MB, "MB", "MB_", num);
            dbw.upload(Net, "Net", "Net_", num);
            dbw.upload(RAM, "RAM", "RAM_", num);
            dbw.upload(RAM2, "RAM2", "RAM2_", num);
            dbw.upload(soft, "SOFT", "SOFT_", num);

            Console.WriteLine("ok");
            Console.ReadLine();
        }
    }
}
