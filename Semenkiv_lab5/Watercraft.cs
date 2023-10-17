using System;

namespace Laba5_V_11
{
    /// <summary>
    /// Класс плавательное средство
    /// </summary>
    public class Watercraft
    {
        private readonly int MAX_COUNT_PEOPLE = 1000;
        private readonly int MAX_COUNT_MOTORS = 10;
        private Vehicle _vehicle;
        private int _countMotors;
        private int _maxCountPeople;

        public Watercraft(double speed, string manufacturerBrand, string mamanufacturerCountry, bool iSLicense, int yearRelease,int maxCountPeople, int countMotors)
        {
            MaxCountPeople = maxCountPeople;
            CountMotors = countMotors;
            Vehicle = new Vehicle(speed,manufacturerBrand,mamanufacturerCountry,iSLicense,yearRelease);
        }

        /// <summary>
        /// Свойстов максимальное количество людей вмещаемых на судно (_maxCountPeople), возвращает ArgumentOutOfRangeException, 
        /// когда пытаемся присвоить отрицательное значение или меньше допустимого  MAX_COUNT_PEOPLE
        /// </summary>
        public int MaxCountPeople { get => _maxCountPeople; 
            set
            {
                if (value > 0 && value < MAX_COUNT_PEOPLE)
                {
                    _maxCountPeople = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }
        /// <summary>
        /// Свойстов количество моторов у на судна (_countMotors), возвращает ArgumentOutOfRangeException, 
        /// когда пытаемся присвоить отрицательное значение или меньше допустимого MAX_COUNT_MOTORS
        /// </summary>
        public int CountMotors
        {
            get => _countMotors;
            set
            {
                if (value > 0 && value < MAX_COUNT_MOTORS)
                {
                    _countMotors = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }
        /// <summary>
        /// СВойстов про основные характеристики данного средства передвижения
        /// </summary>
        public Vehicle Vehicle { get => _vehicle; set => _vehicle = value; }
        public override string ToString()
        {
            return Vehicle+ "Watercraft\nmaximum count of people accommodated ="+MaxCountPeople+";count motors="+CountMotors+"\n";
        }
    }
}
