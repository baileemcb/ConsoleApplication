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
            DateTime now = DateTime.Now;
            int day = now.DayOfYear;
            int christmasTime = (365-6) - day;
            Console.WriteLine("The number of days until Christmas is " + christmasTime);

            // 6. 
            double width, height, woodLength, glassArea;
            string widthString, heightString;

            Console.WriteLine("What is the width of the window?");
            widthString = Console.ReadLine();
            width = double.Parse(widthString);

            Console.WriteLine("What is the height of the window?");
            heightString = Console.ReadLine();
            height = double.Parse(heightString);

            woodLength = 2 * (width + height ) * 3.25;

            glassArea = 2 * (width + height);

            Console.WriteLine("The length of the wood is " + woodLength + " feet.");
            Console.WriteLine("The area of the glass is " + glassArea + " square metres.");

            // 7. 
            Console.WriteLine("Press Any Key to Exit");
            Console.ReadKey();
        }
    }
}
