using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace koledar
{
    class AlgoritemiKoledar
    {
        //Zellerjeva kongruenca je algoritem,  z njim pa lahko izračunamo dan v tednu za kateri koli datum.
        public int AlgoritemKoledar(int leto, int mesec, int dan)
        {
            int[] t = new int[] { 0, 3, 2, 5, 0, 3, 5, 1, 4, 6, 2, 4 };
            int[] n = new int[] { 7, 1, 2, 3, 4, 5, 6 };
            if (mesec < 3)
            {
                leto = leto - 1;
            }
            long w = 0;
            w = (leto + (leto / 4) - (leto / 100) + (leto / 400) + t[mesec - 1] + dan) % 7;
            return n[w];
        }
        //dobimo število dni v mescu
        public int GetDaysInmonth(int month, int year)
        {
            int StDni = 0;
            if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
            {
                StDni = 31;
            }
            else if (month == 2)
            {
                if (year % 4 == 0)
                {
                    StDni = 29;
                }
                else
                {
                    StDni = 28;
                }
            }
            else
            {
                StDni = 30;
            }
            return StDni;
        }
    }
}
