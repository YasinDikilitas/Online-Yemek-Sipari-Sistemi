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
    
    public partial class SepetUrunler
    {
        public int id { get; set; }
        public string UrunAd { get; set; }
        public string UrunFiyat { get; set; }
        public Nullable<int> kullaniciid { get; set; }
        public Nullable<int> urunlerid { get; set; }
    
        public virtual Kullanici Kullanici { get; set; }
        public virtual Urunler Urunler { get; set; }
    }
}