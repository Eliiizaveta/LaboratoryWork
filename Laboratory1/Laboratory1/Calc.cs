using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratory1
{
    class Calc
    {
        public void Сalculate()
        {
            float one = 0;
            float two = 0;
            char operation;

            Console.Write("Введите первое число: ");
            one = float.Parse(Console.ReadLine());

            Console.Write("Введите второе число: ");
            two = float.Parse(Console.ReadLine());

            Console.Write("Введите операцию: ");

            operation = char.Parse(Console.ReadLine());

            switch (operation)
            {
                case '+':
                    Console.WriteLine("Результат операции: " + (one + two)); break;
                case '-':
                    Console.WriteLine("Результат операции: " + (one - two)); break;
                case '*':
                    Console.WriteLine("Результат операции: " + (one * two)); break;
                case '/':
                    Console.WriteLine("Результат операции: " + (one / two)); break;

                default:
                    {
                        Console.WriteLine("Ошибка!");
                    }
                    break;
            }

        }
    }
}
