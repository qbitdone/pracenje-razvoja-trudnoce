//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PRT
{
    using System;
    using System.Collections.Generic;
    
    public partial class majka_dodatak_prehrani
    {
        public int id_majka_dodatak { get; set; }
        public int id_majka { get; set; }
        public int id_dodatak { get; set; }
        public int kolicina { get; set; }
        public System.DateTime datum_uzimanja { get; set; }
    
        public virtual dodatak_prehrani dodatak_prehrani { get; set; }
        public virtual majka majka { get; set; }
    }
}
