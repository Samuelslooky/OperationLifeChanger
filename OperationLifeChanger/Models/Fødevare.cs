using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OperationLifeChanger.Models
{
    public class Fødevare
    {

        public string Navn;

        public string Beskrivelse;

        public Protein Protein;

        public Fedt Fedt;

        public Kulhydrat Kulhydrat;

        public Vitaminer Vitaminer;

        public Mineraler Mineraler;

        public Fødevare(string navn, string beskrivelse, Protein protein, Fedt fedt, Kulhydrat kulhydrat, Vitaminer vitaminer, Mineraler mineraler)
        {
            Navn = navn;
            Beskrivelse = beskrivelse;
            Protein = protein;
            Fedt = fedt;
            Kulhydrat = kulhydrat;
            Vitaminer = vitaminer;
            Mineraler = mineraler;
        }

        public static double BeregnKalorier(double samletProtein, double samletKulhydrat, double samletFedt, double alkohol)
        {
            double kalorierPr100 = 0;

            kalorierPr100 = kalorierPr100 + (samletProtein * 4);
            kalorierPr100 = kalorierPr100 + (samletKulhydrat * 4);
            kalorierPr100 = kalorierPr100 + (samletFedt * 9);
            kalorierPr100 = kalorierPr100 + (alkohol * 7);

            return kalorierPr100;
        }
    }
}
    

