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
    class ListOfCollectors : CommonFunc
    {
        List<Collector> collectior = new List<Collector>();
        
        public List<Collector> Collectior
        {
            set { collectior = value; }
            get { return collectior; }
        }

        /// <summary>
        /// Индексатор списка.
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public Collector this[int i]
        {
            set { collectior[i] = value; }
            get { return collectior[i]; }
        }

        /// <summary>
        /// Длина списка.
        /// </summary>
        public int Length
        {
            get { return collectior.Count; }
        }


        /// <summary>
        /// Сериализация списка.
        /// </summary>
        public void Save()
        {
            BinaryFormatter binFormat = new BinaryFormatter();
            using (Stream fStream = new FileStream("listOfCollector.dat", FileMode.OpenOrCreate))
            {
                binFormat.Serialize(fStream, collectior);
            }
        }


        /// <summary>
        /// Десериализация списка.
        /// </summary>
        public void Open()
        {
            BinaryFormatter binFormat = new BinaryFormatter();
            try
            {
                using (Stream fStream = new FileStream("listOfCollector.dat", FileMode.OpenOrCreate))
                {
                    collectior = (List<Collector>)binFormat.Deserialize(fStream);
                }
            }
            catch { }
        }

        /// <summary>
        /// Добавление нового коллекционера в список.
        /// </summary>
        /// <param name="a"></param>
        public void Add(Collector a)
        {
            collectior.Add(a);
        }


        /// <summary>
        /// Удаление коллекционера по индексу в списке.
        /// </summary>
        /// <param name="n"></param>
        public void RemoveAt(int n)
        {
            collectior.RemoveAt(n);
        }


        /// <summary>
        /// Проверка на то, если ли уже данный коллекционер в списке.
        /// </summary>
        /// <param name="ic"></param>
        /// <returns></returns>
        public bool IsCopy(Collector ic)
        {
            foreach (Collector a in collectior)
            {
                if (a.Name == ic.Name)
                    return true;
            }
            return false;
        }



    }
}
