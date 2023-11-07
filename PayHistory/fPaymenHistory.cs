using DevExpress.XtraEditors;
using İNTEKO.Enums;
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
using static İNTEKO.Enums.EnumsOperation;

namespace İNTEKO.PayHistory
{
    public partial class fPaymenHistory : FormBase
    {
        IntekodbEntities db = new IntekodbEntities();

        private int CustomerID { get; }

        private string Operation { get; }

        public fPaymenHistory(string key, int id)
        {
            InitializeComponent();
            Operation = key;
            CustomerID = id;
        }

        private void fPaymenHistory_Load(object sender, EventArgs e)
        {
            dateStart.EditValue = DateTime.Now;
            dateFinish.EditValue = DateTime.Now;
            cmbMonth.DataSource = Enum.GetValues(typeof(Month));
            var control = db.Payments.Where(x => x.CustomerID == CustomerID).FirstOrDefault();
            if (Operation == "fPay")
            {
                if (control == null)
                {
                    Message(AutoMessage.NotFoundData, UserControls.MessageForm.enmType.Error);
                    Close();
                    return;
                }
                gridHistory.ViewCaption = control.Customers.CompanyName;
                gridControlHistory.DataSource = db.Payments.AsNoTracking().Where(x => x.CustomerID == control.CustomerID && x.Status == true).OrderBy(x => x.Id).ToList();
            }
            else if (Operation == "fDetail")
            {
                if (control == null)
                {
                    Message(AutoMessage.NotFoundData, UserControls.MessageForm.enmType.Error);
                    Close();
                    return;
                }
                gridHistory.ViewCaption = control.Customers.CompanyName;
                gridControlHistory.DataSource = db.Payments.AsNoTracking().Where(x => x.CustomerID == control.CustomerID && x.Status == true).OrderBy(x => x.Id).ToList();
            }
        }

        private void bSearch_Click(object sender, EventArgs e)
        {
            var dateSearch = db.Payments.AsNoTracking().Select(x => new { x.Id, x.Date }).Where(x => x.Date >= dateStart.DateTime && x.Date <= dateFinish.DateTime);
            if (dateSearch != null)
            {
                gridControlHistory.DataSource = dateSearch.OrderByDescending(x => x.Id).ToList();
                gridHistory.RefreshData();
            }
        }

        private void bPrint_Click(object sender, EventArgs e)
        {
        }
    }
}