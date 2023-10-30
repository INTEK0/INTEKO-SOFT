using DevExpress.Export;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraPrinting;
using İNTEKO.Enums;
using OfficeOpenXml;
using OfficeOpenXml.Table;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static İNTEKO.Enums.EnumsOperation;

namespace İNTEKO
{
    public partial class fTestInnerJoin : DevExpress.XtraEditors.XtraForm
    {
        public fTestInnerJoin()
        {
            InitializeComponent();
        }

        private void fTestInnerJoin_Load(object sender, EventArgs e)
        {
            using (var db = new IntekodbEntities())
            {
                var result = (from c in db.Customers
                              join p in db.Payments on c.Id equals p.CustomerID
                              join area in db.Area on c.AreaID equals area.Id
                              join kassa in db.Kassalar on c.Kassa_Model equals kassa.Id
                              join ptype in db.PaymentType on p.PaymentTypeID equals ptype.Id
                              select new
                              {
                                  ID = c.Id,
                                  AdSoyad = c.NameSurname,
                                  ObyektAdı = c.CompanyName,
                                  Rayon = area.AreaName,
                                  Ünvan = c.Address,
                                  TəqribiYerləşmə = c.GuessLocation,
                                  KassaModeli = kassa.Name,
                                  QeydiyyatTarixi = c.Registration_Date,
                                  MüqaviləNo = c.ContractNo,
                                  Satanİşçi = c.SalesMan,
                                  Telefon = c.Phone,
                                  YazılmaQiyməti = c.RegistrationPrice,
                                  AylıqÖdəniş = c.ServicePrice,
                                  QaiməTarixi = p.Date,
                                  ÖdənişStatusu = p.Status.Value ? "Aktiv" : "Passiv",
                                  Qeyd = p.Comment,
                                  ÖdənişNövü = ptype.PaymentName,
                                  ÖdənəcəkMəbləğ = p.OdenecekMebleg,
                                  VöenKod = c.Voen + " - " + c.CompanyCode,
                                  İl = p.Date.Value.Year,
                                  Ay = p.Date.Value.Month,

                              }).OrderBy(x => x.İl).ThenBy(x => x.Ay);


                gridControl1.DataSource = result.ToList().OrderBy(x => GetMonthOrder((Month)x.Ay)).ToList();


            }
        }

        private int GetMonthOrder(Month month)
        {
            Month[] monthsInOrder = new Month[]{
        Month.Yanvar,
        Month.Fevral,
        Month.Mart,
        Month.Aprel,
        Month.May,
        Month.İyun,
        Month.İyun,
        Month.Avqust,
        Month.Sentyabr,
        Month.Oktyabr,
        Month.Noyabr,
        Month.Dekabr
            };

            return Array.IndexOf(monthsInOrder, month);
        }

        private void gridView1_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            //if (e.Column.FieldName == "Ay") // Ay isimlerini göstermek istediğiniz sütunun adını kullanın
            //{
            //    if (e.Value != null)
            //    {
            //        Month ayEnumValue;
            //        if (Enum.TryParse(e.Value.ToString(), out ayEnumValue))
            //        {
            //            // Enum değerini ay ismine dönüştürün
            //            string ayIsim = ayEnumValue.ToString();
            //            e.DisplayText = ayIsim;
            //        }
            //    }
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Excel faylı|*.xlsx";
            save.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            save.OverwritePrompt = true; //varsa soruşmadan üstünə yazması üçün false olaraq qalmalıdır
            save.FileName = "Ödənişlər siyahısı" + "_" + DateTime.Now.ToShortDateString() + ".xlsx";
            if (save.ShowDialog() == DialogResult.OK)
            {
                string fileName = save.FileName;
                gridView1.ExportToXlsx(fileName, new XlsxExportOptionsEx
                {
                    ExportType = ExportType.DataAware
                });
            }
        }
    }
}