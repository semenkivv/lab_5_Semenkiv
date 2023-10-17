using System;


namespace Laba5_V_11
{
    /// <summary>
    /// Класс Баржа унаследуется от плавотельного судна  
    /// </summary>
    public class Barge:Watercraft
    {
        private double _maximumCargoWeight;
        private double _maximumCargoSquare;
        private bool _isBusy;

        public Barge(double speed, string manufacturerBrand, string mamanufacturerCountry, bool iSLicense, int yearRelease, int maxCountPeople, int countMotors, double maximumCargoWeight, double maximumCargoSquare, bool isBusy) : base(speed, manufacturerBrand, mamanufacturerCountry, iSLicense, yearRelease, maxCountPeople, countMotors)
        {
            MaximumCargoSquare = maximumCargoSquare;
            MaximumCargoWeight = maximumCargoWeight;
            IsBusy = isBusy;
        }
        /// <summary>
        /// Свойство максимально допустимого веса перевозимого груза в тоннах(_maximumCargoWeight), возвращает ArgumentOutOfRangeException, когда пытаемся присвоить отрицательное значение
        /// </summary>
        public double MaximumCargoWeight
        {
            get => _maximumCargoWeight;
            set
            {
                if (value > 0)
                {
                    _maximumCargoWeight = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }
        /// <summary>
        /// Свойство максимально допустимая площадь  груза в м^2(_maximumCargoSquare), возвращает ArgumentOutOfRangeException, когда пытаемся присвоить отрицательное значение
        /// </summary>
        public double MaximumCargoSquare
        {
            get => _maximumCargoSquare;
            set
            {
                if (value > 0)
                {
                    _maximumCargoSquare = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }
        /// <summary>
        /// Свойстов занят ли перевозкой (_isBusy)
        /// </summary>
        public bool IsBusy { get => _isBusy; set => _isBusy = value; }
        public override string ToString()
        {
            return base.ToString() + "Barge\nmaximum permissible weight of transported cargo =" + MaximumCargoWeight + " tons; maximum permissible  square of transported cargo=" + MaximumCargoSquare + " m^2;is busy=" + IsBusy + ";\n";
        }
    }
}
