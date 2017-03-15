using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace naracka_na_piva
{
    class Naracka
    {
        public Pizza Pica { get; set; }
        public List<String> Dodatoci { get; set; }
        public List<String> Pijalaci { get; set; }
        public Desert Desert { get; set; }
        public Naracka(Pizza pica,Desert desert)
        {
            Pica = pica;
            Desert = desert;
            Dodatoci = new List<String>();
            Pijalaci = new List<String>();
        }

    }
}
