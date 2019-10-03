namespace SKFP_Model
{
    public interface ISKMPersonList
    {
        void AddPerson(SKMPerson person, string stunde);
        void AddPerson(string id, string name, string vname, string stunde);
        void AddStunden(string searchString, string menge, int ByWhat);
        bool Equals(object obj);
        int GetHashCode();
        void RemovePerson(string searchString, int ByWhat);
        void RemoveStunden(string searchString, string menge, int ByWhat);
    }
}