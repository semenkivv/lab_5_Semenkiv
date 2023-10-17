using System;


namespace Laba5_V_11
{
    /// <summary>
    /// Класс Корабль унаследуется от плавотельного судна
    /// </summary>
    public class Ship:Watercraft
    {
        private string _type;
        private bool _isMilitary;
        private int _countDistanceTravel;

        public Ship(double speed, string manufacturerBrand, string mamanufacturerCountry, bool iSLicense, int yearRelease,int maxCountPeople,int countMotors,string type, bool isMilitary, int countDistanceTravel):base(speed,manufacturerBrand,mamanufacturerCountry,iSLicense,yearRelease,maxCountPeople,countMotors)
        {
            Type = type;
            IsMilitary = isMilitary;
            CountDistanceTravel = countDistanceTravel;
        }



        /// <summary>
        /// Свойство тип корабля(_type), возвращает ArgumentNullException, когда пытаемся присвоить пустую строку 
        /// </summary>
        private string Type
        {
            get => _type;
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _type = value;

                }
                else
                {
                    throw new ArgumentNullException();
                }

            }

        }
        /// <summary>
        /// Свойстов военный ли корабль(_isMilitary)
        /// </summary>
        private bool IsMilitary { get => _isMilitary; set => _isMilitary = value; }
        /// <summary>
        /// Свойство коколичевство пройденного пути в милях(_countDistanceTravel), возвращает ArgumentOutOfRangeException, когда пытаемся присвоить отрицательное значение
        /// </summary>
        private int CountDistanceTravel
        {
            get => _countDistanceTravel;
            set
            {
                if (value > 0)
                {
                    _countDistanceTravel = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }
        public override string ToString()
        {
            return base.ToString()+"Ship\ntype="+Type+ ";is military="+IsMilitary+ ";count distance travel="+CountDistanceTravel+" miles;\n";
        }
    }
}
