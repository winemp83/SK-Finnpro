namespace SKFP_Model
{
    public interface ISKMPerson
    {
        string ID { get; set; }
        string Name { get; set; }
        string VName { get; set; }

        bool Equals(object obj);
        int GetHashCode();
        string ToString();
    }
}