using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pojistovna
{
    public class Pojistenec
    {
        public string Jmeno { get; set; }
        public string Prijmeni { get; set; }
        public int Vek { get; set; }
        public int TelefonniCislo { get; set; }

        public override string ToString()
        {
            return Jmeno + "    " + Prijmeni + "    " + Vek + "     " + TelefonniCislo;
        }
    }
}
