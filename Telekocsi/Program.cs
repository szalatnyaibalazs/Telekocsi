using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Telekocsi
{
    class Program
    {
        static List<Auto> autok = new List<Auto>();
        static List<Igeny> igenyek = new List<Igeny>();
        static void beolvas()
        {
            StreamReader ol = new StreamReader("autok.csv");
            ol.ReadLine();
            while (!ol.EndOfStream)
            {
                string[] adat = ol.ReadLine().Split(';');
                autok.Add(new Auto(adat[0],adat[1], adat[2], adat[3], int.Parse(adat[4])));
            }
            ol.Close();


            StreamReader lo = new StreamReader("igenyek.csv");
            lo.ReadLine();
            while (!lo.EndOfStream)
            {
                string[] adat = lo.ReadLine().Split(';');
                igenyek.Add(new Igeny(adat[0], adat[1], adat[2], int.Parse(adat[3])));
            }
            lo.Close();

        }
        static void MasodikFeladat()
        {
            Console.WriteLine($"2.feladat\n  {autok.Count} autos hirdet fuvart");
        }
        static void HarmadikFeladat()
        {
            foreach (var a in autok)
            {

            }
        }
        static void NegyedikFeladat()
        {
            //Dictionary<string,int> utvonalak = new Dictionary<string, int>();

            //foreach (var a in autok)
            //{
            //    if (!utvonalak.ContainsKey(a.utvonal))
            //    {
            //        utvonalak.Add(a.utvonal, a.Ferohely);
            //    }
            //    else
            //    {
            //        utvonalak[a.utvonal] = utvonalak[a.utvonal];
            //    }
            //}
            int max = 0;
            string utv = "";
            //foreach (var u in utvonalak)
            //{
            //    if (u.Value > max)
            //    {
            //        max = u.Value;
            //        utv = u.Key;
            //    }

            //}
            var utvonalak = from a in autok
                            orderby a.utvonal
                            group a by a.utvonal into temp
                            select temp;

            foreach (var u in utvonalak)
            {
                int fh = u.Sum(x => x.Ferohely);
                if (max<fh)
                {
                    max = fh;
                    utv = u.Key;
                }
               //Console.WriteLine($"{u.Key} -> {u.Count()}");
            }

            Console.WriteLine($"4.feladat\n{max}-{utv}");
        }
        static void OtodikFeladat()
        {
            Console.WriteLine("5.feladat");
            foreach (var i in igenyek)
            {
                int x = 0;
                while (x < autok.Count && 
                    !(i.Indulas == autok[x].Indulas && 
                    i.Cel == autok[x].Cel && i.Szemelyek <= autok[x].Ferohely))
                {
                    x++;
                }
                if (x<autok.Count)
                {
                    Console.WriteLine($"{i.Azonosito} => {autok[x].Rendszam}");
                }
            }
        }
        static void Main(string[] args)
        {
            beolvas();
            MasodikFeladat();

            NegyedikFeladat();
            OtodikFeladat();


            Console.ReadKey();
        }
    }
}
