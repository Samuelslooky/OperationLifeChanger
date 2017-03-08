using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OperationLifeChanger.Models
{
    public class Mineraler
    {
        public List<Næringsstof> mineralListe = new List<Næringsstof>();

        private static string[] mineralNavne = { "Calcium#Mikro", "Jod#Milli", "Jern#Milli", "Magnesium#Milli",
            "Fosfor#Milli", "Kobber#Milli", "Mangan#Milli", "Krom#Mikro", "Molybdæn#Mikro", "Zink#Milli", "Kalium#Milli" };

        public Mineraler(double mineral_Calcium, double mineral_Jod, double mineral_Jern, double mineral_Magnesium, double mineral_Fosfor, double mineral_Kobber,
            double mineral_Mangan, double mineral_Krom, double mineral_Molybdæn, double mineral_Zink, double mineral_Kalium)

        {
            DoCreate(mineral_Calcium, mineral_Jod, mineral_Jern, mineral_Magnesium, mineral_Fosfor, mineral_Kobber,
            mineral_Mangan, mineral_Krom, mineral_Molybdæn, mineral_Zink, mineral_Kalium);
        }

        public void DoCreate(params object[] values)
        {
            for (int i = 0; i <= mineralNavne.Length; i++)
            {
                try
                {
                    Næringsstof næringsstof = new Næringsstof(mineralNavne[i], Næringsstof.Type.Mineral, (double)values[i]);

                    mineralListe.Add(næringsstof);
                }
                catch (IndexOutOfRangeException)
                {
                    break;
                }
            }
        }

        public Mineraler()
        {

        }
    }
}