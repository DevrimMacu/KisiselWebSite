using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebSitem.Models.Siniflar
{
    public class AnaSayfa
    {
        [Key]
        public int id { get; set; }
        public string Profil  { get; set; }
        public string isim { get; set; }
        
        public string Unvan { get; set; }
        public string Aciklama { get; set; }
        public string iletisim { get; set; }

    }
}