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
    
    public partial class Payments
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Payments()
        {
            this.PaymentHistory = new HashSet<PaymentHistory>();
        }
    
        public int Id { get; set; }
        public string QaimeNo { get; set; }
        public Nullable<int> CustomerID { get; set; }
        public Nullable<double> OdenecekMebleg { get; set; }
        public Nullable<double> OdenenMebleg { get; set; }
        public Nullable<double> Avans { get; set; }
        public Nullable<int> PaymentTypeID { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public Nullable<System.DateTime> PayDate { get; set; }
        public Nullable<double> Qaliq { get; set; }
        public Nullable<bool> Status { get; set; }
        public string Comment { get; set; }
        public string Voen { get; set; }
        public string OdeyiciAdi { get; set; }
        public Nullable<int> UserID { get; set; }
    
        public virtual Customers Customers { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PaymentHistory> PaymentHistory { get; set; }
        public virtual PaymentType PaymentType { get; set; }
        public virtual Users Users { get; set; }
    }
}
