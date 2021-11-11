using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class ForEach
    {
        static void Main(string[] args)
        {
            string[] dept = new string[] { "BSC-IT", "BAF", "BBI" };
            foreach (string d in dept)
            {
                Console.WriteLine(d);
            }
            Console.ReadKey();
        }
    }
}
