using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OperationLifeChanger.Models
{
    public class Mikronæringsstof
    {
        public string Navn;

        public Type Næringstype; 

        public double Mængde;

        public Enhed Måleenhed;

        public enum Type {Vitamin, Mineral};

        public enum Enhed { Gram, Milligram, Mikrogram, Nanogram };

        public Mikronæringsstof(string navn, Type type,  double mængde, Enhed måleenhed)
        {
            Navn = navn;

            if (type == Type.Mineral)
                Næringstype = Type.Mineral;
            else
                Næringstype = Type.Vitamin;

            Mængde = mængde;

            if (måleenhed == Enhed.Gram)
                Måleenhed = Enhed.Gram;
            else if (måleenhed == Enhed.Milligram)
                Måleenhed = Enhed.Milligram;
            else if (måleenhed == Enhed.Mikrogram)
                Måleenhed = Enhed.Mikrogram;
            else
                Måleenhed = Enhed.Nanogram;
        }
    }
}