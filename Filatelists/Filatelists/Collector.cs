using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Drawing;

namespace Filatelists
{
    [Serializable]
    class Collector
    {
        public string Country { set; get; }     // Страна
        public string Name { set; get; }    // Имя
     //   public ListOfMarks Listmarks { set; get; }    // Колекция редких марк
        public string Phone { set; get; }     // телефон
        public double Id { set; get; } // Номер коллекционера.
        public bool Part { set; get; } // Добавление/удаление коллекционера.
        public bool Change { set; get; } // Для поиска информации о коллекционере, которую кужно изменить.
        public bool ShowAuthor { set; get; } // Для поиска коллекционера, информацию о котором нужно показать.
        public bool Show { set; get; } // Для поиска марок, которые нужно показывать.
        /// <summary>
        /// Конструктор для создания нового коллекционера.
        /// </summary>
        /// <param name="n"></param>
        /// <param name="c"></param>
        /// <param name="p"></param>
        /// <param name="id"></param>

        public Collector(string n, string c, string p, double id)//, ListOfMarks lm)
        {
            Name = n;
            Phone = p;
            Country = c;
            Id = id;
       //     Listmarks = lm;
        }
    }
}
