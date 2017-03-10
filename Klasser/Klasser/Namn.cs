using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasser
{
    class Namn
    {
        public string Förnamn   { get; set; }
        public string Efternamn { get; set; }

        public string FullständigtNamn { get { return Förnamn + " " + Efternamn; } }
    }
}
