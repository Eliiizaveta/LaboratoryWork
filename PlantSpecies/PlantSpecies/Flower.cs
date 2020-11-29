using System;
using System.Collections.Generic;
using System.Text;

namespace PlantSpecies
{
    class Flower<T> : Plant
    {
        public string name;
        public int age;
        public T index;

        public Flower(string name, int age) : base(name, age)
        {
        }
        public Flower(string name, int age, T index) : base(name, age)
        {
            this.index = index;
        }
        public override void Grow()
        {
            Console.WriteLine("Цветок подрос");
        }
        public void Rename(string name)
        {
            this.name = name;
            Console.WriteLine("Новое имя цветка: "+name);
        }

        public override string ToString()
        {
            return string.Format("Индекс цветка {0}", this.index);
        }
    }
}
