using DevExpress.XtraEditors;
using İNTEKO.PayHistory;
using İNTEKO.Tools;
using İNTEKO.Licence;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using OfficeOpenXml;
using System.Windows.Forms;
using LicenseContext = OfficeOpenXml.LicenseContext;
using OfficeOpenXml.Table;
using System.Net;
using İNTEKO.Enums;
using İNTEKO.Helpers;
using static İNTEKO.Enums.EnumsOperation;
using İNTEKO.Messages;
using System.Threading.Tasks;

namespace İNTEKO.DetailForm
{
    public partial class fDetail : FormBase
    {
        IntekodbEntities db = new IntekodbEntities();
        Customers Customerid;

        private int CustomerID { get; set; }

        public fDetail(Customers _id)
        {
            InitializeComponent();
            Customerid = _id;
            CustomerID = _id.Id;
            var teest = DateTime.Now;
            this.Text = _id.CompanyName + Proccess.Versiya();
        }

        private void FormFill(Customers _customer)
        {
            var customer = db.Customers.FirstOrDefault(x => x.Id == _customer.Id);
            lContractNo.Text = customer.ContractNo;

            tNameSurname.Text = customer.NameSurname;
            tCompanyName.Text = customer.CompanyName;
            tVoen.Text = customer.Voen;
            tCompanyCode.Text = customer.CompanyCode;
            tPhone.Text = customer.Phone;
            cmbCity.Text = customer.City.CityName;
            cmbArea.Text = customer.Area.AreaName;
            tAddress.Text = customer.Address;
            dateRegistration.EditValue = customer.Registration_Date;
            tSalesMan.Text = customer.SalesMan;
            tTypeofCompany.Text = customer.TypeofCompany;
            tGuessLocation.Text = customer.GuessLocation;

            if (customer.Status == true)
            {
                lCustomerStatus.Text = StatusType.Active.GetDescription();
                lCustomerStatus.ForeColor = Color.FromArgb(16, 172, 132);
            }
            else
            {
                lCustomerStatus.Text = StatusType.Deactive.GetDescription();
                lCustomerStatus.ForeColor = Color.FromArgb(192, 0, 0);
            }

            //Lisenziya
            tLicenceKey.Text = customer.LicenceID.ToString();
            tLicenceVersion.Text = customer.LicenceVersion;
            dateLicenceRegister.EditValue = customer.LicenceRegister;
            if (customer.LicenceStatus != null)
            {
                if ((bool)customer.LicenceStatus) //Lisenziya statusu
                {
                    lLicenceStatus.Text = EnumsOperation.StatusType.Active.GetDescription();
                    lLicenceStatus.ForeColor = Color.FromArgb(1, 131, 131);
                    bMposStatusControl.Text = EnumsOperation.ButtonTextName.Deactivate.GetDescription();
                    bMposStatusControl.Appearance.ForeColor = Color.FromArgb(232, 65, 24);

                }
                else
                {
                    lLicenceStatus.Text = EnumsOperation.StatusType.Deactive.GetDescription();
                    lLicenceStatus.ForeColor = Color.FromArgb(232, 65, 24);
                    bMposStatusControl.Text = EnumsOperation.ButtonTextName.Activate.GetDescription();
                    bMposStatusControl.Appearance.ForeColor = Color.FromArgb(1, 131, 131);
                }
            }
            else
            {
                lLicenceStatus.Text = "Yoxdur";
                lLicenceStatus.ForeColor = Color.FromArgb(232, 65, 24);
            }


            if ((bool)customer.MposVersion) // Mpos versiya
            {
                lMposVersion.Text = "Yeni versiya";
                lMposVersion.ForeColor = Color.FromArgb(1, 131, 131);
            }
            else
            {
                lMposVersion.Text = "Köhnə versiya";
                lMposVersion.ForeColor = Color.FromArgb(232, 65, 24);
            }

            //Kassa
            cmbKassaType.Text = customer.Kassalar.Name;
            tKassaSerialNumber.Text = customer.KassaSerialNumber;
            tKassaVersionNumber.Text = customer.KassaVersionNumber;

            //Ödenişler
            cmbPaymentType.Text = customer.PaymentType.PaymentName;
            tRegisterPrice.Text = customer.RegistrationPrice.ToString();
            tServicePrice.Text = customer.ServicePrice.ToString();
        }

        private void bContractShow_Click(object sender, EventArgs e)
        {
            OpenFile(Customerid.Id);
        }

        private void OpenFile(int id)
        {
            var control = db.Customers.Where(x => x.Id == Customerid.Id).FirstOrDefault();

            if (control.ContractData == null)
            {
                if (FormHelpers.ManualDialogResult("Müqavilə əlavə edilməyib !\nƏlavə etmək istəyirsiniz ?", "Mesaj", MessageBoxButtons.YesNo, MessageBoxIcon.Information))
                {
                    fContract contract = new fContract();
                    contract.CusomerID = CustomerID;
                    contract.ShowDialog();
                }
                else
                {
                    return;
                }
            }
            else
            {
                using (SqlConnection con = new SqlConnection(db.Database.Connection.ConnectionString))
                {
                    string query = "SELECT ContractData,FileExtensions,ContractFileName FROM Customers WHERE Id=@id";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                    con.Open();
                    var reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        var name = reader["ContractFileName"].ToString();
                        var data = (byte[])reader["ContractData"];
                        var extn = reader["FileExtensions"].ToString();

                        var newFileName = name.Replace(extn, DateTime.Now.ToString("ddMMyyyyhhmmss")) + extn;
                        File.WriteAllBytes(Application.StartupPath + "\\temp\\" + newFileName, data);
                        //File.WriteAllBytes(newFileName, data);
                        Process.Start(Application.StartupPath + "\\temp\\" + newFileName);
                    }
                }
            }
        }

        private void TextBoxReadOnly()
        {
            tNameSurname.ReadOnly = false;
            tCompanyName.ReadOnly = false;
            tVoen.ReadOnly = false;
            tCompanyCode.ReadOnly = false;
            tPhone.ReadOnly = false;
            tAddress.ReadOnly = false;
            cmbCity.Enabled = false;
            cmbArea.Enabled = false;
            dateRegistration.ReadOnly = false;
            tSalesMan.ReadOnly = false;
            tGuessLocation.ReadOnly = false;
            tTypeofCompany.ReadOnly = false;
            tLicenceKey.ReadOnly = false;
            tLicenceVersion.ReadOnly = false;
            dateLicenceRegister.ReadOnly = false;
            cmbKassaType.Enabled = false;
            tKassaVersionNumber.ReadOnly = false;
            tKassaSerialNumber.ReadOnly = false;
            cmbPaymentType.Enabled = false;
            tRegisterPrice.ReadOnly = false;
            tServicePrice.ReadOnly = false;
        }

        private void fDetail_Load(object sender, EventArgs e)
        {
            //todo setup halına gətirdikdə bu kodu aktiv et
            //if (Properties.Settings.Default.UserID is 1)
            //    bMposLicenceControl.Visible = true;

            FormFill(Customerid);
            userFooter_Save1.CancelVisible = false;
            userFooter_Save1.SaveButtonText = EnumsOperation.ButtonTextName.Close.GetDescription();
            TextBoxReadOnly();
            //TraverseTextEditControls(this);
        }

        void ReqemYazdirma(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void TraverseTextEditControls(Control parentControl)
        {
            var look = db.Users.Where(x => x.User_ID == Properties.Settings.Default.UserID).FirstOrDefault();
            foreach (Control childControl in parentControl.Controls)
            {
                if (childControl is TextEdit)
                {
                    TextEdit textEdit = (TextEdit)childControl;
                    textEdit.Enabled = (bool)look.UserRole.Edit;
                }
                else if (childControl.Controls.Count > 0)
                {
                    TraverseTextEditControls(childControl);
                }
            }
            foreach (Control item in parentControl.Controls)
            {
                if (item is System.Windows.Forms.ComboBox)
                {
                    System.Windows.Forms.ComboBox comboBox = (System.Windows.Forms.ComboBox)item;
                    comboBox.Enabled = (bool)look.UserRole.Edit;
                }
                else if (item.Controls.Count > 0)
                {
                    TraverseTextEditControls(item);
                }
            }
            toogleMposVersion.Enabled = (bool)look.UserRole.Edit;
        }

        private void bExtraContract_Click(object sender, EventArgs e)
        {
            fExtraContracts f = new fExtraContracts();
            f.CustomerID = Customerid;
            f.ShowDialog();
        }

        private void bPaymentProcces_Click(object sender, EventArgs e)
        {
            fPaymenHistory f = new fPaymenHistory("fDetail", CustomerID);
            f.ShowDialog();
        }

        private void fDetail_FormClosed(object sender, FormClosedEventArgs e)
        {
            db.Dispose();
            this.Dispose();
        }

        private void bDelete_Click(object sender, EventArgs e)
        {
            //if (MessageBox.Show("Seçili müştəriyə aid olan məlumatlar və müqavilələr bazadan qalıcı olaraq silinəcəkdir. \n\nBu əməliyyatı təsdiqləyirsiniz ?", "Mesaj", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            //{
            //    var contractDelete = db.Contracts.Where(x => x.CustomerID == Customerid.Id).FirstOrDefault();
            //    var customersDelete = db.Customers.Where(x => x.Id == Customerid.Id).FirstOrDefault();
            //    if (contractDelete != null) { db.Contracts.Remove(contractDelete); }
            //    db.Customers.Remove(customersDelete);
            //    db.SaveChanges();
            //    Message("Müştərinin məlumatları bazadan qalıcı olaraq silindi", UserControls.MessageForm.enmType.Success);
            //    db.Dispose();
            //    this.Dispose();
            //}
        }

        private void bExport_Click(object sender, EventArgs e)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            string CustomerCompany = Customerid.CompanyName;
            var newFile = new FileInfo(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\" + CustomerCompany + "_" + DateTime.Now.ToShortDateString() + ".xlsx");
            if (newFile.Exists)
            {
                Message("Fayl mövcud olduğu üçün üzərinə yenisi yazılabilməz !", UserControls.MessageForm.enmType.Error);
                if (MessageBox.Show("Mövcud faylı silib yenisinin yazılmasını istəyirsiniz ?", "Mesaj", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Process[] processes = Process.GetProcessesByName("EXCEL");
                    if (processes.Length > 0)
                    {
                        Message("Açıq olan excel faylını bağlayıb yenidən test edin !", UserControls.MessageForm.enmType.Error); return;
                    }
                    else { File.Delete(newFile.ToString()); }
                }
                else { return; }
            }
            try
            {
                using (var package = new ExcelPackage(newFile))
                {
                    // Excel səhifəsinin adı
                    var worksheet = package.Workbook.Worksheets.Add("Info");
                    //Sütunlar
                    worksheet.Cells[1, 1].Value = "ADI SOYADI";
                    worksheet.Cells[1, 2].Value = "OBYEKT ADI";
                    worksheet.Cells[1, 3].Value = "VÖEN - KOD";
                    worksheet.Cells[1, 4].Value = "ÜNVAN";
                    worksheet.Cells[1, 5].Value = "KASSA MODEL";
                    worksheet.Cells[1, 6].Value = "MÜQAVİLƏ №";
                    worksheet.Cells[1, 7].Value = "QEYDİYYAT TARİXİ";
                    worksheet.Cells[1, 8].Value = "SATAN İŞÇİ";
                    worksheet.Cells[1, 9].Value = "VERSİYA";
                    worksheet.Cells[1, 10].Value = "TELEFON";
                    worksheet.Cells[1, 11].Value = "VƏZİYYƏT";
                    worksheet.Cells[1, 12].Value = "ÖDƏNİŞİN NÖVÜ";
                    worksheet.Cells[1, 13].Value = "YAZILMA QİYMƏTİ";
                    worksheet.Cells[1, 14].Value = "SERVİS XİDMƏTİ";
                    worksheet.Cells[1, 15].Value = "TOPLAM DAXİL OLMA";

                    // Sətirləri doldurma
                    worksheet.Cells[2, 1].Value = Customerid.NameSurname;
                    worksheet.Cells[2, 2].Value = Customerid.CompanyName;
                    worksheet.Cells[2, 3].Value = Customerid.Voen + " - " + Customerid.CompanyCode;
                    worksheet.Cells[2, 4].Value = Customerid.Address;
                    worksheet.Cells[2, 5].Value = Customerid.Kassalar.Name;
                    worksheet.Cells[2, 6].Value = Customerid.ContractNo;
                    worksheet.Cells[2, 7].Value = Customerid.Registration_Date.ToString();
                    worksheet.Cells[2, 8].Value = Customerid.SalesMan;
                    if (Customerid.MposVersion == true) { worksheet.Cells[2, 9].Value = "YENİ"; }
                    else { worksheet.Cells[2, 9].Value = "KÖHNƏ"; }
                    worksheet.Cells[2, 10].Value = Customerid.Phone;
                    if (Customerid.LicenceStatus == true) { worksheet.Cells[2, 11].Value = "İŞLƏK"; }
                    else { worksheet.Cells[2, 11].Value = "İSTİFADƏ OLUNMUR"; }
                    worksheet.Cells[2, 12].Value = Customerid.PaymentType.PaymentName;
                    worksheet.Cells[2, 13].Value = Customerid.RegistrationPrice;
                    worksheet.Cells[2, 14].Value = Customerid.ServicePrice;
                    worksheet.Cells[2, 15].Value = Customerid.ServicePrice + Customerid.RegistrationPrice;

                    // Sütun başlıqlarının stilləri
                    using (var range = worksheet.Cells[1, 1, 1, 15])
                    {
                        range.Style.Font.Bold = true;
                        range.Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                        //range.Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.LightGray);
                    }

                    //Excel cədvəl yaratma
                    var tableRange = worksheet.Cells[1, 1, 2, 15];
                    var excelTable = worksheet.Tables.Add(tableRange, "Values");
                    excelTable.TableStyle = TableStyles.Medium20;

                    // Excel faylını yadda saxlama
                    package.Save();
                    Message(AutoMessage.ExcelExportSuccesfulyMessage, UserControls.MessageForm.enmType.Success);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void bTarif_Click(object sender, EventArgs e)
        {
            fTarif f = new fTarif();
            f.CustomerID = Customerid;
            if (f.ShowDialog() == DialogResult.OK)
                DialogResult = DialogResult.OK;
        }

        private void bLicenceICopy_Click(object sender, EventArgs e)
        {
            if (tLicenceKey.Text != null)
            {
                Clipboard.SetText(tLicenceKey.Text);
                Message(CustomerMessages.LICENCE_KEY_COPY, UserControls.MessageForm.enmType.Success);
            }
        }

        private void DeactiveLicence()
        {
            string data;

            // FtpWebRequest yaratma
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(Servers.ServerAddress + Servers.RemoteFilePath);
            request.Method = WebRequestMethods.Ftp.UploadFile;
            request.Credentials = new NetworkCredential(Servers.Username, Servers.Password);

            //Dataları oxuma
            using (var web = new WebClient())
            {
                data = web.DownloadString(Servers.BlockLicenceURL);
            }

            // Düzəliş ediləcək lisenziyanı qeyd edilməsi
            string updatedData = tLicenceKey.Text.Trim() + "\n" + data;

            // Yazdırma
            byte[] fileContents = System.Text.Encoding.UTF8.GetBytes(updatedData.Trim());
            request.ContentLength = fileContents.Length;

            using (Stream requestStream = request.GetRequestStream())
                requestStream.Write(fileContents, 0, fileContents.Length);

            var updateCustomer = db.Customers.Where(x => x.Id == Customerid.Id).FirstOrDefault();
            updateCustomer.LicenceStatus = false;
            LicenceHistory history = new LicenceHistory();
            history.CustomerID = Customerid.Id;
            history.Description = "Deaktiv edildi";
            history.UserID = Properties.Settings.Default.UserID;
            history.LicenceKey = Customerid.LicenceID;
            history.Tarix = DateTime.Now;
            db.LicenceHistory.Add(history);
            db.SaveChanges();
            FormFill(Customerid);
            Message(CustomerMessages.LICENCE_DEACTIVATING, UserControls.MessageForm.enmType.Success);
            Logger.Log(tCompanyName.Text + " istifadəçisinin lisenziyası deaktiv edildi");
        }

        private void ActiveLicence()
        {
            // FtpWebRequest yaratma
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(Servers.ServerAddress + Servers.RemoteFilePath);
            request.Method = WebRequestMethods.Ftp.DownloadFile;
            request.Credentials = new NetworkCredential(Servers.Username, Servers.Password);

            // FtpWebResponse alma
            using (FtpWebResponse response = (FtpWebResponse)request.GetResponse())
            {
                // Faylın içini oxuma
                using (Stream stream = response.GetResponseStream())
                {
                    StreamReader reader = new StreamReader(stream);

                    string fileContents = reader.ReadToEnd();

                    fileContents = fileContents.Replace(tLicenceKey.Text.Trim(), "");

                    UploadFile(fileContents);
                }
            }
        }

        private void UploadFile(string localFilePath)
        {
            try
            {
                // FtpWebRequest yaratma
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(Servers.ServerAddress + Servers.RemoteFilePath);
                request.Method = WebRequestMethods.Ftp.UploadFile;
                request.Credentials = new NetworkCredential(Servers.Username, Servers.Password);

                // fayl məlumatlarını yükləmə
                byte[] fileContents = System.Text.Encoding.UTF8.GetBytes(localFilePath.Trim());
                request.ContentLength = fileContents.Length;
                using (Stream requestStream = request.GetRequestStream())
                {
                    requestStream.Write(fileContents, 0, fileContents.Length);
                }

                var updateCustomer = db.Customers.FirstOrDefault(x => x.Id == Customerid.Id);
                updateCustomer.LicenceStatus = true;
                LicenceHistory history = new LicenceHistory();
                history.CustomerID = Customerid.Id;
                history.Description = "Aktiv edildi";
                history.UserID = Properties.Settings.Default.UserID;
                history.LicenceKey = Customerid.LicenceID;
                history.Tarix = DateTime.Now;
                db.LicenceHistory.Add(history);
                db.SaveChanges();
                FormFill(Customerid);
                Message(CustomerMessages.LICENCE_ACTIVATING, UserControls.MessageForm.enmType.Success);
                Logger.Log(tCompanyName.Text + " istifadəçisinin lisenziyası aktiv edildi");
            }
            catch (WebException ex)
            {
                MessageBox.Show("Xəta: \n" + ex.Message, "UploadLicenceError", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bMposStatusControl_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (tLicenceVersion.Text == "1.0.0.2" || tLicenceVersion.Text == "1.0.0.3")
            {
                Message(tLicenceVersion.Text + " versiyalı lisenziyaya müdaxilə etmək mümkün deyil", UserControls.MessageForm.enmType.Info);
                return;
            }
            if (lLicenceStatus.Text == "Yoxdur")
            {
                Message(CustomerMessages.LICENCE_KEY_NULL, UserControls.MessageForm.enmType.Info);
                return;
            }
            MposStatusControl(Customerid);
            Cursor.Current = Cursors.Default;
        }

        private void MposStatusControl(Customers customer)
        {
            if (!Proccess.IsInternetAvailable()) { return; }

            try
            {
                if (bMposStatusControl.Text == EnumsOperation.ButtonTextName.Deactivate.GetDescription())
                {
                    LicenceRemoteServerControl();
                    DeactiveLicence();
                }
                else
                {
                    LicenceRemoteServerControl();
                    ActiveLicence();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bLicenceProcces_Click(object sender, EventArgs e)
        {
            fLicenceHistory f = new fLicenceHistory();
            f.CustomerID = CustomerID;
            f.ShowDialog();
        }

        private  void bMposLicenceControl_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            LicenceRemoteServerControl();
            Message(CustomerMessages.LICENCE_STATUS_CONTROL, UserControls.MessageForm.enmType.Info);
            Logger.Log(tCompanyName.Text + " istifadəçisinin lisenziyasını serverdən yoxlatdırdı");
            Cursor.Current = Cursors.Default;
        }

        private async void LicenceRemoteServerControl()
        {
            if (!Proccess.IsInternetAvailable()) { return; }

            var licenceControl = db.Customers.FirstOrDefault(x => x.Id == CustomerID);
            if (String.IsNullOrEmpty(tLicenceKey.Text)) { Message(CustomerMessages.LICENCE_KEY_NULL, UserControls.MessageForm.enmType.Info); return; }


            if (tLicenceVersion.Text == "1.0.0.2" || tLicenceVersion.Text == "1.0.0.3")
            {
                WebClient web = new WebClient();

                if (web.DownloadString(Servers.GithubBlockLicenceURL).Contains(tLicenceKey.Text))
                {
                    lLicenceStatus.Text = EnumsOperation.StatusType.Deactive.GetDescription();
                    lLicenceStatus.ForeColor = Color.FromArgb(192, 0, 0);
                    licenceControl.LicenceStatus = false;
                }
                else
                {
                    lLicenceStatus.Text = EnumsOperation.StatusType.Active.GetDescription();
                    lLicenceStatus.ForeColor = Color.FromArgb(16, 172, 132);
                    licenceControl.LicenceStatus = true;
                }
            }
            else
            {
                // FtpWebRequest yaratma
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(Servers.ServerAddress + Servers.RemoteFilePath);
                request.Method = WebRequestMethods.Ftp.DownloadFile;
                request.Credentials = new NetworkCredential(Servers.Username, Servers.Password);

                // FtpWebResponse alma
                using (FtpWebResponse response = (FtpWebResponse)request.GetResponse())
                {
                    // Faylın içini oxuma
                    using (Stream stream = response.GetResponseStream())
                    {
                        StreamReader reader = new StreamReader(stream);

                        string fileContents = reader.ReadToEnd();

                        if (fileContents.Contains(tLicenceKey.Text))
                        {
                            lLicenceStatus.Text = EnumsOperation.StatusType.Deactive.GetDescription();
                            lLicenceStatus.ForeColor = Color.FromArgb(192, 0, 0);
                            licenceControl.LicenceStatus = false;
                        }
                        else
                        {
                            lLicenceStatus.Text = EnumsOperation.StatusType.Active.GetDescription();
                            lLicenceStatus.ForeColor = Color.FromArgb(16, 172, 132);
                            licenceControl.LicenceStatus = true;
                        }
                    }
                }
            }
            await db.SaveChangesAsync();
        }

        private void userFooter_Save1_SaveClick(object sender, EventArgs e)
        {
            db.Dispose();
            this.Dispose();
        }
    }
}