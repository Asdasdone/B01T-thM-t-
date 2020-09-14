using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace B01TóthMáté
{
    class Program
    {
        static int[] tömb = new int[1000];
        static void beolvasas()
        {
            StreamReader ol = new StreamReader("adatok.dat");
            int i = 0;
            while (!ol.EndOfStream)
            {
                tömb[i] = int.Parse(ol.ReadLine())*3;
                i++;
            }
            ol.Close();
        }
        static void Main(string[] args)
        {
            beolvasas();
            Console.ReadKey();
        }
    }
}
