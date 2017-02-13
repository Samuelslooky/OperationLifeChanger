using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using OperationLifeChanger.Models;

namespace OperationLifeChanger.Views
{
    public partial class Main : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataBaseConnection DataBase = new DataBaseConnection();

            Response.Redirect("http://localhost:54642/Views/CreateFood.aspx");
        }
    }
}