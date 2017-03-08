using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OperationLifeChanger.Models
{
    public class Vitaminer
    {
        public List<Næringsstof> vitaminListe = new List<Næringsstof>();

        private static string[] vitaminNavne = { "A#Mikro", "B1#Milli", "B2#Milli", "B3#Milli", "B5#Milli", "B6#Milli",
            "B7#Milli", "B9#Mikro", "B12#Mikro", "C#Milli", "D#Mikro", "E#Milli", "K#Mikro" };

        public Vitaminer(double vitamin_A, double vitamin_B1, double vitamin_B2, double vitamin_B3, double vitamin_B5, double vitamin_B6,
            double vitamin_B7, double vitamin_B9, double vitamin_B12, double vitamin_C, double vitamin_D, double vitamin_E, double vitamin_K)

        {
            DoCreate(vitamin_A, vitamin_B1, vitamin_B2, vitamin_B3, vitamin_B5, vitamin_B6,
            vitamin_B7, vitamin_B9, vitamin_B12, vitamin_C, vitamin_D, vitamin_E, vitamin_K);
        }

        public void DoCreate(params object[] values)
        {
            for (int i = 0; i <= vitaminNavne.Length; i++)
            {
                try
                {
                    Næringsstof næringsstof = new Næringsstof(vitaminNavne[i], Næringsstof.Type.Vitamin, (double)values[i]);

                    vitaminListe.Add(næringsstof);
                }
                catch (IndexOutOfRangeException)
                {
                    break;
                }
            }
        }

        public Vitaminer()
        {

        }
    }
}