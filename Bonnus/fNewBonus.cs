using DevExpress.XtraEditors;
using İNTEKO.Enums;
using İNTEKO.Helpers;
using İNTEKO.Messages;
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

namespace İNTEKO.Bonnus
{
    public partial class fNewBonus : FormBase
    {
        IntekodbEntities db = new IntekodbEntities();

        private Operation Operation { get; set; }

        public fNewBonus(Operation _operation)
        {
            InitializeComponent();
            Operation = _operation;
        }

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

            Bonus bonus = db.Bonus.FirstOrDefault(x => x.Id == BonusID);
            if (Operation == Operation.Show)
            {
                userFooter_Save1.SaveButtonText = EnumsOperation.ButtonTextName.Close.GetDescription();
                userFooter_Save1.CancelVisible = false;
                lStatus.Visible = true;
                lStatus.Text = EnumsOperation.StatusType.Paid.GetDescription().ToUpper();
                tCustomerName.Text = bonus.CustomerNameSurname;
                tCompanyName.Text = bonus.CompanyName;
                tVOEN.Text = bonus.Voen;
                cmbInstaller.Text = bonus.Installer;
                cmbProccesType.Text = bonus.ProccessType;
                dateTarix.EditValue = bonus.Date;
                tTotal.EditValue = bonus.Payment_Amount;
                tComment.Text = bonus.Comment;
                ShowModeRead();
                Logger.Log(tCompanyName.Text + " bonusuna baxış keçirdi");
            }
            if (Operation == Operation.Payment)
            {
                lStatus.Text = EnumsOperation.StatusType.NotPaid.GetDescription().ToUpper(); ;
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
            if (Operation == Operation.Edit)
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

        private string BonusValidation()
        {
            if (String.IsNullOrEmpty(tCustomerName.Text))
                return BonusMessages.CUSTOMER_NAME_NOT_FOUND;
            if (String.IsNullOrEmpty(tCompanyName.Text))
                return BonusMessages.COMPANY_NAME_NOT_FOUND;
            if (String.IsNullOrEmpty(cmbProccesType.Text))
                return BonusMessages.PROCCES_TYPE_NOT_FOUND;
            if (String.IsNullOrEmpty(dateTarix.Text))
                return BonusMessages.DATE_NOT_FOUND;
            if (String.IsNullOrEmpty(tTotal.Text))
                return BonusMessages.PRICE_NOT_FOUND;
            return null;
        }

        enum BonusType
        {
            [Description("YENİ YAZILMA")]
            New,
            [Description("BƏRPA")]
            Restore,
            [Description("YENİDƏN YAZMA")]
            Retry
        }

        private void cmbProccesType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProccesType.Text == BonusType.New.GetDescription().ToUpper()) { tTotal.EditValue = 20; }
            if (cmbProccesType.Text == BonusType.Restore.GetDescription().ToUpper()) { tTotal.EditValue = 15; }
            if (cmbProccesType.Text == BonusType.Retry.GetDescription().ToUpper()) { tTotal.EditValue = 10; }
        }

        private void userFooter_Save1_SaveClick(object sender, EventArgs e)
        {
            try
            {
                if (Operation == Operation.Add)
                {
                    if (BonusValidation() != null) { Message(BonusValidation(), UserControls.MessageForm.enmType.Error); return; }
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
                    Message(AutoMessage.SuccesfulOperation, UserControls.MessageForm.enmType.Success);
                    Logger.Log(tCompanyName.Text + " obyektinə yeni bonus əlavə edildi");
                    Clear();
                }
                else if (Operation == Operation.Payment)
                {
                    double odenenMebleg = Convert.ToDouble(tTotal.Text.Replace(" AZN", ""));
                    Bonus control = db.Bonus.FirstOrDefault(x => x.Id == BonusID);
                    control.Status = true;
                    control.PaymentPaid = odenenMebleg;
                    control.LogUpdateDate = DateTime.Now;
                    control.Comment = tComment.Text;
                    db.SaveChanges();
                    Message(AutoMessage.SuccesfulPayment, UserControls.MessageForm.enmType.Success);
                    Logger.Log(tCompanyName.Text + " bonusunun ödənişini etdi");
                    Close();
                }
                else if (Operation == Operation.Show)
                {
                    Close();
                }
                else if (Operation == Operation.Edit)
                {
                    Bonus control = db.Bonus.FirstOrDefault(x => x.Id == BonusID);
                    control.CustomerNameSurname = tCustomerName.Text.Trim();
                    control.CompanyName = tCompanyName.Text.Trim();
                    control.Voen = tVOEN.Text.Trim();
                    control.Installer = cmbInstaller.Text;
                    control.ProccessType = cmbProccesType.Text;
                    control.Date = dateTarix.DateTime;
                    control.Payment_Amount = Convert.ToDouble(tTotal.EditValue);
                    control.Comment = tComment.Text;
                    db.SaveChanges();
                    Message(AutoMessage.SuccesfulPayment, UserControls.MessageForm.enmType.Success);
                    Logger.Log(tCompanyName.Text + " bonusunda düzəliş edildi");
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