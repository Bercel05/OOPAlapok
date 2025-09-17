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
        public int Kor
        { get { return kor; }
        set {  kor = value; }
        }


        public override string ToString()
        {
            return $"A tanuló neve: {nev} és életkora {kor} ebves";
        }
    }
    public class hallgato : szemely
    {
        private string neptunkod;

        public string Neptunkod
        {
            get { return neptunkod; }
            set
            {
                if(value.Length < 7)
                    neptunkod = value;
                else
                    Console.WriteLine("Nem megfelelő hosszúság.");
            }
        }
        public void Kiir()
        {
            Nev = string.Empty;
        }
    }
           
    public class Bankszamla
    {
        private int egyenleg;

        public int Egyenleg
        {
            get { return egyenleg; }
            set
            { 
                if(value >= 0)
                egyenleg = value;
                else
                Console.WriteLine("Az érték nem lehet negatív.");
            }
        }

        private void Betesz()
        { 
        
        }

        private void Kivesz()
        {

        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            szemely tanulo1 = new szemely();
            tanulo1.Nev = "Gabor";
            Console.WriteLine(tanulo1.Nev);
            tanulo1.Kor = 44;
            Console.WriteLine(tanulo1.Kor);

            Bankszamla bankszamla1 = new Bankszamla();
            bankszamla1.Egyenleg = 5700;
            Console.WriteLine(bankszamla1.Egyenleg);

            hallgato hallgato1 = new hallgato();
            hallgato1.Neptunkod = "MWHLN9";
            Console.WriteLine(hallgato1.Neptunkod);

            List<hallgato> hallgatok = new List<hallgato>();

            for (int i = 0; i < 2; i++)
            {
                hallgato hallgato = new hallgato();
                Console.Write($"Kérem a(z) {i+1} hallgató nevét:");
                hallgato.Nev = Console.ReadLine();
                Console.Write($"Kérem a(z) {i + 1} hallgató életkorát:");
                hallgato.Kor = int.Parse ( Console.ReadLine() );
                Console.Write($"Kérem a(z) {i + 1} hallgató neptunkódját:");
                hallgato.Neptunkod = Console.ReadLine();
                hallgatok.Add( hallgato );
                
            }
            foreach (var item in hallgatok)
            {
                Console.WriteLine($"A hallgatók neve: {item.Nev}");

            }
            
            
            
        }
    }
}