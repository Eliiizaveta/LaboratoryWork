using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;

namespace Сollection
{
    class Program
    {
        static void Main(string[] args)
        {
            Books b1 = new Books(1, "Дюна", "Фантастика");
            Books b2 = new Books(2, "Мы", "Фантастика");
            Books b3 = new Books(3, "Горе от ума", "Классика");
            Books b4 = new Books(4, "Морской волк", "Приключения");
            Books b5 = new Books(5, "Зов предков", "Приключения");
            string x;
            List<Books> temp = new List<Books>() { b1, b2, b3, b4, b5 };
            List<Books> temp2 = temp.Where(x => x.genre == "Фантастика").ToList();

            Console.WriteLine("Введите целое число:");
            try
            {
               int a = int.Parse(Console.ReadLine()); 
               x = "Вы все сделали правильно";
            }
            catch (FormatException)
            {
                x = "Error!";
            }
            Console.WriteLine(x);
            Console.ReadLine();

        }
    }
}
