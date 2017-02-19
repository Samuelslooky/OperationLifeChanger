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


            //            <asp:TextBox runat = "server" ID="fødevareNavnFelt"/><br /><br />
            //<asp:TextBox runat = "server" ID="KalorierPr100Felt" /><br /><br />
            //<asp:TextBox runat = "server" ID="samletProteinFelt" /><br /><br />
            //<asp:TextBox runat = "server" ID="samletKulhydratFelt" /><br /><br />
            //<asp:TextBox runat = "server" ID="samletFedtFelt" /><br /><br />
            //<asp:TextBox runat = "server" ID="BeskrivelseFelt" TextMode="MultiLine" Height="200px" Width="300px"/><br /><br />

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        public void createFoodButtonClicked(object sender, EventArgs e)
        {
            Fedt fedt = new Fedt(double.Parse(samletFedtFelt.Text), 0, 0, 0);
            Kulhydrat kulhydrat = new Kulhydrat(double.Parse(samletKulhydratFelt.Text), 0, 0);
            Protein protein = new Protein(double.Parse(samletProteinFelt.Text));
            Vitaminer vitaminer = new Vitaminer();
            Mineraler mineraler = new Mineraler();

            Fødevare fødevare = new Fødevare(fødevareNavnFelt.Text, beskrivelseFelt.Text, protein, fedt, kulhydrat, vitaminer, mineraler);

            fødevareListe.Add(fødevare);
        }
    }
}