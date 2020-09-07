using HectorAndradeTest.AplicationConsole.Entities;
using HectorAndradeTest.AplicationConsole.ProcessCore;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;

namespace HectorAndradeTest.AplicationConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            ConfigParameters();
            Console.WriteLine("Hola este es el resultado de la prueba!");
            PrintData();
            Console.ReadLine();
        }

        private static void PrintData()
        {
            foreach (var item in ProcessPages.PagesNumbersPrime())
            {
                Console.WriteLine(item);
            }
        }

        private static void ConfigParameters()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsetting.json", optional: true, reloadOnChange: true);
            ConfigurationData.ItemCount = Convert.ToInt32(builder.Build().GetSection("ConfigurationData").GetSection("ItemCount").Value);
            ConfigurationData.ColumsPage = Convert.ToInt32(builder.Build().GetSection("ConfigurationData").GetSection("ColumsPage").Value);
            ConfigurationData.RowsPage = Convert.ToInt32(builder.Build().GetSection("ConfigurationData").GetSection("RowsPage").Value);
        }
    }
}
