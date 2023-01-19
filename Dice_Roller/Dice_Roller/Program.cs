using System; 
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Dice_Roller
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" We are going to make Dice Roller program ");
            Console.WriteLine();
            Console.WriteLine("Please write your name is first");
            string name= Console.ReadLine();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Do you want to roll a Dice please type ( yes / no ) ");
                string ans = Console.ReadLine().ToUpper();                                     // Converting any text to Capital Letters
                if (ans == "YES")
                {
                    Random rd = new Random();                                                  // It is predefined Random class
                    Console.WriteLine("New Dice number is :" + rd.Next(1, 10));

                }
                else
                {
                    Console.WriteLine("ok thanks for playing\t"+"("+ name+")");

                }

            }

        }
    }
}
