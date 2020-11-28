using System;
using System.Collections.Generic;
using System.Text;

namespace PlantSpecies
{
    class Flower : Plant
    {
        string name;
        public int age;
        public Flower(string name, int age) : base(name, age)
        {
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
    }
}
