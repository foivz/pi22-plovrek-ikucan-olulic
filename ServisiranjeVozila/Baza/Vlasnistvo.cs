//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Baza
{
    using System;
    using System.Collections.Generic;
    
    public partial class Vlasnistvo
    {
        public string Registracija_vozila { get; set; }
        public string Korisnicko_ime { get; set; }
        public byte[] Od { get; set; }
        public Nullable<System.DateTime> Do { get; set; }
    
        public virtual Korisnik Korisnik { get; set; }
        public virtual Vozilo Vozilo { get; set; }
    }
}
