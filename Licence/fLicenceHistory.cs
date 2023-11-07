using DevExpress.XtraEditors;
using İNTEKO.Helpers;
using İNTEKO.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace İNTEKO.Licence
{
    public partial class fLicenceHistory : DevExpress.XtraEditors.XtraForm
    {
        public int CustomerID { get; set; }

        IntekodbEntities db = new IntekodbEntities();
        public fLicenceHistory()
        {
            InitializeComponent();
            this.Text = Proccess.Versiya();

        }

        void Loadfill()
        {
            dateStart.DateTime = DateTime.Now.AddDays(-1);
            dateFinish.DateTime = DateTime.Now;
            var customer = db.LicenceHistory.Where(x => x.Customers.Id == CustomerID).FirstOrDefault();
            gridControlLicence.DataSource = db.LicenceHistory.Where(x => x.Customers.Id == CustomerID).OrderByDescending(x => x.LicenceID).ToList();
        }

        private void fLicenceHistory_Load(object sender, EventArgs e)
        {
            Loadfill();
        }

        private void gridLicence_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            if (e.Column.FieldName == "Description")
            {
                if (e.CellValue != null && e.CellValue is string value)
                {
                    if (value == "Aktiv edildi")
                    {
                        e.Appearance.ForeColor = Color.Green;
                        e.Appearance.FontStyleDelta = FontStyle.Bold;
                    }
                    else if (value == "Deaktiv edildi")
                    {
                        e.Appearance.ForeColor = ColorTranslator.FromHtml("#e74c3c");
                        e.Appearance.FontStyleDelta = FontStyle.Bold;
                    }
                }
            }
        }

        private void bSearch_Click(object sender, EventArgs e)
        {
            if (db.LicenceHistory.Any())
            {
                var dateSearch = db.LicenceHistory.Where(x => x.CustomerID == CustomerID && x.Tarix >= dateStart.DateTime && x.Tarix <= dateFinish.DateTime);
                gridControlLicence.DataSource = dateSearch.OrderByDescending(x => x.LicenceID).ToList();
                gridLicence.RefreshData();
            }
        }

        private void bPrint_Click(object sender, EventArgs e)
        {
            FormHelpers.ExportExcelGridData("Lisenziya keçmişi", gridLicence);
        }
    }
}