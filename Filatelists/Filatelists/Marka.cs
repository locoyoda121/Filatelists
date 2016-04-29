using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filatelists
{
    class Marka
    {
        public string Country { set; get; } // страна
        public string Nominal { set; get; }  // номинальная цена
        public string Year { set; get; }  // год выпуска
        public string Tirage { set; get; }  // тираж
        public string Special { set; get; }   // особенности
        public double Id { set; get; } // Номар марки
        public Collector Coll { set; get; } // коллекционер
        public bool Part { set; get; } // Добавление/удаление марки
        public bool Change { set; get; } // Для именения марки
        public bool Show { set; get; } // Для показа опреденных марок
        public bool ShowMark { set; get; } // Для поиска марки, информацию о которой нужно показать.

        /// <summary>
        /// Конструктор.
        /// </summary>
        /// <param name="cou"></param>
        /// <param name="nomin"></param>
        /// <param name="yea"></param>
        /// <param name="tirag"></param>
        /// <param name="specia"></param>
        /// <param name="id"></param>
        public Marka(string cou, string nomin, string yea, string tirag, string specia, double id, Collector c)
        {
            Country = cou;
            Nominal = nomin;
            Year = yea;
            Tirage = tirag;
            Special = specia;
            Id = id;
            Coll = c;
          
        }
             

        /// <summary>
        /// Проверка, есть ли данная особенность в марке
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public bool IsIn(string str)
        {
            string temp = "";
            for (int i = 0; i <= this.Special.Length - str.Length; i++)
            {
                for (int j = i; j < i + str.Length; j++)
                {
                    temp += this.Special[j];
                }

                if (temp.Equals(str)) return true;

                temp = "";

            }
            return false;
        }

        /// <summary>
        /// Перекрытие метода ToString().
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return String.Format(" Страна: {0}, Номинальная стоимость: {1}, Год: {2}, Тираж: {3}, Особенность: {4} ", Country, Nominal, Year, Tirage, Special);
        }
    }
}
