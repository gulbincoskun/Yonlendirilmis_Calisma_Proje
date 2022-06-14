using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace NeredeNeYesem.Models.Siniflar
{
    public class Context:DbContext
    {
        
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Hakkimizda> Hakkimizdas { get; set; }
        public DbSet<AdresSite> AdresSites { get; set; }
        public DbSet<Iletisim> Iletisims { get; set; }
        public DbSet<YemekMekanlari> YemekMekanlaris { get; set; }
        public DbSet<Yorumlar> Yorumlars{ get; set; }
    }
}