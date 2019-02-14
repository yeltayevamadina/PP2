using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            //examplear class - punktagy zattardy kaytarady
            DirectoryInfo dir = new DirectoryInfo(@"C:/Users/1/source/repos/week2/Task1/Task1");
            // принтинфо метод
            PrintInfo(dir, 0);
            Console.ReadKey();
        }

        static void PrintInfo(FileSystemInfo fsi, int k)
        {
            string s = new string(' ', k);
            Console.WriteLine(s + fsi.Name);

            if (fsi.GetType() == typeof(DirectoryInfo))
            {
                FileSystemInfo[] arr = ((DirectoryInfo)fsi).GetFileSystemInfos();
                for (int i = 0; i < arr.Length; ++i)
                {
                    PrintInfo(arr[i], k + 3);
                }
            }
        }
    }
}

