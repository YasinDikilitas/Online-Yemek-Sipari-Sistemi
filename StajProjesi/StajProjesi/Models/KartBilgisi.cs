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
    
    public partial class KartBilgisi
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KartBilgisi()
        {
            this.Kullanicis = new HashSet<Kullanici>();
        }
    
        public int id { get; set; }
        public string KartNo { get; set; }
        public string AdSoyad { get; set; }
        public string CVC { get; set; }
        public Nullable<System.DateTime> Skt { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Kullanici> Kullanicis { get; set; }
    }
}
