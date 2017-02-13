using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OperationLifeChanger.Models
{
    public class Fedt
    {
        private double SamletFedt;

        private double MættetFedt;

        private double FlerumættetFedtsyrer;

        private double EnkeltumættetFedtsyrer;

        public Fedt(double samletFedt, double mættetFedt, double flerumættetFedtsyrer, double enkeltumættetFedtsyrer)
        {
            SamletFedt = samletFedt;
            MættetFedt = mættetFedt;
            FlerumættetFedtsyrer = flerumættetFedtsyrer;
            EnkeltumættetFedtsyrer = enkeltumættetFedtsyrer; 
        }
    }
}