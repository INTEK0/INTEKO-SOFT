using DevExpress.XtraEditors;
using İNTEKO.Bonnus;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using İNTEKO.Tools;
using İNTEKO.PayHistory;
using İNTEKO.DetailForm;
using İNTEKO.Helpers;
using İNTEKO.Enums;
using System.Data.SqlClient;
using İNTEKO.Messages;

namespace İNTEKO.Pay
{
    public partial class fPay : FormBase
    {
        IntekodbEntities db = new IntekodbEntities();

        public int? CustomerID { get; set; }

        public int PaymentID { get; set; }

        public string Operations { get; set; }

        public fPay()
        {
            InitializeComponent();
        }

        private string ValidationControl()
        {
            if (String.IsNullOrWhiteSpace(tCustomerName.Text)) { return PaymentMessage.CUSTOMER_NAME_NOT_FOUND; }
            if (String.IsNullOrWhiteSpace(tVOEN.Text)) { return PaymentMessage.VOEN_NOT_FOUND; }
            if (String.IsNullOrWhiteSpace(tContractNo.Text)) { return PaymentMessage.CONTRACT_NUMBER_NOT_FOUND; }
            if (String.IsNullOrWhiteSpace(tTotal.Text)) { return PaymentMessage.PRICE_NOT_FOUND; }
            if (String.IsNullOrWhiteSpace(dateTarix.Text)) { return PaymentMessage.DATE_NOT_FOUND; }
            return null;
        }

        void Clear()
        {
            tCustomerName.Text = null;
            tVOEN.Text = Text = null;
            tContractNo.Text = null;
            tTotal.EditValue = null;
            tQaimeNo.Text = null;
            dateTarix.DateTime = DateTime.Now;
            tComment.Text = null;
        }

        private void bSelectCustomer_Click(object sender, EventArgs e)
        {
            tCustomerName.SelectionStart = 0;
            fSelectedCustomer f = new fSelectedCustomer("Payments");
            f.ShowDialog();
            if (!String.IsNullOrEmpty(tCustomerName.Text) || !String.IsNullOrEmpty(tVOEN.Text))
            {
                groupPay.Enabled = true;
                groupComment.Enabled = true;
            }
        }

        private void fPay_Load(object sender, EventArgs e)
        {
            this.Text = Proccess.Versiya();
            dateTarix.DateTime = DateTime.Now;
            //Ödəniş növləri
            var data = db.PaymentType.Select(x => new { x.Id, x.PaymentName, x.Status })
                                     .Where(x => x.Status == true)
                                     .OrderBy(x => x.Id)
                                     .ToList();

            FormHelpers.ControlLoad(data, cmbPaymentType, displayMember: "PaymentName");

            if (Operations == EnumsOperation.Operation.Show.ToString())
            {
                //var customer = db.Customers.Where(x => x.Id == CustomerID).FirstOrDefault();
                var payments = db.Payments.AsNoTracking().FirstOrDefault(x => x.Id == PaymentID);
                this.Text = payments.Customers.CompanyName + Proccess.Versiya();

                userFooter_Save1.SaveButtonText = EnumsOperation.ButtonTextName.Close.GetDescription();
                userFooter_Save1.CancelVisible = false;
                bSelectCustomer.Visible = false;
                tCustomerName.Width = 523;
                tVOEN.Width = 523;
                tContractNo.Width = 523;
                lStatus.Visible = true;
                lStatus.Text = " ÖDƏNİLİB ";
                lStatus.BackColor = ColorTranslator.FromHtml("#2ecc71");
                lPaymentHistory.Visible = true;
                lCustomerDetail.Visible = true;

                tCustomerName.Text = payments.Customers.NameSurname;
                tVOEN.Text = payments.Customers.Voen;
                tContractNo.Text = payments.Customers.ContractNo;
                tTotal.Text = payments.OdenecekMebleg.ToString();
                tQaimeNo.Text = payments.QaimeNo;
                dateTarix.DateTime = (DateTime)payments.Date;
                tComment.Text = payments.Comment;
                cmbPaymentType.Text = payments.PaymentType.PaymentName;
                Logger.Log(payments.Customers.CompanyName + " ödənişinə baxış keçirdi");
            }
            else if (Operations == EnumsOperation.Operation.Payment.ToString())
            {
                //var customer = db.Customers.Where(x => x.Id == CustomerID).FirstOrDefault();
                var payments = db.Payments.FirstOrDefault(x => x.Id == PaymentID);
                this.Text = payments.Customers.CompanyName + Proccess.Versiya();

                groupPay.Enabled = true;
                groupComment.Enabled = true;
                userFooter_Save1.SaveButtonText = EnumsOperation.ButtonTextName.Payment.GetDescription();
                userFooter_Save1.CancelVisible = false;
                lStatus.Visible = true;
                bSelectCustomer.Visible = false;
                tCustomerName.Width = 523;
                tVOEN.Width = 523;
                tContractNo.Width = 523;
                lStatus.Text = " ÖDƏNİLMƏYİB ";
                lStatus.BackColor = Color.FromArgb(231, 76, 60);
                lPaymentHistory.Visible = true;
                lCustomerDetail.Visible = true;


                tCustomerName.Text = payments.Customers.NameSurname;
                tVOEN.Text = payments.Customers.Voen;
                tContractNo.Text = payments.Customers.ContractNo;
                tTotal.Text = payments.Qaliq.ToString();
                tQaimeNo.Text = payments.QaimeNo;
                dateTarix.DateTime = (DateTime)payments.Date;
                tComment.Text = payments.Comment;
                cmbPaymentType.Text = payments.PaymentType.PaymentName;
            }
            else if (Operations == EnumsOperation.Operation.Edit.ToString())
            {
                var payments = db.Payments.FirstOrDefault(x => x.Id == PaymentID);
                this.Text = payments.Customers.CompanyName + Proccess.Versiya();
                groupPay.Enabled = true;
                groupCustomer.Enabled = true;
                groupComment.Enabled = true;
                userFooter_Save1.SaveButtonText = EnumsOperation.ButtonTextName.Edit.GetDescription();
                userFooter_Save1.CancelVisible = true;
                lPaymentHistory.Visible = true;
                lCustomerDetail.Visible = true;
                lStatus.Visible = false;

                tCustomerName.Text = payments.Customers.NameSurname;
                tVOEN.Text = payments.Customers.Voen;
                tContractNo.Text = payments.Customers.ContractNo;
                tTotal.Text = payments.OdenecekMebleg.ToString();
                tQaimeNo.Text = payments.QaimeNo;
                dateTarix.DateTime = (DateTime)payments.Date;
                tComment.Text = payments.Comment;
                cmbPaymentType.Text = payments.PaymentType.PaymentName;
            }
        }

        private void userFooter_Save1_SaveClick(object sender, EventArgs e)
        {

            if (ValidationControl() != null) { Message(ValidationControl(), UserControls.MessageForm.enmType.Error); return; }
            if (Operations == EnumsOperation.Operation.Add.ToString())
            {
                if (cmbPaymentType.Text == "BANK" && String.IsNullOrWhiteSpace(tQaimeNo.Text))
                {
                    Message(PaymentMessage.DOCUMENT_NOT_NUMBER, UserControls.MessageForm.enmType.Warning); tQaimeNo.Focus(); return;
                }
                Payments payment = new Payments();
                payment.CustomerID = CustomerID;
                payment.OdeyiciAdi = tCustomerName.Text;
                payment.Voen = tVOEN.Text;
                payment.OdenecekMebleg = Convert.ToDouble(tTotal.EditValue);
                payment.OdenenMebleg = 0;
                payment.Qaliq = Convert.ToDouble(tTotal.EditValue);
                payment.Avans = 0;
                payment.PaymentTypeID = (int)cmbPaymentType.SelectedValue;
                payment.QaimeNo = tQaimeNo.Text;
                payment.Status = false;
                payment.Date = (DateTime)dateTarix.EditValue;
                payment.Comment = tComment.Text;
                payment.PayDate = null;
                payment.UserID = Properties.Settings.Default.UserID;
                db.Payments.Add(payment);
                db.SaveChanges();
                Message(PaymentMessage.PAYMENT_ADDED, UserControls.MessageForm.enmType.Success);
                Logger.Log(tCustomerName.Text + " ödənişi yaradıldı");
            }
            else if (Operations == EnumsOperation.Operation.Edit.ToString())
            {
                var payments = db.Payments.FirstOrDefault(x => x.Id == PaymentID);
                payments.CustomerID = CustomerID;
                payments.OdeyiciAdi = tCustomerName.Text;
                payments.Voen = tVOEN.Text;

                payments.OdenecekMebleg = Convert.ToDouble(tTotal.EditValue);
                //payments.OdenenMebleg = 0;
                payments.Qaliq = Convert.ToDouble(tTotal.EditValue) - (double)payments.OdenenMebleg;
                //payments.Avans = 0;
                payments.PaymentTypeID = (int)cmbPaymentType.SelectedValue;
                payments.QaimeNo = tQaimeNo.Text;
                //payments.Status = false;
                payments.Date = (DateTime)dateTarix.EditValue;
                payments.Comment = tComment.Text;
                payments.PayDate = DateTime.Now;
                payments.UserID = Properties.Settings.Default.UserID;

                db.SaveChanges();
                userFooter_Save1.Enabled = false;
                Message(AutoMessage.EditSaveChange, UserControls.MessageForm.enmType.Success);
                Logger.Log(payments.Customers.CompanyName + " düzəliş edildi");
            }
            else if (Operations == EnumsOperation.Operation.Payment.ToString())
            {
                if (tTotal.Text.Replace("AZN", "") == 0.ToString()) { return; }
                var payments = db.Payments.Where(x => x.Id == PaymentID).FirstOrDefault();
                double odenenmebleg = Convert.ToDouble(tTotal.EditValue);
                double odenecekmebleg = (double)payments.OdenecekMebleg;
                double qaliq = (double)payments.Qaliq;

                if (odenenmebleg == qaliq)
                {
                    payments.Avans = 0;
                    payments.Qaliq = 0;
                    payments.Status = true;
                }
                else if (odenenmebleg > qaliq)
                {
                    double avans = odenenmebleg - qaliq;
                    payments.Avans = avans;
                    payments.Qaliq = 0;
                    payments.Status = true;
                }
                else if (odenenmebleg < qaliq)
                {
                    payments.Qaliq = qaliq - odenenmebleg;
                    payments.Avans = 0;
                    payments.Status = false;
                }
                payments.OdenenMebleg = odenenmebleg;
                userFooter_Save1.Enabled = false;

                db.SaveChanges();
                Message(PaymentMessage.PAYMENT_COMPLETED, UserControls.MessageForm.enmType.Success);
                Logger.Log(payments.Customers.CompanyName + " ödənişi edildi");
            }
            else if (Operations == EnumsOperation.Operation.Show.ToString())
            {
                Close();
            }
            Clear();
            fDashboard f = (fDashboard)Application.OpenForms["fDashboard"];
            f.PaymentsGridFill();
            Close();
        }

        private void lPaymentHistory_Click(object sender, EventArgs e)
        {
            fPaymenHistory f = new fPaymenHistory("fPay", (int)CustomerID);
            f.ShowDialog();
        }

        private void lCustomerDetail_Click(object sender, EventArgs e)
        {
            var customerID = db.Customers.FirstOrDefault(x => x.Id == CustomerID);
            fDetail detail = new fDetail(customerID);
            detail.ShowDialog();
        }

        private void userFooter_Save1_CancelClick(object sender, EventArgs e)
        {
            Close();
        }

        private void TriggerTest()
        {
            string insertQuery = "INSERT INTO payments (month, payment_amount, advance) VALUES (@month, @payment_amount, @advance)";

            using (SqlConnection connection = new SqlConnection(db.Database.Connection.ConnectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(insertQuery, connection))
                {
                    // Parametreleri ayarla
                    command.Parameters.Add(new SqlParameter("@month", SqlDbType.Date)).Value = DateTime.Now; // Şu anın tarihini kullanabilirsiniz.
                    command.Parameters.Add(new SqlParameter("@payment_amount", SqlDbType.Decimal)).Value = 500;  // Ödeme miktarını belirtin
                    command.Parameters.Add(new SqlParameter("@advance", SqlDbType.Decimal)).Value = 0;  // İlk avansı belirtin

                    try
                    {
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            Console.WriteLine("INSERT işlemi başarılı.");
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Hata oluştu: " + ex.Message);
                    }
                }
            }
        }
    }
}