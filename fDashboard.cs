using DevExpress.Export;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraPrinting;
using İNTEKO.Bonnus;
using İNTEKO.Comments;
using İNTEKO.Definitions;
using İNTEKO.DetailForm;
using İNTEKO.Enums;
using İNTEKO.Helpers;
using İNTEKO.Helpers.GridDataSource;
using İNTEKO.NewCustomer;
using İNTEKO.Pay;
using İNTEKO.Setting;
using İNTEKO.Tools;
using İNTEKO.User;
using OfficeOpenXml;
using OfficeOpenXml.Table;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using static İNTEKO.Enums.EnumsOperation;

namespace İNTEKO
{
    public partial class fDashboard : FormBase
    {
        IntekodbEntities Intekodb = new IntekodbEntities();
        public fDashboard()
        {
            InitializeComponent();
            //GridLocalizer.Active = new MyGridLocalizer();
        }

        private void officeNavigationBar1_ItemClick(object sender, DevExpress.XtraBars.Navigation.NavigationBarItemEventArgs e)
        {
            if (officeNavigationBar1.SelectedItem == bCustomers) { navigationFrame1.SelectedPage = pageCustomers; }
            else if (officeNavigationBar1.SelectedItem == bSendPayment) { navigationFrame1.SelectedPage = pageSendOverhead; }
            else if (officeNavigationBar1.SelectedItem == bCashPayment) { navigationFrame1.SelectedPage = pageCashPayment; /*Doldur(dateStart.DateTime, dateFinish.DateTime);*/}
            else if (officeNavigationBar1.SelectedItem == bSettings) { navigationFrame1.SelectedPage = pageSettings; }
            else if (officeNavigationBar1.SelectedItem == bUsers) { navigationFrame1.SelectedPage = pageUsers; }
            else if (officeNavigationBar1.SelectedItem == bBonus) { navigationFrame1.SelectedPage = pageBonus; }
            else if (officeNavigationBar1.SelectedItem == bSSS) { navigationFrame1.SelectedPage = pageComment; }
        }

        private void navigationFrame1_SelectedPageChanged(object sender, DevExpress.XtraBars.Navigation.SelectedPageChangedEventArgs e)
        {
            switch (e.Page.Caption)
            {
                case "pageCustomers": /*CustomerGridFill();*/ break;
                case "pageSendOverhead":
                    datePStart.EditValue = DateTime.Now.ToString("dd.MM.yyyy");
                    datePFinish.EditValue = DateTime.Now.ToString("dd.MM.yyyy");
                    PaymentsGridFill();
                    break;
                case "pageCashPayment":
                    ExpensesTotal();
                    dateEStart.EditValue = DateTime.Now;
                    dateEFinish.EditValue = DateTime.Now;
                    break;
                case "pageBonus":
                    BonusGridFill();
                    dateBStart.EditValue = DateTime.Now;
                    dateBFinish.EditValue = DateTime.Now;
                    break;
                case "pageUsers": userGridFill(); break;
                case "pageComment": SSSLoad(); break;
            }
        }

        private void fDashboard_Load(object sender, EventArgs e)
        {
            CustomerGridFill();
            lBonusOdenilen.Click += TotalBonusOdenilen_Click;
            lBonusBorc.Click += TotalBonusBorc_Click;
            lVersion.Text = Proccess.Versiya();
        }


        #region Müştərilər

        Customers Musteriler;

        private void tLicenceSearch_EditValueChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tLicenceSearch.Text))
                gridCustomers.ActiveFilterString = $"Contains([LicenceID], '{tLicenceSearch.Text}')";
            else
                gridCustomers.ActiveFilter.Clear();
        }

        private void tLicenceSearch_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tLicenceSearch.Text))
                gridCustomers.ActiveFilterString = $"Contains([LicenceID], '{tLicenceSearch.Text}')";
        }

        private void GridCustomerColumnsVisibleSort(bool value)
        {
            if (value)
            {
                colCustomerNo.VisibleIndex = 0;
                colCustStatus.VisibleIndex = 1;
                colCustContractNo.VisibleIndex = 2;
                colCustName.VisibleIndex = 3;
                colCustCompany.VisibleIndex = 4;
                colCustVoen.VisibleIndex = 5;
                colCompanyCode.VisibleIndex = 6;
                colCustPhone.VisibleIndex = 7;
                colCity.VisibleIndex = 8;
                colRegion.VisibleIndex = 9;
                colCustAddress.VisibleIndex = 10;
                colCustRegistrationDate.VisibleIndex = 11;
                colSalesMan.VisibleIndex = 12;
                colLicenceStatus.VisibleIndex = 13;
                colLicenceKey.VisibleIndex = 14;
                colLicenceVersion.VisibleIndex = 15;
                colLicenceRegister.VisibleIndex = 16;
                colCustKassaModel.VisibleIndex = 17;
                colKassaSerialNumber.VisibleIndex = 18;
                colKassaVersionNumber.VisibleIndex = 19;
                colCustPaymentType.VisibleIndex = 20;
                colCustRegPrice.VisibleIndex = 21;
                colCustServicePrice.VisibleIndex = 22;
                coMposVersion.VisibleIndex = 23;
                colCustomerNo.Visible = false;
            }
            else
            {
                gridCustomers.Columns["CompanyCode"].Visible = false;
                gridCustomers.Columns["CustomerNo"].Visible = true;
                gridCustomers.Columns["City.CityName"].Visible = false;
                gridCustomers.Columns["Area.AreaName"].Visible = false;
                gridCustomers.Columns["SalesMan"].Visible = false;
                gridCustomers.Columns["KassaSerialNumber"].Visible = false;
                gridCustomers.Columns["KassaVersionNumber"].Visible = false;
                gridCustomers.Columns["LicenceID"].Visible = false;
                gridCustomers.Columns["LicenceRegister"].Visible = false;
                gridCustomers.Columns["LicenceVersion"].Visible = false;
                gridCustomers.Columns["MposVersion"].Visible = false;
            }
        }

        private async void CustomerGridFill()
        {
            gridCustomers.ActiveFilter.Clear();
            try
            {
                await Task.Run(() =>
                {
                    Cursor.Current = Cursors.WaitCursor;
                    if (Intekodb.Customers.Any())
                    {
                        var data = Intekodb.Customers.Select(x => new
                        {
                            x.Id,
                            x.ContractNo,
                            x.NameSurname,
                            x.CompanyName,
                            x.Voen,
                            Status = x.Status.Value ? "Aktiv" : "Deaktiv",
                            x.CompanyCode,
                            x.Phone,
                            //x.City,
                            //x.Area,
                            x.Address,
                            x.Registration_Date,
                            //x.SalesMan,
                            x.LicenceID,
                            //x.LicenceVersion,
                            //x.LicenceRegister,
                            x.Kassalar,
                            //x.Kassa_Model,
                            //x.KassaSerialNumber,
                            //x.KassaVersionNumber,
                            x.PaymentType,
                            //x.PaymentTypeID,
                            x.RegistrationPrice,
                            x.ServicePrice,
                            LisenziyaStatusu = x.LicenceStatus.Value ? "Aktiv" : "Deaktiv",
                            MposVersion = x.MposVersion.Value ? "Yeni" : "Köhnə",
                            //x.PaymentHistory,
                            //x.LicenceHistory,
                            //x.Tarifler
                        }).OrderBy(x => x.Id).ToList();
                        this.Invoke((MethodInvoker)delegate
                        {
                            FormHelpers.ControlLoad(data, gridControlCustomers);

                            lActiveCustomerCount.Text = Intekodb.Customers.Count(x => x.Status == true).ToString();
                            lDeactiveCustomerCount.Text = Intekodb.Customers.Count(x => x.Status == false).ToString();
                            lTotalCustomerCount.Text = Intekodb.Customers.Count().ToString();

                            var ayliqQazanc = Intekodb.Customers.Where(x => x.Status == true).Sum(x => x.ServicePrice);

                            lAyliqQazanc.Text = (ayliqQazanc != null) ? ayliqQazanc.Value.ToString("C2") : DefaultConstants.DEFAULT_CURRENCY_STRING;
                        });

                    }
                    else
                    {
                        this.Invoke((MethodInvoker)delegate
                        {
                            lActiveCustomerCount.Text = DefaultConstants.DEFAULT_COUNT_STRING;
                            lDeactiveCustomerCount.Text = DefaultConstants.DEFAULT_COUNT_STRING;
                            lTotalCustomerCount.Text = DefaultConstants.DEFAULT_COUNT_STRING;
                            lAyliqQazanc.Text = DefaultConstants.DEFAULT_CURRENCY_STRING;
                        });
                    }
                    Cursor.Current = Cursors.Default;
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "CustomerLoadError", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        private void gridCustomers_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            e.Info.ImageIndex = -1;
            if (e.RowHandle >= 0) { e.Info.DisplayText = e.RowHandle.ToString(); }
        }

        private void bCustomerLoad_Click(object sender, EventArgs e)
        {
            CustomerGridFill();
        }

        private void gridCustomers_DoubleClick(object sender, EventArgs e)
        {
            if (gridCustomers.GetFocusedRow() is null) { Message(AutoMessage.NoSelection, UserControls.MessageForm.enmType.Info); return; }

            int id = Convert.ToInt32(gridCustomers.GetFocusedRowCellValue("Id").ToString());
            Customers look = Intekodb.Customers.FirstOrDefault(x => x.Id == id);
            fDetail f = new fDetail(look);
            if (f.ShowDialog() is DialogResult.OK)
                CustomerGridFill();
        }

        private void barCustomerExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Message("Funksiya müvəqqəti olaraq deaktiv edilib", UserControls.MessageForm.enmType.Info);
            //if (gridCustomers.RowCount == 0) return;
            //SaveFileDialog save = new SaveFileDialog();
            //save.Filter = "Excel faylı|*.xlsx";
            //save.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            //save.OverwritePrompt = true; //varsa soruşmadan üstünə yazması üçün false olaraq qalmalıdır
            //save.FileName = "Müştəri siyahısı" + "_" + DateTime.Now.ToShortDateString() + ".xlsx";
            //if (save.ShowDialog() == DialogResult.OK)
            //    gridCustomers.ExportToXlsx(save.FileName);
        }

        private void bCustomerExport_Click(object sender, EventArgs e)
        {
            if (gridCustomers.RowCount == 0) { Message(AutoMessage.NotFoundData, UserControls.MessageForm.enmType.Info); return; }

            GridCustomerColumnsVisibleSort(true);

            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Excel faylı|*.xlsx";
            save.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            save.OverwritePrompt = true; //varsa soruşmadan üstünə yazması üçün false olaraq qalmalıdır
            save.FileName = "Müştəri siyahısı" + "_" + DateTime.Now.ToShortDateString() + ".xlsx";
            if (save.ShowDialog() == DialogResult.OK)
            {
                GridViewDataSource.CusromerFullData(gridControlCustomers);
                string fileName = save.FileName;
                gridCustomers.ExportToXlsx(fileName, new XlsxExportOptionsEx
                {
                    ExportType = ExportType.WYSIWYG
                });
            }
            GridCustomerColumnsVisibleSort(false);
        }

        private void bNewCustomers_Click(object sender, EventArgs e)
        {
            fNewCustomer f = new fNewCustomer(Operation.Add);
            if (f.ShowDialog() == DialogResult.OK)
                CustomerGridFill();
        }

        private void ətraflıBaxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (gridCustomers.GetFocusedRow() is null)
            {
                Message(AutoMessage.NoSelection, UserControls.MessageForm.enmType.Warning);
                return;
            }
            short id = Convert.ToInt16(gridCustomers.GetFocusedRowCellValue("Id").ToString());
            Customers look = Intekodb.Customers.FirstOrDefault(x => x.Id == id);
            fDetail f = new fDetail(look);
            if (f.ShowDialog() is DialogResult.OK)
                CustomerGridFill();
        }

        private void toogleCustomerStatus_CheckedChanged(object sender, EventArgs e)
        {
            var edit = (CheckEdit)sender;
            if (gridCustomers.GetFocusedRow() != null)
            {
                Musteriler = (Customers)gridCustomers.GetFocusedRow();
                if (Musteriler.Status is true) { Musteriler.Status = (bool)edit.EditValue; }
                else { Musteriler.Status = (bool)edit.EditValue; }
                Intekodb.SaveChanges();
                gridCustomers.RefreshData();
            }
            else { Message(AutoMessage.NoSelection, UserControls.MessageForm.enmType.Warning); }
        }

        /// <summary>
        /// Gridin status sütunlarına gələn Aktiv yaxud Deaktiv yazısının rəngini Yaşıl və Qırmızı rəngə çevirir.
        /// </summary>
        private void gridCustomers_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            FormHelpers.GridViewStatusDisplayColor(colCustStatus,
                EnumsOperation.StatusType.Active.GetDescription(),
                EnumsOperation.StatusType.Deactive.GetDescription(),
                e, gridCustomers);

            FormHelpers.GridViewStatusDisplayColor(colLicenceStatus,
                EnumsOperation.StatusType.Active.GetDescription(),
                EnumsOperation.StatusType.Deactive.GetDescription(),
                e, gridCustomers);
        }

        private void bCustomerStatus_Click(object sender, EventArgs e)
        {
            //Seçili istifadəçinin statusunun dəyiştirilməsi
            if (gridCustomers.GetFocusedRow() is null)
            {
                Message(AutoMessage.NoSelection, UserControls.MessageForm.enmType.Warning);
                return;
            }
            else
            {
                short CustomerID = short.Parse(gridCustomers.GetFocusedRowCellValue("Id").ToString());
                var control = Intekodb.Customers.FirstOrDefault(x => x.Id == CustomerID);

                control.Status = ((bool)control.Status) ? false : true;

                Intekodb.SaveChanges();
                if (control.Status == false) { Logger.Log(control.NameSurname + " müştərisinin statusunu aktiv etdi"); }
                else { Logger.Log(control.NameSurname + " müştərisinin statusunu deaktiv etdi"); }
                CustomerGridFill();
            }
        }

        private void PassiveCustomerShow(object sender, EventArgs e)
        {
            FormHelpers.GridViewContainsLoad("Status", "Deaktiv", gridCustomers);
        }

        private void ActiveCustomerShow(object sender, EventArgs e)
        {
            FormHelpers.GridViewContainsLoad("Status", "Aktiv", gridCustomers);
        }

        private void TotalCustomerShow(object sender, EventArgs e)
        {
            gridCustomers.ActiveFilter.Clear();
        }

        private void gridCustomers_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (e.Column.FieldName is "CustomerNo")
            {
                if (e.RowHandle >= 0)
                    e.DisplayText = (e.RowHandle + 1).ToString();
            }
        }

        private void bCustomerEdit_Click(object sender, EventArgs e)
        {
            if (gridCustomers.GetFocusedRow() is null)
            {
                Message(AutoMessage.NoSelection, UserControls.MessageForm.enmType.Warning);
                return;
            }
            var db = new IntekodbEntities();
            int GridID = Convert.ToInt32(gridCustomers.GetFocusedRowCellValue("Id").ToString());
            var CustomerID = db.Customers.FirstOrDefault(x => x.Id == GridID);

            fNewCustomer customer = new fNewCustomer(Operation.Edit);
            customer.Customer = CustomerID;
            if (customer.ShowDialog() == DialogResult.OK)
                CustomerGridFill();
        }

        private void bCustomerImport_Click(object sender, EventArgs e)
        {
            fExcel f = new fExcel();
            f.Operation = "Customers";
            f.ShowDialog();
            CustomerGridFill();
        }

        #endregion



        #region Xərclər

        private void lXercOdenilen_Click(object sender, EventArgs e)
        {
            FormHelpers.GridViewContainsLoad("Status", StatusType.Paid.GetDescription(), gridExpenses);
        }

        private void lXercBorc_Click(object sender, EventArgs e)
        {
            FormHelpers.GridViewContainsLoad("Status", StatusType.NotPaid.GetDescription(), gridExpenses);
        }

        private void baddExpenses_Click(object sender, EventArgs e)
        {
            fExpenses f = new fExpenses(Operation.Add);
            if (f.ShowDialog() == DialogResult.OK)
                ExpensesTotal();
        }

        private void gridExpenses_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            e.Info.ImageIndex = -1;
            if (e.RowHandle >= 0)
                e.Info.DisplayText = e.RowHandle.ToString();
        }

        private void ExpensesTotal()
        {
            if (Intekodb.Expenses.Any())
            {
                var data = Intekodb.Expenses.AsNoTracking().
                    Select(x => new
                    {
                        x.Id,
                        x.ExNo,
                        x.Comment,
                        x.Date,
                        x.Header,
                        x.LogDate,
                        x.PaymentType,
                        x.TotalPaid,
                        x.Users,
                        Status = x.Status.Value ? StatusType.Paid.GetDescription() : StatusType.NotPaid.GetDescription(),
                        x.Category
                    }).
                    OrderByDescending(x => x.Id).ToList();

                FormHelpers.ControlLoad(data, gridControlExpenses);

                var borc = Intekodb.Expenses.Where(x => x.Status == false).Sum(x => x.TotalPaid);
                var odenilen = Intekodb.Expenses.Where(x => x.Status == true).Sum(x => x.TotalPaid);

                lXercBorc.Text = (borc == null) ? DefaultConstants.DEFAULT_CURRENCY_STRING : borc.Value.ToString("C2");
                lXercOdenilen.Text = (odenilen == null) ? DefaultConstants.DEFAULT_CURRENCY_STRING : odenilen.Value.ToString("C2");

                gridExpenses.RefreshData();
            }
        }

        private void bExpensesLoad_Click(object sender, EventArgs e)
        {
            if (Intekodb.Expenses.Any())
            {
                gridExpenses.ActiveFilter.Clear();
                var dateSearch = Intekodb.Expenses.Where(x => x.Date >= dateEStart.DateTime && x.Date <= dateEFinish.DateTime);
                gridControlExpenses.DataSource = dateSearch.OrderByDescending(x => x.Id).ToList();
                var borc = dateSearch.Where(x => x.Status == false).Sum(x => x.TotalPaid);
                var odenilen = dateSearch.Where(x => x.Status == true).Sum(x => x.TotalPaid);
                if (borc is null)
                    lXercBorc.Text = DefaultConstants.DEFAULT_CURRENCY_STRING;
                else
                    lXercBorc.Text = borc.Value.ToString("C2");

                if (odenilen is null)
                    lXercOdenilen.Text = DefaultConstants.DEFAULT_CURRENCY_STRING;
                else
                    lXercOdenilen.Text = odenilen.Value.ToString("C2");

                gridExpenses.RefreshData();
            }
        }

        private void bExpensesExport_Click(object sender, EventArgs e)
        {
            if (gridExpenses.RowCount is 0) return;
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Excel faylı|*.xlsx";
            save.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            save.OverwritePrompt = true; //varsa soruşmadan üstünə yazması üçün false olaraq qalmalıdır
            save.FileName = "Xərclər" + "_" + DateTime.Now.ToShortDateString() + ".xlsx";
            if (save.ShowDialog() is DialogResult.OK)
                gridExpenses.ExportToXlsx(save.FileName);
        }

        private void gridExpenses_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (e.Column.FieldName is "ENo")
            {
                if (e.RowHandle >= 0)
                {
                    e.DisplayText = (e.RowHandle + 1).ToString();
                }
            }
        }

        private void gridExpenses_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            FormHelpers.GridViewStatusDisplayColor(colExpensesStatus, "Ödənilib", "Ödənilməyib", e, gridExpenses);
        }

        private void gridExpenses_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {

        }

        private void gridExpenses_DoubleClick(object sender, EventArgs e)
        {
            fExpenses expenses;
            if (gridExpenses.GetFocusedRow() == null)
            {
                Message(AutoMessage.NoSelection, UserControls.MessageForm.enmType.Info);
                return;
            }

            short id = Convert.ToInt16(gridExpenses.GetFocusedRowCellValue("Id").ToString());
            Expenses look = Intekodb.Expenses.FirstOrDefault(x => x.Id == id);
            if (look.Status == true)
            {
                expenses = new fExpenses(Operation.Show);
                expenses.expensesID = look.Id;
                if (expenses.ShowDialog() == DialogResult.OK)
                    ExpensesTotal();
            }
            else
            {
                expenses = new fExpenses(Operation.Payment);
                expenses.expensesID = look.Id;
                if (expenses.ShowDialog() == DialogResult.OK)
                    ExpensesTotal();
            }
        }

        private void XercMenuStrip_Edit_Click(object sender, EventArgs e)
        {
            int GridID = Convert.ToInt32(gridExpenses.GetFocusedRowCellValue("Id").ToString());
            var ExtID = Intekodb.Expenses.FirstOrDefault(x => x.Id == GridID);

            fExpenses ex = new fExpenses(Operation.Edit);
            ex.expensesID = GridID;
            if (ex.ShowDialog() == DialogResult.OK)
                ExpensesTotal();
        }

        #endregion



        #region Bonus

        private void bNewBonus_Click(object sender, EventArgs e)
        {
            fNewBonus bonus = new fNewBonus(Operation.Add);
            bonus.ShowDialog();
            BonusGridFill();
        }

        public void BonusGridFill()
        {
            if (Intekodb.Bonus.Any())
            {
                var data = Intekodb.Bonus.Select(x => new
                {
                    x.Id,
                    x.CustomerNameSurname,
                    x.CompanyName,
                    x.Voen,
                    x.Installer,
                    x.ProccessType,
                    x.Date,
                    x.Payment_Amount,
                    x.PaymentPaid,
                    Status =  x.Status.Value ? StatusType.Paid.GetDescription() : StatusType.NotPaid.GetDescription(),
                    x.Comment,
                    x.Users
                }).OrderBy(x => x.Id).ToList();

                FormHelpers.ControlLoad(data, gridControlBonus);

                var borc = Intekodb.Bonus.Where(x => x.Status == false).Sum(x => x.Payment_Amount);
                var odenilen = Intekodb.Bonus.Where(x => x.Status == true).Sum(x => x.PaymentPaid);
                if (borc == null)
                    lBonusBorc.Text = DefaultConstants.DEFAULT_CURRENCY_STRING;
                else
                    lBonusBorc.Text = borc.Value.ToString("C2");
                if (odenilen == null)
                    lBonusOdenilen.Text = DefaultConstants.DEFAULT_CURRENCY_STRING;
                else
                    lBonusOdenilen.Text = odenilen.Value.ToString("C2");
            }
            gridBonus.RefreshData();
        }

        private void TotalBonusOdenilen_Click(object sender, EventArgs e)
        {
            FormHelpers.GridViewContainsLoad("Status", StatusType.Paid.GetDescription(), gridBonus);
        }

        private void TotalBonusBorc_Click(object sender, EventArgs e)
        {
            FormHelpers.GridViewContainsLoad("Status", StatusType.NotPaid.GetDescription(), gridBonus);
        }

        private void gridBonus_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            FormHelpers.GridViewStatusDisplayColor(colBStatus, StatusType.Paid.GetDescription(), StatusType.NotPaid.GetDescription(), e, gridBonus);
        }

        private void gridBonus_DoubleClick(object sender, EventArgs e)
        {
            fNewBonus bonus;
            var db = new IntekodbEntities();
            if (gridBonus.GetFocusedRow() is null)
            {
                Message(AutoMessage.NoSelection, UserControls.MessageForm.enmType.Info);
                return;
            }

            int id = Convert.ToInt32(gridBonus.GetFocusedRowCellValue("Id").ToString());
            Bonus look = db.Bonus.FirstOrDefault(x => x.Id == id);
            if (look.Status == true)
            {
                bonus = new fNewBonus(Operation.Show);
                bonus.BonusID = look.Id;
                bonus.ShowDialog();
            }
            else
            {
                bonus = new fNewBonus(Operation.Payment);
                bonus.BonusID = look.Id;
                bonus.ShowDialog();
            }
            BonusGridFill();
            gridBonus.RefreshData();
        }

        private void bBonusLoad_Click(object sender, EventArgs e)
        {
            BonusGridFill();
            if (Intekodb.Bonus.Any())
            {
                var dateSearch = Intekodb.Bonus.Where(x => x.Date >= dateBStart.DateTime && x.Date <= dateBFinish.DateTime);
                gridControlBonus.DataSource = dateSearch.OrderByDescending(x => x.Id).ToList();
                var borc = dateSearch.Where(x => x.Status == false).Sum(x => x.Payment_Amount);
                var odenilen = dateSearch.Where(x => x.Status == true).Sum(x => x.Payment_Amount);
                if (borc == null)
                {
                    lBonusBorc.Text = DefaultConstants.DEFAULT_CURRENCY_STRING;
                }
                else
                {
                    lBonusBorc.Text = borc.Value.ToString("C2");
                }

                if (odenilen == null)
                {
                    lBonusOdenilen.Text = DefaultConstants.DEFAULT_CURRENCY_STRING;
                }
                else
                {
                    lBonusOdenilen.Text = odenilen.Value.ToString("C2");
                }
                gridBonus.RefreshData();
            }
        }

        private void bBonusExport_Click(object sender, EventArgs e)
        {
            if (gridBonus.RowCount == 0) { Message(AutoMessage.NotFoundData, UserControls.MessageForm.enmType.Info); return; }
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Excel faylı|*.xlsx";
            save.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            save.OverwritePrompt = true; //varsa soruşmadan üstünə yazması üçün false olaraq qalmalıdır
            save.FileName = "Ödənişlər" + "_" + DateTime.Now.ToShortDateString() + ".xlsx";
            if (save.ShowDialog() == DialogResult.OK)
                gridBonus.ExportToXlsx(save.FileName);
        }

        private void gridBonus_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (e.Column.FieldName == "BonusNumber")
            {
                if (e.RowHandle >= 0)
                {
                    e.DisplayText = (e.RowHandle + 1).ToString();
                }
            }
        }

        private void BonusMenuStrip_Edit_Click(object sender, EventArgs e)
        {
            var db = new IntekodbEntities();
            int GridID = Convert.ToInt32(gridBonus.GetFocusedRowCellValue("Id").ToString());
            var BonusID = db.Bonus.FirstOrDefault(x => x.Id == GridID);

            if (BonusID.Status == true)
            {
                Message("Ödənişi edilmiş bonusda düzəliş ediləbilməz", UserControls.MessageForm.enmType.Info);
                return;
            }

            fNewBonus bonus = new fNewBonus(Operation.Edit);
            bonus.BonusID = BonusID.Id;
            bonus.ShowDialog();
            BonusGridFill();
        }

        #endregion



        #region Ödenişler

        Customers Customerid;

        public void PaymentsGridFill()
        {
            Cursor.Current = Cursors.WaitCursor;
            gridPayments.ActiveFilter.Clear();
            if (Intekodb.Payments.Any())
            {
                gridControlPayments.DataSource = Intekodb.Payments.AsNoTracking().Where(x => x.Date >= datePStart.DateTime && x.Date <= datePFinish.DateTime).Select(x => new
                {
                    x.Id,
                    x.QaimeNo,
                    x.Customers,
                    x.OdenecekMebleg,
                    x.OdenenMebleg,
                    x.Avans,
                    x.PaymentType,
                    x.Date,
                    x.PayDate,
                    x.Qaliq,
                    Status = x.Status.Value ? "Ödənilib" : "Ödənilməyib",
                    x.Voen,
                    x.OdeyiciAdi,
                    x.Users
                }).OrderBy(x => x.Id).ToList();
                var borc = Intekodb.Payments.Where(x => x.Status == false).Sum(x => x.Qaliq);
                var odenilen = Intekodb.Payments.Where(x => x.Status == true).Sum(x => x.OdenecekMebleg);
                if (borc == null)
                    lPaymentBorc.Text = DefaultConstants.DEFAULT_CURRENCY_STRING;
                else
                    lPaymentBorc.Text = borc.Value.ToString("C2");
                if (odenilen == null)
                    lPaymentOdenilen.Text = DefaultConstants.DEFAULT_CURRENCY_STRING;
                else
                    lPaymentOdenilen.Text = odenilen.Value.ToString("C2");
                gridPayments.RefreshData();
            }
            Cursor.Current = Cursors.Default;
        }

        private void GridPaymentsVisibleSort(bool value)
        {
            if (value)
            {
                colPNo.VisibleIndex = 0;
                colPContractNo.VisibleIndex = 1;
                colPVoen.VisibleIndex = 2;
                colPQaimeNo.VisibleIndex = 3;
                colPQaimeTarixi.VisibleIndex = 4;
                colPCustomer.VisibleIndex = 5;
                colPPaymentType.VisibleIndex = 6;
                colPPayment.VisibleIndex = 7;
                colPLogDate.VisibleIndex = 8;
                colPPaymentPaid.VisibleIndex = 9;
                colPQaliq.VisibleIndex = 10;
                colPAvans.VisibleIndex = 11;
                colPStatus.VisibleIndex = 12;
                colPComment.VisibleIndex = 13;
                colPNo.Visible = false;
            }
            else
            {
                colPComment.Visible = false;
                colPNo.Visible = true;
            }
        }

        private void gridPayments_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            e.Info.ImageIndex = -1;
            if (e.RowHandle >= 0)
                e.Info.DisplayText = e.RowHandle.ToString();
        }

        private void gridPayments_DoubleClick(object sender, EventArgs e)
        {
            fPay pay = new fPay();

            var db = new IntekodbEntities();
            if (gridPayments.GetFocusedRow() == null)
            {
                Message(AutoMessage.NoSelection, UserControls.MessageForm.enmType.Info);
                return;
            }

            short id = Convert.ToInt16(gridPayments.GetFocusedRowCellValue("Id").ToString());
            Payments look = db.Payments.FirstOrDefault(x => x.Id == id);
            if (look.Status == true)
            {
                pay.Operations = "Show";
                pay.PaymentID = look.Id;
                pay.CustomerID = look.CustomerID;
                pay.ShowDialog();
            }
            else
            {
                pay.Operations = "Payment";
                pay.PaymentID = look.Id;
                pay.CustomerID = look.CustomerID;
                pay.ShowDialog();
            }
            PaymentsGridFill();
            gridPayments.RefreshData();
        }

        private void gridPayments_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            FormHelpers.GridViewStatusDisplayColor(colPStatus, "Ödənilib", "Ödənilməyib", e, gridPayments);
        }

        private void bPaymentLoad_Click(object sender, EventArgs e)
        {
            PaymentsGridFill();
        }

        private void bPaymentExport_Click(object sender, EventArgs e)
        {
            if (gridPayments.RowCount == 0) { Message(AutoMessage.NotFoundData, UserControls.MessageForm.enmType.Info); return; }
            GridPaymentsVisibleSort(true);
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Excel faylı|*.xlsx";
            save.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            save.OverwritePrompt = true; //varsa soruşmadan üstünə yazması üçün false olaraq qalmalıdır
            save.FileName = "Ödənişlər" + "_" + DateTime.Now.ToShortDateString() + ".xlsx";
            if (save.ShowDialog() == DialogResult.OK)
            {
                string fileName = save.FileName;
                gridPayments.ExportToXlsx(fileName, new XlsxExportOptionsEx
                {
                    ExportType = ExportType.WYSIWYG
                });
            }
            GridPaymentsVisibleSort(false);
        }

        private void bPaymentImport_Click(object sender, EventArgs e)
        {
            fExcel f = new fExcel();
            f.Operation = "Payments";
            if (f.ShowDialog() == DialogResult.OK)
                PaymentsGridFill();
        }  //İmport

        private void bNewPay_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            fPay pay = new fPay();
            pay.Operations = "Add";
            pay.ShowDialog();
            PaymentsGridFill();
            Cursor.Current = Cursors.Default;
        }

        private void gridPayments_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (e.Column.FieldName == "PNo")
                if (e.RowHandle >= 0) { e.DisplayText = (e.RowHandle + 1).ToString(); }
        }

        private void lPaymentOdenilen_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            FormHelpers.GridViewContainsLoad("Status", "Ödənilib", gridPayments);
            Cursor.Current = Cursors.Default;
        }

        private void lPaymentBorc_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            FormHelpers.GridViewContainsLoad("Status", "Ödənilməyib", gridPayments);
            Cursor.Current = Cursors.Default;
        }

        private void PaymentsMenuStrip_Edit_Click(object sender, EventArgs e)
        {
            var db = new IntekodbEntities();
            int GridID = Convert.ToInt32(gridPayments.GetFocusedRowCellValue("Id").ToString());
            var paymentID = Intekodb.Payments.FirstOrDefault(x => x.Id == GridID);
            if (paymentID.Status == true)
            {
                Message("Ödənilən ödənişdə düzəliş edilə bilməz", UserControls.MessageForm.enmType.Info);
                return;
            }
            fPay pay = new fPay();
            pay.Operations = "Edit";
            pay.PaymentID = GridID;
            pay.CustomerID = paymentID.CustomerID;
            pay.ShowDialog();
            PaymentsGridFill();
        }

        #endregion



        #region İstifadəçilər

        void userGridFill()
        {
            gridControlUsers.DataSource = null;
            gridControlUsers.DataSource = Intekodb.Users.ToList();
            gridUsers.GroupSummary.Add(DevExpress.Data.SummaryItemType.Count, "colAdd", null, "Total: {0}");
            gridUsers.RefreshData();
            lUsersCount.Text = Intekodb.Users.Count().ToString();
        }

        private void bUserEdit_Click(object sender, EventArgs e)
        {
            if (gridUsers.GetFocusedRow() is null)
            {
                Message(AutoMessage.NoSelection, UserControls.MessageForm.enmType.Warning);
                return;
            }
            else
            {
                short GridID = Convert.ToInt16(gridUsers.GetFocusedRowCellValue("User_ID").ToString());
                fUser f = new fUser(Operation.Edit);
                f.ID = GridID;
                f.ShowDialog();
                userGridFill();
            }
        }

        private void bUserRole_Click(object sender, EventArgs e)
        {
            fDefinitions f = new fDefinitions("Role");
            f.ShowDialog();
            userGridFill();
        }

        private void bUserDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Qeyd edilən istifadəçini silmək istədiyinizə əminsiniz ?", "Mesaj", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (var db = new IntekodbEntities())
                {
                    int id = Convert.ToInt32(gridUsers.GetFocusedRowCellValue("User_ID").ToString());
                    var look = db.Users.FirstOrDefault(x => x.User_ID == id);
                    db.Users.Remove(look);
                    db.SaveChanges();
                    Message("İstifadəçi uğurla silindi", UserControls.MessageForm.enmType.Success);
                    db.Dispose();
                    userGridFill();
                }
            }
        }

        private void bAddUser_Click(object sender, EventArgs e)
        {
            fUser f = new fUser(Operation.Add);
            f.ShowDialog();
            userGridFill();
        }

        private void bUsersLoad_Click(object sender, EventArgs e)
        {
            userGridFill();
        }

        #endregion



        #region Sazlamalar

        private void bPayment_Detail_Click(object sender, EventArgs e)
        {
            fSettings f = new fSettings();
            f.Operation = "PayType";
            f.ShowDialog();
        }

        private void bLog_Detail_Click(object sender, EventArgs e)
        {
            fSettings f = new fSettings();
            f.WindowState = FormWindowState.Maximized;
            f.Operation = "Logs";
            f.ShowDialog();
        }

        private void bLicence_Detail_Click(object sender, EventArgs e)
        {
            fSettings f = new fSettings();
            f.Operation = "Licence";
            f.ShowDialog();
        }

        private void bKassa_Detail_Click(object sender, EventArgs e)
        {
            fSettings f = new fSettings();
            f.Operation = "Kassa";
            f.ShowDialog();
        }

        private void bCity_Detail_Click(object sender, EventArgs e)
        {
            fSettings f = new fSettings();
            f.Operation = "City";
            f.ShowDialog();
        }

        private void bArea_Detail_Click(object sender, EventArgs e)
        {
            fSettings f = new fSettings();
            f.Operation = "Area";
            f.ShowDialog();
        }

        #endregion



        #region SSS

        public void SSSLoad()
        {
            if (Intekodb.Problems.Any())
            {
                if (xtraTabControl1.SelectedTabPage == bCommentAdd)
                {
                    fComments f = new fComments();
                    f.ShowDialog();
                    xtraTabControl1.SelectedTabPage = xtraTabControl1.TabPages[0];
                }
                else if (xtraTabControl1.SelectedTabPage == tabComment_Mpos)
                {
                    gridControlMpos.DataSource = Intekodb.Problems.Select(x => new { x.Id, x.Name, x.Comment, x.Video, x.Type }).Where(x => x.Type == "MPOS").OrderBy(x => x.Id).ToList();
                }
                else if (xtraTabControl1.SelectedTabPage == tabComment_Kassa)
                {
                    gridControlKassa.DataSource = Intekodb.Problems.Select(x => new { x.Id, x.Name, x.Comment, x.Video, x.Type }).Where(x => x.Type == "KASSA").OrderBy(x => x.Id).ToList();
                }
            }
        }

        private void xtraTabControl1_Selected(object sender, DevExpress.XtraTab.TabPageEventArgs e)
        {
            SSSLoad();
        }

        private void bMposVideoDownload_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (gridMpos.GetFocusedRow() != null)
            {
                int id = Convert.ToInt32(gridMpos.GetFocusedRowCellValue("Id").ToString());
                var control = Intekodb.Problems.FirstOrDefault(x => x.Id == id);
                if (control.Video != null)
                {
                    using (SqlConnection con = new SqlConnection(Intekodb.Database.Connection.ConnectionString))
                    {
                        string query = "SELECT Video,FileName,FileExtensions FROM Problems WHERE Id=@id";
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                        con.Open();
                        var reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            var name = reader["FileName"].ToString();
                            var data = (byte[])reader["Video"];
                            var extn = reader["FileExtensions"].ToString();

                            var newFileName = name.Replace(extn, DateTime.Now.ToString("ddMMyyyyhhmmss"));
                            File.WriteAllBytes(Application.StartupPath + "\\temp\\" + newFileName, data);
                            //File.WriteAllBytes(newFileName, data);
                            Process.Start(Application.StartupPath + "\\temp\\" + newFileName);
                        }
                    }
                }
                else { Message("Fayl əlavə edilməyib", UserControls.MessageForm.enmType.Info); return; }
            }
        }

        #endregion


        private void fDashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            Logger.Log("Proqramdan çıxış etdi");

            #region SSS


            //Form fshutdown = new Form();
            //try
            //{
            //    using (fShutdown shutdown = new fShutdown())
            //    {
            //        fshutdown.StartPosition = FormStartPosition.CenterScreen;
            //        fshutdown.FormBorderStyle = FormBorderStyle.None;
            //        fshutdown.Opacity = .50d;
            //        fshutdown.BackColor = Color.Black;
            //        fshutdown.WindowState = FormWindowState.Maximized;
            //        fshutdown.TopMost = true;
            //        fshutdown.Location = this.Location;
            //        fshutdown.ShowInTaskbar = false;
            //        fshutdown.Show();

            //        shutdown.Owner = fshutdown;
            //        shutdown.ShowDialog();


            //        fshutdown.Dispose();

            //        //Çıxış
            //        if (shutdown.Exit == true) { e.Cancel = false; }

            //        //Sonlandır və çıxış et
            //        else if (shutdown.EndExit == true)
            //        {
            //            Cursor.Current = Cursors.WaitCursor;
            //            Proccess.Backup();
            //            Cursor.Current = Cursors.Default;
            //            e.Cancel = false;
            //        }

            //        //Kompüteri söndür
            //        else if (shutdown.Shutdown == true)
            //        {
            //            Cursor.Current = Cursors.WaitCursor;
            //            Proccess.Backup();
            //            Process.Start("shutdown", "-f -s -t 10");
            //            Cursor.Current = Cursors.Default;
            //            e.Cancel = false;
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
            //    fshutdown.Dispose();
            //    MessageBox.Show(ex.Message);
            //}
            //finally
            //{
            //    fshutdown.Dispose();
            //}
            #endregion
        }

        private void fDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Directory.Exists(Application.StartupPath + "\\temp"))
            {
                Directory.Delete(Application.StartupPath + "\\temp", true);
                Directory.CreateDirectory(Application.StartupPath + "\\temp");
            }
            else
            {
                Directory.CreateDirectory(Application.StartupPath + "\\temp");
            }
            Application.Exit();
        }

        private void bMposVideoView_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (gridMpos.GetFocusedRow() != null)
            {
                xtraTabControl1.SelectedTabPage = xtraTabControl1.TabPages[0];
            }
        }

        private void bHistoryİmport_Click(object sender, EventArgs e)
        {
            fAddHistory f = new fAddHistory();
            f.Show();
            //fExcel f = new fExcel();
            //f.Operation = "History";
            //f.ShowDialog();
        }

        private void barPaymentTotalReport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //using (var db = new IntekodbEntities())
            //{
            //    var result = (from c in db.Customers
            //                  join p in db.Payments on c.Id equals p.CustomerID
            //                  join area in db.Area on c.AreaID equals area.Id
            //                  join kassa in db.Kassalar on c.Kassa_Model equals kassa.Id
            //                  join ptype in db.PaymentType on p.PaymentTypeID equals ptype.Id
            //                  select new
            //                  {
            //                      ID = c.Id,
            //                      AdSoyad = c.NameSurname,
            //                      ObyektAdı = c.CompanyName,
            //                      Rayon = area.AreaName,
            //                      Ünvan = c.Address,
            //                      TəqribiYerləşmə = c.GuessLocation,
            //                      KassaModeli = kassa.Name,
            //                      QeydiyyatTarixi = c.Registration_Date,
            //                      MüqaviləNo = c.ContractNo,
            //                      Satanİşçi = c.SalesMan,
            //                      Telefon = c.Phone,
            //                      YazılmaQiyməti = c.RegistrationPrice,
            //                      AylıqÖdəniş = c.ServicePrice,
            //                      QaiməTarixi = p.Date,
            //                      ÖdənişStatusu = p.Status.Value ? "Aktiv" : "Passiv",
            //                      Qeyd = p.Comment,
            //                      ÖdənişNövü = ptype.PaymentName,
            //                      ÖdənəcəkMəbləğ = p.OdenecekMebleg,
            //                      VöenKod = c.Voen + " - " + c.CompanyCode,
            //                      İl = p.Date.Value.Year,
            //                      Ay = p.Date.Value.Month,

            //                  }).OrderBy(x => x.İl).ThenBy(x => x.Ay);


            //    gridControlPayments.DataSource = result.ToList().OrderBy(x => GetMonthOrder((Month)x.Ay)).ToList();

            //    SaveFileDialog save = new SaveFileDialog();
            //    save.Filter = "Excel faylı|*.xlsx";
            //    save.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            //    save.OverwritePrompt = true; //varsa soruşmadan üstünə yazması üçün false olaraq qalmalıdır
            //    save.FileName = "Ümumi ödəniş hesabatı" + "_" + DateTime.Now.ToShortDateString() + ".xlsx";
            //    if (save.ShowDialog() == DialogResult.OK)
            //    {
            //        string fileName = save.FileName;
            //        gridPayments.ExportToXlsx(fileName, new XlsxExportOptionsEx
            //        {
            //            ExportType = ExportType.DataAware
            //        });
            //    }
            //}
        }

        private void barPaymentEverydayReport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gridPayments.RowCount == 0) { Message(AutoMessage.NotFoundData, UserControls.MessageForm.enmType.Info); return; }
            GridPaymentsVisibleSort(true);
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Excel faylı|*.xlsx";
            save.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            save.OverwritePrompt = true; //varsa soruşmadan üstünə yazması üçün false olaraq qalmalıdır
            save.FileName = $"{datePStart.Text} - {datePFinish.Text}_Aralıq Hesabatı.xlsx";
            if (save.ShowDialog() == DialogResult.OK)
            {
                string fileName = save.FileName;
                gridPayments.ExportToXlsx(fileName, new XlsxExportOptionsEx
                {
                    ExportType = ExportType.WYSIWYG
                });
            }
            GridPaymentsVisibleSort(false);
        }
    }
}

/*
 * gridCustomers.GroupPanelText = "Kateqoriyalandırmaq üçün sütunu bura sürükləyin"; //Grid qrup panelinin textini dəyiştirmə
 * gridCustomers.OptionsFind.FindNullPrompt = "Axtarış edin.."; // Axtarış qutusunun içindəki textbox mətnini dəyiştirmə
 */

/*
     public class MyGridLocalizer : GridLocalizer
     {
         public override string GetLocalizedString(GridStringId id)
         {
             if (id == GridStringId.FindControlFindButton)
                 return "Axtar";
             return base.GetLocalizedString(id);
         }
     } //Gridin axtarış çubuğundakı düymənin adını dəyiştirir

     */