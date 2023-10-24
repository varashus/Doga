using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doga
{
    internal class Bolygo
    {
        public Bolygo(string r)
        {
            var v = r.Split(';');
            this.bolygo = v[0];
            this.holdak = int.Parse(v[1]);
            this.terfogat = double.Parse(v[2].Replace('.', ','));
        }

        public string bolygo { get; set; }
        public int holdak { get; set; }
        public double terfogat { get; set; }
    }
}
