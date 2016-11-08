using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicExercises
{
    class Exercise13
    {
        static void Main(string[] args)
        {
            //Write a C# program that takes a number as input and then display a rectangle
            //3 columns wide and 5 rows tall using that digit. 

            int digit;
            Console.WriteLine("Enter the digit: ");
            digit = int.Parse(Console.ReadLine());

            Console.WriteLine("{0}{0}{0}", digit);
            Console.WriteLine("{0} {0}", digit);
            Console.WriteLine("{0} {0}", digit);
            Console.WriteLine("{0} {0}", digit);
            Console.WriteLine("{0}{0}{0}", digit);


            Console.ReadKey();
        }
    }
}
