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
        //private int m_alter;

        public Verein(string newName, string newInstrument)
        {
            if (string.IsNullOrWhiteSpace(newName)) throw new ArgumentException("Name darf nicht leer sein.", nameof(newName));
            if (string.IsNullOrWhiteSpace(newInstrument)) throw new ArgumentException("Alter muss > 0 sein.", nameof(newAlter));

            Name = newName;
            Instrument = newInstrument;
            UpdateAlter(m_alter);


        }

        public string Name { get; }
        public string Instrument { get; }
        public int  m_alter { get; private set; }

        static void Main(string[] args)
        {
            var verein = new[]
            {
                new Verein("Dorn", "Klarinette"),
                new Verein("Kuestner", "Fluegelhorn"),
                new Verein("Mauser", "Tuba"),

            };

            foreach (var b in verein)
            {
                Console.WriteLine(b.Name, b.Instrument, b.m_alter);
            }
        }

        public void UpdateAlter(int newAlter)
        {
            if (newAlter <= 0) throw new ArgumentException("Alter darf nicht 0 sein.", nameof(newAlter));
            m_alter = newAlter;

        }
    }
}

