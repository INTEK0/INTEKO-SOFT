//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace İNTEKO
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tarifler
    {
        public int Id { get; set; }
        public Nullable<int> CustomerID { get; set; }
        public string Month { get; set; }
        public Nullable<double> OldTarif { get; set; }
        public Nullable<double> NewTarif { get; set; }
        public Nullable<System.DateTime> Tarix { get; set; }
        public Nullable<System.DateTime> EditDate { get; set; }
    
        public virtual Customers Customers { get; set; }
    }
}
