using System.Collections.Generic;

namespace SKFP_Model
{
    public class SKMPerson : ISKMPerson
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string VName { get; set; }

        public SKMPerson(string id = "000", string name = "Musterman", string vname = "Max")
        {
            this.ID = id;
            this.Name = name;
            this.VName = vname;
        }

        public override string ToString()
        {
            return "ID:" + this.ID + ";Name:" + this.Name + ";VName:" + this.VName + ";";
        }

        public override bool Equals(object obj)
        {
            return obj is SKMPerson person &&
                   ID == person.ID &&
                   Name == person.Name &&
                   VName == person.VName;
        }

        public override int GetHashCode()
        {
            var hashCode = 1229861752;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ID);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(VName);
            return hashCode;
        }
    }
}
