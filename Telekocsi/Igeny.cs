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

        public Igeny(string azonosito,string indulas,string cel,int szemely)
        {
            Azonosito = azonosito;
            Indulas = indulas;
            Cel = cel;
            Szemelyek = szemely;
        }
    }
}
