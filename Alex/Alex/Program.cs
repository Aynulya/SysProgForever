using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Alex                   //При запуске нажимайте на Enter до тех
{                                //пор, пока программа не остановится.
    class Program
    {
        static void Integral(int a, int b)
        {
            double x = 0, y = 0, s = 0, I = 0, h = 0.0001;
            for (x = a; x <= b; x = x + h)
            {
                y = Math.Sqrt(1 - x * x);
                s += y;
            }
            I = h * s;
            Console.WriteLine(I);
        }
        static void SortirovkaMassiva(int[] a)
        {
            int i, j, x;
            for (i = 0; i < a.Length; i++)
            {
                for (j = 0; j < a.Length; j++)
                {
                    if (a[i] < a[j])
                    {
                        x = a[i];
                        a[i] = a[j];
                        a[j] = x;
                    }
                }
            }
            for (i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();
        }
        static string Reverse(string s)
        {
            string r = null;
            for (int i = s.Length - 1; i >= 0; i--)
            {
                r += s[i];
            }
            return r;
        }
        static int ProstoeChisloBolsheZadannogo(int a)
        {
            int b, k, p;
            k = 0;
            p = a;
            while (true)
            {
                p++;
                a = p;
                b = p;
                for (; a >= 1; a--)
                {
                    if (b % a == 0) k++;
                }
                if (k == 2) break;
                else k = 0;
            }
            return b;
        }
        static void Main(string[] args)
        {
            //Вычисление интеграла под кривой в интервале от -1 до 1.
            Integral(-1, 1);
            Console.ReadLine();
            //Сортировка массива.
            int[] m = { 10, 6, 2, 7, 8, 5, 1, 3, 4, 9, 0 };
            SortirovkaMassiva(m);
            Console.ReadLine();
            //Вывод строки задом наперед.
            string s;
            s = "Hello World, the most beautiful world ever";
            Console.WriteLine(Reverse(s));
            Console.ReadLine();
            //Минимальное простое число больше заданного.
            int a;
            a = 11;
            Console.WriteLine(ProstoeChisloBolsheZadannogo(a));
            Console.ReadLine();
        }
    }
}
