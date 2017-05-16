
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Net;

namespace Task2
{

    public class Verein
    {
       
        public Verein(string name, string alter)
        {
            if (string.IsNullOrWhiteSpace(name)) throw new ArgumentException("Name darf nicht leer sein.", nameof(name));
            if (string.IsNullOrWhiteSpace(alter)) throw new ArgumentException("Alter darf nicht leer sein.", nameof(alter));

            Name = name;
            Alter = alter;
        }

        public string Name { get; }

        public string Alter { get; }

    }

    class MainClass
    {
        public static void Main(string[] args)
        {
            var verein = new[]
            {
                new Verein("Rainer Dorn", "28"),
                new Verein("Max Mustermann", "18"),
                new Verein("Judith Haberl", "23"),
                new Verein("Stefanie Frank", "22"),
                
            };

            
            foreach (var b in verein)
            {
                Console.WriteLine("{0} {1,-40}", b.Alter, b.Name.Truncate(40));
            }

            var alter = verein.Select(x => x.Alter).OrderBy(x => x);
            Console.WriteLine();
            Console.WriteLine("Alter sortiert");
            foreach (var x in alter) Console.WriteLine(x);
        }
    }

    

    public static class StringExtensions
    {
       
        public static string Truncate(this string s, int maxLength) => (s == null || s.Length <= maxLength) ? s : s.Substring(0, maxLength);
    }
}




