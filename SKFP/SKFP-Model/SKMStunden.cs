using System;
using System.Collections.Generic;

namespace SKFP_Model
{
    public class SKMStunden : ISKMStunden
    {
        public double Stunden { get; set; }
        public SKMPerson Eigner { get; set; }

        public SKMStunden(string stunden, SKMPerson person)
        {
            try { this.Stunden = Convert.ToDouble(stunden); } catch (Exception) { this.Stunden = 0.0; }
            this.Eigner = person;
        }

        public override string ToString()
        {
            string result = Eigner.ToString();
            result += "Stunden:" + Stunden + ";";
            return result;
        }

        public override bool Equals(object obj)
        {
            return obj is SKMStunden stunden &&
                   Stunden == stunden.Stunden &&
                   EqualityComparer<SKMPerson>.Default.Equals(Eigner, stunden.Eigner);
        }

        public override int GetHashCode()
        {
            var hashCode = 1759191273;
            hashCode = hashCode * -1521134295 + Stunden.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<SKMPerson>.Default.GetHashCode(Eigner);
            return hashCode;
        }
    }
}
