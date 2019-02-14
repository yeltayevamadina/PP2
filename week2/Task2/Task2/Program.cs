using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Task2
{
    class Program
    {
        private static bool F2(int x)
        {
            if (x == 1 || x == 0)
                return false;
            for (int i = 2; i <= Math.Sqrt(x); i++)
                if (x % i == 0)
                    return false;
            return true;
        }
        static void Main(string[] args)
        {
                StreamReader sr = new StreamReader(@"C:\Users\1\source\repos\week2\Task2\TextFile1.txt");
                string[] numbers = sr.ReadToEnd().Split();
            List<int> Vector = new List<int>();
            for (int i = 0; i < numbers.Length; i++)
                if (F2(int.Parse(numbers[i])))
                    Vector.Add(int.Parse(numbers[i]));
                StreamWriter sw = new StreamWriter(@"C:\Users\1\source\repos\week2\Task2\TextFile2.txt");
                foreach(int x in Vector)
                sw.Write(x + " ");
            sw.Close();
            
        }
    }
}

