using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, i, j, k;
            num = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= num; i++)
            {
                for (k = 1; k <= i; k++)
                    {
                        Console.Write("[*]");
                    }
                    Console.WriteLine();
            }
        }
    }
}

