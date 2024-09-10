using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int s = 1;
            int a, b, c, d;
            Console.WriteLine("Введите 4 числа");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            d = Convert.ToInt32(Console.ReadLine());
            if ((a % 2 != 0) && (c % 2 != 0) && (b % 2 != 0) && (d % 2 != 0)) //все числа нечетные
            {
                s = a * b * c * d; //проиводение всех
                Console.SetCursorPosition(40, 5);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(s);
                Console.ResetColor();

            }
            else
            {
                if (a % 2 == 0) //проверка первого числа на четность
                {
                    Console.ForegroundColor = ConsoleColor.Yellow; //присваивание цвета

                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;//присваивание цвета

                }
                Console.SetCursorPosition(40, 5); // вывод по центру
                Console.WriteLine(a);
                Console.ResetColor();
                if (b % 2 == 0)//проверка второго числа на четность
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;//присваивание цвета

                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;//присваивание цвета
                }
                Console.SetCursorPosition(40, 6); // вывод по центру
                Console.WriteLine(b);
                Console.ResetColor();
                if (c % 2 == 0) //проверка третьего числа на четность
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;//присваивание цвета
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;//присваивание цвета
                }
                Console.SetCursorPosition(40, 7); // вывод по центру
                Console.WriteLine(c);
                Console.ResetColor();
                if (d % 2 == 0) //проверка четвертого числа на четность
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;//присваивание цвета
                }
                else
                {
                    Console.SetCursorPosition(40, 5);// вывод по центру
                    Console.ForegroundColor = ConsoleColor.Red;//присваивание цвета
                }
                Console.SetCursorPosition(40, 5);// вывод по центру
                Console.WriteLine(d);
                Console.ResetColor();
                Console.WriteLine();
            }
        }
    }
}


