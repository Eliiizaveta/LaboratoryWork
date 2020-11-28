using System;
using System.Collections.Generic;
using System.Text;

namespace PlantSpecies
{
    class Moss : Plant
    {
        public Moss(string name, int age) : base(name, age)
        {
        }
        public override void Grow()
        {
            Console.WriteLine("Мох подрос");
        }
    }
}
