using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OperationLifeChanger.Models
{
    public class Kulhydrater
    {
        public List<Næringsstof> kulhydratListe = new List<Næringsstof>();

        private static string[] kulhydratNavne = { "SamletKulhydrat#Gram", "Sukkerarter#Gram", "Fibre#Gram" };

        public Kulhydrater(double samletKulhydrat, double sukkerarter, double fibre)
        {
            DoCreate(samletKulhydrat, sukkerarter, fibre);
        }
        public void DoCreate(params object[] values)
        {
            for (int i = 0; i <= kulhydratNavne.Length; i++)
            {
                try
                {
                    Næringsstof næringsstof = new Næringsstof(kulhydratNavne[i], Næringsstof.Type.Kulhydrat, (double)values[i]);

                    kulhydratListe.Add(næringsstof);
                }
                catch (IndexOutOfRangeException)
                {
                    break;
                }
            }
        }
        public Kulhydrater()
        {

        }
    }
}