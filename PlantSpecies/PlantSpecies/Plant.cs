using System;
using System.Collections.Generic;
using System.Text;

namespace PlantSpecies
{
    abstract class Plant
    {
        string name;
        int age;

        protected Plant(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public virtual void Grow()
        {
            Console.WriteLine("Растение подросло");
        }
        
    }
}
