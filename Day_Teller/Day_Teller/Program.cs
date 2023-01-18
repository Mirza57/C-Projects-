using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_Teller
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Enter the day number ");
            var day = Console.ReadLine();
            Console.WriteLine("Enter the month number ");
            var month = Console.ReadLine();
            Console.WriteLine("Enter the year ");
            var year = Console.ReadLine();

            DateTime dt = new DateTime(int.Parse(year), int.Parse(month), int.Parse(day));
            Console.WriteLine("\n "+" According to your input information the day will be -->" + dt.DayOfWeek);
            Console.ReadLine();


        }
    }
}
