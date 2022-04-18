using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Versenyzok
{
    class Pilota
    {
        //név;születési_dátum;nemzetiség;rajtszám
        string nev;
        DateTime szuletesi_datum;
        string nemzetiseg;
        byte rajtszam;

        public Pilota (string sor)
        {
            string[] daraboltSor = sor.Split(';');
            Nev = daraboltSor[0];
            Szuletesi_datum = Convert.ToDateTime(daraboltSor[1]);
            Nemzetiseg = daraboltSor[2];
            if (!string.IsNullOrEmpty(daraboltSor[3]))
            {
                Rajtszam = Convert.ToByte(daraboltSor[3]); 
            }
        }

        public string Nev { get => nev; set => nev = value; }
        public DateTime Szuletesi_datum { get => szuletesi_datum; set => szuletesi_datum = value; }
        public string Nemzetiseg { get => nemzetiseg; set => nemzetiseg = value; }
        public byte Rajtszam { get => rajtszam; set => rajtszam = value; }
    }
}
