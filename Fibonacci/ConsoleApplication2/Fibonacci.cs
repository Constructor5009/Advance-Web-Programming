using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Fibonacci
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 1;
            int i = 1;
            int f;
            Console.Write(a);
            Console.Write(b);
            for (i = 1; i < 10; i++)
            {
                f = 1;
                a = b;
                b = f + b;
                Console.Write(b);
            }
            Console.ReadKey();
        }
    }
}
