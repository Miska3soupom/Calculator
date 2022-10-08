using System;
using System.Numerics;
using System.Security.Cryptography;

namespace Игры_и_игрушки
{
    class Program
    {
        static void Main(string[] args)
        { 

            Console.WriteLine("Добрый день!\nВыберете приложение из списка:\n  1: Игра \"Угадай число\"\n  2: Таблица умножения\n" +
            "  3: Вывод делителей числа\n  4: Выход из программы");
            while (true)
            {
                int vibor = Convert.ToInt32(Console.ReadLine());
                switch (vibor)
                {
                    case 1: string answer = Game(); Console.WriteLine(answer);
                    Console.WriteLine(); break;
                    case 2: Tabl(); break;
                    case 3: Meth(); break;
                    case 4: Console.WriteLine("Спасибо за участие!"); return;
                    default:
                        Console.WriteLine("Неправильный выбор.\nПорпобуйте снова\n");break;
                }
                Console.WriteLine("Выберете ещё одно дейсвтие:\n  1: Игра \"Угадай число\"\n  2: Таблица умножения\n" +
                    "  3: Вывод делителей числа\n  4: Выход из программы");
            }
        }
        static string Game()
        {
            Console.WriteLine("Попробуйте угадать число от 1 до 100");
            Random chislo = new Random();
            int rd_ch = chislo.Next(0, 101);
            int my = Convert.ToInt32(Console.ReadLine());
            while (my != rd_ch)
            {
                Console.WriteLine("Вы не угадали");
                if (my < rd_ch)
                {
                    Console.WriteLine("Загадонное число больше");
                }
                else
                {
                    Console.WriteLine("Загадонное число меньше");
                }
                my = Convert.ToInt32(Console.ReadLine());
            }
            string answer = "Поздравляю! Вы угадали)";
            return answer;
        }
        static void Tabl()
        {
            Console.WriteLine("Таблица умножения: ");
            int[,] Schert = new int[10, 10];
            for (int i = 1; i < 10; i++)
            {
                for (int o = 1; o < 10; o++)
                {
                    Schert[i, o] = i * o;
                    Console.Write(Schert[i, o] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }  
        static void Meth()
        {
                Console.WriteLine("Введите своё число: ");
                int delimoe = Convert.ToInt32(Console.ReadLine());
                int chastnoe;
                for (int i = 1; i != delimoe + 1; i++)
                {
                    chastnoe = delimoe % i;
                    if (chastnoe == 0)
                    {
                        Console.Write($"\b\t{i}");
                    }
                }
            Console.WriteLine();
        }
    }
}
