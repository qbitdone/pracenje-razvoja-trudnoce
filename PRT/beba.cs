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
    
    public partial class beba
    {
        public int id_beba { get; set; }
        public int id_majka { get; set; }
        public string ime { get; set; }
        public string prezime { get; set; }
        public string spol { get; set; }
    
        public virtual majka majka { get; set; }
    }
}
