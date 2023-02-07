using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiDimentional_Array_Program
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[,] multiArray= new string[3,3];
            multiArray[0, 0] = "Item 00";
            multiArray[0, 1] = "Item 01";
            multiArray[0, 2] = "Item 02";
            multiArray[1, 0] = "Item 10";
            multiArray[1, 1] = "Item 11";
            multiArray[1, 2] = "Item 12";
            multiArray[2, 0] = "Item 20"; 
            multiArray[2, 1] = "Item 21";
            multiArray[2, 2] = "Item 22";

            Console.WriteLine("\tColumn 1 \tColumn 2 \tColumn 3");
            Console.WriteLine("\t-------- \t-------- \t--------");

            for (int i = 0; i < 3; i++)
            {
                Console.Write("Row "+(i+1));
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("\t");
                    Console.Write(multiArray[i, j]);
                    Console.Write("\t");

                    if (j == 2) { Console.WriteLine(); }

                }
            }

            
        }
    }
}
