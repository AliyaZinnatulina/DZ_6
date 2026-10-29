using System;
namespace DZ6_Latypova.Classes
{
    // Класс тигра, наследуется от животных и живых организмов
    public class Tiger : Animal
    {
        private int _stripesCount;

        public int StripesCount
        {
            get { return _stripesCount; }
            set { _stripesCount = value; }
        }

        public Tiger() : base()
        {
            StripesCount = 100;
        }

        public Tiger(string name, int age, double height, string habitat, int stripesCount) : base(name, age, height, habitat)
        {
            _stripesCount = stripesCount;
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} рычит: Ррррр!");
        }

        public override void Grow()
        {
            Console.WriteLine($"Тигр {Name} стал больше и сильнее");
        }
    }
}
