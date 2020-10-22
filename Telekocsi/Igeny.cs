using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Telekocsi
{
    class Igeny
    {
        //Azonosító;Indulás;Cél;Személyek

        public string Azonosito { get; set; }
        public string Indulas { get; set; }
        public string Cel { get; set; }
        public int Szemelyek { get; set; }
        public string utvonal { get; private set; }

        public Igeny(string azonosito,string indulas,string cel,int szemely)
        {
            Azonosito = azonosito;
            Indulas = indulas;
            Cel = cel;
            Szemelyek = szemely;
            utvonal = Indulas + " " + Cel;
        }
        public int VanAuto(List<Auto> autok)
        {
            int x = 0;
            while (x < autok.Count &&
                !(utvonal == autok[x].utvonal &&
                Szemelyek <= autok[x].Ferohely))
            {
                x++;
            }
            if (x<autok.Count)
            {
                return x;
            }
            else
            {
                return -1;
            }

        }
    }
}
