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

        bool ricerca = false;

        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["user"] == null || Session["user"] == "")
            {
                Response.Redirect("Default.aspx");
            }

            AnnullaRicercaButton.Visible = this.ricerca;

            using (var db = new AppDbContext()) {
                var elenco = db.Prodotti.OrderBy(p => p.Titolo).ToList();
                GridViewProdotti.DataSource = elenco;
                GridViewProdotti.DataBind();
            }

            ProdottoDaEliminareNonTrovatoLabel.Visible = false;
        }

        protected void LogoutButton_Click(object sender, EventArgs e)
        {
            var _default = new _Default();
            _default.Logout();
            Response.Redirect("Default.aspx");
        }

        
        protected void EliminaProdotto_Click(Object sender, EventArgs e)
        {
            using (var db = new AppDbContext())
            {
                var idProdotto = int.Parse(IdProdottoDaEliminareInput.Text);
                var prodotto = db.Prodotti.Find(idProdotto);

                if (prodotto == null)
                {
                    ProdottoDaEliminareNonTrovatoLabel.Visible = true;
                } else
                {
                    db.Prodotti.Remove(prodotto);
                    db.SaveChanges();

                    Response.Redirect("./ElencoProdotti.aspx");
                }
			}
		}

		protected void CercaButton_Click(Object sender, EventArgs e)
        {
            var filtro = CercaInput.Text;

            using (var db = new AppDbContext())
            {
                var elencoProdottiFiltrati = db.Prodotti.Where(p => p.Titolo.Equals(filtro)).ToList();
                GridViewProdotti.DataSource = elencoProdottiFiltrati;
                GridViewProdotti.DataBind();
                this.ricerca = true;
                AnnullaRicercaButton.Visible = this.ricerca;
            }
        }

		protected void AnnullaRicercaButton_Click(Object sender, EventArgs e)
        {
            using (var db = new AppDbContext())
            {
                var elenco = db.Prodotti.OrderBy(p => p.Titolo).ToList();
                GridViewProdotti.DataSource = elenco;
                GridViewProdotti.DataBind();
                this.ricerca = false;
                AnnullaRicercaButton.Visible = this.ricerca;
            }
        }
        
    }
}