using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Lab2
{
    class Program
    {
        static void Main()
        {
            string s;
            int attempts = 0;   //количество попыток 
            int i = 0;
            int kol;
            char[] ran = {'а','б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и',
            'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц',
            'ч', 'ш', 'щ', 'ы', 'э', 'ю', 'я'};
            int buf = 0;
            Console.Write($"Введите слово состоящее из 4 букв и начинающиеся на {ran[buf]}:  ");// меняется заглавная буква
            s = Console.ReadLine();
            while (!String.IsNullOrEmpty(s)||(buf==31))
            {
                if ((s.Length == 4) && (s[0] == ran[buf]))// число должно быть 4 значным и начинающиеся на заглавные буквы которые указаны
                {
                    i++;//посчет праивльных ответов
                }
                attempts++;//кол-во попыток
                buf++;//чередование букв по алфавиту
                Console.Write($"Введите слово состоящее из 4 букв и начинающиеся на {ran[buf]}: ");
                s = Console.ReadLine();
            }
            kol =  i * 100 / 31;//Количество баллов
            Console.WriteLine("Количество попыток:" + attempts);
            Console.WriteLine("Количество правильных слов: " + i);
            Console.WriteLine("Количество баллов:" + kol);
            Console.ReadLine();
        }
    }
}

