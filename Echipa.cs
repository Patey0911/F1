using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F1
{
    public class Echipa
    {
        string nume;
        public int puncte;
        public string Nume
        {
            get { return nume; }
            set { nume = value; }
        }

        public int Puncte
        {
            get { return puncte; }
            set { puncte += value; }
        }
        public Echipa(string nume, int puncte)
        {
            this.nume = nume;
            this.puncte = puncte;
        }
    }
}
