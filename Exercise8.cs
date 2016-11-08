using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicExercises
{
    class Exercise7
    {
        static void Main(string[] args)
        {
            //Write a C# Sharp program that takes a number as input and print its multiplication table. 

            int nr;
            Console.WriteLine("\n8. Enter the number: ");
            nr = int.Parse(Console.ReadLine());
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(nr + "+" + i + "=" + (nr * i));
            }

            Console.ReadKey();
        }
    }
}
