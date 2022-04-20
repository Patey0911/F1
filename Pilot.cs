using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F1
{
    public class Pilot
    {
        public string nume, echipa;
        public int puncte;
        public string Nume
        {
            get { return nume; }
            set { nume = value; }
        }

        public string Echipa
        {
            get { return echipa; }
            set { echipa = value; }
        }

        public int Puncte
        {
            get { return puncte; }
            set { puncte += value; }
        }
        public Pilot(string nume, string echipa, int puncte)
        {
            this.echipa = echipa;
            this.nume = nume;
            this.puncte = puncte;
        }
    }
}
