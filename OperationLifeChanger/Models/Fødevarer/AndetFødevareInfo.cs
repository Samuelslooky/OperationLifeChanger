using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OperationLifeChanger.Models.Fødevarer
{
    public class AndetFødevareInfo
    {
        public List<Næringsstof> andetListe = new List<Næringsstof>();

        private static string[] andetNavne = { "Alkohol#Gram", "Salt#Milli" };

        public AndetFødevareInfo(double alkohol, double salt)

        {
            DoCreate(alkohol, salt);
        }

        public void DoCreate(params object[] values)
        {
            for (int i = 0; i <= andetNavne.Length; i++)
            {
                try
                {
                    Næringsstof næringsstof = new Næringsstof(andetNavne[i], Næringsstof.Type.Andet, (double)values[i]);

                    andetListe.Add(næringsstof);
                }
                catch (IndexOutOfRangeException)
                {
                    break;
                }
            }
        }

        public AndetFødevareInfo()
        {

        }
    }
}