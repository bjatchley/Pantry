namespace Pantry.Console
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Pantry.Data.Models;
    using Pantry.Data.Helpers;
    using System.ServiceModel;
    using Pantry.Services;
    using System.Diagnostics;

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ServiceHost host = new ServiceHost(typeof(PantryService));

                host.Open();
                Console.WriteLine("Type any key to exit");
                Console.ReadKey();
                host.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

                Console.ReadKey();
            }
            
        }
    }
}
