using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class ship2 : baseship
    {
        public ship2(int lo, string name2, int v, int s) : base(lo, name2, v)
        {
            Name2 = name2;
            V = v;
            S = s;
        }
             public virtual string PrintInformation()
        {
          
            int t = S / V;
            string re = "За время " + t + " судно  " + Name2 + " проплывет " + S + " метров";
            return re;

        }
        public string Name2 { get; private set; }
        public int S { get; private set; }
        public int V { get; private set; }

    }
}
