using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Student
    {
        struct student
        {
            public String sname, course, sid;
            public DateTime dob;
        }
        static void Main(string[] args)
        {
            student[] s = new student[2];
            for (int i = 0; i < 2; i++)
            {
                Console.Write("Enter name:");
                s[i].sname = Console.ReadLine();
                Console.Write("Enter id:");
                s[i].sid = Console.ReadLine();
                Console.Write("Enter cousre:");
                s[i].course = Console.ReadLine();
                Console.Write("enter date:");
                s[i].dob = Convert.ToDateTime(Console.ReadLine());
            }
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Name:" + s[i].sname);
                Console.WriteLine("Id:" + s[i].sid);
                Console.WriteLine("Course:" + s[i].course);
                Console.WriteLine("DOB:" + s[i].dob);
            }
            Console.ReadKey();
        }
    }
}
