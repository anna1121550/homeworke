using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class ship1 : baseship
    {
        public ship1(int lo, string name1, int v, int h) : base (lo, name1, v)
        {
            H = h;
            Name1 = name1;
            string y = "высота судна   " + name1 +"  "+ H + "    метров";
            Console.WriteLine(y);

        }
        public virtual string PrintInformation()
        {
            string res = "Название судна " + Name1 + " Длина = " + Lon + " Скорость = " + V;
            return res;
        }
        public int H { get; private set; }
        public string Name1 { get; private set; }
    }
}
