using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OperationLifeChanger.Models
{
    public class Vitaminer
    {
        public Dictionary<string, double> vitaminDictionary = new Dictionary<string, double>();

        public string[] VitaminNavne = { @"Vitamin_A, Vitamin_B1, Vitamin_B2, Vitamin_B3, Vitamin_B5, Vitamin_B6,
            Vitamin_B7, Vitamin_B9, Vitamin_B12, Vitamin_C, Vitamin_D, Vitamin_E, Vitamin_K" }; 

        public Vitaminer(double vitamin_A, double vitamin_B1, double vitamin_B2, double vitamin_B3, double vitamin_B5, double vitamin_B6, 
            double vitamin_B7, double vitamin_B9, double vitamin_B12, double vitamin_C, double vitamin_D, double vitamin_E, double vitamin_K)

        {
            DoCreate(vitamin_A, vitamin_B1, vitamin_B2, vitamin_B3, vitamin_B5, vitamin_B6,
            vitamin_B7, vitamin_B9, vitamin_B12, vitamin_C, vitamin_D, vitamin_E, vitamin_K);
        }

        public void DoCreate(params object[] values)
        {
            for (int i = 0; i <= VitaminNavne.Length; i++)
            {
                vitaminDictionary.Add(VitaminNavne[i], (double)values[i]);
            }
            
        }

        public Vitaminer()
        {

        }
    }
}