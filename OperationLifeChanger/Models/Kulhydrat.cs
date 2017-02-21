using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OperationLifeChanger.Models
{
    public class Kulhydrat
    {
        public double SamletKulhydrat;

        public double Sukkerarter;

        public double Fibre;

        public Kulhydrat(double samletKulhydrat, double sukkerarter, double fibre)
        {
            SamletKulhydrat = samletKulhydrat;
            Sukkerarter = sukkerarter;
            Fibre = fibre;
        }
    }
}