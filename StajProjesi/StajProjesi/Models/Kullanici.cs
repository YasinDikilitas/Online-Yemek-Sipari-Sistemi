//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StajProjesi.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Kullanici
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Kullanici()
        {
            this.SatısBilgi = new HashSet<SatısBilgi>();
            this.SepetUrunlers = new HashSet<SepetUrunler>();
        }
    
        public int id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Mail { get; set; }
        public string Sifre { get; set; }
        public Nullable<int> adresid { get; set; }
        public Nullable<int> kartid { get; set; }
        public Nullable<bool> Aktiflik_durumu { get; set; }
    
        public virtual Adre Adre { get; set; }
        public virtual KartBilgisi KartBilgisi { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SatısBilgi> SatısBilgi { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SepetUrunler> SepetUrunlers { get; set; }
    }
}