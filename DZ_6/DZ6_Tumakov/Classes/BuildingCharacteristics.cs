using DZ6_Tumakov.Enums;
using System;
namespace DZ6_Tumakov.Classes
{
    public class BuildingCharacteristics
    {
        private int _uniqueNumber;
        private byte _height;
        private byte _storeysCount;
        private int _apartmentCount;
        private byte _entranceCount;
        private static int _uniqueNumberBuilding = 0;

        public BuildingCharacteristics()
        {
            _uniqueNumber = GenerateIUniqueNumberBuilding();
        }

        /// <summary>
        /// Статический метод, который увеличивает счетчик и возвращает уникальный номер
        /// </summary>
        /// <returns>Новый уникальный номер</returns>
        private static int GenerateIUniqueNumberBuilding()
        {
            ++ _uniqueNumberBuilding;
            return _uniqueNumberBuilding;
        }

        public int UniqueNumber
        {
            get { return _uniqueNumber; }
        }

        public byte Height
        {
            get { return _height; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Высота здания не может быть отрицательной");
                }
                _height = value;
            }
        }

        public byte StoreysCount
        {
            get { return _storeysCount; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Количество этажей не может быть отрицательным");
                }
                _storeysCount = value;
            }
        }

        public int ApartmentCount
        {
            get { return _apartmentCount; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Количество квартир не может быть отрицательным");
                }
                _apartmentCount = value;
            }
        }

        public byte EntranceCount
        {
            get { return _entranceCount; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Количество подъездов не может быть отрицательным");
                }
                _entranceCount = value;
            }
        }

        /// <summary>
        /// Вычисляет высоту одного этажа
        /// </summary>
        /// <returns>Высота этажа</returns>
        public double CalculateStoreyHeight()
        {
            return Math.Round((double)Height / StoreysCount, 2);
        }

        /// <summary>
        /// Вычисляет количество квартир в одном подъезде
        /// </summary>
        /// <returns>Квартир в подъезде</returns>
        public int CalculateApartmentsPerEntrance()
        {
            return ApartmentCount / EntranceCount;
        }

        /// <summary>
        /// Вычисляет количество квартир на одном этаже
        /// </summary>
        /// <returns>Квартир на этаже</returns>
        public int CalculateApartmentsPerStorey()
        {
            return ApartmentCount / (StoreysCount * EntranceCount);
        }

        /// <summary>
        /// Выводит характеристику (описание) здания
        /// </summary>
        public void PrintBuildingInfo()
        {
            Console.WriteLine($"Уникальный номер здания: {UniqueNumber}\nВысота здания: {Height}\nКоличество этажей (этажность): {StoreysCount}" +
                $"\nКоличество квартир: {ApartmentCount}\nКоличество подъездов: {EntranceCount}");
        }

    }
}
