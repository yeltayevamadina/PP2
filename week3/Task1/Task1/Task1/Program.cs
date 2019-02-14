using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            //examplear class - punktagy zattardy kaytarady
            DirectoryInfo dir = new DirectoryInfo(@"C:/Users/1/source/repos/");
            // принтинфо метод
            PrintInfo(dir, 0);
        }

        static void PrintInfo(FileSystemInfo fsi, int k)
        { //part1
            FileSystemInfo[] arr = ((DirectoryInfo)fsi).GetFileSystemInfos();
            for (int i = 0; i < arr.Length; ++i)
            {
                if (i == k)
                {
                    Console.BackgroundColor = ConsoleColor.Red;

                }
                if (arr[i].GetType() == typeof(DirectoryInfo))
                {
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }
                Console.WriteLine((i + 1) + ". " + arr[i].Name);
                Console.ResetColor();
            }
            Console.WriteLine("R=rename, Backspace=delete, Enter=open, UpArrow and DownArrow = move");
            //Part2
            switch (Console.ReadKey().Key)
            {

                case ConsoleKey.UpArrow:
                    Console.Clear();
                    if (k == 0)
                    {
                        k = arr.Length - 1;
                    }
                    else
                    {
                        k--;
                    }
                    PrintInfo(fsi, k);
                    break;
                case ConsoleKey.DownArrow:
                    Console.Clear();
                    if (k == arr.Length - 1)
                    {
                        k = 0;
                    }
                    else {
                        k++;
                    }
                    PrintInfo(fsi, k);
                    break;
                // papka, file ashu   
                case ConsoleKey.Enter:
                    Console.Clear();
                    if (arr[k].GetType() == typeof(DirectoryInfo))
                    {
                        PrintInfo(arr[k], 0);
                    }
                    else
                    { // fail awu
                        using (FileStream stream = File.Open(arr[k].FullName, FileMode.Open))
                        {
                            byte[] b = new byte[1024];
                            UTF8Encoding temp = new UTF8Encoding(true);

                            while (stream.Read(b, 0, b.Length) > 0)
                            { 
                                // faildyn iwyndegy line
                                Console.WriteLine(temp.GetString(b));
                            }
                            Console.ReadKey();
                            stream.Close();
                            Console.Clear();
                            PrintInfo(fsi, k);
                        }
                    }
                    break;
                //Ketiru
                case ConsoleKey.Backspace:
                    if (arr[k].GetType() == typeof(DirectoryInfo))
                    {
                        ((DirectoryInfo)arr[k]).Delete(true);
                    }
                    else
                    {
                        arr[k].Delete();
                    }
                    Console.Clear();
                    PrintInfo(fsi, k);
                    break;
                //atyn ozgertu
                case ConsoleKey.R:
                    Console.Clear();
                    Console.WriteLine("Введите название");
                    string name = Console.ReadLine();
                    name += arr[k].Extension;
                    string names = arr[k].FullName;
                    name = names.Replace(arr[k].Name, name);
                    if (arr[k].GetType() == typeof(DirectoryInfo))
                    {
                        ((DirectoryInfo)arr[k]).MoveTo(name);
                    }
                    else
                    {
                        ((FileInfo)arr[k]).MoveTo(name);
                    }
                    Console.Clear();
                    PrintInfo(fsi, k);
                    break;
                case ConsoleKey.LeftArrow:
                    Console.Clear();
                    string dir = fsi.FullName;
                    string name1 = dir.Replace("\\"+fsi.Name, "");
                    PrintInfo(new DirectoryInfo(@name1), 0);
                    break; 
                default:
                    Console.Clear();
                    PrintInfo(fsi, k);
                    break;
            }
        }
    }
}
