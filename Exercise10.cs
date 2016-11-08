using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicExercises
{
    class Exercise10
    {
        static void Main(string[] args)
        {
            //Write a C# Sharp program to that takes three numbers(x,y,z) as input and 
            //print the output of (x+y)·z and x·y + y·z.

            int x, y, z, res1, res2;
            Console.WriteLine("Enter the first number: ");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            y = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the third number: ");
            z = int.Parse(Console.ReadLine());
            res1 = (x + y) * z;
            res2 = x * y + y * z;
            Console.WriteLine("For given numbers {0}, {1} and {2}: \n (x+y)·z = {3} and x·y + x·z = {4}", x, y, z, res1, res2);

            Console.ReadKey();
        }
    }
}
