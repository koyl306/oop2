using System;

namespace _1pr
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Cat kitty = new Cat("Мурка", 3, "Сіамська", "Гастрит");
            kitty.Info();
            kitty.ShowBreedAndName();
            kitty.AnalyzeIllness("середньої тяжкості");

            Console.WriteLine();

            Dog doggy = new Dog("Барсик", 5, "Алергія", "легка");
            doggy.Info();
            doggy.AnalyzeIllness();

            Console.ReadLine();
        }
    }
}