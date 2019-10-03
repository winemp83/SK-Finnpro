namespace SKFP_Model
{
    public interface ISKMStunden
    {
        SKMPerson Eigner { get; set; }
        double Stunden { get; set; }

        bool Equals(object obj);
        int GetHashCode();
        string ToString();
    }
}