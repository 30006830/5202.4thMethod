//Blake Jensen 30006830
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5202._4thMethod
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            //the purpose of this program is to return the name of the day when a number is entered
            Console.WriteLine("This Program will return the name of the day of a particular numer you enter.");
            Console.WriteLine("Enter a number (1-7): ");

           
            Console.WriteLine("The day that corresponds to your number is: " + Day(int.Parse(Console.ReadLine())));
            Console.ReadLine();
        }
        static string Day(int num)
        {
            string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            return days[num - 1];
        }
    }
}
