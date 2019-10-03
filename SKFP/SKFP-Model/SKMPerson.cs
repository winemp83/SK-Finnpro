using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKFP_Model
{
    public class SKMPerson
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string VName { get; set; }

        public SKMPerson (string id = "000", string name = "Musterman", string vname ="Max"){
            this.ID = id;
            this.Name = name;
            this.VName = vname;
        }

        public override string ToString(){
            return "ID:" + this.ID + ";Name:" + this.Name + ";VName:" + this.VName + ";";
        }
    }
}
