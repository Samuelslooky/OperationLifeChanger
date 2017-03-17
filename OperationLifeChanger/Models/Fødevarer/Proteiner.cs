using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OperationLifeChanger.Models.Fødevarer
{
    public class Proteiner
    {
        public double SamletProtein;

        public List<Næringsstof> proteinListe = new List<Næringsstof>();

        private static string[] proteinNavne = { "SamletProtein#Gram" };

        public Proteiner(double samletProtein)
        {
            DoCreate(samletProtein);
        }

        public void DoCreate(params object[] values)
        {
            for (int i = 0; i <= proteinNavne.Length; i++)
            {
                try
                {
                    Næringsstof næringsstof = new Næringsstof(proteinNavne[i], Næringsstof.Type.Protein, (double)values[i]);

                    proteinListe.Add(næringsstof);
                }
                catch (IndexOutOfRangeException)
                {
                    break;
                }
            }
        }

        public Proteiner()
        {

        }
    }
}