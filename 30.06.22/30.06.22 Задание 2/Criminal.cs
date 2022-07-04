using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30._06._22_Задание_2
{
    class Criminal
    {
        private string fio;
        private string crime;
        public Criminal(string s, string n)
        {
            fio = s;
            crime = n;
        }
        public string FIO
        {
            get
            {
                return fio;
            }
        }
        public string Crime
        {
            get
            {
                return crime;
            }
        }
    }
}

