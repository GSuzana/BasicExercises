using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicExercises
{
    class Exercise11
    {
        static void Main(string[] args)
        {
            //Write a C# Sharp program that takes age (for example 20) as input and print
            //something as "You look older than 20".

            int age;
            Console.WriteLine("Enter the age: ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You look older than {0}", age);

            Console.ReadKey();
        }
    }
}
