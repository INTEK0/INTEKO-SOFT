using DevExpress.XtraEditors;
using ExcelDataReader;
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
using Z.Dapper.Plus;

namespace İNTEKO
{
    public partial class fExcel : FormBase
    {
        IntekodbEntities db = new IntekodbEntities();
        public string Operation { get; set; }

        public fExcel()
        {
            InitializeComponent();
        }
        DataTableCollection tableCollection;

        private void bBrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog() { Filter = "Excel 97-2003 faylı |*.xls|Excel faylı |*.xlsx", FilterIndex = 2, Title = "İmport ediləcək excel faylını seçin" })
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    tFilePath.Text = openFileDialog.FileName;
                    using (var stream = File.Open(openFileDialog.FileName, FileMode.Open, FileAccess.Read))
                    {
                        using (IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream))
                        {
                            DataSet result = reader.AsDataSet(new ExcelDataSetConfiguration()
                            {
                                ConfigureDataTable = (_) => new ExcelDataTableConfiguration() { UseHeaderRow = true }
                            });
                            tableCollection = result.Tables;
                            cmbSheet.Items.Clear();
                            foreach (DataTable table in tableCollection)
                                cmbSheet.Items.Add(table.TableName);
                        }
                    }
                }
            }
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            using (var db = new IntekodbEntities())
            {
                if (!String.IsNullOrEmpty(cmbSheet.Text))
                {
                    try
                    {
                        Cursor.Current = Cursors.WaitCursor;
                        if (Operation == "Payments")
                        {
                            DapperPlusManager.Entity<Payments>().Table("Payments");
                            List<Payments> payments = gridControlExcelData.DataSource as List<Payments>;
                            if (payments != null)
                            {
                                using (IDbConnection db2 = new SqlConnection(db.Database.Connection.ConnectionString))
                                {
                                    db2.BulkInsert(payments);
                                }
                            }
                            Message("Ödənişlər sistemə əlavə edildi", UserControls.MessageForm.enmType.Success);
                            DialogResult = DialogResult.OK;
                            Close();
                        }
                        else if (Operation == "Customers")
                        {
                            DapperPlusManager.Entity<Customers>().Table("Customers");
                            List<Customers> customers = gridControlExcelData.DataSource as List<Customers>;
                            if (customers != null)
                            {
                                using (IDbConnection db2 = new SqlConnection(db.Database.Connection.ConnectionString))
                                {
                                    db2.BulkInsert(customers);
                                }
                            }
                            Message("Müştərilər sistemə əlavə edildi", UserControls.MessageForm.enmType.Success);
                            Cursor.Current = Cursors.Default;
                            Close();
                        }
                        else if (Operation == "History")
                        {
                            DapperPlusManager.Entity<Customers>().Table("History");
                            List<PaymentHistory> histories = gridControlExcelData.DataSource as List<PaymentHistory>;
                            if (histories != null)
                            {
                                using (IDbConnection db2 = new SqlConnection(db.Database.Connection.ConnectionString))
                                {
                                    db2.BulkInsert(histories);
                                }
                            }
                            Message("Ödəniş keçmişi sistemə əlavə edildi", UserControls.MessageForm.enmType.Success);
                            Cursor.Current = Cursors.Default;
                            Close();
                        }
                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message); }
                }
                else { Message("Seçim edin", UserControls.MessageForm.enmType.Warning); }
            }
        }

        private void cmbSheet_SelectedValueChanged(object sender, EventArgs e)
        {
            DataTable dt = tableCollection[cmbSheet.SelectedItem.ToString()];

            switch (Operation)
            {
                case "Payments":
                    if (dt != null)
                    {
                        List<Payments> payments = new List<Payments>();
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            var voen = dt.Rows[i]["VÖEN"].ToString();
                            var payType = dt.Rows[i]["ÖDƏNİŞ NÖVÜ"].ToString();

                            var typeControl = db.PaymentType.Where(x => x.PaymentName == payType).FirstOrDefault();
                            var voencontrol = db.Customers.Where(x => x.Voen == voen).FirstOrDefault();

                            Payments payment = new Payments();
                            if (voencontrol != null)
                            {
                                payment.CustomerID = voencontrol.Id;
                                payment.QaimeNo = dt.Rows[i]["QAİMƏ NÖMRƏSİ"].ToString();
                                payment.Voen = voencontrol.Voen;
                                payment.OdeyiciAdi = voencontrol.NameSurname;
                                payment.OdenecekMebleg = Convert.ToDouble(dt.Rows[i]["ÖDƏNİŞ MƏBLƏĞİ"]);
                                payment.PaymentTypeID = typeControl.Id;
                                payment.OdenenMebleg = Convert.ToDouble(dt.Rows[i]["ÖDƏNƏN MƏBLƏĞ"]);
                                payment.Date = Convert.ToDateTime(dt.Rows[i]["QAİMƏ TARİXİ"]);
                                payment.PayDate = DateTime.Now;

                                double qaliq = Convert.ToDouble(dt.Rows[i]["ÖDƏNİŞ MƏBLƏĞİ"]) - Convert.ToDouble(dt.Rows[i]["ÖDƏNƏN MƏBLƏĞ"]);
                                if (qaliq <= 0)
                                {
                                    payment.Qaliq = 0;
                                    payment.Avans = qaliq * -1;
                                    payment.Status = true;
                                }
                                else if (qaliq > 0)
                                {
                                    payment.Qaliq = qaliq;
                                    payment.Status = false;
                                    payment.Avans = 0;
                                }
                                payment.Comment = null;
                                payment.UserID = Properties.Settings.Default.UserID;
                                payments.Add(payment);
                            }
                        }
                        gridControlExcelData.DataSource = payments;
                    }
                    break;
                case "Customers":
                    if (dt != null)
                    {
                        List<Customers> customers = new List<Customers>();
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            //Şəhər
                            var CityName = dt.Rows[i]["ŞƏHƏR"].ToString();
                            var city = db.City.Where(x => x.CityName == CityName).FirstOrDefault();
                            //Rayon
                            var AreaName = dt.Rows[i]["RAYON"].ToString();
                            var area = db.Area.Where(x => x.AreaName == AreaName).FirstOrDefault();
                            //Customer Status
                            var customerStatus = Convert.ToBoolean(dt.Rows[i]["STATUS"]);
                            ////Lisenziya statusu
                            //var licenceStatus = Convert.ToBoolean(dt.Rows[i]["LİSENZİYA STATUS"]);
                            //Kassa Model
                            var KassaName = dt.Rows[i]["KASSA"].ToString();
                            var kassa = db.Kassalar.Where(x => x.Name == KassaName).FirstOrDefault();
                            //Ödəniş növü
                            var PaymentName = dt.Rows[i]["ÖDƏNİŞ NÖVÜ"].ToString();
                            var paymentType = db.PaymentType.Where(x => x.PaymentName == PaymentName).FirstOrDefault();
                            //Mpos Version
                            var mposVersion = Convert.ToBoolean(dt.Rows[i]["MPOS VERSİYA"]);

                            Customers customer = new Customers();
                            customer.ContractNo = dt.Rows[i]["MÜQAVİLƏ №"].ToString();
                            customer.NameSurname = dt.Rows[i]["AD SOYAD"].ToString();
                            customer.CompanyName = dt.Rows[i]["OBYEKT ADI"].ToString();
                            customer.Voen = dt.Rows[i]["VÖEN"].ToString();
                            customer.CompanyCode = dt.Rows[i]["OBYEKT KODU"].ToString();
                            customer.Phone = dt.Rows[i]["TELEFON"].ToString();
                            customer.CityID = city.Id;
                            customer.AreaID = area.Id;
                            customer.Address = dt.Rows[i]["ÜNVAN"].ToString();
                            customer.Registration_Date = Convert.ToDateTime(dt.Rows[i]["QEYDİYYAT TARİXİ"]);
                            customer.SalesMan = dt.Rows[i]["SATAN İŞÇİ"].ToString();
                            customer.Status = customerStatus;
                            customer.LicenceID = Guid.Parse(dt.Rows[i]["LİSENZİYA AÇARI"].ToString());
                            customer.LicenceVersion = dt.Rows[i]["LİSENZİYA VERSİYA"].ToString();
                            customer.LicenceRegister = Convert.ToDateTime(dt.Rows[i]["LİSENZİYA QEYDİYYAT TARİXİ"]);
                            //customer.LicenceStatus = licenceStatus;
                            customer.Kassa_Model = kassa.Id;
                            customer.KassaSerialNumber = dt.Rows[i]["KASSA S/N"].ToString();
                            customer.KassaVersionNumber = dt.Rows[i]["KASSA V/N"].ToString();
                            customer.PaymentTypeID = paymentType.Id;
                            customer.RegistrationPrice = Convert.ToDouble(dt.Rows[i]["YAZILMA QİYMƏTİ"]);
                            customer.ServicePrice = Convert.ToDouble(dt.Rows[i]["SERVİS QİYMƏTİ"]);
                            customer.MposVersion = mposVersion;

                            customer.UserID = Properties.Settings.Default.UserID;
                            customer.LogDate = DateTime.Now;
                            customers.Add(customer);
                        }
                        gridControlExcelData.DataSource = customers;
                    }
                    break;
                case "History":
                    if (dt != null)
                    {
                        List<PaymentHistory> histories = new List<PaymentHistory>();
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            var voen = dt.Rows[i]["VÖEN"].ToString();
                            var payType = dt.Rows[i]["ÖDƏNİŞ NÖVÜ"].ToString();

                            var typeControl = db.PaymentType.Where(x => x.PaymentName == payType).FirstOrDefault();
                            var voencontrol = db.Customers.Where(x => x.Voen == voen).FirstOrDefault();
                            var payments = db.Payments.Where(x => x.Voen == voen).FirstOrDefault();

                            PaymentHistory paymentHistory = new PaymentHistory();
                            paymentHistory.CustomerID = voencontrol.Id;
                            paymentHistory.PaymentTypeID = typeControl.Id;
                            paymentHistory.Date = Convert.ToDateTime(dt.Rows[i]["DATE"]);
                            paymentHistory.PaymentTotal = Convert.ToDouble(dt.Rows[i]["ÖDƏNƏCƏK"]);
                            paymentHistory.PaymentPaid = Convert.ToDouble(dt.Rows[i]["ÖDƏNƏN"]);
                            paymentHistory.PaymentID = payments.Id;
                            histories.Add(paymentHistory);
                        }
                        gridControlExcelData.DataSource = histories;
                    }
                    break;
            }
        }

        private void fExcel_Load(object sender, EventArgs e)
        {
            this.Text = Proccess.Versiya();
        }
    }
}