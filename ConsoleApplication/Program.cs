using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2.
            string name = "Bailee McBreairty";
            string location = "Riverton, Utah";

            //3. 
            Console.WriteLine("My name is " + name);
            Console.WriteLine("I am from " + location);

            // 4. 
            var currentDate = DateTime.Now;
            Console.WriteLine("The current date is " + currentDate.ToString("d"));

            // 5. 

            Console.WriteLine("The number of days until Christmas is ");



            Console.WriteLine("Press Any Key to Exit");
            Console.ReadKey();
        }
    }
}
