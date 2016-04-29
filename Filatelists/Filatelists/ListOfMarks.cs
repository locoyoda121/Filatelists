using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Filatelists
{
    [Serializable]
    class ListOfMarks : CommonFunc
    {
        List<Marka> collection = new List<Marka>();

        public List<Marka> Collection
        {
            set { collection = value; }
            get { return collection; }
        }

        /// <summary>
        /// Индексатор списка марок
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public Marka this[int i]
        {
            set { collection[i] = value; }
            get { return collection[i]; }
        }


        /// <summary>
        /// Длина списка марок
        /// </summary>
        public int Length
        {
            get { return collection.Count; }
        }


        /// <summary>
        /// Сериализация списка марок в папку проекта.
        /// </summary>
        public void Save()
        {
            BinaryFormatter binFormat = new BinaryFormatter();
            try
            {
                using (Stream fStream = new FileStream("listOfMarks.dat", FileMode.OpenOrCreate))
                {
                    binFormat.Serialize(fStream, collection);
                }
            }
            catch { }
        }


        /// <summary>
        /// Десериализация списка марок из папки проекта.
        /// </summary>
        public void Open()
        {
            BinaryFormatter binFormat = new BinaryFormatter();
            try
            {
                using (Stream fStream = new FileStream("listOfMarks.dat", FileMode.Open))
                {
                    collection = (List<Marka>)binFormat.Deserialize(fStream);
                }
            }
            catch { }
        }

        /// <summary>
        /// Добавление новой марки в список.
        /// </summary>
        /// <param name="q"></param>
        public void Add(Marka q)
        {
            collection.Add(q);
        }

        /// <summary>
        /// Удаление марки
        /// </summary>
        /// <param name="q"></param>
        public void Remove(Marka q)
        {
            collection.Remove(q);
        }


        /// <summary>
        /// Метод, который возвращает марку определенного коллекционера.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public string MarksOf(string n)
        {
            this.Open();
            string res = "";
            foreach (Marka q in collection)
            {
                if (q.Coll.Name == n)
                    res += q.ToString();
            }
            return res;
        }

        /// <summary>
        /// Метод, который возвращает коллекцию марок определенного коллекционера
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public List<string> ListMarksOf(string n)
        {
            this.Open();
            List<string> res = new List<string>();
            foreach (Marka q in collection)
            {
                if (q.Coll.Name == n)
                    res.Add(q.ToString());
            }
            return res;
        }

        /// <summary>
        /// Метод, который возвращает коллекцию марок по номеру:
        /// 0 - коллекционера;
        /// 1 - марки;
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<string> MarksById(double id, int n)
        {
            this.Open();
            double tempId = -1;
            List<string> res = new List<string>();
            foreach (Marka q in collection)
            {
                if (n == 0) tempId = q.Coll.Id; // По номеру коллекционера.
                else if (n == 1) tempId = q.Id; // По номеру марки.
                if (tempId == id)
                    res.Add(q.ToString());
            }
            return res;
        }

        /// <summary>
        ///  Метод, который возращает весь список марок
        /// </summary>
        /// <returns></returns>
        public List<string> AllMarks()
        {
            this.Open();
            List<string> res = new List<string>();
            foreach (Marka q in collection)
            {
                res.Add(q.ToString());
            }
            return res;
        }

        /// <summary>
        /// Удаление марки по индексу.
        /// </summary>
        /// <param name="i"></param>
        public void RemoveAt(int i)
        {
            collection.RemoveAt(i);
        }

        /// <summary>
        /// Поиск по:
        /// 0 - особенности;
        /// 1 - коллекционерам;
        
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public List<string> Search(string str, int n)
        {
            this.Open();
            str = str.ToLower();
            List<string> res = new List<string>();
            for (int z = 0; z < this.Length; z++)
            {
                string text = "";
                if (n == 0) text = this[z].Special.ToLower(); // Поиск по выражению.
                if (n == 1) text = this[z].Coll.Name.ToLower(); // По коллекционерам.
               
                string temp = "";
                for (int i = 0; i <= text.Length - str.Length; i++)
                {
                    for (int j = i; j < i + str.Length; j++)
                    {
                        temp += text[j];
                    }

                    if (temp.Equals(str))
                    {
                        bool isIn = false;
                        for (int k = 0; k < res.Count; k++)
                        {
                            if (res[k] == this[z].ToString())
                                isIn = true;
                        }
                        if (!isIn)
                        {
                            res.Add(this[z].ToString());
                            isIn = false;
                        }
                    }

                    temp = "";
                }
            }
            return res;
        }



    }
}
