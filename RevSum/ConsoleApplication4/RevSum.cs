using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication4
{
    class RevSum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("reverse the number");
            int num = Convert.ToInt32(Console.ReadLine());
            int rem, sum = 0;
            while (num >= 1)
            {
                rem = num % 10;
                num = num / 10;
                Console.Write(rem);
                sum = sum + rem;

            }
            Console.WriteLine(" And sum is " + sum);

            Console.ReadLine();
        }
    }
}
