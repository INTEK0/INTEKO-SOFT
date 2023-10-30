using DevExpress.XtraEditors;
using İNTEKO.Pay;
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

namespace İNTEKO.Bonnus
{
    public partial class fSelectedCustomer : FormBase
    {
        IntekodbEntities db = new IntekodbEntities();

        public string Type { get; set; }
        public fSelectedCustomer(string _type)
        {
            InitializeComponent();
            Type = _type;
        }

        private void fSelectedCustomer_Load(object sender, EventArgs e)
        {
            gridControlCustomers.DataSource = db.Customers.AsNoTracking().Where(x => x.Status == true).OrderByDescending(x => x.Id).ToList();
        }

        private void gridCustomers_DoubleClick(object sender, EventArgs e)
        {
            Customers customer = new Customers();
            if (Type == "Payments")
            {
                try
                {
                    var row = gridCustomers.GetFocusedRow();
                    if (row == null)
                    {
                        Message("Seçim edilmədi", UserControls.MessageForm.enmType.Info);
                        return;
                    }
                    fPay pay = (fPay)Application.OpenForms["fPay"];
                    customer = (Customers)row;
                    pay.tCustomerName.Text = customer.CompanyName;
                    pay.tVOEN.Text = customer.Voen;
                    pay.tContractNo.Text = customer.ContractNo;
                    pay.CustomerID = customer.Id;
                    pay.tTotal.EditValue = customer.ServicePrice;
                    pay.cmbPaymentType.Text = customer.PaymentType.PaymentName;
                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (Type == "Bonus")
            {
                try
                {
                    var row = gridCustomers.GetFocusedRow();
                    if (row == null)
                    {
                        Message("Seçim edilmədi", UserControls.MessageForm.enmType.Info);
                        return;
                    }
                    fNewBonus f = (fNewBonus)Application.OpenForms["fNewBonus"];
                    customer = (Customers)row;
                    f.tCustomerName.Text = customer.NameSurname;
                    f.tCompanyName.Text = customer.CompanyName;
                    f.tVOEN.Text = customer.Voen;
                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}