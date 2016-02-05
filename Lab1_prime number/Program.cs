using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_prime_number
{
    class Program
    {
        static void Main(string[] args)

        {
            bool prime;//объявляем логическую переменную 
            for (int i = 0; i < args.Length; i++)//прогбегаемся по циклу с 0 до максимальной длины
            {
                prime = true;//обозначим переменную как истина
                int x = int.Parse(args[i]);//конвертация строки в целое число
                if (x == 1 || x == 2) // если встречаются 1 или 2, то мы их сразу выводим
                {
                    Console.WriteLine(x);
                    continue;//продолжаем поиск всех простых чисел
                }

                for (int j = 2; j < x; j++)//пробегаемся по циклу с 2 до самого числа
                {
                    if (x % j == 0) prime = false;//если число делится на числа от 2 до самого числа, то число не является простым
                }
                if (prime == true) Console.WriteLine(x);//если переменная истина, то выводим все простые числа

            }


        }
    }
}
