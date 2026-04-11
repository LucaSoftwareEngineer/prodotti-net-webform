using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebForm1App
{
    public partial class ModificaProdotto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            RisulatatoModifica.Visible = false;
            var idProdotto = Request.QueryString["id"];

            if (Session["user"] == null || Session["user"] == "")
            {
                Response.Redirect("Default.aspx");
            }

            if (!IsPostBack)
            {
                if (idProdotto == null)
                {
                    Response.Redirect("ElencoProdotti.aspx");
                }
                else
                {
                    using (var db = new AppDbContext())
                    {
                        var prodotto = db.Prodotti.Find(int.Parse(idProdotto));
                        if (prodotto == null)
                        {
                            Response.Redirect("ElencoProdotti.aspx");
                        }
                        else
                        {
                            idProdottoHidden.Value = prodotto.IdProdotto.ToString();
                            TitoloInput.Text = prodotto.Titolo;
                            PrezzoInput.Text = prodotto.Prezzo.ToString();
                        }
                    }
                }
            }

        }

        protected void Modifica_Click(object sender, EventArgs e)
        {
            using (var db = new AppDbContext())
            {
                var idProdotto = int.Parse(idProdottoHidden.Value);
                var prodotto = db.Prodotti.Where(p => p.IdProdotto == idProdotto).FirstOrDefault();
                
                if (prodotto != null)
                {
                    prodotto.Titolo = TitoloInput.Text;
                    prodotto.Prezzo = int.Parse(PrezzoInput.Text);

                    db.SaveChanges();

                    RisulatatoModifica.Text = "Modifiche salvate";

                } else
                {
                    RisulatatoModifica.Text = "Si è verificato un errore, riprova più tardi";
                }

                RisulatatoModifica.Visible = true;

            }
        }

        protected void LogoutButton_Click(object sender, EventArgs e)
        {
            var _default = new _Default();
            _default.Logout();
            Response.Redirect("Default.aspx");
        }
    }
}