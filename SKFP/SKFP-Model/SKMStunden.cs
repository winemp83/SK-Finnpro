using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKFP_Model
{
    public class SKMStunden
    {
        public double Stunden { get; set; }
        public SKMPerson Eigner { get; set; }

        public SKMStunden(string stunden, SKMPerson person) {
            try { Convert.ToDouble(stunden); } catch (Exception) { this.Stunden = 0.0; }
            this.Eigner = person;
        }
    }
}
