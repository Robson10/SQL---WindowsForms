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
    
    public partial class Gatunek
    {
        public Gatunek()
        {
            this.Towar = new HashSet<Towar>();
        }
    
        public int Ga_ID { get; set; }
        public string Ga_Gatunek { get; set; }
    
        public virtual ICollection<Towar> Towar { get; set; }
    }
}