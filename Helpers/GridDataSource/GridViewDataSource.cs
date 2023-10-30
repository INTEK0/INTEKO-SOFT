using DevExpress.XtraGrid;
using İNTEKO.Enums;
using İNTEKO.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace İNTEKO.Helpers.GridDataSource
{
    public static class GridViewDataSource
    {
        //public static void BindDataToGridView<T>(IEnumerable<T> data, GridControl control) where T : class
        //{
        //    control.DataSource = data.ToList();
        //}


        //public static IEnumerable<T> GetDataFromDatabase<T>() where T : class
        //{
        //    using (IntekodbEntities db = new IntekodbEntities())
        //    {
        //        var result = db.Set<T>().ToList();
        //        return result;
        //    }
        //}


        public static void CusromerFullData(GridControl control)
        {
            using (var db = new IntekodbEntities())
            {
                dynamic customerData = db.Customers.AsNoTracking().
                                                    Where(x => x != null).
                                                    Select(x => new
                                                    {
                                                        x.Id,
                                                        x.ContractNo,
                                                        x.NameSurname,
                                                        x.CompanyName,
                                                        x.Voen,
                                                        Status = x.Status.Value ? "Aktiv" : "Deaktiv",
                                                        x.CompanyCode,
                                                        x.Phone,
                                                        x.City,
                                                        x.Area,
                                                        x.Address,
                                                        x.Registration_Date,
                                                        x.SalesMan,
                                                        x.LicenceID,
                                                        x.LicenceVersion,
                                                        x.LicenceRegister,
                                                        x.Kassalar,
                                                        x.Kassa_Model,
                                                        x.KassaSerialNumber,
                                                        x.KassaVersionNumber,
                                                        x.PaymentType,
                                                        x.PaymentTypeID,
                                                        x.RegistrationPrice,
                                                        x.ServicePrice,
                                                        LisenziyaStatusu = x.LicenceStatus.Value ? "Aktiv" : "Deaktiv",
                                                        MposVersion = x.MposVersion.Value ? "Yeni" : "Köhnə",
                                                        x.PaymentHistory,
                                                        x.LicenceHistory,
                                                        x.Tarifler
                                                    }).OrderBy(x => x.Id).ToList();

                control.DataSource = customerData;
            }
        }

        public static void PaymentsFullData(GridControl control)
        {
            using (var db = new IntekodbEntities())
            {
                var data = db.Payments.AsNoTracking().
                                       Where(x => x != null)
                                       .Select(x => new
                                       {
                                           x.Id,
                                           x.QaimeNo,
                                           x.Customers,
                                           x.OdenecekMebleg,
                                           x.OdenenMebleg,
                                           x.Avans,
                                           x.PaymentType,
                                           x.Date,
                                           x.PayDate,
                                           x.Qaliq,
                                           Status = x.Status.Value ? "Ödənilib" : "Ödənilməyib",
                                           x.Voen,
                                           x.OdeyiciAdi,
                                           x.Users
                                       }).OrderBy(x => x.Id).ToList();
            }
        }
    }
}
