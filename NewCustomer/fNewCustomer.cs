using DevExpress.XtraEditors;
using İNTEKO.Enums;
using İNTEKO.Helpers;
using İNTEKO.Messages;
using İNTEKO.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static İNTEKO.Enums.EnumsOperation;

namespace İNTEKO.NewCustomer
{
    public partial class fNewCustomer : FormBase
    {
        IntekodbEntities db = new IntekodbEntities();

        private Operation Operation { get; }

        public Customers Customer { get; set; }

        public fNewCustomer(Operation operations)
        {
            InitializeComponent();
            Operation = operations;
        }

        bool No = false;

        void Clear()
        {
            //Customer
            tNameSurname.Text = null;
            tCompanyName.Text = null;
            tVoen.Text = null;
            tCompanyCode.Text = null;
            tPhone.Text = null;
            cmbCity.Text = null;
            cmbArea.Text = null;
            tAddress.Text = null;
            dateRegistration.Text = DateTime.Now.ToShortDateString();
            tSalesMan.Text = null;
            tGuessLocation.Text = null;
            tTypeofCompany.Text = null;
            //Licence
            tLicenceKey.Text = null;
            cmbLicenceVersion.Text = null;
            dateLicenceRegister.Text = DateTime.Now.ToShortDateString();
            toogleLicenceStatus.IsOn = false;
            //Kassa
            cmbKassaType.Text = null;
            tKassaSerialNumber.Text = null;
            tKassaVersionNumber.Text = null;
            //Payment
            cmbPaymentType.Text = null;
            tRegisterPrice.Text = null;
            tServicePrice.Text = null;
            //Contract
            tContractNo.Text = null;
            tContractPath.Text = null;
            No = false;
            lLicenceExists.Text = "Lisenziya yoxdur";
        }

        private void bClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        void ReqemYazdirma(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private string CustomerValidation()
        {
            if (String.IsNullOrWhiteSpace(tNameSurname.Text))
                return CustomerMessages.NAME_SURNAME_NOT_FOUND;
            if (String.IsNullOrWhiteSpace(tCompanyName.Text))
                return CustomerMessages.COMPANY_NAME_NOT_FOUND;
            if (String.IsNullOrWhiteSpace(tVoen.Text))
                return CustomerMessages.VOEN_NOT_FOUND;
            if (String.IsNullOrWhiteSpace(tCompanyCode.Text))
                return CustomerMessages.COMPANY_CODE_NOT_FOUND;
            if (String.IsNullOrWhiteSpace(tPhone.Text))
                return CustomerMessages.PHONE_NUMBER_NOT_FOUND;
            if (String.IsNullOrEmpty(cmbCity.Text))
                return CustomerMessages.CITY_NOT_FOUND;
            if (String.IsNullOrWhiteSpace(cmbArea.Text))
                return CustomerMessages.AREA_NOT_FOUND;
            if (String.IsNullOrWhiteSpace(tAddress.Text))
                return CustomerMessages.ADDRESS_NOT_FOUND;
            if (String.IsNullOrWhiteSpace(dateRegistration.Text))
                return CustomerMessages.REGISTERED_DATE_NOT_FOUND;
            if (String.IsNullOrWhiteSpace(tContractNo.Text))
                return CustomerMessages.CONTRACTNO_NOT_FOUND;
            //if (String.IsNullOrWhiteSpace(tLicenceKey.Text))
            //    return "Lisenziya kodunu daxil edin";
            //if (String.IsNullOrWhiteSpace(tLicenceVersion.Text))
            //    return "Lisenziya versiyasını daxil edin";
            //if (String.IsNullOrWhiteSpace(dateLicenceRegister.Text))
            //    return "Lisenziyanın quraşdırılma tarixini seçin";
            if (String.IsNullOrWhiteSpace(cmbKassaType.Text))
                return CustomerMessages.KASSA_MODEL_NOT_FOUND;

            if (cmbKassaType.Text == KassaType.SUNMI.ToString())
            {
                if (String.IsNullOrWhiteSpace(tKassaSerialNumber.Text))
                    return CustomerMessages.KASSA_SERIAL_NUMBER_NOT_FOUND;
            }
            else if (cmbKassaType.Text == KassaType.AZSMART.ToString())
            {
                if (String.IsNullOrWhiteSpace(tKassaSerialNumber.Text))
                    return CustomerMessages.KASSA_SERIAL_NUMBER_NOT_FOUND;
            }
            else if (cmbKassaType.Text == KassaType.OMNİTECH.ToString())
            {
                if (String.IsNullOrWhiteSpace(tKassaSerialNumber.Text))
                    return CustomerMessages.KASSA_SERIAL_NUMBER_NOT_FOUND;
            }
            //if (String.IsNullOrEmpty(tKassaVersionNumber.Text))
            //    return "Kassa versiya nömrəsini daxil edin";
            if (String.IsNullOrWhiteSpace(cmbPaymentType.Text))
                return CustomerMessages.PAYMENT_TYPE_NOT_FOUND;
            if (String.IsNullOrWhiteSpace(tRegisterPrice.Text))
                return CustomerMessages.REGISTER_PRICE_NOT_FOUND;
            if (String.IsNullOrWhiteSpace(tServicePrice.Text))
                return CustomerMessages.SUPPORT_PRICE_NOT_FOUND;
            //if(String.IsNullOrEmpty(tFilePath.Text))
            return null;
        }

        //public bool ContractNo { get; set; }

        void SaveFile(string filePath)
        {
            //using (Stream stream = File.OpenRead(filePath))
            //{
            //    byte[] buffer = new byte[stream.Length];
            //    stream.Read(buffer, 0, buffer.Length);

            //    var fi = new FileInfo(filePath);

            //    string extn = fi.Extension;
            //    string name = fi.Name;

            //    string query = "INSERT INTO Documents(Data, FileName, Extensions) VALUES(@Data, @FileName, @Extensions)";

            //    using (SqlConnection con = new SqlConnection(db.Database.Connection.ConnectionString))
            //    {
            //        SqlCommand cmd = new SqlCommand(query, con);
            //        cmd.Parameters.Add("@Data", SqlDbType.VarBinary).Value = buffer;
            //        cmd.Parameters.Add("@Extensions", SqlDbType.Char).Value = extn;
            //        cmd.Parameters.Add("@FileName", SqlDbType.NVarChar).Value = name;
            //        con.Open();
            //        cmd.ExecuteNonQuery();
            //    }
            //}
        }

        private void bFileBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK) { tContractPath.Text = dlg.FileName; }
        }

        private void fNewCustomer_Load(object sender, EventArgs e)
        {
            cmbFill();
            userFooter_Save1.CancelVisible = false;
            dateLicenceRegister.Text = DateTime.Now.ToShortDateString();
            dateRegistration.Text = DateTime.Now.ToShortDateString();
            if (Operation == Operation.Edit)
            {
                using (var db = new IntekodbEntities())
                {
                    labelControl21.Text = "Fayl adı";
                    bClear.Visible = false;
                    userFooter_Save1.SaveButtonText = "Düzəliş et";
                    this.Text = "Müştəri düzəlişi - " + Proccess.Versiya();

                    tContractNo.Text = Customer.ContractNo;
                    tNameSurname.Text = Customer.NameSurname;
                    tCompanyName.Text = Customer.CompanyName;
                    tVoen.Text = Customer.Voen;
                    tCompanyCode.Text = Customer.CompanyCode;
                    tPhone.Text = Customer.Phone;
                    cmbCity.Text = Customer.City.CityName;
                    cmbArea.Text = Customer.Area.AreaName;
                    tAddress.Text = Customer.Address;
                    dateRegistration.EditValue = Customer.Registration_Date;
                    tSalesMan.Text = Customer.SalesMan;
                    tTypeofCompany.Text = Customer.TypeofCompany;
                    tGuessLocation.Text = Customer.GuessLocation;
                    //Licence
                    if (Customer.LicenceID == null)
                    {
                        lLicenceExists.Text = "Lisenziya var";
                        tLicenceKey.Text = null;
                        cmbLicenceVersion.Text = null;
                        dateLicenceRegister.EditValue = null;
                        dateLicenceRegister.Enabled = false;
                        cmbLicenceVersion.Enabled = false;
                        tLicenceKey.Enabled = false;
                        toogleLicenceStatus.IsOn = false;
                        cmbLicenceVersion.Text = null;
                        dateLicenceRegister.Text = null;
                        tLicenceKey.Text = null;
                    }
                    else
                    {
                        tLicenceKey.Text = Customer.LicenceID.ToString();
                        cmbLicenceVersion.Text = Customer.LicenceVersion;
                        dateLicenceRegister.EditValue = Customer.LicenceRegister;
                        toogleLicenceStatus.IsOn = (bool)Customer.LicenceStatus;
                    }

                    //Kassa
                    cmbKassaType.Text = Customer.Kassalar.Name;
                    tKassaSerialNumber.Text = Customer.KassaSerialNumber;
                    tKassaVersionNumber.Text = Customer.KassaVersionNumber;
                    //Payment
                    cmbPaymentType.Text = Customer.PaymentType.PaymentName;
                    tRegisterPrice.EditValue = Customer.RegistrationPrice;
                    tServicePrice.EditValue = Customer.ServicePrice;
                    toogleMposVersion.IsOn = (bool)Customer.MposVersion;
                    tContractPath.Text = Customer.ContractFileName;

                }
            }
            else if (Operation == Operation.Add)
            {
                userFooter_Save1.SaveButtonText = ButtonTextName.Save.GetDescription();
                this.Text = "Yeni müştəri - " + Proccess.Versiya();
            }
        }

        void cmbFill()
        {
            #region City
            var city = db.City.AsNoTracking().
                               Where(x => x.Status == true).
                               OrderBy(x => x.Id).ToList();

            FormHelpers.ControlLoad(city, cmbCity, "CityName");
            #endregion

            #region Kassa
            var kassa = db.Kassalar.AsNoTracking().
                                    Select(x => new { x.Id, x.Name, x.Status }).
                                    Where(x => x.Status == true).
                                    OrderBy(x => x.Id).ToList();

            FormHelpers.ControlLoad(kassa, cmbKassaType, "Name");
            #endregion

            #region PaymentType
            var payType = db.PaymentType.AsNoTracking().
                                         Select(x => new { x.Id, x.PaymentName, x.Status }).
                                         Where(x => x.Status == true).
                                         OrderBy(x => x.Id).ToList();

            FormHelpers.ControlLoad(payType, cmbPaymentType, "PaymentName");
            #endregion

            #region LicenceVersion
            var licence = db.LicenceVersions.AsNoTracking().
                                             Select(x => new { x.LicenceVersionNumber, x.Status }).
                                             Where(x => x.Status == true).
                                             OrderBy(x => x.LicenceVersionNumber).ToList();

            FormHelpers.ControlLoad(licence, cmbLicenceVersion, "LicenceVersionNumber");
            #endregion
        }

        private void cmbCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            var data = db.Area.AsNoTracking().Where(x => x.City.CityName == cmbCity.Text && x.Status == true).ToList();
            FormHelpers.ControlLoad(data, cmbArea, "AreaName");
        }

        private void userFooter_Save1_CancelClick(object sender, EventArgs e)
        {
            Close();
        }

        private void userFooter_Save1_SaveClick(object sender, EventArgs e)
        {
            try
            {
                if (CustomerValidation() != null)
                {
                    Message(CustomerValidation(), UserControls.MessageForm.enmType.Warning); 
                    return;
                }
                if (Operation == Operation.Edit)
                {
                    Customers editCustomer = db.Customers.FirstOrDefault(x => x.Id == Customer.Id);
                    editCustomer.NameSurname = tNameSurname.Text;
                    editCustomer.CompanyName = tCompanyName.Text;
                    editCustomer.Voen = tVoen.Text;
                    editCustomer.CompanyCode = tCompanyCode.Text;
                    editCustomer.Phone = tPhone.Text;
                    editCustomer.CityID = (int)cmbCity.SelectedValue;
                    editCustomer.AreaID = (int)cmbArea.SelectedValue;
                    editCustomer.Address = tAddress.Text;
                    editCustomer.Registration_Date = dateRegistration.DateTime;
                    editCustomer.SalesMan = tSalesMan.Text;
                    editCustomer.GuessLocation = tGuessLocation.Text;
                    editCustomer.TypeofCompany = tTypeofCompany.Text;
                    //Licence
                    if (lLicenceExists.Text == "Lisenziya var")
                    {
                        editCustomer.LicenceID = null;
                        editCustomer.LicenceVersion = null;
                        editCustomer.LicenceRegister = null;
                        editCustomer.LicenceStatus = null;
                    }
                    else
                    {
                        editCustomer.LicenceID = Guid.Parse(tLicenceKey.Text);
                        editCustomer.LicenceVersion = cmbLicenceVersion.Text;
                        editCustomer.LicenceRegister = dateLicenceRegister.DateTime;
                        editCustomer.LicenceStatus = toogleLicenceStatus.IsOn;
                    }
                    editCustomer.MposVersion = toogleMposVersion.IsOn;
                    //Kassa
                    editCustomer.Kassa_Model = (int)cmbKassaType.SelectedValue;
                    editCustomer.KassaSerialNumber = tKassaSerialNumber.Text;
                    editCustomer.KassaVersionNumber = tKassaVersionNumber.Text;
                    //Payment
                    editCustomer.PaymentTypeID = (int)cmbPaymentType.SelectedValue;
                    editCustomer.RegistrationPrice = Convert.ToDouble(tRegisterPrice.EditValue);
                    editCustomer.ServicePrice = Convert.ToDouble(tServicePrice.EditValue);
                    //Contract
                    editCustomer.ContractNo = tContractNo.Text;
                    DialogResult = DialogResult.OK;
                    if (tContractPath.Text == editCustomer.ContractFileName) { goto ContractSkip; }
                    else
                    {
                        if (!String.IsNullOrEmpty(tContractPath.Text))
                        {
                            using (Stream stream = File.OpenRead(tContractPath.Text))
                            {
                                byte[] data = new byte[stream.Length];
                                stream.Read(data, 0, data.Length);
                                var fi = new FileInfo(tContractPath.Text);
                                string extn = fi.Extension;
                                string name = fi.Name;

                                editCustomer.ContractData = (byte[])data;
                                editCustomer.FileExtensions = extn;
                                editCustomer.ContractFileName = name;
                            }
                        }
                        else
                        {
                            Form fshutdown = new Form();
                            try
                            {
                                using (fContractNotification shutdown = new fContractNotification())
                                {
                                    fshutdown.StartPosition = FormStartPosition.CenterScreen;
                                    fshutdown.FormBorderStyle = FormBorderStyle.None;
                                    fshutdown.Opacity = .50d;
                                    fshutdown.BackColor = Color.Black;
                                    fshutdown.WindowState = FormWindowState.Maximized;
                                    fshutdown.TopMost = true;
                                    fshutdown.Location = this.Location;
                                    fshutdown.ShowInTaskbar = false;
                                    fshutdown.Show();

                                    shutdown.Owner = fshutdown;
                                    shutdown.Operation = "Edit";
                                    shutdown.ShowDialog();
                                    No = shutdown.No;
                                    fshutdown.Dispose();
                                    if (No == false)
                                    {
                                        return;
                                    }
                                    else
                                    {
                                        editCustomer.ContractData = null;
                                        editCustomer.FileExtensions = null;
                                        editCustomer.ContractFileName = null;
                                    }
                                }
                            }
                            catch (Exception ex)
                            {
                                fshutdown.Dispose();
                                MessageBox.Show(ex.Message);
                            }
                            finally { fshutdown.Dispose(); }
                        }
                    }


                ContractSkip:
                    db.SaveChanges();
                    Message(tCompanyName.Text + " Müştərisində uğurla düzəliş edildi", UserControls.MessageForm.enmType.Success);
                    Logger.Log(tCompanyName.Text + " Müştərisində düzəliş edildi");
                    Close();

                }
                else if (Operation == Operation.Add)
                {
                    Customers customers = new Customers();
                    customers.NameSurname = tNameSurname.Text;
                    customers.CompanyName = tCompanyName.Text;
                    customers.Voen = tVoen.Text;
                    customers.CompanyCode = tCompanyCode.Text;
                    customers.Phone = tPhone.Text;
                    customers.CityID = (int)cmbCity.SelectedValue;
                    customers.AreaID = (int)cmbArea.SelectedValue;
                    customers.Address = tAddress.Text;
                    customers.Registration_Date = dateRegistration.DateTime;
                    customers.Status = true;
                    customers.MposVersion = toogleMposVersion.IsOn;
                    customers.SalesMan = tSalesMan.Text;
                    customers.GuessLocation = tGuessLocation.Text;
                    customers.TypeofCompany = tTypeofCompany.Text;
                    //Licence
                    if (lLicenceExists.Text == "Lisenziya var")
                    {
                        customers.LicenceID = null;
                        customers.LicenceVersion = null;
                        customers.LicenceRegister = null;
                        customers.LicenceStatus = null;
                    }
                    else
                    {
                        customers.LicenceID = Guid.Parse(tLicenceKey.Text);
                        customers.LicenceVersion = cmbLicenceVersion.Text;
                        customers.LicenceRegister = dateLicenceRegister.DateTime;
                        customers.LicenceStatus = toogleLicenceStatus.IsOn;
                    }
                    //Kassa
                    customers.Kassa_Model = (int)cmbKassaType.SelectedValue;
                    customers.KassaSerialNumber = tKassaSerialNumber.Text;
                    customers.KassaVersionNumber = tKassaVersionNumber.Text;
                    //Payment
                    customers.PaymentTypeID = (int)cmbPaymentType.SelectedValue;
                    customers.RegistrationPrice = Convert.ToDouble(tRegisterPrice.EditValue);
                    customers.ServicePrice = Convert.ToDouble(tServicePrice.EditValue);
                    //Contract
                    //if (String.IsNullOrEmpty(tContractPath.Text)) { goto ContractSkip; }
                    customers.ContractNo = tContractNo.Text;
                    if (!String.IsNullOrEmpty(tContractPath.Text))
                    {
                        using (Stream stream = File.OpenRead(tContractPath.Text))
                        {
                            byte[] data = new byte[stream.Length];
                            stream.Read(data, 0, data.Length);
                            var fi = new FileInfo(tContractPath.Text);
                            string extn = fi.Extension;
                            string name = fi.Name;

                            customers.ContractData = (byte[])data;
                            customers.FileExtensions = extn;
                            customers.ContractFileName = name;
                            customers.ContractNo = tContractNo.Text;
                        }
                    }
                    else
                    {
                        Form fshutdown = new Form();
                        try
                        {
                            using (fContractNotification shutdown = new fContractNotification())
                            {
                                fshutdown.StartPosition = FormStartPosition.CenterScreen;
                                fshutdown.FormBorderStyle = FormBorderStyle.None;
                                fshutdown.Opacity = .50d;
                                fshutdown.BackColor = Color.Black;
                                fshutdown.WindowState = FormWindowState.Maximized;
                                fshutdown.TopMost = true;
                                fshutdown.Location = this.Location;
                                fshutdown.ShowInTaskbar = false;
                                fshutdown.Show();

                                shutdown.Owner = fshutdown;
                                shutdown.Operation = "Add";
                                shutdown.ShowDialog();
                                No = shutdown.No;
                                fshutdown.Dispose();
                                if (No == false) { return; }
                                else
                                {
                                    customers.ContractData = null;
                                    customers.FileExtensions = null;
                                    customers.ContractFileName = null;
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            fshutdown.Dispose();
                            MessageBox.Show(ex.Message);
                        }
                        finally { fshutdown.Dispose(); }
                    }

                    customers.UserID = Properties.Settings.Default.UserID;
                    customers.LogDate = DateTime.Now;

                    //Tarif
                    Tarifler tarifler = new Tarifler();
                    tarifler.CustomerID = customers.Id;
                    tarifler.OldTarif = 0;
                    tarifler.NewTarif = Convert.ToDouble(tServicePrice.EditValue);
                    tarifler.EditDate = DateTime.Now;

                    db.Customers.Add(customers);
                    db.Tarifler.Add(tarifler);
                    db.SaveChanges();
                    Message("Yeni müştəri yaradıldı", UserControls.MessageForm.enmType.Success);
                    Logger.Log(tCompanyName.Text + " Müştərisi yaradıldı");
                    DialogResult = DialogResult.OK;
                    Clear();
                    cmbFill();
                    lLicenceExists_Click(null, null);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lLicenceExists_Click(object sender, EventArgs e)
        {
            if (lLicenceExists.Text == "Lisenziya yoxdur")
            {
                lLicenceExists.Text = "Lisenziya var";
                toogleLicenceStatus.Enabled = false;

                dateLicenceRegister.Enabled = false;
                cmbLicenceVersion.Enabled = false;
                tLicenceKey.Enabled = false;
                toogleLicenceStatus.IsOn = false;
                cmbLicenceVersion.Text = null;
                dateLicenceRegister.Text = null;
                tLicenceKey.Text = null;
            }
            else
            {
                toogleLicenceStatus.Enabled = true;
                dateLicenceRegister.Enabled = true;
                cmbLicenceVersion.Enabled = true;
                tLicenceKey.Enabled = true;
                toogleLicenceStatus.IsOn = true;
                lLicenceExists.Text = "Lisenziya yoxdur";
            }
        }

        enum KassaType
        {
            SUNMI,
            OMNİTECH,
            AZSMART,
            DATAPAY,
            IBM,
            NBA,
            XPRİNTER,
            BAZA
        }

        private void fNewCustomer_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!FormHelpers.ManualDialogResult("Səhifədən çıxış etmək istəyirsiniz ?", "Mesaj", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                e.Cancel = true;
        }
    }
}