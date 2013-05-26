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

        static void Main(string[] args)
        {
            //Вычисление интеграла под кривой в интервале от -1 до 1.
            Integral(-1, 1);
            Console.ReadLine();
        }
    }
}
