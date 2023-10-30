using DevExpress.XtraEditors;
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

namespace İNTEKO.Setting
{
    public partial class fSettings : FormBase
    {
        public fSettings()
        {
            InitializeComponent();
        }

        IntekodbEntities db = new IntekodbEntities();
        public string Operation { get; set; }
        LicenceVersions Licence;
        PaymentType Type;
        Kassalar kassa;
        City _city;
        Area _area;

        private void fSettings_Load(object sender, EventArgs e)
        {
            switch (Operation)
            {
                case "Logs":
                    this.Text = "Arxiv - " + Proccess.Versiya();
                    navigationFrame1.SelectedPage = pageLogs;
                    dateLogStart.DateTime = DateTime.Now.AddDays(-1);
                    dateLogFinish.DateTime = DateTime.Now;
                    gridControlLog.DataSource = db.Logs.AsNoTracking().Select(x => new { x.Users, x.Operation, x.Date, x.Id }).Where(x => x.Date >= dateLogStart.DateTime && x.Date <= dateLogFinish.DateTime).OrderBy(x => x.Id).ToList();
                    break;
                case "Licence":
                    this.Text = "Lisenziya - " + Proccess.Versiya();
                    navigationFrame1.SelectedPage = pageLicence;
                    gridControlLicence.DataSource = db.LicenceVersions.OrderBy(x => x.LicenceVersionNumber).ToList();
                    break;
                case "Kassa":
                    this.Text = "Kassalar - " + Proccess.Versiya();
                    navigationFrame1.SelectedPage = pageKassa;
                    gridControlKassalar.DataSource = db.Kassalar.OrderBy(x => x.Id).ToList();
                    break;
                case "PayType":
                    this.Text = "Ödəniş növləri - " + Proccess.Versiya();
                    navigationFrame1.SelectedPage = pagePayments;
                    gridControlPayment.DataSource = db.PaymentType.OrderBy(x => x.Id).ToList();
                    break;
                case "City":
                    this.Text = "Şəhərlər - " + Proccess.Versiya();
                    navigationFrame1.SelectedPage = pageCity;
                    gridControlCity.DataSource = db.City.OrderBy(x => x.Id).ToList();
                    break;
                case "Area":
                    this.Text = "Rayonlar - " + Proccess.Versiya();
                    navigationFrame1.SelectedPage = pageArea;
                    CityGet();
                    gridControlArea.DataSource = db.Area.OrderBy(x => x.Id).ToList();
                    break;
            }
        }


        #region [...] Logs
        private void bLogsLoad_Click(object sender, EventArgs e)
        {
            var dateSearch = db.Logs.AsNoTracking().Select(x => new { x.Users, x.Operation, x.Date, x.Id }).Where(x => x.Date >= dateLogStart.DateTime && x.Date <= dateLogFinish.DateTime);
            gridControlLog.DataSource = dateSearch.OrderBy(x => x.Id).ToList();
        }
        #endregion [...] Logs


        #region [...] City

        private void chCity_Status_CheckedChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            CheckEdit edit = (CheckEdit)sender;
            if (gridCity.GetFocusedRow() != null)
            {
                _city = (City)gridCity.GetFocusedRow();
                if (_city.Status == true) { _city.Status = (bool)edit.EditValue; }
                else { _city.Status = (bool)edit.EditValue; }
                db.SaveChanges();
                gridCity.RefreshData();
            }
            else { Message("Seçim edilmədi", UserControls.MessageForm.enmType.Warning); }
            Cursor.Current = Cursors.Default;
        }

        private void bCitySave_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tCityName.Text))
            {
                City result = db.City.Where(x => x.CityName == tCityName.Text).FirstOrDefault();
                if (result is null)
                {
                    IntekodbEntities dbCity = new IntekodbEntities();
                    _city = new City();
                    _city.CityName = tCityName.Text.Trim();
                    _city.Status = true;
                    db.City.Add(_city);
                    db.SaveChanges();
                    Message(tCityName.Text + " şəhəri əlavə edildi", UserControls.MessageForm.enmType.Success);
                    Logger.Log(tCityName.Text + " şəhəri yarattı");
                    tCityName.Text = null;
                    gridControlCity.DataSource = dbCity.City.OrderBy(x => x.Id).ToList();
                }
                else { Message(tCityName.Text + " şəhəri sistemdə mövcuddur", UserControls.MessageForm.enmType.Info); return; }
            }
            else { Message("Şəhər adını qeyd etmədiniz !", UserControls.MessageForm.enmType.Warning); return; }
        }
        #endregion


        #region [...] Area
        private void CityGet()
        {
            cmbCity.DataSource = db.City.AsNoTracking().ToList();
            cmbCity.DisplayMember = "CityName";
            cmbCity.ValueMember = "Id";
        }

        private void chAreaStatus_CheckedChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            CheckEdit edit = (CheckEdit)sender;
            if (gridArea.GetFocusedRow() != null)
            {
                _area = (Area)gridArea.GetFocusedRow();
                if (_area.Status == true) { _area.Status = (bool)edit.EditValue; }
                else { _area.Status = (bool)edit.EditValue; }
                db.SaveChanges();
                gridArea.RefreshData();
            }
            else { Message("Seçim edilmədi", UserControls.MessageForm.enmType.Warning); }
            Cursor.Current = Cursors.Default;
        }

        private void bAreaSave_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tArea.Text))
            {
                Area result = db.Area.Where(x => x.AreaName == tArea.Text).FirstOrDefault();
                if (result is null)
                {
                    IntekodbEntities dbArea = new IntekodbEntities();
                    _area = new Area();
                    _area.CityID = (int)cmbCity.SelectedValue;
                    _area.AreaName = tArea.Text.Trim();
                    _area.Status = true;
                    db.Area.Add(_area);
                    db.SaveChanges();
                    Message(tArea.Text + " şəhəri əlavə edildi", UserControls.MessageForm.enmType.Success);
                    Logger.Log(tArea.Text + " şəhəri yarattı");
                    tArea.Text = null;
                    gridControlArea.DataSource = dbArea.Area.OrderBy(x => x.Id).ToList();
                }
                else { Message(tArea.Text + " rayonu sistemdə mövcuddur", UserControls.MessageForm.enmType.Info); return; }
            }
            else { Message("Rayon adını qeyd etmədiniz !", UserControls.MessageForm.enmType.Warning); return; }
        }
        #endregion [...] Area


        #region [...] Licence
        private void chStatus_CheckedChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            var edit = (CheckEdit)sender;
            if (gridLicence.GetFocusedRow() != null)
            {
                Licence = (LicenceVersions)gridLicence.GetFocusedRow();
                if (Licence.Status == true) { Licence.Status = (bool)edit.EditValue; }
                else { Licence.Status = (bool)edit.EditValue; }
                db.SaveChanges();
                gridLicence.RefreshData();
            }
            else { Message("Seçim edilmədi", UserControls.MessageForm.enmType.Warning); }
            Cursor.Current = Cursors.Default;
        }

        private void bLicenceSave_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tLicenceVersionNumber.Text))
            {
                var control = db.LicenceVersions.Where(x => x.LicenceVersionNumber == tLicenceVersionNumber.Text).FirstOrDefault();
                if (control == null)
                {
                    IntekodbEntities dbLicence = new IntekodbEntities();
                    LicenceVersions licence = new LicenceVersions();
                    licence.LicenceVersionNumber = tLicenceVersionNumber.Text.Trim();
                    licence.Status = true;
                    db.LicenceVersions.Add(licence);
                    db.SaveChanges();
                    Message(tLicenceVersionNumber.Text + " versiya nömrəsi əlavə edildi", UserControls.MessageForm.enmType.Success);
                    Logger.Log(tLicenceVersionNumber.Text + " lisenziya versiyasını yarattı");
                    tLicenceVersionNumber.Text = null;
                    gridControlLicence.DataSource = dbLicence.LicenceVersions.OrderBy(x => x.LicenceVersionNumber).ToList();
                }
                else { Message(tLicenceVersionNumber.Text + " versiya nömrəsi sistemdə mövcuddur", UserControls.MessageForm.enmType.Info); return; }
            }
            else { Message("Versiya nömrəsini qeyd etmədiniz !", UserControls.MessageForm.enmType.Warning); return; }
        }
        #endregion [...] Licence


        #region [...] PaymentType
        private void bPaySave_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tPayName.Text))
            {
                var control = db.PaymentType.Where(x => x.PaymentName == tPayName.Text).FirstOrDefault();
                if (control == null)
                {
                    IntekodbEntities dbPay = new IntekodbEntities();
                    PaymentType type = new PaymentType();
                    type.PaymentName = tPayName.Text.Trim();
                    type.Status = true;
                    db.PaymentType.Add(type);
                    db.SaveChanges();
                    Message(tPayName.Text + " ödəniş növü əlavə edildi", UserControls.MessageForm.enmType.Success);
                    Logger.Log(tPayName.Text + " ödəniş növünü yarattı");
                    tPayName.Text = null;
                    gridControlPayment.DataSource = dbPay.PaymentType.OrderBy(x => x.Id).ToList();
                }
                else { Message(tPayName.Text + " ödəniş növü sistemdə mövcuddur", UserControls.MessageForm.enmType.Info); return; }
            }
            else { Message("Ödəniş növünü qeyd etmədiniz !", UserControls.MessageForm.enmType.Warning); return; }
        }

        private void chPayStatus_CheckedChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            var edit = (CheckEdit)sender;
            if (gridPayment.GetFocusedRow() != null)
            {
                Type = (PaymentType)gridPayment.GetFocusedRow();
                if (Type.Status == true) { Type.Status = (bool)edit.EditValue; }
                else { Type.Status = (bool)edit.EditValue; }
                db.SaveChanges();
                gridPayment.RefreshData();
            }
            else { Message("Seçim edilmədi", UserControls.MessageForm.enmType.Warning); }
            Cursor.Current = Cursors.Default;
        }
        #endregion [...] PaymentType


        #region [...] Kassa
        private void bKassaSave_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tKassaName.Text))
            {
                var control = db.Kassalar.Where(x => x.Name == tKassaName.Text).FirstOrDefault();
                if (control == null)
                {
                    IntekodbEntities dbKassa = new IntekodbEntities();
                    Kassalar kassa = new Kassalar();
                    kassa.Name = tKassaName.Text.Trim();
                    kassa.Status = true;
                    db.Kassalar.Add(kassa);
                    db.SaveChanges();
                    Message(tKassaName.Text + " kassası əlavə edildi", UserControls.MessageForm.enmType.Success);
                    Logger.Log(tKassaName.Text + " kassa növünü yarattı");
                    tKassaName.Text = null;
                    gridControlKassalar.DataSource = dbKassa.Kassalar.OrderBy(x => x.Id).ToList();
                }
                else { Message(tKassaName.Text + " kassası sistemdə mövcuddur", UserControls.MessageForm.enmType.Info); return; }
            }
            else { Message("Kassa adını qeyd etmədiniz !", UserControls.MessageForm.enmType.Warning); return; }
        }

        private void chKassaStatus_CheckedChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            var edit = (CheckEdit)sender;
            if (gridKassalar.GetFocusedRow() != null)
            {
                kassa = (Kassalar)gridKassalar.GetFocusedRow();
                if (kassa.Status == true) { kassa.Status = (bool)edit.EditValue; }
                else { kassa.Status = (bool)edit.EditValue; }
                db.SaveChanges();
                gridKassalar.RefreshData();
            }
            else { Message("Seçim edilmədi", UserControls.MessageForm.enmType.Warning); }
            Cursor.Current = Cursors.Default;
        }
        #endregion [...] Kassa
    }
}