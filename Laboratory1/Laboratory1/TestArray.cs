using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratory1
{
    class TestArray
    {
        public int[] BubbleSort(int[] mas)
        {
            int a;
            for (int i = 0; i < mas.Length; i++)
            {
                for (int j = i + 1; j < mas.Length; j++)
                {
                    if (mas[i] > mas[j])
                    {
                        a = mas[i];
                        mas[i] = mas[j];
                        mas[j] = a;
                    }
                }
            }
            return mas;
        }
    }
}
