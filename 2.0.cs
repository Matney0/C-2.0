using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Asks for grade
            Console.WriteLine("Enter a grade to be submitted:");
            //Stores grade
            int userGrade = int.Parse(Console.ReadLine());


            //If else to give user appropriate grade
            if (userGrade >= 89.5)
            {
                Console.WriteLine("Because your grade is:" + userGrade + ", You get an A!");
            }
            else if (userGrade >= 79.5 && userGrade < 89.5)
            {
                Console.WriteLine("Because your grade is:" + userGrade + ", You got a B!");
            }
            else if (userGrade >= 69.5 && userGrade < 79.5)
            {
                Console.WriteLine("Because your grade is:" + userGrade + ", You got a C!");
            }
            else if (userGrade >= 59.5 && userGrade < 69.5)
            {
                Console.WriteLine("Because your grade is:" + userGrade + ", You got a D!");
            }
            else if (userGrade < 59.5)
            {
                Console.WriteLine("Because your grade is less than 59.5, you get an F.");
            }
        }
    }
}

