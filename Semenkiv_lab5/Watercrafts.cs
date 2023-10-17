using System;


namespace Laba5_V_11
{
    /// <summary>
    /// Класс где хранится массив плавательных средств
    /// </summary>
    public class Watercrafts
    {

        private Watercraft[] _watercrafts;
        /// <summary>
        /// инициализация массива с помощью елементов или с нулевой длиной 
        /// </summary>
        /// <param name="watercrafts">елементы вставляемые в массив</param>
        public Watercrafts(params Watercraft[] watercrafts)
        {
            if (watercrafts is not null)
            {
                _watercrafts = watercrafts;
            }
            else
            {
                _watercrafts = new Watercraft[0];
            }
        }
        /// <summary>
        /// добавление елемента в конец массива
        /// </summary>
        /// <param name="watercraft">елемент для добавления в массив</param>
        public void Add(Watercraft watercraft)
        {
            Array.Resize(ref _watercrafts, _watercrafts.Length + 1);
            _watercrafts[_watercrafts.Length - 1] = watercraft;
        }
        /// <summary>
        /// удаления елемента массива по индексу, возвращает ArgumentOutOfRangeException, если некоректный индекс(indexRemove)
        /// </summary>
        /// <param name="indexRemove">индекс удаляемого обьекта</param>
        public void RemoveByIndex(int indexRemove)
        {
            if (indexRemove >= 0 && indexRemove < _watercrafts.Length)
            {
                Watercraft[] newWatercrafts = new Watercraft[_watercrafts.Length - 1];
                for (int i = 0, j = 0; i < _watercrafts.Length; i++)
                {
                    if (i != indexRemove)
                    {
                        newWatercrafts[j] = _watercrafts[i];
                        j++;
                    }
                }
                _watercrafts = newWatercrafts;
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }

        }
        /// <summary>
        /// обновление елемента по индексу , возвращает ArgumentOutOfRangeException, если некоректный индекс(indexUpdate)
        /// </summary>
        /// <param name="newWatercraft"> новый елемент</param>
        /// <param name="indexUpdate">индекс куда обновляемого елемента</param>
        public void UpdateByIndex(Watercraft newWatercraft, int indexUpdate)
        {
            if (indexUpdate >= 0 && indexUpdate < _watercrafts.Length)
            {
                _watercrafts[indexUpdate] = newWatercraft;
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }

        }

        public override string ToString()
        {
            String result = "";
            foreach (Watercraft watercraft in _watercrafts)
            {
                result += watercraft + "\n";
            }
            return result;
        }
    }
}
