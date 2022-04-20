using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F1
{
    class Compara_punctaj:IComparer<Pilot>
    {
        public int Compare(Pilot x, Pilot y)
        {
            if (x.Puncte < y.Puncte)
                return 1;
            else if (x.Puncte == y.Puncte)
                return 0;
            else
                return -1;
        }
    }
}
