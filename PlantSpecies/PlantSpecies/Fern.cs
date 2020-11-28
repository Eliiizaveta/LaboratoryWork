using System;
using System.Collections.Generic;
using System.Text;

namespace PlantSpecies
{
    class Fern : Plant
    {
        public string color;
        public Fern(string name, int age) : base(name, age)
        {
        }
        public override void Grow()
        {
            Console.WriteLine("Папоротник подрос");
        }
    }
}
