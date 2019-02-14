using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = new FileStream(@"C:\Users\1\source\repos\Example.txt", FileMode.Create, FileAccess.ReadWrite);
      
            StreamWriter sw = new StreamWriter(fs);
            sw.Write("asdasd");

            FileStream fs1 = new FileStream(@"C:\Users\1\source\repos\path1\Example.txt", FileMode.Create);
            sw.Close();
            fs.Close();
            FileStream fs2 = new FileStream(@"C:\Users\1\source\repos\Example.txt", FileMode.Open);
            Console.ReadKey();
            fs2.CopyTo(fs1);
            fs1.Close();
            fs2.Close();
            File.Delete(@"C:\Users\1\source\repos\Example.txt");


        }
    }
}
