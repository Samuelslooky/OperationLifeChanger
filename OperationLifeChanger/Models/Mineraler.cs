using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OperationLifeChanger.Models
{
    public class Mineraler
    {
        public List<Mikronæringsstof> mineralListe = new List<Mikronæringsstof>();

        private static string[] MineralNavne = { "Calcium#Mikro", "Jod#Milli", "Jern#Milli", "Magnesium#Milli",
            "Fosfor#Milli", "Kobber#Milli", "Mangan#Milli", "Krom#Mikro", "Molybdæn#Mikro", "Zink#Milli" };

        public Mineraler(double mineral_Calcium, double mineral_Jod, double mineral_Jern, double mineral_Magnesium, double mineral_Fosfor, double mineral_Kobber,
            double mineral_Mangan, double mineral_Krom, double mineral_Molybdæn, double mineral_Zink)

        {
            DoCreate(mineral_Calcium, mineral_Jod, mineral_Jern, mineral_Magnesium, mineral_Fosfor, mineral_Kobber,
            mineral_Mangan, mineral_Krom, mineral_Molybdæn, mineral_Zink);
        }

        public void DoCreate(params object[] values)
        {
            for (int i = 0; i <= MineralNavne.Length; i++)
            {
                try
                {
                    string mineralString = MineralNavne[i];

                    string[] mineralSplit = mineralString.Split('#');

                    Mikronæringsstof.Enhed mineralEnhed = Mikronæringsstof.Enhed.Gram;

                    switch (mineralSplit[1])
                    {
                        case "Gram":
                            mineralEnhed = Mikronæringsstof.Enhed.Gram;
                            break;
                        case "Milli":
                            mineralEnhed = Mikronæringsstof.Enhed.Milligram;
                            break;
                        case "Mikro":
                            mineralEnhed = Mikronæringsstof.Enhed.Mikrogram;
                            break;
                        case "Nano":
                            mineralEnhed = Mikronæringsstof.Enhed.Nanogram;
                            break;
                    }

                    Mikronæringsstof mikronæringsstof = new Mikronæringsstof(mineralSplit[0], Mikronæringsstof.Type.Mineral, (double)values[i], mineralEnhed);

                    mineralListe.Add(mikronæringsstof);
                }
                catch (Exception)
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