using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTABLE
{
    class Atom
    {
        uint protons = 0;
        uint electrons = 0;
        uint nuetrons = 0;
        uint[] shells = null;
        public Atom(uint protons = 0,uint electrons = 0,uint nuetrons = 0, uint shell_count = 1)
        {
            shells = new uint[shell_count];
        }
       static public Atom operator+(Atom a, Atom b)//f(x)
       {
            return null;
       }
        int Charge()
        {
            return (int)protons - (int)electrons;
        }

        public bool AddToShell(uint shellLayer , uint electrons = 1)
        {
            if (shellLayer == 0 || shellLayer > shells.Length) return false;
            if (shells[shellLayer-1] + electrons <= (2 * Math.Pow(shellLayer,2)))
            {
                shells[shellLayer-1] += electrons;
                return true;
            }
            return false;
        }
    }
}
