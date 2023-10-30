using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;
using İNTEKO.Tools;
using İNTEKO.Definitions;
using İNTEKO.Helpers;
using İNTEKO.Enums;

namespace İNTEKO
{
    public partial class fExpenses : FormBase
    {
        IntekodbEntities db = new IntekodbEntities();
        private int Operations { get; }
        public int ID { get; set; }
        public fExpenses(EnumsOperation.Operation operation)
        {
            InitializeComponent();
            cmbDoldur();
            Operations = (int)operation;
        }

        private string Control()
        {
            if (String.IsNullOrWhiteSpace(tHeader.Text)) { return "Başlıq əlavə edin"; }
            if (String.IsNullOrWhiteSpace(cmbCategory.Text)) { return "Kateqoriya seçimi edin"; }
            if (String.IsNullOrWhiteSpace(tTotal.Text)) { return "Məbləği daxil edin"; }
            if (String.IsNullOrWhiteSpace(dateTarix.Text)) { return "Tarix seçimi edin"; }
            return null;
        }

        public void cmbDoldur()
        {
            //Ödəniş növləri
            var payType = db.PaymentType.AsNoTracking().Where(x => x.Status == true).ToList();
            FormHelpers.ControlLoad(payType, cmbPaymentType, "PaymentName");

            //Kateqoriyalar
            var category = db.Category.AsNoTracking().ToList();
            FormHelpers.ControlLoad(category, cmbCategory, "CategoryName");
        }

        private void bNewCategory_Click(object sender, EventArgs e)
        {
            fDefinitions f = new fDefinitions("Category");
            f.ShowDialog();
            cmbDoldur();
        }

        private void fExpenses_Load(object sender, EventArgs e)
        {
            this.Text = Proccess.Versiya();
            if (Operations == (int)EnumsOperation.Operation.Show)
            {
                lStatus.Text = " ÖDƏNİLİB ";
                lStatus.Visible = true;
                userFooter_Save1.SaveButtonText = "Bağla";
                userFooter_Save1.CancelVisible = false;
                bNewCategory.Enabled = false;
                cmbCategory.Enabled = false;
                cmbPaymentType.Enabled = false;


                var show = db.Expenses.FirstOrDefault(x => x.Id == ID);
                tHeader.Text = show.Header;
                cmbCategory.Text = show.Category.CategoryName;
                tTotal.EditValue = show.TotalPaid.ToString();
                cmbPaymentType.Text = show.PaymentType.PaymentName;
                dateTarix.EditValue = show.Date;
                tComment.Text = show.Comment;
                lProccesNo.Text = "Əməliyyat № : " + show.ExNo;
                lStatus.Focus();
            }
            else if (Operations == (int)EnumsOperation.Operation.Edit)
            {
                userFooter_Save1.SaveButtonText = "Düzəliş et";

                var show = db.Expenses.FirstOrDefault(x => x.Id == ID);
                tHeader.Text = show.Header;
                cmbCategory.Text = show.Category.CategoryName;
                tTotal.EditValue = show.TotalPaid.ToString();
                cmbPaymentType.Text = show.PaymentType.PaymentName;
                dateTarix.EditValue = show.Date;
                tComment.Text = show.Comment;
                lProccesNo.Text = "Əməliyyat № : " + show.ExNo;
                lStatus.Focus();
            }
            else if (Operations == (int)EnumsOperation.Operation.Add)
            {
                userFooter_Save1.SaveButtonText = "Əlavə et";
                dateTarix.EditValue = DateTime.Now;
                lProccesNo.Text = "Əməliyyat № : " + db.ExpensesProcNo().FirstOrDefault().ToString();
            }
            else if (Operations == (int)EnumsOperation.Operation.Payment)
            {
                lStatus.Text = " ÖDƏNİLMƏYİB ";
                lStatus.Visible = true;
                lStatus.BackColor = Color.FromArgb(231, 76, 60);
                userFooter_Save1.SaveButtonText = "Ödəniş et";
                bNewCategory.Enabled = false;
                cmbCategory.Enabled = false;
                var show = db.Expenses.FirstOrDefault(x => x.Id == ID);
                tHeader.Text = show.Header;
                cmbCategory.Text = show.Category.CategoryName;
                tTotal.EditValue = show.TotalPaid.ToString();
                cmbPaymentType.Text = show.PaymentType.PaymentName;
                dateTarix.EditValue = show.Date;
                tComment.Text = show.Comment;
                lProccesNo.Text = show.ExNo;
            }
        }

        private void userFooter_Save1_SaveClick(object sender, EventArgs e)
        {
            if (Operations == (int)EnumsOperation.Operation.Show)
            {
                Close();
            }
            else if (Operations == (int)EnumsOperation.Operation.Edit)
            {
                if (Control() != null) { Message(Control(), UserControls.MessageForm.enmType.Warning); return; }
                var edit = db.Expenses.FirstOrDefault(x => x.Id == ID);

                edit.Header = tHeader.Text.Trim();
                edit.CategoryID = (int)cmbCategory.SelectedValue;
                edit.TotalPaid = Double.Parse(tTotal.Text.Replace("AZN", ""));
                edit.Date = dateTarix.DateTime;
                edit.Comment = tComment.Text.Trim();

                Logger.Log("Xərclərdə dəyişiklik edildi.  Ə/N: " + edit.ExNo);

                db.SaveChanges();
                Message(AutoMessage.EditSaveChange, UserControls.MessageForm.enmType.Success);
                DialogResult = DialogResult.OK;
                Close();
            }
            else if (Operations == (int)EnumsOperation.Operation.Add)
            {
                MessageBox.Show(tTotal.Text.ToString());
                var categoryID = db.Category.FirstOrDefault(x => x.CategoryName == cmbCategory.Text);
                if (Control() != null) { Message(Control(), UserControls.MessageForm.enmType.Warning); return; }
                Expenses xercler = new Expenses();
                xercler.Header = tHeader.Text;
                xercler.UsersID = Properties.Settings.Default.UserID;
                xercler.CategoryID = categoryID.Id;
                xercler.TotalPaid = Double.Parse(tTotal.Text.Replace("AZN",""));
                xercler.PaymentTypeID = (int)cmbPaymentType.SelectedValue;
                xercler.Date = (DateTime)dateTarix.EditValue;
                xercler.Comment = tComment.Text;
                xercler.Status = false;
                xercler.LogDate = DateTime.Now;
                xercler.ExNo = lProccesNo.Text.Replace("Əməliyyat № : ", "");
                db.Expenses.Add(xercler);
                Logger.Log("Yeni xərc yaradıldı.  Ə/N: " + lProccesNo.Text.Replace("Əməliyyat № : ", ""));
                db.SaveChanges();
                Message("Yeni xərc yaradıldı", UserControls.MessageForm.enmType.Success);
                DialogResult = DialogResult.OK;
                Close();
            }
            else if (Operations == (int)EnumsOperation.Operation.Payment)
            {
                var payments = db.Expenses.FirstOrDefault(x => x.Id == ID);
                payments.Status = true;
                Logger.Log(payments.Header + " xərcinin ödənişi edildi.  Ə/N: " + payments.ExNo);
                db.SaveChanges();
                Message("Ödəniş qəbul edildi", UserControls.MessageForm.enmType.Success);
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}