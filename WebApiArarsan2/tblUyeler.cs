//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApiArarsan2
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblUyeler
    {
        public int UyeID { get; set; }
        public string UyeAdi { get; set; }
        public string UyeSoyad { get; set; }
        public Nullable<int> Telefon { get; set; }
        public string Parola { get; set; }
        public string KullaniciAdi { get; set; }
    
        public virtual tblFavoriler tblFavoriler { get; set; }
    }
}
