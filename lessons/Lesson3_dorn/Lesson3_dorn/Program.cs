using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3_dorn
{

    abstract class Artikel
    {

        public string Name { get; }
        public Artikel (string name)
        {
            Name = name;
        }

        public abstract decimal GetPreis();
       


    }

    class Katze : Artikel
    {
        public int Leben { get; private set; } = 7;
        public void Sterben() => Leben--;

        public Katze(string name, int leben) : base(name)
        {
            Leben = leben > 0 ? leben : 1;

        }

        public override decimal GetPreis()
        {
            return 123;
        }

    }

    class Hund : Artikel
    {
        public string Rasse { get; }
        public Hund(string name, string rasse) : base(name)
        {
            Rasse = rasse;
        }

        public override decimal GetPreis()
        {
            
            return 456;
        }
    }

    class Program
    {
        static void PrintArtikel(Artikel x)
        {

            //Console.WriteLine($"[name: {x.Name}]");
            Console.WriteLine($"[name: {x.Name}; preis: {x.GetPreis()}]");
        }

        static void Main(string[] args)
        {
            //var a = new Artikel("Artikel A");
            var b = new Katze("Kathe K", 11);
            var c = new Hund("Hund H", "Dackel");

            //PrintArtikel(a);
            PrintArtikel(b);
            PrintArtikel(c);


        }
    }
}
