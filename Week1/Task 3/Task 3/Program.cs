using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            n = Convert.ToInt32(Console.ReadLine());//конвертирование из строки в цифры 
            int[] d = new int[n]; //создание массива
            string[] nm = Console.ReadLine().Split(); //читаю строку и разделяю ее пробелами
            string ans ="";
            for (int i = 0; i < n; ++i)
            {
                d[i] = Convert.ToInt32(nm[i]);
                for (int j = 0; j < 2; j++)
                {
                    
                    Console.Write(d[i] + " ");
                }  
                    
                
            }
            Console.ReadKey();
        }
    }
}
