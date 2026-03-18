using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NASACLII
{
    public class Kuldetes
    {
        public string Nev {  get; private set; }
        public int Ev { get; private set; }
        public string Celpont { get; private set; }
        public int Legenyseg { get; private set; }
        public bool Sikeres { get; private set; }
        public string Leiras { get; private set; }
        public double Koltseg { get; private set; }
        public double HasznosTeher { get; private set; }

        public Kuldetes(string sor)
        {
            Nev = sor.Split(';')[0];
            Ev = int.Parse(sor.Split(';')[1]);
            Celpont = sor.Split(';')[2];
            Legenyseg = int.Parse(sor.Split(';')[3]);
            Sikeres = sor.Split(';')[4] == "Igen" ? true : false;
            Leiras = sor.Split(';')[5];
            Koltseg = double.Parse(sor.Split(';')[6]);
            HasznosTeher = double.Parse(sor.Split(';')[7]);
        }
    }
}
