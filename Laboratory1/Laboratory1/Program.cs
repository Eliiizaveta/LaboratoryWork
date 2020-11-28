using System;

namespace Laboratory1
{
    class Program
    {
        static void Main(string[] args)
        {
                Console.Write("Введите количество элементов массива: ");
                int n = int.Parse(Console.ReadLine());
                int[] mas = new int[n];
                for (int i = 0; i < n; i++)
                {
                    Console.Write("Введите arr[{0}] : ", i);
                    mas[i] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("Элементы массива:");
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine(mas[i]);
                }
                TestArray newTestArray = new TestArray();
                newTestArray.BubbleSort(mas);
                Console.WriteLine("После сортировки:");
                for (int i = 0; i < mas.Length; i++)
                {
                    Console.WriteLine(mas[i]);
                }
                Console.WriteLine();
                Console.WriteLine("Теперь калькулятор!");
                Console.WriteLine();
                Calc c1 = new Calc();
                c1.Сalculate();
        }
    }   
}

