using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Product
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the four Integer Value");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            int d = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("result = " + a * b * c * d);
            Console.ReadKey();
        }
    }
}
