﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebSitem.Models.Siniflar
{
    public class ikonlar
    {
        [Key]
        public int id { get; set; }
        public string ikon { get; set; }
        public string link { get; set; }
    }
}