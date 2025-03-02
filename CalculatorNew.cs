﻿using System.Linq.Expressions;
internal class Program
{
    private static void Main(string[] args)
    {
        int a;
        int b;
        Console.WriteLine("Введите операцию из списка:");
        Console.WriteLine("1. Сложить 2 числа\r\n2. Вычесть первое из второго\r\n3. Перемножить два числа\r\n4. Разделить первое на второе\r\n5. Возвести в степень N первое число\r\n6. Найти квадратный корень из числа\r\n7. Найти 1 процент от числа\r\n8. Найти факториал из числа\r\n9. Выйти из программы");
        int operation = Convert.ToInt32(Console.ReadLine());
        do
        {
            if (operation < 1 || operation > 9)
            {
                    Console.WriteLine("Некоректно введено число.\r\nПовторите попытку.");
                    Console.WriteLine("Введите операцию: ");
                    operation = Convert.ToInt32(Console.ReadLine());
            }
                switch (operation)
                {
                    case 1:
                        Console.WriteLine("Введите первое число: ");
                        a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Введите второе число: ");
                        b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ответ: " + (a + b));
                        Console.WriteLine("Введите ещё одну операцию: ");
                        operation = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 2:
                        Console.WriteLine("Введите первое число: ");
                        a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Введите второе число: ");
                        b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ответ: " + (b - a));
                        Console.WriteLine("Введите ещё одну операцию: ");
                        operation = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 3:
                        Console.WriteLine("Введите первое число: ");
                        a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Введите второе число: ");
                        b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ответ: " + a * b);
                        Console.WriteLine("Введите ещё одну операцию: ");
                        operation = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 4:
                        Console.WriteLine("Введите первое число: ");
                        a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Введите второе число: ");
                        b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ответ: " + a / b);
                        Console.WriteLine("Введите ещё одну операцию: ");
                        operation = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 5:
                        Console.WriteLine("Введите число: ");
                        a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Введите степень числа: ");
                        int N = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ответ: " + Math.Pow(a, N));
                        Console.WriteLine("Введите ещё одну операцию: ");
                        operation = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 6:
                        Console.WriteLine("Введите число: ");
                        a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ответ: " + Math.Sqrt(a));
                        Console.WriteLine("Введите ещё одну операцию: ");
                        operation = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 7:
                        Console.WriteLine("Введите число: ");
                        a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ответ: " + a / 100);
                        Console.WriteLine("Введите ещё одну операцию: ");
                        operation = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 8:
                        Console.WriteLine("Введите число: ");
                        a = Convert.ToInt32(Console.ReadLine());
                        int factorial = 1;
                        for (int i = 1; i <= a; i++)
                            factorial *= i;
                        Console.WriteLine("Ответ: " + factorial);
                        Console.WriteLine("Введите ещё одну операцию: ");
                        operation = Convert.ToInt32(Console.ReadLine());
                        break;
                }
        } while (operation != 9) ;
        Console.WriteLine("Вы прошли калькулятор!");
    }
}
