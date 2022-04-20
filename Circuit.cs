using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F1
{
    class Circuit
    {
        public string nume, locatie, lungime, distanta;
        public int laps;
        public DateTime data;
  

        public Circuit(string nume, string locatie, string lungime, string distanta, int laps, DateTime data)
        {
            this.laps = laps;
            this.lungime = lungime;
            this.nume = nume;
            this.locatie = locatie;
            this.distanta = distanta;
            this.data = data;
        }

        public string Nume
        {
            get { return nume; }
            set { nume = value; }
        }
        public string Locatie
        {
            get { return locatie; }
            set { locatie = value; }
        }

        public string Lungime
        {
            get { return lungime; }
            set { lungime = value; }
        }
        public string Distanta
        {
            get { return distanta; }
            set { distanta = value; }
        }

        public int Laps
        {
            get { return laps; }
            set { laps = value; }
        }
    }
}
