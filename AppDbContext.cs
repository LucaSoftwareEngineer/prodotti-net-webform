using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebForm1App.models;

namespace WebForm1App
{
    public class AppDbContext: DbContext
    {
        public AppDbContext() : base("name=db_locale")
        {

        }

        public DbSet<Prodotto> Prodotti { get; set; }
    }
}