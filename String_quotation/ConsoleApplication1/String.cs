using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string:");
            string st = Console.ReadLine();
            string[] s1 = st.Split(' ');
            foreach(string i in s1)
            {
                Console.WriteLine("\""+i+"\"");
            }
            Console.ReadKey();
        }
    }
}
