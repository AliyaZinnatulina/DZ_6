using System;
using System.Xml.Linq;
namespace DZ6_Latypova.Classes
{
    // Класс растений, наследуется от живых организмов
    public class Plant : LivingOrganism
    {
        private string _type;

        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }

        public Plant() : base()
        {
            Type = "Трава";
        }

        public Plant(string name, int age, double height, string type) : base(name, age, height)
        {
            _type = type;
        }

        // Фотосинтез растений
        public void Photosynthesize()
        {
            Console.WriteLine($"{Name} поглощает солнечный свет");
        }

        // Переопределяет рост
        public override void Grow()
        {
            Console.WriteLine($"{Name} тянется вверх к солнцу");
        }
    }
}
