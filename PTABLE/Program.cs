using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
namespace PTABLE
{
    class Program
    {   
        static void Main(string[] args)
        {
            Atom Helium = new Atom("Helium",CATEGORY.NONMETALS,2,2,2);
            Console.Write(Helium.ToString());
        }
    }
}
