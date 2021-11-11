using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication3
{
    class Prime
    {
        static void Main(string[] args)
        {

            int prime = 0;
            int i;
            Console.WriteLine("Enter a number:");
            int a = Convert.ToInt32(Console.ReadLine());
            for (i = 2; i < a / 2; i++)
            {
                if (a % i == 0)
                {
                    prime = 1;
                }
            }
            if (prime == 0)
            {
                Console.WriteLine("This is a prime number");
            }
            else
            {
                Console.WriteLine("This is not a prime number");
            }
            Console.ReadKey();
        }
    }
}
