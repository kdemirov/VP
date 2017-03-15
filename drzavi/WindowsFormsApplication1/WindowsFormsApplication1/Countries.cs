using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Countries
    {
        public string Name { get; set; }
        public string Capital { get; set; }
        public string Short { get; set; }
        public Countries(string name,string capital,string srt)
        {
            Name = name;
            Capital = capital;
            Short = srt;
        }
        public override string ToString()
        {
            return string.Format("{0} - {1}", Name, Short);
        }

    }
}
