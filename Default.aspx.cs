using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebForm1App.models;
using WebForm1App;

namespace WebForm1App
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void salva_Click(object sender, EventArgs e)
        {
            var nuovoProdotto = new Prodotto() {
                Titolo = titolo.Text,
                Prezzo = Double.Parse(prezzo.Text)
            };

            using (var db = new AppDbContext())
            {
                try
                {
                    db.Prodotti.Add(nuovoProdotto);
                    db.SaveChanges();
                    lbl_esito_operazione.Text = "Prodotto salvato";
                } catch (Exception ex)
                {
                    lbl_esito_operazione.Text = "Si è vericato un problema";
                }
            }

        }
    }
}