using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicExercises
{
    class Exercise9
    {
        static void Main(string[] args)
        {
            //Write a C# Sharp program that takes four numbers as input to calculate
            //and print the average.

            double num1, num2, num3, num4;
            Console.WriteLine("Enter the first number: ");
            num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            num2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the third number: ");
            num3 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the fourth number: ");
            num4 = double.Parse(Console.ReadLine());
            double med = (num1 + num2 + num3 + num4) / 4;
            Console.WriteLine("The average of {0},{1},{2},{3} is: {4}", num1, num2, num3, num4, med);

            Console.ReadKey();
        }
    }
}
