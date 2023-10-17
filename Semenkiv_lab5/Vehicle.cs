using System;


namespace Laba5_V_11
{
    /// <summary>
    /// Класс средство передвижения
    /// </summary>
    public class Vehicle
    {
        private double _speed;
        private string _manufacturerBrand;
        private string _manufacturerCountry;
        private bool _iSLicense;
        private int _yearRelease;

        public Vehicle(double speed, string manufacturerBrand, string mamanufacturerCountry, bool iSLicense, int yearRelease)
        {
            Speed = speed;
            ManufacturerBrand = manufacturerBrand;
            MamanufacturerCountry = mamanufacturerCountry;
            ISLicense = iSLicense;
            YearRelease = yearRelease;
        }


        /// <summary>
        /// Свойство скорости(_speed), возвращает ArgumentOutOfRangeException, когда пытаемся присвоить отрицательное значение
        /// </summary>
        public double Speed
        {
            get => _speed;
            set
            {
                if (value > 0)
                {
                    _speed = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }               
            }
        }

        /// <summary>
        /// Свойство бренд производителя(_manufacturerBrand), возвращает ArgumentNullException, когда пытаемся присвоить пустую строку 
        /// </summary>
        public string ManufacturerBrand
        {
            get => _manufacturerBrand;
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _manufacturerBrand = value;

                }
                else
                {
                    throw new ArgumentNullException();
                }

            }

        }
        /// <summary>
        /// Свойство страна производителя(_manufacturerCountry), возвращает ArgumentNullException, когда пытаемся присвоить пустую строку 
        /// </summary>
        public string MamanufacturerCountry
        {
            get => _manufacturerCountry;
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _manufacturerCountry = value;

                }
                else
                {
                    throw new ArgumentNullException();
                }

            }

        }
        /// <summary>
        /// Свойстов на наличие лицензии(_iSLicense)
        /// </summary>
        public bool ISLicense { get => _iSLicense; set => _iSLicense = value; }
        /// <summary>
        /// Свойстов год выпуска, возвращает ArgumentOutOfRangeException, когда пытаемся присвоить некорректный год
        /// </summary>
        public int YearRelease {
            get => _yearRelease;
            set { 
                if(value>0 && value <= DateTime.Now.Year)
                {
                    _yearRelease = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            } 
        }
        public override string ToString()
        {
            return "Vehicle\nmanufacturer brand=" + ManufacturerBrand+ ";manufacturer country="+ 
                MamanufacturerCountry +"; year of release="+YearRelease+";have license="+ISLicense+";speed="+Speed+"\n";
        }

    }
}
