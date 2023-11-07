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
    
    public partial class Customers
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Customers()
        {
            this.LicenceHistory = new HashSet<LicenceHistory>();
            this.PaymentHistory = new HashSet<PaymentHistory>();
            this.Tarifler = new HashSet<Tarifler>();
            this.Payments = new HashSet<Payments>();
        }
    
        public int Id { get; set; }
        public string ContractNo { get; set; }
        public string NameSurname { get; set; }
        public string CompanyName { get; set; }
        public string Voen { get; set; }
        public string CompanyCode { get; set; }
        public string Phone { get; set; }
        public Nullable<int> CityID { get; set; }
        public Nullable<int> AreaID { get; set; }
        public string Address { get; set; }
        public Nullable<System.DateTime> Registration_Date { get; set; }
        public string SalesMan { get; set; }
        public Nullable<bool> Status { get; set; }
        public Nullable<System.Guid> LicenceID { get; set; }
        public string LicenceVersion { get; set; }
        public Nullable<System.DateTime> LicenceRegister { get; set; }
        public Nullable<bool> LicenceStatus { get; set; }
        public Nullable<int> Kassa_Model { get; set; }
        public string KassaSerialNumber { get; set; }
        public string KassaVersionNumber { get; set; }
        public Nullable<int> PaymentTypeID { get; set; }
        public Nullable<double> RegistrationPrice { get; set; }
        public Nullable<double> ServicePrice { get; set; }
        public Nullable<bool> MposVersion { get; set; }
        public string ContractFileName { get; set; }
        public string FileExtensions { get; set; }
        public byte[] ContractData { get; set; }
        public Nullable<int> UserID { get; set; }
        public Nullable<System.DateTime> LogDate { get; set; }
        public string TypeofCompany { get; set; }
        public string GuessLocation { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
    
        public virtual Area Area { get; set; }
        public virtual City City { get; set; }
        public virtual Kassalar Kassalar { get; set; }
        public virtual PaymentType PaymentType { get; set; }
        public virtual Users Users { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LicenceHistory> LicenceHistory { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PaymentHistory> PaymentHistory { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tarifler> Tarifler { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Payments> Payments { get; set; }
    }
}
