using System;

namespace PlantSpecies
{
    class Program
    {
        static void Main(string[] args)
        {
            Fern fern1 = new Fern("Аспелениум", 10,"розовый");
            Fern fern2 = new Fern("Аспелениум", 20, "розовый");
            Fern fern3 = new Fern("Аспелениум", 20, "голубой");
            Moss moss1 = new Moss("Риччия", 70);
            Moss moss2 = new Moss("Риччия", 70);
            Flower<int> flower1 = new Flower<int>("Лилия", 3, 1);
            Flower<string> flower2 = new Flower<string>("Лилия", 3, "второй");
            Console.WriteLine(flower1.ToString());
            Console.WriteLine(flower2.ToString());
            fern1.Grow();
            moss1.Grow();
            flower1.Grow();
            flower1.Rename("Роза");
            Console.WriteLine(fern1.Equals(fern2));
            Console.WriteLine(fern1.ToString());
            Console.WriteLine(fern3.ToString());

        }
    }
}
