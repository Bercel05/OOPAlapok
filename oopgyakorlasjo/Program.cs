using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopgyakorlasjo
{
    public class szemely
    {
        private string nev;
        private int kor;

        public string Nev
        {
            get { return nev; }
            set { nev = value; }
        }



        /*public szemely(string Nev, int Kor)
        {
            nev = Nev;
            kor = Kor;
        }
        public string Kiir()
        {
            return $"A tanulo neve: {nev} es {kor} eves.";
        }*/
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            szemely tanulo1 = new szemely();
            Console.WriteLine(tanulo1.Nev);

            /*szemely tanulo1 = new szemely("Jani", 55);
            Console.WriteLine(tanulo1.Kiir());
            szemely tanulo2 = new szemely("Ildi", 33);
            Console.WriteLine(tanulo2.Kiir());
            //Console.WriteLine($"A tanulo neve: {tanulo1.nev} es {tanulo1.kor} eves.");*/
        }
    }
}