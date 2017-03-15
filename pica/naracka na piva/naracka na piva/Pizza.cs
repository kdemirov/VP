using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace naracka_na_piva
{
    class Pizza
    {
        public String Ime { get; set; }
        public int Cena { get; set; }
        public Pizza(String ime,int cena)
        {
            Ime = ime;
            Cena = cena;
        }
        public override string ToString()
        {
            return String.Format("{0}", Ime);
        }

    }
}
