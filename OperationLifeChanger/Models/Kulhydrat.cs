using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OperationLifeChanger.Models
{
    public class Kulhydrat
    {
        private double SamletKulhydrat;

        private double Sukkerarter;

        private double Fibre;

        public Kulhydrat(double samletKulhydrat, double sukkerarter, double fibre)
        {
            SamletKulhydrat = samletKulhydrat;
            Sukkerarter = sukkerarter;
            Fibre = fibre;
        }
    }
}