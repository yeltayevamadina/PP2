using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static bool isP(int x) // функция возвращает true если число простое,false если нет
        {
            int cnt = 0;
            for(int i=1;i<=x;++i)
            {
                if (x % i == 0) cnt++;
            }
            return cnt == 2; //простые числа это числа у которых два делителя
        }
        static void Main(string[] args)
        {
            int n;
            n = Convert.ToInt32(Console.ReadLine());//конвертирование из строки в цифры 
            int[] d = new int[n]; //создание массива
            string[] nm = Console.ReadLine().Split(); //читаю строку и разделяю ее пробелами
            string ans = "";
            int cnt = 0;
            for(int i=0;i<n;++i)
            {
                d[i] = Convert.ToInt32(nm[i]);
                if(isP(d[i])==true)
                {
                    cnt++;//если число простое то счетчик = счетчик +1 
                          /*  if (cnt == 1) //чтобы перед выбором не было
                            {
                                ans = Convert.ToString(d[i]);
                            }
                            else
                            {
                                ans = ans + " " + Convert.ToString(d[i]);
                            }*/
                    ans = ans+ d[i] + ' ';
                }
            }
            Console.WriteLine(cnt); //кол-во
            Console.WriteLine(ans); // простые числа
        }
     }


}

    
