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
    
    public partial class Dio_u_kupovini
    {
        public int ID_kupovine { get; set; }
        public int ID_dijela { get; set; }
        public int Kolicina { get; set; }
    
        public virtual Dijelovi Dijelovi { get; set; }
        public virtual Kupovina Kupovina { get; set; }
    }
}
