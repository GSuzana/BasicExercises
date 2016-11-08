using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicExercises
{
    class Exercise14
    {
        static void Main(string[] args)
        {
            //Write a C# program to convert from celsius degrees to Kelvin and Fahrenheit. 

            int degreeCelsius;
            Console.WriteLine("Enter the number of Celsius degree: ");
            degreeCelsius = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Kelvin: " + (degreeCelsius + 273));
            Console.WriteLine("Fahrenheit: " + (degreeCelsius * 18 / 10 + 32));


            Console.ReadKey();
        }
    }
}
