using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30._06._22_Задание_1
{
    class Criminal
    {
        private string fio;
        private double rost;
        private double ves;
        private string naz;
        private bool concluded;
        public Criminal(string s, double r, double v, string n, bool c)
        {
            fio = s;
            rost = r;
            ves = v;
            naz = n;
            concluded = c;
        }
        public string FIO
        {
            get
            {
                return fio;
            }
        }
        public double Rost
        {
            get
            {
                return rost;
            }
        }
        public double Ves
        {
            get
            {
                return ves;
            }
        }
        public string Naz
        {
            get
            {
                return naz;
            }
        }
        public bool Concluded
        {
            get
            {
                return concluded;
            }
        }
    }
}

