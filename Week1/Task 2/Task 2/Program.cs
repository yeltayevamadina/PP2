using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    {
        class Student
        {
            string name;
            string id;
            public Student(string n, string g)
            {
               
                name = n;
                id = g;
            }
            public void PrintInfo()
            {
                Console.WriteLine(name + " " + id + " ");
            }
        }

        class Master : Student
        {
            int year;
            public Master(string n, string g, int t) : base(n, g)
            {
                year = t;
            }
            public void PrintInfo2()
            {
                base.PrintInfo();
                Console.WriteLine(year);
            }
        }

        class Program1
        {
            static void Main(string[] args)
            {
                
                string name = Console.ReadLine();
                string id = Console.ReadLine();
                int year = Convert.ToInt32(Console.ReadLine());
                Student s = new Student(name, id);
                Master m = new Master(name,id, year);

                m.PrintInfo2();
                Console.ReadLine();
            }
        }
    }
}
