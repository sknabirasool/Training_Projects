using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice_LinQ_14_06
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Console.WriteLine("Persons List");
            List<Person> list =  ListManager.LoadDemoData();

            foreach(var person in list)
            {
                 Console.WriteLine($"{person.FirstName},{person.LastName},{person.Country},{person.Old}");       
            }
            Console.ReadLine();

            //Application.SetHighDpiMode(HighDpiMode.SystemAware);
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
        }
    }
}
