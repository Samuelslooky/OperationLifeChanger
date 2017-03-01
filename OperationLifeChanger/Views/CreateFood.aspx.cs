using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OperationLifeChanger.Models
{
    public partial class CreateFood : System.Web.UI.Page
    {
        List<Fødevare> fødevareListe = new List<Fødevare>();

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        public void createFoodButtonClicked(object sender, EventArgs e)
        {
            Fedt fedt = new Fedt(double.Parse(samletFedtFelt.Text), double.Parse(MættetFedtFelt.Text), double.Parse(FlerFedtFelt.Text), double.Parse(EnkeltFedtFelt.Text));

            Kulhydrat kulhydrat = new Kulhydrat(double.Parse(samletKulhydratFelt.Text), double.Parse(sukkerarterFelt.Text), double.Parse(FifreFelt.Text));

            Protein protein = new Protein(double.Parse(samletProteinFelt.Text));

            Vitaminer vitaminer = new Vitaminer(double.Parse(VitaminAFelt.Text), double.Parse(VitaminB1Felt.Text), double.Parse(VitaminB2Felt.Text), double.Parse(VitaminB3Felt.Text),
                double.Parse(VitaminB5Felt.Text), double.Parse(VitaminB6Felt.Text), double.Parse(VitaminB7Felt.Text), double.Parse(VitaminB9Felt.Text), double.Parse(VitaminB12Felt.Text),
                double.Parse(VitaminCFelt.Text), double.Parse(VitaminDFelt.Text), double.Parse(VitaminEFelt.Text), double.Parse(VitaminKFelt.Text));

            Mineraler mineraler = new Mineraler(double.Parse(CalciumFelt.Text), double.Parse(JodFelt.Text), double.Parse(JernFelt.Text), double.Parse(MagnesiumFelt.Text), 
                double.Parse(FosforFelt.Text), double.Parse(KobberFelt.Text), double.Parse(ManganFelt.Text), double.Parse(KromFelt.Text), double.Parse(MolybdænFelt.Text), double.Parse(ZinkFelt.Text));

            Fødevare fødevare = new Fødevare(fødevareNavnFelt.Text, beskrivelseFelt.Text, protein, fedt, kulhydrat, vitaminer, mineraler);

            fødevareListe.Add(fødevare);
        }

        public void beregnKalorier(object sender, EventArgs e)
        {
            double protein = samletProteinFelt.Text != null ? double.Parse(samletProteinFelt.Text) : 0;
            double kulhydrat = samletKulhydratFelt.Text != null ? double.Parse(samletKulhydratFelt.Text) : 0;
            double fedt = samletFedtFelt.Text != null ? double.Parse(samletFedtFelt.Text) : 0;
            double alkohol = 0;


            KalorierPr100Felt.Text = Fødevare.BeregnKalorier(protein, kulhydrat, fedt, alkohol).ToString();
        }
    }
}