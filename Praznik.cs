using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace koledar
{
    class Praznik
    {
        public string imePraznika { get; set; }
        public bool ponavljajoce { get; set; }
        public int dan { get; set; }
        public int mesec { get; set; }
        public int leto { get; set; }
    }
}
