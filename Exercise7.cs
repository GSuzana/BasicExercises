using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicExercises
{
    class Exercise6
    {
        static void Main(string[] args)
        {

            //Write a C# Sharp program to print on screen the output of adding, subtracting, multiplying 
            //and dividing of two numbers which will entered by the user.

            int number1, number2;
            Console.WriteLine("Input the first number: ");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the second number: ");
            number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Expected output:");
            Console.WriteLine("{0} + {1} == " + (number1 + number2), number1, number2);
            Console.WriteLine("{0} - {1} == " + (number1 - number2), number1, number2);
            Console.WriteLine("{0} * {1} == " + (number1 * number2), number1, number2);
            Console.WriteLine("{0} / {1} == " + (number1 / number2), number1, number2);
            Console.WriteLine("{0} mod {1} == " + (number1 % number2), number1, number2);

            Console.ReadKey();
        }
    }
}
