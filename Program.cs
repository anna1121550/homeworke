using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int h = 3;
            int lo =5;
            string name = "Титаник";
            string name1 = "Победа";
            string name2 = "Беда";
            int v = 23;
            int s = 100;
            baseship myship = new baseship(lo, name, v);
            string toPrint = myship.PrintInformation();
            Console.WriteLine(toPrint);
            Console.ReadKey();
            ship1 myc = new ship1(lo, name1, v, h);
            string toPrint1 = myc.PrintInformation();
            Console.WriteLine(toPrint1);
            Console.ReadKey();
            ship2 my2 = new ship2(lo, name2, v, s);
            string w= my2.PrintInformation();
            Console.WriteLine(w);
            Console.ReadKey();
        }
    }
}
