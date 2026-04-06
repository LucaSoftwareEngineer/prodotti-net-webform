using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebForm1App
{
    public partial class ElencoProdottiaspx : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using (var db = new AppDbContext()) {
                var elenco = db.Prodotti.OrderBy(p => p.Titolo).ToList();
                GridViewProdotti.DataSource = elenco;
                GridViewProdotti.DataBind();
            }
        }
    }
}