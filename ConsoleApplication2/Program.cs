using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            Console.WriteLine("Enter Your Age :");
            age = int.Parse(Console.ReadLine());

            if (age>=18)
            {
                Console.WriteLine("eligible");
            }
            else
            {
                Console.WriteLine("Not eligible");
            }
            Console.ReadKey();
        }
    }
}
