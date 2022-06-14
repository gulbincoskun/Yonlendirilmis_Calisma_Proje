﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NeredeNeYesem.Models.Siniflar
{
    public class YemekMekanlari
    {
        [Key]
        public int ID { get; set; }
        public string Baslik { get; set; }
        public DateTime Tarih { get; set; }
        public string FotoUrl { get; set; }
        public string Aciklama { get; set; }
        public ICollection<Yorumlar> Yorumlars { get; set; } 
       
    }
}