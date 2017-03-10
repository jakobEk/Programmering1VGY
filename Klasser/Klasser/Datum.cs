using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasser
{
    class Datum
    {
        public int År    { get; set; }
        public int Månad { get; set; }
        public int Dag   { get; set; }

        DateTime datum = DateTime.Now;

        public bool Myndig { get { return true; } }
    }
}
