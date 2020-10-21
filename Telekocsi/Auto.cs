using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Telekocsi
{
    class Auto
    {
        //Indulás;Cél;Rendszám;Telefonszám;Féröhely
        public string Indulas { get;  private set; }
        public string Cel { get; private set; }
        public string Rendszam { get; private set; }
        public string Telefonszam { get; private set; }
        public int Ferohely { get; private set; }
        public string utvonal { get; private set; }

        public Auto(string indulas, string cel,string rendszam,string telefonszam,int ferohely)
        {
            Indulas = indulas;
            Cel = cel;
            Rendszam = rendszam;
            Telefonszam = telefonszam;
            Ferohely = ferohely;
            utvonal = Indulas + " " + Cel;
        }
    }
}
