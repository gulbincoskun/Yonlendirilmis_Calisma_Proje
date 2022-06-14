using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NeredeNeYesem.Models.Siniflar
{
    public class MekanYorum
    {
        public IEnumerable<YemekMekanlari> Deger1 { get; set; }
        public IEnumerable<Yorumlar> Deger2 { get; set; }
        public IEnumerable<YemekMekanlari> Deger3 { get; set; }

    }
}