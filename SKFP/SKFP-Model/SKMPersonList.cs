using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKFP_Model
{
    public class SKMPersonList
    {
        public List<SKMPerson> PList = new List<SKMPerson>();
        public List<SKMStunden> SList = new List<SKMStunden>();
        public SKMPersonList() {
            AddPerson("001", "Schäfer", "Timo", "1000");
            AddPerson(new SKMPerson("002", "Stender", "Andreas"), "980");
            AddPerson("003", "Liebbrot", "Nikki", "200");
            AddPerson("004", "Köhne", "Sascha", "240");
            AddPerson("005", "Nowak", "Marko", "400");
        }

        public void AddPerson(string id, string name, string vname, string stunde) {
            try {
                SKMPerson P = new SKMPerson(id, name, vname);
                PList.Add(P);
                SList.Add(new SKMStunden(stunden: stunde, person: P));
                return;
            } catch (Exception) {
                return; }
        }

        public void AddPerson(SKMPerson person, string stunde) {
            try {
                PList.Add(person);
                SList.Add(new SKMStunden(stunden: stunde, person: person));
                return;
            } catch(Exception) {
                return; }
        }

        public void RemovePerson(string searchString, int ByWhat) {
            try {
                switch (ByWhat) {
                    //ByID
                    case 1:
                        SList.Remove(SList.Find(x => x.Eigner.ID == searchString));
                        PList.Remove(PList.Find(x => x.ID == searchString));
                        break;
                    //ByName
                    case 2:
                        SList.Remove(SList.Find(x => x.Eigner.Name == searchString));
                        PList.Remove(PList.Find(x => x.Name == searchString));
                        break;
                }
                return;
            }
            catch (Exception) {
                return;
            }
        }

        public void AddStunden(string searchString, string menge, int ByWhat) {
            try{
                var stunden = new SKMStunden("0", new SKMPerson()); 
                switch (ByWhat){
                    //ByID
                    case 1:
                        stunden = SList.FirstOrDefault(s => s.Eigner.ID == searchString);
                        break;
                    //ByName
                    case 2:
                        stunden = SList.FirstOrDefault(s => s.Eigner.Name == searchString);
                        break;
                }
                if (stunden != null && stunden.Eigner.Name != "Musterman"){
                    stunden.Stunden += Convert.ToDouble(menge);
                }
            }
            catch (Exception){
                return;
            }
        }

        public void RemoveStunden(string searchString, string menge, int ByWhat)
        {
            try{
                var stunden = new SKMStunden("0", new SKMPerson());
                switch (ByWhat){
                    //ByID
                    case 1:
                        stunden = SList.FirstOrDefault(s => s.Eigner.ID == searchString);
                        break;
                    //ByName
                    case 2:
                        stunden = SList.FirstOrDefault(s => s.Eigner.Name == searchString);
                        break;
                }
                if (stunden != null && stunden.Eigner.Name != "Musterman"){
                    stunden.Stunden -= Convert.ToDouble(menge);
                }
            }catch (Exception){
                return;
            }
        }
    }
}
