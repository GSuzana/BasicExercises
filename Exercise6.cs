using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicExercises
{
    class Exercise5
    {
        static void Main(string[] args)
        {

            //Write a C# Sharp program to print the output of multiplication of three 
            //numbers which will entered by the user.

            int no1, no2, no3;
            Console.WriteLine("Input the first number to multiply: ");
            no1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Input the second number to multiply: ");
            no2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Input the third number to multiply: ");
            no3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Expected output: " + no1 + "*" + no2 + "*" + no3 + "=" + (no1 * no2 * no3));

            Console.ReadKey();
        }
    }
}
