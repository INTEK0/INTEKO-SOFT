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

namespace İNTEKO.Bonnus
{
    public partial class fNewBonus : FormBase
    {
        public fNewBonus()
        {
            InitializeComponent();
        }
        IntekodbEntities db = new IntekodbEntities();

        public string Operations { get; set; }

        public int BonusID { get; set; }

        private void ShowModeRead()
        {
            tCustomerName.ReadOnly = false;
            tCompanyName.ReadOnly = false;
            tVOEN.ReadOnly = false;
            cmbInstaller.Enabled = false;
            cmbProccesType.Enabled = false;
            dateTarix.ReadOnly = false;
            tTotal.ReadOnly = false;
            tComment.ReadOnly = false;
        }

        private void fNewBonus_Load(object sender, EventArgs e)
        {
            dateTarix.DateTime = DateTime.Now;
            var data = db.Users.Where(x => x.UserRole.Name == "QURAŞDIRICI").ToList();
            FormHelpers.ControlLoad(data, cmbInstaller, "NameSurname", "User_ID");

            var bonus = db.Bonus.Where(x => x.Id == BonusID).FirstOrDefault();
            if (Operations == EnumsOperation.Operation.Show.ToString())
            {
                userFooter_Save1.SaveButtonText = "Bağla";
                userFooter_Save1.CancelVisible = false;
                lStatus.Visible = true;
                lStatus.Text = " ÖDƏNİLİB ";
                tCustomerName.Text = bonus.CustomerNameSurname;
                tCompanyName.Text = bonus.CompanyName;
                tVOEN.Text = bonus.Voen;
                cmbInstaller.Text = bonus.Installer;
                cmbProccesType.Text = bonus.ProccessType;
                dateTarix.EditValue = bonus.Date;
                tTotal.EditValue = bonus.Payment_Amount;
                tComment.Text = bonus.Comment;
                ShowModeRead();
                Logger.Log(tCompanyName.Text + " Bonusuna baxış keçirdi");
            }
            if (Operations == EnumsOperation.Operation.Payment.ToString())
            {
                lStatus.Text = " ÖDƏNİLMƏYİB ";
                lStatus.BackColor = Color.FromArgb(231, 76, 60);
                lStatus.Visible = true;
                userFooter_Save1.SaveButtonText = EnumsOperation.ButtonTextName.Payment.GetDescription();
                userFooter_Save1.CancelVisible = false;

                tCustomerName.Text = bonus.CustomerNameSurname;
                tCompanyName.Text = bonus.CompanyName;
                tVOEN.Text = bonus.Voen;
                cmbInstaller.Text = bonus.Installer;
                cmbProccesType.Text = bonus.ProccessType;
                dateTarix.EditValue = bonus.Date;
                tTotal.EditValue = bonus.Payment_Amount;
                tComment.Text = bonus.Comment;
            }
            if (Operations == EnumsOperation.Operation.Edit.ToString())
            {
                groupPay.Enabled = true;
                groupComment.Enabled = true;
                userFooter_Save1.SaveButtonText = EnumsOperation.ButtonTextName.Edit.GetDescription();
                tCustomerName.Text = bonus.CustomerNameSurname;
                tCompanyName.Text = bonus.CompanyName;
                tVOEN.Text = bonus.Voen;
                cmbInstaller.Text = bonus.Installer;
                cmbProccesType.Text = bonus.ProccessType;
                dateTarix.EditValue = bonus.Date;
                tTotal.EditValue = bonus.Payment_Amount;
                tComment.Text = bonus.Comment;
            }

        }

        private void bSelectCustomer_Click(object sender, EventArgs e)
        {
            fSelectedCustomer f = new fSelectedCustomer("Bonus");
            f.ShowDialog();
            if (!String.IsNullOrEmpty(tCustomerName.Text) || !String.IsNullOrEmpty(tVOEN.Text))
            {
                groupPay.Enabled = true;
                groupComment.Enabled = true;
            }
        }

        private void Clear()
        {
            tCustomerName.Text = null;
            tCompanyName.Text = null;
            cmbProccesType.Text = null;
            dateTarix.EditValue = null;
            tTotal.EditValue = null;
            tComment.Text = null;
            tVOEN.Text = null;
            dateTarix.EditValue = DateTime.Now;
        }

        private string Control()
        {
            if (String.IsNullOrEmpty(tCustomerName.Text))
                return "Müştərinin ad və soyadını daxil edin";
            if (String.IsNullOrEmpty(tCompanyName.Text))
                return "Obyekt adını daxil edin";
            if (String.IsNullOrEmpty(cmbProccesType.Text))
                return "Əməliyyat növünü seçin";
            if (String.IsNullOrEmpty(dateTarix.Text))
                return "Tarix seçin";
            if (String.IsNullOrEmpty(tTotal.Text))
                return "Ödəniş məbləğini daxil edin";
            return null;
        }

        private void cmbProccesType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProccesType.Text == "YENİ YAZILMA") { tTotal.EditValue = 20; }
            if (cmbProccesType.Text == "BƏRPA") { tTotal.EditValue = 15; }
            if (cmbProccesType.Text == "YENİDƏN YAZMA") { tTotal.EditValue = 10; }
        }

        private void userFooter_Save1_SaveClick(object sender, EventArgs e)
        {
            try
            {
                if (Operations == "Add")
                {
                    if (Control() != null) { Message(Control(), UserControls.MessageForm.enmType.Error); return; }
                    Bonus bonus = new Bonus();
                    bonus.CustomerNameSurname = tCustomerName.Text.Trim();
                    bonus.CompanyName = tCompanyName.Text.Trim();
                    bonus.Voen = tVOEN.Text.Trim();
                    bonus.Installer = cmbInstaller.Text;
                    bonus.ProccessType = cmbProccesType.Text;
                    bonus.Date = dateTarix.DateTime;
                    bonus.Payment_Amount = Convert.ToDouble(tTotal.EditValue);
                    bonus.Status = false;
                    bonus.PaymentPaid = null;
                    bonus.Comment = tComment.Text;
                    bonus.UserID = Properties.Settings.Default.UserID;
                    bonus.LogDate = DateTime.Now;
                    bonus.LogUpdateDate = null;
                    db.Bonus.Add(bonus);
                    db.SaveChanges();
                    Message("Uğurlu əməliyyat", UserControls.MessageForm.enmType.Success);
                    Logger.Log(tCompanyName.Text + " obyektinə yeni bonus əlavə edildi");
                    Clear();
                }
                else if (Operations == "Payment")
                {
                    double odenenMebleg = Convert.ToDouble(tTotal.Text.Replace(" AZN", ""));
                    var control = db.Bonus.Where(x => x.Id == BonusID).FirstOrDefault();
                    control.Status = true;
                    control.PaymentPaid = odenenMebleg;
                    control.LogUpdateDate = DateTime.Now;
                    control.Comment = tComment.Text;
                    db.SaveChanges();
                    Message("Uğurlu ödəniş", UserControls.MessageForm.enmType.Success);
                    Logger.Log(tCompanyName.Text + " obyektinin bonusunun ödənişini etdi");
                    Close();
                }
                else if (Operations == "Show")
                {
                    Close();
                }
                else if (Operations == "Edit")
                {
                    var control = db.Bonus.Where(x => x.Id == BonusID).FirstOrDefault();
                    control.CustomerNameSurname = tCustomerName.Text.Trim();
                    control.CompanyName = tCompanyName.Text.Trim();
                    control.Voen = tVOEN.Text.Trim();
                    control.Installer = cmbInstaller.Text;
                    control.ProccessType = cmbProccesType.Text;
                    control.Date = dateTarix.DateTime;
                    control.Payment_Amount = Convert.ToDouble(tTotal.EditValue);
                    control.Comment = tComment.Text;
                    db.SaveChanges();
                    Message("Uğurlu əməliyyat", UserControls.MessageForm.enmType.Success);
                    Logger.Log(tCompanyName.Text + " obyektinin bonusunda düzəliş edildi");
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\nQeydiyyat zamanı xəta yarandı", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void userFooter_Save1_CancelClick(object sender, EventArgs e)
        {
            Close();
        }
    }
}