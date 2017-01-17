using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Viikkotehtavat
{
    class Program
    {
        static void Main(string[] args)
        {
            Tehtava1();
            //Tehtava2();
        }
        static void Tehtava1()
        {
            Console.WriteLine("Anna luku 1,2 tai 3 ja tulostan sen tekstinä");
            string retval = Console.ReadLine();
            int luku = int.Parse(retval);
            if (luku == 1)
            {
                retval = "yksi";
            }
            else
            {

            }
            Console.WriteLine(retval);
            Console.ReadLine();
        }
    }
}
