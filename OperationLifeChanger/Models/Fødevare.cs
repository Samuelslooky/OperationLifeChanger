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

        public Proteiner Proteiner;

        public Fedt Fedt;

        public Kulhydrater Kulhydrater;

        public Vitaminer Vitaminer;

        public Mineraler Mineraler;

        public AndetFødevareInfo Andet;

        public Fødevare(string navn, string beskrivelse, Proteiner protein, Fedt fedt, Kulhydrater kulhydrat, Vitaminer vitaminer, Mineraler mineraler, AndetFødevareInfo andet)
        {
            Navn = navn;
            Beskrivelse = beskrivelse;
            Proteiner = protein;
            Fedt = fedt;
            Kulhydrater = kulhydrat;
            Vitaminer = vitaminer;
            Mineraler = mineraler;
            Andet = andet;
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
    

