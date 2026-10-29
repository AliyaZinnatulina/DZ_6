using DZ6_Tumakov.Classes;
using DZ6_Tumakov.Enums;
using System;
using System.Security.Principal;

namespace DZ6_Tumakov
{
    internal class Program
    {

        // Упражнения №7.1-7.3
        static void Exercise7()
        {
            Console.WriteLine("Упражнения №7.1-7.3");

            BankAccount account = new BankAccount();

            Console.Write("Введите баланс: ");
            bool isBalance = decimal.TryParse(Console.ReadLine(), out decimal balance);

            while (!isBalance)
            {
                Console.Write("Ошибка! Введите число: ");
                isBalance = decimal.TryParse(Console.ReadLine(), out balance);
            }
            account.Balance = balance;

            Console.Write("Введите тип банковского счёта: ");
            bool isType = Enum.TryParse(Console.ReadLine(), true, out AccountType accountType);

            while (!isType)
            {
                Console.Write("Ошибка! Введите тип банковского счёта (Текущий или Сберегательный): ");
                isType = Enum.TryParse(Console.ReadLine(), true, out accountType);
            }
            account.AccountType = accountType;

            account.PrintBankAccountInfo();

            Console.Write("Введите сумму, которую хотите снять со счёта: ");
            bool isWithDrawAmount = decimal.TryParse(Console.ReadLine(), out decimal WithDrawAmount);

            while (!isType)
            {
                Console.Write("Ошибка! Введите сумму, которую хотите снять, числом: ");
                isType = decimal.TryParse(Console.ReadLine(), out WithDrawAmount);
            }
            account.WithDraw(WithDrawAmount);

            Console.Write("Введите сумму, на которую хотите пополнить счёт: ");
            bool isDepositAmount = decimal.TryParse(Console.ReadLine(), out decimal DepositAmount);

            while (!isType)
            {
                Console.Write("Ошибка! Введите сумму пополнения числом: ");
                isType = decimal.TryParse(Console.ReadLine(), out DepositAmount);
            }
            account.Deposit(DepositAmount);
        }

        // Домашнее задание №7.1
        static void Homework71()
        {
            Console.WriteLine("Домашнее задание №7.1");

            BuildingCharacteristics build = new BuildingCharacteristics();

            Console.Write("Введите высоту здания (в метрах): ");
            bool isHeight = byte.TryParse(Console.ReadLine(), out byte height);

            while (!isHeight)
            {
                Console.Write("Ошибка! Введите число: ");
                isHeight = byte.TryParse(Console.ReadLine(), out height);
            }
            build.Height = height;

            Console.Write("Введите количество этажей в здании: ");
            bool isStoreys = byte.TryParse(Console.ReadLine(), out byte storeys);

            while (!isStoreys)
            {
                Console.Write("Ошибка! Введите число: ");
                isStoreys = byte.TryParse(Console.ReadLine(), out storeys);
            }
            build.StoreysCount = storeys;

            Console.Write("Введите количество квартир в здании: ");
            bool isApartment = int.TryParse(Console.ReadLine(), out int apartment);

            while (!isApartment)
            {
                Console.Write("Ошибка! Введите число: ");
                isApartment = int.TryParse(Console.ReadLine(), out apartment);
            }
            build.ApartmentCount = apartment;

            Console.Write("Введите количество подъездов в здании: ");
            bool isEntrance = byte.TryParse(Console.ReadLine(), out byte entrance);

            while (!isEntrance)
            {
                Console.Write("Ошибка! Введите число: ");
                isEntrance = byte.TryParse(Console.ReadLine(), out entrance);
            }
            build.EntranceCount = entrance;

            build.PrintBuildingInfo();

            Console.WriteLine($"Высота этажа: {build.CalculateStoreyHeight()} м\nКоличество квартир в подъезде: {build.CalculateApartmentsPerEntrance()}" +
                $"\nКоличество квартир на этаже: {build.CalculateApartmentsPerStorey()}");
        }

        static void Main(string[] args)
        {
            Exercise7();
            Homework71();
            Console.ReadKey();
        }
    }
}
