//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DesktopSQL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Klienci
    {
        public Klienci()
        {
            this.Zamowienia = new HashSet<Zamowienia>();
        }
    
        public int Kl_ID { get; set; }
        public string Kl_Imie { get; set; }
        public string Kl_Nazwisko { get; set; }
        public string Kl_Pesel { get; set; }
        public string Kl_Mail { get; set; }
        public string Kl_Adres { get; set; }
    
        public virtual ICollection<Zamowienia> Zamowienia { get; set; }
    }
}
