using DevExpress.XtraPrinting;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace İNTEKO
{
    public partial class Form1 : Form
    {
        IntekodbEntities db = new IntekodbEntities();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gridPayments.IndicatorWidth = 30;
            gridControlPayments.DataSource = db.Payments.AsNoTracking().Select(x => new
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
                x.Status,
                x.Voen,
                x.OdeyiciAdi,
                x.Users
            }).OrderBy(x => x.Id).ToList();
            gridPayments.RefreshData();
        }

        private void bPaymentExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "Excel faylı|*.xlsx";
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                gridPayments.ExportToXlsx(saveFile.FileName);
            }
        }
    }
}
