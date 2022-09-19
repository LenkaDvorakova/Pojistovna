using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pojistovna
{
    public class SpravaPojistencu
    {
        List<Pojistenec> seznamPojistencu;
        
        public SpravaPojistencu()
        {
            seznamPojistencu = new List<Pojistenec>();
        }

        public void Pridej(Pojistenec pojistenec)
        {
            seznamPojistencu.Add(pojistenec);
        }

        public List<Pojistenec> VratSeznam()
        {
            return seznamPojistencu;
        }

        public List<Pojistenec> Vyhledej (string jmeno, string prijmeni)
        {
            List <Pojistenec> nalezene = new List <Pojistenec>(); 
            foreach (Pojistenec p in seznamPojistencu)
            {
                if (p.Jmeno == jmeno && p.Prijmeni == prijmeni)
                {
                    nalezene.Add(p);
                }
            }
            return nalezene;
        }
    }
}
