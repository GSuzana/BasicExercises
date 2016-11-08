using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicExercises
{
    class Exercise4
    {
        static void Main(string[] args)
        {

            //Write a C# Sharp program to swap two numbers.

            int nr1, nr2, aux;
            Console.WriteLine("The first number is ");
            nr1 = int.Parse(Console.ReadLine());
            Console.WriteLine("The second number is ");
            nr2 = int.Parse(Console.ReadLine());
            aux = nr1;
            nr1 = nr2;
            nr2 = aux;
            Console.WriteLine("\nAfter swapping: \nThe first number is " + nr1 + "\nThe second number is " + nr2);

            Console.ReadKey();
        }
    }
}
