using System;

namespace PlantSpecies
{
    class Program
    {
        static void Main(string[] args)
        {
            Fern fern1 = new Fern("Аспелениум", 10);
            Moss moss1 = new Moss("Риччия", 70);
            Flower flower1 = new Flower("Лилия", 3);
            fern1.Grow();
            moss1.Grow();
            flower1.Grow();
            flower1.Rename("Роза");
        }
    }
}
