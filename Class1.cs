using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class baseship
    {
        public baseship(int lo, string name, int v)//это пармаетры конструктора
        {
            Lon = lo;//а это что? Для чего это и почему это так?
            Name = name;
            V = v;
        }
        public virtual string PrintInformation()
        {
            string res = "Название судна " + Name + " Длина = " + Lon + " Скорость = " + V;
            return res;
        }
        public int Lon { get; private set; }
        public string Name { get; private set; }
        public int V { get; private set; }
    }
}
   