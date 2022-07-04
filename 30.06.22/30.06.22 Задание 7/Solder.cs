using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30._06._22_Задание_7
{
    class Solder
    {
        private string fio;
        private string armament;
        private string title;
        private int srok;
        public Solder(string f, string a, string t, int s)
        {
            fio = f;
            armament = a;
            title = t;
            srok = s;
        }
        public string FIO
        {
            get
            {
                return fio;
            }
        }
        public string Armament
        {
            get
            {
                return armament;
            }
        }
        public string Title
        {
            get
            {
                return title;
            }
        }
        public int Srok
        {
            get
            {
                return srok;
            }
        }
    }
}

