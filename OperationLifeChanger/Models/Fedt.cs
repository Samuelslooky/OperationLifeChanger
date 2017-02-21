using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OperationLifeChanger.Models
{
    public class Fedt
    {
        public double SamletFedt;

        public double MættetFedt;

        public double FlerumættetFedtsyrer;

        public double EnkeltumættetFedtsyrer;

        public Fedt(double samletFedt, double mættetFedt, double flerumættetFedtsyrer, double enkeltumættetFedtsyrer)
        {
            SamletFedt = samletFedt;
            MættetFedt = mættetFedt;
            FlerumættetFedtsyrer = flerumættetFedtsyrer;
            EnkeltumættetFedtsyrer = enkeltumættetFedtsyrer; 
        }
    }
}