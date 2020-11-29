using System;
using System.Collections.Generic;
using System.Text;

namespace PlantSpecies
{
    class Fern : Plant
    {
        public string color;

        public Fern(string name, int age, string color): base(name, age)
        {
            this.color = color;       
        }

        public override bool Equals(object obj)
        {
            return obj is Fern fern &&
                   color == fern.color;
        }

        public override void Grow()
        {
            Console.WriteLine("Папоротник подрос");
        }

        public override string ToString()
        {
            return string.Format("Цвет папоротника {0}",this.color);
        }
    }
}
