using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OperationLifeChanger.Models
{
    public class Næringsstof
    {
        public string Navn;

        public Type Næringstype;

        public double Mængde;

        public Enhed Måleenhed;

        public enum Type { Protein, Kulhydrat, Fedt, Vitamin, Mineral, Andet };

        public enum Enhed { Gram, Milligram, Mikrogram, Nanogram };

        public Næringsstof(string navn, Type type, double mængde, Enhed måleenhed)
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

        public Næringsstof(string navnEnhedText, Type type, double mængde)
        {
            string[] navnEnhedSplit = navnEnhedText.Split('#');

            Navn = navnEnhedSplit[0];

            Mængde = mængde;

            Næringstype = type;

            switch (navnEnhedSplit[1])
            {
                case "Gram":
                    Måleenhed = Næringsstof.Enhed.Gram;
                    break;
                case "Milli":
                    Måleenhed = Næringsstof.Enhed.Milligram;
                    break;
                case "Mikro":
                    Måleenhed = Næringsstof.Enhed.Mikrogram;
                    break;
                case "Nano":
                    Måleenhed = Næringsstof.Enhed.Nanogram;
                    break;
            }
        }
    }
}