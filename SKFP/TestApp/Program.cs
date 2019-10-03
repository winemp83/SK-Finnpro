using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SKFP_Model;

namespace TestApp
{
    class Program
    {
        
        static void Main(string[] args)
        {
            SKMPersonList pList = new SKMPersonList();
            foreach (SKMPerson p in pList.PList) {
                Console.WriteLine(p.ToString());
            }
            Console.WriteLine("#####################################################################################");
            foreach (SKMStunden s in pList.SList) {
                Console.WriteLine(s.ToString());
            }
            Console.WriteLine("#####################################################################################");
            Console.ReadKey();
            pList.AddStunden("003", "40,5", 1);
            pList.RemoveStunden("002", "205,33", 1);
            foreach (SKMStunden s in pList.SList)
            {
                Console.WriteLine(s.ToString());
            }
            Console.WriteLine("#####################################################################################");
            pList.AddStunden("Köhne", "6,75", 2);
            pList.RemoveStunden("Schäfer", "75,33", 2);
            foreach (SKMStunden s in pList.SList)
            {
                Console.WriteLine(s.ToString());
            }
            Console.WriteLine("#####################################################################################");
            Console.ReadKey();
        }
    }
}
