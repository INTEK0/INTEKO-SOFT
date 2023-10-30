using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace İNTEKO.DetailForm
{
    public partial class fTarif : DevExpress.XtraBars.ToolbarForm.ToolbarForm
    {
        IntekodbEntities db = new IntekodbEntities();

        public Customers CustomerID { get; set; }

        public fTarif()
        {
            InitializeComponent();
        }

        private void fTarif_Load(object sender, EventArgs e)
        {
            TarifFill();
            dateStart.Text = DateTime.Now.ToShortDateString();
            dateFinish.Text = DateTime.Now.ToShortDateString();
        }

        void TarifFill()
        {
            gridControlTarif.DataSource = db.Tarifler.Where(x => x.CustomerID == CustomerID.Id).ToList();
            gridTarif.RefreshData();
        }


        private void bNewTarif_Click(object sender, EventArgs e)
        {
            fNewTarif f = new fNewTarif(CustomerID);
            if (f.ShowDialog() == DialogResult.OK)
            {
                TarifFill();
                gridTarif.RefreshData();
                DialogResult = DialogResult.OK;
            }
        }

        private void bLoad_Click(object sender, EventArgs e)
        {
            var control = db.Tarifler.Where(x => x.CustomerID == CustomerID.Id);
            if (control != null)
            {
                var dateSearch = control.Where(x => x.EditDate >= dateStart.DateTime && x.EditDate <= dateFinish.DateTime);
                gridControlTarif.DataSource = dateSearch.OrderByDescending(x => x.Id).ToList();
                gridTarif.RefreshData();
            }
        }
    }
}