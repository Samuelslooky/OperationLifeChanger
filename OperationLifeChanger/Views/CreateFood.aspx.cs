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
            Fedt fedt = new Fedt(double.Parse(samletFedtFelt.Text), double.Parse(MættetFedtFelt.Value), double.Parse(FlerFedtFelt.Value), double.Parse(EnkeltFedtFelt.Value));

            Kulhydrat kulhydrat = new Kulhydrat(double.Parse(samletKulhydratFelt.Text), double.Parse(sukkerarterFelt.Value), double.Parse(FibreFelt.Value));

            Protein protein = new Protein(double.Parse(samletProteinFelt.Text));

            Vitaminer vitaminer = new Vitaminer(double.Parse(VitaminAFelt.Value), double.Parse(VitaminB1Felt.Value), double.Parse(VitaminB2Felt.Value), double.Parse(VitaminB3Felt.Value),
                double.Parse(VitaminB5Felt.Value), double.Parse(VitaminB6Felt.Value), double.Parse(VitaminB7Felt.Value), double.Parse(VitaminB9Felt.Value), double.Parse(VitaminB12Felt.Value),
                double.Parse(VitaminCFelt.Value), double.Parse(VitaminDFelt.Value), double.Parse(VitaminEFelt.Value), double.Parse(VitaminKFelt.Value));

            Mineraler mineraler = new Mineraler(double.Parse(CalciumFelt.Value), double.Parse(JodFelt.Value), double.Parse(JernFelt.Value), double.Parse(MagnesiumFelt.Value), 
                double.Parse(FosforFelt.Value), double.Parse(KobberFelt.Value), double.Parse(ManganFelt.Value), double.Parse(KromFelt.Value), double.Parse(MolybdænFelt.Value), double.Parse(ZinkFelt.Value));

            Fødevare fødevare = new Fødevare(fødevareNavnFelt.Value, beskrivelseFelt.Text, protein, fedt, kulhydrat, vitaminer, mineraler);

            fødevareListe.Add(fødevare);
        }

        public void beregnKalorier(object sender, EventArgs e)
        {
            if (CalculatePr100Auto.Checked)
            {
                samletProteinFelt.AutoPostBack = true;
                samletKulhydratFelt.AutoPostBack = true;
                samletFedtFelt.AutoPostBack = true;

                double protein = !string.IsNullOrEmpty(samletProteinFelt.Text) ? double.Parse(samletProteinFelt.Text) : 0;
                double kulhydrat = !string.IsNullOrEmpty(samletKulhydratFelt.Text) ? double.Parse(samletKulhydratFelt.Text) : 0;
                double fedt = !string.IsNullOrEmpty(samletFedtFelt.Text) ? double.Parse(samletFedtFelt.Text) : 0;
                double alkohol = 0;


                KalorierPr100Felt.Value = Fødevare.BeregnKalorier(protein, kulhydrat, fedt, alkohol).ToString();

                KalorierPr100Felt.Disabled = true;
            }
            else
            {
                samletProteinFelt.AutoPostBack = true;
                samletKulhydratFelt.AutoPostBack = true;
                samletFedtFelt.AutoPostBack = true;

                KalorierPr100Felt.Value = "0";
                KalorierPr100Felt.Disabled = false;
            }
        }
    }
}