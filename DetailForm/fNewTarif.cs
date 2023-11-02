using İNTEKO.Enums;
using İNTEKO.Tools;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace İNTEKO.DetailForm
{
    public partial class fNewTarif :FormBase
    {
        IntekodbEntities db = new IntekodbEntities();
        private Customers CustomerID { get; set; }

        public fNewTarif( Customers customers)
        {
            InitializeComponent();
            CustomerID = customers;
        }

        private void fNewTarif_Load(object sender, EventArgs e)
        {
            dateEdit.DateTime = DateTime.Now;
            var control = db.Tarifler.Where(x => x.CustomerID == CustomerID.Id).OrderByDescending(x=> x.Id).FirstOrDefault();
            if (control == null)
            {
                var customerControl = db.Customers.Where(x => x.Id == CustomerID.Id).FirstOrDefault();
                tContractNo.Text = customerControl.ContractNo;
                tOldTarif.EditValue = customerControl.ServicePrice;
            }
            else
            {
                tOldTarif.Text = control.NewTarif.ToString();
                tContractNo.Text = control.Customers.ContractNo;
            }
        }

        private string tControl()
        {
            if (String.IsNullOrEmpty(dateEdit.Text))
                return "Tarix seçimi edilmədi";
            if (String.IsNullOrEmpty(tOldTarif.Text))
                return "Köhnə tarifin məbləğini daxil edin !";
            if (String.IsNullOrEmpty(tNewTarif.Text))
                return "Yeni tarifin məbləğini daxil edin !";
            return null;
        }


        void ReqemYazdirma(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            if (tControl() != null) { Message(tControl(), UserControls.MessageForm.enmType.Warning); return; }

            double oldTarif = Convert.ToDouble(tOldTarif.EditValue);
            double newTarif = Convert.ToDouble(tNewTarif.EditValue);

            var customer = db.Customers.FirstOrDefault(x => x.Id == CustomerID.Id);
            customer.ServicePrice = newTarif;

            Tarifler tarif = new Tarifler();
            tarif.CustomerID = CustomerID.Id;
            tarif.OldTarif = oldTarif;
            tarif.NewTarif = newTarif;
            tarif.EditDate = dateEdit.DateTime;
            db.Tarifler.Add(tarif);
            db.SaveChanges();
            Message("Yeni tarif təyin edildi", UserControls.MessageForm.enmType.Success);
            Logger.Log(tarif.Customers.CompanyName  + " yeni tarif təyin etdi");
            DialogResult = DialogResult.OK;
        }
    }
}