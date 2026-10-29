using System;
using System.Xml.Linq;
namespace DZ6_Latypova.Classes
{
    // Класс животных, наследуется от живых организмов
    public abstract class Animal : LivingOrganism
    {
        private string _habitat;

        public string Habitat
        {
            get { return _habitat; }
            set { _habitat = value; }
        }

        public Animal() : base()
        {
            Habitat = "Неизвестная среда обитания";
        }

        public Animal(string name, int age, double height, string habitat) : base(name, age, height)
        {
            _habitat = habitat;
        }

        // Животные издают звуки
        public abstract void MakeSound();

        // Переопределяет рост
        public override void Grow()
        {
            Console.WriteLine($"{Name} растет и набирает вес");
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Среда обитания: {Habitat}");
        }
    }
}
