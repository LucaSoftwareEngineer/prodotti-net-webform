using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebForm1App.models
{
    [Table("managers")]
    public class Manager
    {
        [Key]
        [Column("man_id")]
        public int Id { get; set; }

        [Column("man_username")]
        public string Username { get; set; }

        [Column("man_password")]
        public string Password { get; set; }
    }
}