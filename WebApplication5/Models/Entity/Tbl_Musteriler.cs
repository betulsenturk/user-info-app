//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication5.Models.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tbl_Musteriler
    {
        public int ID { get; set; }
        public string Isim { get; set; }
        public string Soyad { get; set; }
        public Nullable<System.DateTime> DogumTarihi { get; set; }
        public string Cinsiyet { get; set; }
        public string YasadigiYer { get; set; }
        public string Fotograf { get; set; }
    
        public virtual Tbl_Sehirler Tbl_Sehirler { get; set; }
    }
}