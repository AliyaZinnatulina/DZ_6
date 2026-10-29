using System;
using DZ6_Latypova.Classes;

namespace DZ6_Latypova
{
    internal class Program
    {
        // Задание №1
        static void Exercise1()
        {
            Console.WriteLine("Задание №1. Заповедник");

            Tiger tiger = new Tiger("Раджа", 5, 1, "Джунгли", 130);

            Plant baobab = new Plant("Баобаб", 1000, 25, "Дерево");

            Console.WriteLine("\tТигр");
            tiger.MakeSound();       
            tiger.Grow();            
            tiger.PrintInfo();       

            Console.WriteLine("\tБаобаб");
            baobab.Photosynthesize();   
            baobab.Grow();            
            baobab.PrintInfo();         
        }

        static void Main(string[] args)
        {
            Exercise1();
            Console.ReadKey();
        }
    }
}
