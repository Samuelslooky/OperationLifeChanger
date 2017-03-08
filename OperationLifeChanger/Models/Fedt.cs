using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OperationLifeChanger.Models
{
    public class Fedt
    {
        public List<Næringsstof> fedtListe = new List<Næringsstof>();

        private static string[] fedtNavne = {"SamletFedt#Gram", "MættetFedt#Gram", "FlerumættetFedtsyrer#Gram",
            "Enkeltumættet#Gram", "Omega3#Gram", "Omega6#Gram"};

        public Fedt(double samletFedt, double mættetFedt, double flerumættetFedtsyrer, double enkeltumættetFedtsyrer, double omega3, double omega6)
        {
            DoCreate(samletFedt, mættetFedt, flerumættetFedtsyrer, enkeltumættetFedtsyrer, omega3, omega6);
        }

        public void DoCreate(params object[] values)
        {
            for (int i = 0; i <= fedtNavne.Length; i++)
            {
                try
                {
                    Næringsstof næringsstof = new Næringsstof(fedtNavne[i], Næringsstof.Type.Fedt, (double)values[i]);

                    fedtListe.Add(næringsstof);
                }
                catch (IndexOutOfRangeException)
                {
                    break;
                }
            }
        }

        public Fedt()
        {

        }
    }
}