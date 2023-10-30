using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace İNTEKO.Tools
{
    public partial class fAddHistory : DevExpress.XtraEditors.XtraForm
    {
        public int MyProperty { get; set; }
        public fAddHistory()
        {
            InitializeComponent();
            lookUpEdit1.Properties.DataSource = Enum.GetValues(typeof(PaymentTypes));
        }

        enum PaymentTypes
        {
            Cash = 2,
            Bank = 3,
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var db = new IntekodbEntities())
            {
                //DateTime startDate = new DateTime(2023, 1, 6);
                //DateTime endDate = new DateTime(2023, 7, 6);
                DateTime startDate = dateEdit1.DateTime;
                DateTime endDate = dateEdit2.DateTime;
                int ay = 1;
                var control = db.Customers.Where(x => x.Voen == tVoen.Text).FirstOrDefault();
                for (DateTime date = startDate; date <= endDate; date = date.AddMonths(ay))
                {
                //    MessageBox.Show(date.ToString());
                    Payments payments = new Payments();
                    payments.QaimeNo = null;
                    payments.Avans = 0;
                    payments.PaymentTypeID = (int)lookUpEdit1.EditValue;
                    payments.Date = date;
                    payments.PayDate = date;
                    payments.Qaliq = 0;
                    payments.Status = true;
                    payments.Comment = null;
                    payments.Voen = tVoen.Text;
                    payments.OdeyiciAdi = control.CompanyName;
                    payments.CustomerID = control.Id;
                    payments.OdenecekMebleg = Convert.ToDouble(tOdenecek.Text);
                    payments.OdenenMebleg = Convert.ToDouble(tOdenen.Text);
                    payments.UserID = 1;
                    db.Payments.Add(payments);
                    db.SaveChanges();
                }
                MessageBox.Show("Yükleme tamamlandı");
            }
        }
    }
}