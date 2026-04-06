using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebForm1App.models
{
    public class Prodotto
    {
        [Key]
        public int IdProdotto { get; set; }
        public string Titolo { get; set; }
        public double Prezzo { get; set; }
    }
}