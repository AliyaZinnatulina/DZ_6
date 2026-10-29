using System;
namespace DZ6_Latypova.Classes
{
    public class LivingOrganism
    {
        private string _name;
        private int _age;
        private double _height;

        // Свойства
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Age
        {
            get { return _age; }
            set
            {
                if (value < 0) throw new ArgumentException("Возраст не может быть отрицательным");
                _age = value;
            }
        }

        public double Height
        {
            get { return _height; }
            set { _height = value; }
        }

        // Конструкторы
        public LivingOrganism()
        {
            Name = "Неизвестный живой организм";
        }

        public LivingOrganism(string name, int age, double height)
        {
            Name = name;
            Age = age;
            Height = height;
        }

        public virtual void Grow()
        {
            Console.WriteLine($"{Name} растёт");
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine($"Живой организм: {Name}\nВозраст: {Age} лет\nРост: {Height} м");
        }
    }
}
