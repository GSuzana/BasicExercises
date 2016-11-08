using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicExercises
{
    class Exercise12
    {
        static void Main(string[] args)
        {
            //Write a C# program to that takes a number as input and display it four times 
            //in a row (separated with blank spaces), and then four times in the next row,
            //with no separation. 

            int numb;
            Console.WriteLine("\n12. Enter the number: ");
            numb = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 2; i++)
            {
                Console.WriteLine("{0} {0} {0} {0}", numb);
                Console.WriteLine("{0}{0}{0}{0}", numb);
            }

            Console.ReadKey();
        }
    }
}
