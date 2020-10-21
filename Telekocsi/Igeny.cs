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

        private string Azonosito { get; set; }
        private string Indulas { get; set; }
        private string Cel { get; set; }
        private int Szemelyek { get; set; }

        public Igeny(string azonosito,string indulas,string cel,int szemely)
        {
            Azonosito = azonosito;
            Indulas = indulas;
            Cel = cel;
            Szemelyek = szemely;
        }
    }
}
