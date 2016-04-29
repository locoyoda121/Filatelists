using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filatelists
{
    class CommonFunc
    {
        /// <summary>
        /// Удаление лишних пробелов в тексте.
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public string RemoveSpaces(string str)
        {
            string[] t = str.Split(' ');
            string res = "";
            for (int i = 0; i < t.Length; i++)
            {
                if (t[i] != "")
                {
                    res += t[i];
                    if (i != t.Length - 1)
                    {
                        res += " ";
                    }
                }
            }
            return res;
        }
    }
}
