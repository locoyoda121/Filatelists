using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Filatelists
{
    class ThemesList
    {
        List<string> themes = new List<string>();

        public List<string> Thems
        {
            set { themes = value; }
            get { return themes; }
        }

        /// <summary>
        /// Индексатор.
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public string this[int i]
        {
            set { themes[i] = value; }
            get { return themes[i]; }
        }

        /// <summary>
        /// Сериализация
        /// </summary>
        public void Ser()
        {
            BinaryFormatter binFormat = new BinaryFormatter();
            using (Stream fStream = new FileStream("themes.dat", FileMode.OpenOrCreate))
            {
                binFormat.Serialize(fStream, themes);
            }
        }

        /// <summary>
        /// Десериализация.
        /// </summary>
        public void Open()
        {
            BinaryFormatter binFormat = new BinaryFormatter();
            try
            {
                using (Stream fStream = new FileStream("themes.dat", FileMode.Open))
                {
                    themes = (List<string>)binFormat.Deserialize(fStream);
                }
            }
            catch { }
        }

        /// <summary>
        /// Поиск.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public List<string> Search(string s)
        {
            this.Open();
            List<string> res = new List<string>();
            s = s.ToLower();
            for (int i = 0; i < themes.Count; i++)
            {
                string temp = this[i].ToLower();
                if (temp.Contains(s))
                {
                    bool isIn = false;
                    for (int k = 0; k < res.Count; k++)
                    {
                        if (res[k] == this[i])
                            isIn = true;
                    }
                    if (!isIn)
                    {
                        res.Add(this[i]);
                        isIn = false;
                    }
                }
            }
            return res;
        }
    }
}
