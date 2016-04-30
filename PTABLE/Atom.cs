using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTABLE
{
    public enum CATEGORY {METALS, NONMETALS };
    class Atom
    {
        
        uint protons = 0;
        uint electrons = 0;
        uint nuetrons = 0;
        string name;
        CATEGORY type;
        uint[] shells = null;
        public Atom(string name ,CATEGORY type ,uint protons = 0,uint electrons = 0,uint nuetrons = 0)
        {
            this.name = name;
            this.type = type;
            this.protons = protons;
            this.electrons = electrons;
            this.nuetrons = nuetrons;
            uint shell_count = 1;

            while (electrons > (2 * Math.Pow(shell_count, 2)))
                   ++shell_count;

            shells = new uint[shell_count];
        }
        public override string ToString()
        {
            if ( Charge() > 0)
                return name+"+" +Charge();//base.ToString();
            else if (Charge() < 0)
                return name + "-" + Charge();
            else return name;
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
