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
    
    public partial class Narudzba
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Narudzba()
        {
            this.Napredak = new HashSet<Napredak>();
            this.Racun = new HashSet<Racun>();
            this.Dijelovi = new HashSet<Dijelovi>();
        }
    
        public int ID_narudzbe { get; set; }
        public string Korisnicko_ime { get; set; }
        public string Registracija_vozila { get; set; }
        public string Marka_vozila { get; set; }
        public string Model_vozila { get; set; }
        public int Stanje_brojaca { get; set; }
        public string Napomene { get; set; }
        public System.DateTime Datum_narudzbe { get; set; }
        public Nullable<byte> Potvrđeno { get; set; }
        public Nullable<byte> Otkazano { get; set; }
        public Nullable<byte> Zavrsena { get; set; }
    
        public virtual Korisnik Korisnik { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Napredak> Napredak { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Racun> Racun { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Dijelovi> Dijelovi { get; set; }
    }
}