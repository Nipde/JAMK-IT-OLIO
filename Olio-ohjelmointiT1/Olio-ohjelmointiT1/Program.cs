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
            //Tehtava1();
            //Tehtava2();
            Tehtava3();
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
            else if (luku == 2)
            {
                retval = "kaksi";
            }
            else if (luku == 3)
            {
                retval = "kolme";
            }
            else
            {
                retval = "joku muu luku!";
            }
            Console.WriteLine(retval);
            Console.ReadLine();
        }

        static void Tehtava2()
        {
            Console.WriteLine("Anna oppilaan pistemäärä: ");
            string pisteet = Console.ReadLine();
            int pisteret = int.Parse(pisteet);
            if (pisteret == 0 || pisteret == 1)
            {
                pisteet = "0";
            }
            else if (pisteret == 2 || pisteret == 3)
                {
                pisteet = "1";
                }
            else if (pisteret == 4 || pisteret == 5)
            {
                pisteet = "2";
            }
            else if (pisteret == 6 || pisteret == 7)
            {
                pisteet = "3";
            }
            else if (pisteret == 8 || pisteret == 9)
            {
                pisteet = "4";
            }
            else if (pisteret >= 10 || pisteret <= 12 )
            {
                pisteet = "5";
            }
            else
            {
                pisteet = "Et antanu valideja numeroita!";
            }
            Console.WriteLine("Opiskelijan numero on: " + pisteet);
            Console.ReadLine();
        }
        static void Tehtava3()
        {
            Console.WriteLine("Anna ensimmäinen luku: ");
            string eka = Console.ReadLine();
            int ekaluku = int.Parse(eka);
            Console.WriteLine("Anna toinen luku: ");
            string toka = Console.ReadLine();
            int tokaluku = int.Parse(toka);
            Console.WriteLine("Anna kolmas luku: ");
            string koka = Console.ReadLine();
            int kolmasluku = int.Parse(koka);
            int summa = ekaluku + tokaluku + kolmasluku;
            int keskiarvo = summa / 3;
            Console.WriteLine("Lukujen summa on: " + summa + " ja lukujen keskiarvo on: " + keskiarvo);
            Console.ReadLine();
        }
    }
}
