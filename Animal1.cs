using System;

namespace _1pr
{
    class Animal
    {
        protected string name;
        protected int age;

        public Animal(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public virtual void Info()
        {
            Console.WriteLine($"Це тварина {name}, їй {age} літ.");
        }
    }

    class Cat : Animal
    {
        public string Breed { get; set; }
        public string Illness { get; set; }

        public Cat(string name, int age, string breed, string illness)
            : base(name, age)
        {
            Breed = breed;
            Illness = illness;
        }

        public override void Info()
        {
            Console.WriteLine($"Це кішка {name}, їй {age} літ. Порода {Breed}, Хвороба {Illness}.");
        }

        public void ShowBreedAndName()
        {
            Console.WriteLine($"Ця кішка {Breed}. Її звуть {name}.");
        }

        public void AnalyzeIllness(string stage)
        {
            switch (stage.ToLower())
            {
                case "тяжка":
                    Console.WriteLine("Хвороба тяжка. Потрібна операція.");
                    break;
                case "середньої тяжкості":
                    Console.WriteLine("Хвороба середня. Потрібно лікування у клініці.");
                    break;
                case "легка":
                    Console.WriteLine("Хвороба легка. Лікуйте кішку дома.");
                    break;
                default:
                    Console.WriteLine("Помилка. Введіть правильно ступінь хвороби.");
                    break;
            }
        }
    }

    class Dog : Animal
    {
        public string Illness { get; set; }
        public string Tiazhkist { get; set; }

        public Dog(string name, int age, string illness, string tiazhkist)
            : base(name, age)
        {
            Illness = illness;
            Tiazhkist = tiazhkist;
        }

        public override void Info()
        {
            Console.WriteLine($"Це собака {name}, їй {age} літ. Хвороба {Illness}, Тяжкість - {Tiazhkist}.");
        }

        public void AnalyzeIllness()
        {
            switch (Tiazhkist.ToLower())
            {
                case "тяжка":
                    Console.WriteLine("Хвороба тяжка. Потрібна операція.");
                    break;
                case "середньої тяжкості":
                    Console.WriteLine("Хвороба середня. Потрібно лікування у клініці.");
                    break;
                case "легка":
                    Console.WriteLine("Хвороба легка. Лікуйте собаку дома.");
                    break;
                default:
                    Console.WriteLine("Помилка. Введіть правильно ступінь хвороби.");
                    break;
            }
        }
    }
}