using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Vowel
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a character");
            Char n = Convert.ToChar(Console.ReadLine());
            if (n == 'a' || n == 'e' || n == 'i' || n == 'o' || n == 'u' || n == 'A' || n == 'E' || n == 'I' || n == 'O' || n == 'U')
            {
                Console.WriteLine( n + "is a vowel ");
            }
            else
            {
                Console.WriteLine(n + "is not a vowel ");
            }
            Console.ReadKey();
        }
    }
}
