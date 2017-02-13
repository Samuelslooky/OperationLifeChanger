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
    }
}
    

