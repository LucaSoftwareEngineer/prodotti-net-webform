using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebForm1App.models;
using WebForm1App;
using CyberCrypt;

namespace WebForm1App
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LoginButton_Click(object sender, EventArgs e)
        {
            using (var db = new AppDbContext())
            {
                var username = Username.Text;
                var password = _SHA.SHA512Hash(Password.Text);

                var manager = db.Managers.Where(m => m.Username.Equals(username) && m.Password.Equals(password)).FirstOrDefault();

                if (manager != null) {
                    Session["user"] = manager.Username;
                    Response.Redirect("ElencoProdotti.aspx");
                }

            }
        }

        public bool Logout()
        {
            Session.Abandon();
            return true;
        }
    }
}