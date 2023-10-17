using System;


namespace Laba5_V_11
{
    /// <summary>
    /// Класс Яхта унаследуется от плавотельного судна  
    /// </summary>
    public class Yacht:Watercraft
    {
        private readonly int MAX_COUNT_SEILS = 10;
        private int _countSeils;
        private string _location;
        private bool _isHaveAnchor;



        public Yacht(double speed, string manufacturerBrand, string mamanufacturerCountry, bool iSLicense, int yearRelease, int maxCountPeople, int countMotors, int countSeils, string location, bool isHaveAnchor) : base(speed, manufacturerBrand, mamanufacturerCountry, iSLicense, yearRelease, maxCountPeople, countMotors)
        {
            CountSeils = countSeils;
            Location = location;
            IsHaveAnchor = isHaveAnchor;
        }



        /// <summary>
        /// Свойстов количество парусов  (_countSeils), возвращает ArgumentOutOfRangeException, 
        /// когда пытаемся присвоить отрицательное значение или меньше допустимого MAX_COUNT_SEILS
        /// </summary>
        public int CountSeils
        {
            get => _countSeils;
            set
            {
                if (value >= 0 && value < MAX_COUNT_SEILS)
                {
                    _countSeils = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }
        /// <summary>
        /// Свойство место нахождение (_location), возвращает ArgumentNullException, когда пытаемся присвоить пустую строку 
        /// </summary>
        public string Location
        {
            get => _location;
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _location = value;

                }
                else
                {
                    throw new ArgumentNullException();
                }

            }

        }
        /// <summary>
        /// Свойстов есть ли якорь (_isHaveAnchor)
        /// </summary>
        public bool IsHaveAnchor { get => _isHaveAnchor; set => _isHaveAnchor = value; }
        public override string ToString()
        {
            return base.ToString() + "Yacht\ncount seils=" + CountSeils + ";location=" + Location + ";have anchor=" + IsHaveAnchor + " ;\n";
        }
    }
}

