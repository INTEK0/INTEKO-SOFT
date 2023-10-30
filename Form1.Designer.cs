
namespace İNTEKO
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gridControlPayments = new DevExpress.XtraGrid.GridControl();
            this.gridPayments = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colPNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPPaymentType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPContractNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPQaimeNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPVoen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPCustomer = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPQaimeTarixi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPLogDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPPayment = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPPaymentPaid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPQaliq = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPAvans = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit4 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colPComment = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bPaymentExport = new DevExpress.XtraEditors.SimpleButton();
            this.dropDownButton1 = new DevExpress.XtraEditors.DropDownButton();
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPayments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPayments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlPayments
            // 
            this.gridControlPayments.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridControlPayments.Location = new System.Drawing.Point(0, 180);
            this.gridControlPayments.LookAndFeel.SkinName = "Visual Studio 2013 Light";
            this.gridControlPayments.LookAndFeel.UseDefaultLookAndFeel = false;
            this.gridControlPayments.MainView = this.gridPayments;
            this.gridControlPayments.Name = "gridControlPayments";
            this.gridControlPayments.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit4});
            this.gridControlPayments.Size = new System.Drawing.Size(1085, 554);
            this.gridControlPayments.TabIndex = 34;
            this.gridControlPayments.TabStop = false;
            this.gridControlPayments.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridPayments});
            // 
            // gridPayments
            // 
            this.gridPayments.Appearance.HeaderPanel.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Bold);
            this.gridPayments.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridPayments.Appearance.Row.Font = new System.Drawing.Font("Nunito", 12F);
            this.gridPayments.Appearance.Row.Options.UseFont = true;
            this.gridPayments.Appearance.ViewCaption.Font = new System.Drawing.Font("Nunito", 8.25F);
            this.gridPayments.Appearance.ViewCaption.Options.UseFont = true;
            this.gridPayments.ColumnPanelRowHeight = 35;
            this.gridPayments.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPNo,
            this.colPPaymentType,
            this.colPContractNo,
            this.colPQaimeNo,
            this.colPVoen,
            this.colPCustomer,
            this.colPQaimeTarixi,
            this.colPLogDate,
            this.colPPayment,
            this.colPPaymentPaid,
            this.colPQaliq,
            this.colPAvans,
            this.colPStatus,
            this.colPComment});
            this.gridPayments.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.gridPayments.GridControl = this.gridControlPayments;
            this.gridPayments.Name = "gridPayments";
            this.gridPayments.OptionsBehavior.FocusLeaveOnTab = true;
            this.gridPayments.OptionsMenu.EnableColumnMenu = false;
            this.gridPayments.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridPayments.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.gridPayments.OptionsView.ShowAutoFilterRow = true;
            this.gridPayments.OptionsView.ShowGroupPanel = false;
            this.gridPayments.OptionsView.ShowIndicator = false;
            this.gridPayments.RowHeight = 35;
            // 
            // colPNo
            // 
            this.colPNo.AppearanceCell.Font = new System.Drawing.Font("Nunito", 12F);
            this.colPNo.AppearanceCell.Options.UseFont = true;
            this.colPNo.Caption = "№";
            this.colPNo.FieldName = "PNo";
            this.colPNo.MaxWidth = 40;
            this.colPNo.MinWidth = 40;
            this.colPNo.Name = "colPNo";
            this.colPNo.OptionsColumn.AllowEdit = false;
            this.colPNo.OptionsFilter.AllowAutoFilter = false;
            this.colPNo.OptionsFilter.AllowFilter = false;
            this.colPNo.Visible = true;
            this.colPNo.VisibleIndex = 0;
            this.colPNo.Width = 40;
            // 
            // colPPaymentType
            // 
            this.colPPaymentType.AppearanceCell.Font = new System.Drawing.Font("Nunito", 12F);
            this.colPPaymentType.AppearanceCell.Options.UseFont = true;
            this.colPPaymentType.AppearanceCell.Options.UseTextOptions = true;
            this.colPPaymentType.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPPaymentType.AppearanceHeader.Options.UseTextOptions = true;
            this.colPPaymentType.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPPaymentType.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
            this.colPPaymentType.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colPPaymentType.Caption = "Ödəniş növü";
            this.colPPaymentType.FieldName = "PaymentType.PaymentName";
            this.colPPaymentType.Name = "colPPaymentType";
            this.colPPaymentType.OptionsColumn.AllowEdit = false;
            this.colPPaymentType.Visible = true;
            this.colPPaymentType.VisibleIndex = 1;
            this.colPPaymentType.Width = 99;
            // 
            // colPContractNo
            // 
            this.colPContractNo.AppearanceCell.Font = new System.Drawing.Font("Nunito", 12F);
            this.colPContractNo.AppearanceCell.Options.UseFont = true;
            this.colPContractNo.AppearanceCell.Options.UseTextOptions = true;
            this.colPContractNo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPContractNo.AppearanceHeader.Options.UseTextOptions = true;
            this.colPContractNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPContractNo.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
            this.colPContractNo.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colPContractNo.Caption = "Təyinat";
            this.colPContractNo.FieldName = "Customers.ContractNo";
            this.colPContractNo.Name = "colPContractNo";
            this.colPContractNo.OptionsColumn.AllowEdit = false;
            this.colPContractNo.Visible = true;
            this.colPContractNo.VisibleIndex = 2;
            this.colPContractNo.Width = 110;
            // 
            // colPQaimeNo
            // 
            this.colPQaimeNo.AppearanceCell.Font = new System.Drawing.Font("Nunito", 12F);
            this.colPQaimeNo.AppearanceCell.Options.UseFont = true;
            this.colPQaimeNo.AppearanceCell.Options.UseTextOptions = true;
            this.colPQaimeNo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPQaimeNo.AppearanceHeader.Options.UseTextOptions = true;
            this.colPQaimeNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPQaimeNo.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
            this.colPQaimeNo.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colPQaimeNo.Caption = "Qaimə №";
            this.colPQaimeNo.FieldName = "QaimeNo";
            this.colPQaimeNo.Name = "colPQaimeNo";
            this.colPQaimeNo.OptionsColumn.AllowEdit = false;
            this.colPQaimeNo.Visible = true;
            this.colPQaimeNo.VisibleIndex = 3;
            this.colPQaimeNo.Width = 98;
            // 
            // colPVoen
            // 
            this.colPVoen.AppearanceCell.Font = new System.Drawing.Font("Nunito", 12F);
            this.colPVoen.AppearanceCell.Options.UseFont = true;
            this.colPVoen.AppearanceCell.Options.UseTextOptions = true;
            this.colPVoen.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPVoen.AppearanceHeader.Options.UseTextOptions = true;
            this.colPVoen.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPVoen.Caption = "VÖEN";
            this.colPVoen.FieldName = "Customers.Voen";
            this.colPVoen.Name = "colPVoen";
            this.colPVoen.OptionsColumn.AllowEdit = false;
            this.colPVoen.Visible = true;
            this.colPVoen.VisibleIndex = 5;
            this.colPVoen.Width = 124;
            // 
            // colPCustomer
            // 
            this.colPCustomer.AppearanceCell.Font = new System.Drawing.Font("Nunito", 12F);
            this.colPCustomer.AppearanceCell.Options.UseFont = true;
            this.colPCustomer.AppearanceCell.Options.UseTextOptions = true;
            this.colPCustomer.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPCustomer.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
            this.colPCustomer.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colPCustomer.AppearanceHeader.Options.UseTextOptions = true;
            this.colPCustomer.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPCustomer.Caption = "Ödəyici adı";
            this.colPCustomer.FieldName = "Customers.NameSurname";
            this.colPCustomer.Name = "colPCustomer";
            this.colPCustomer.OptionsColumn.AllowEdit = false;
            this.colPCustomer.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.colPCustomer.Visible = true;
            this.colPCustomer.VisibleIndex = 6;
            this.colPCustomer.Width = 267;
            // 
            // colPQaimeTarixi
            // 
            this.colPQaimeTarixi.AppearanceCell.Font = new System.Drawing.Font("Nunito", 12F);
            this.colPQaimeTarixi.AppearanceCell.Options.UseFont = true;
            this.colPQaimeTarixi.AppearanceCell.Options.UseTextOptions = true;
            this.colPQaimeTarixi.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPQaimeTarixi.AppearanceHeader.Options.UseTextOptions = true;
            this.colPQaimeTarixi.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPQaimeTarixi.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
            this.colPQaimeTarixi.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colPQaimeTarixi.Caption = "Qaimə tarixi";
            this.colPQaimeTarixi.FieldName = "Date";
            this.colPQaimeTarixi.Name = "colPQaimeTarixi";
            this.colPQaimeTarixi.OptionsColumn.AllowEdit = false;
            this.colPQaimeTarixi.Visible = true;
            this.colPQaimeTarixi.VisibleIndex = 4;
            this.colPQaimeTarixi.Width = 108;
            // 
            // colPLogDate
            // 
            this.colPLogDate.AppearanceCell.Options.UseTextOptions = true;
            this.colPLogDate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPLogDate.AppearanceHeader.Options.UseTextOptions = true;
            this.colPLogDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPLogDate.Caption = "Ödəniş tarixi";
            this.colPLogDate.FieldName = "PayDate";
            this.colPLogDate.Name = "colPLogDate";
            this.colPLogDate.OptionsColumn.AllowEdit = false;
            this.colPLogDate.Visible = true;
            this.colPLogDate.VisibleIndex = 8;
            this.colPLogDate.Width = 94;
            // 
            // colPPayment
            // 
            this.colPPayment.AppearanceCell.Font = new System.Drawing.Font("Nunito", 12F);
            this.colPPayment.AppearanceCell.Options.UseFont = true;
            this.colPPayment.AppearanceCell.Options.UseTextOptions = true;
            this.colPPayment.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPPayment.AppearanceHeader.Options.UseTextOptions = true;
            this.colPPayment.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPPayment.Caption = "Ödəniş məbləği";
            this.colPPayment.DisplayFormat.FormatString = "C2";
            this.colPPayment.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colPPayment.FieldName = "OdenecekMebleg";
            this.colPPayment.Name = "colPPayment";
            this.colPPayment.OptionsColumn.AllowEdit = false;
            this.colPPayment.Visible = true;
            this.colPPayment.VisibleIndex = 7;
            this.colPPayment.Width = 139;
            // 
            // colPPaymentPaid
            // 
            this.colPPaymentPaid.AppearanceCell.Font = new System.Drawing.Font("Nunito", 12F);
            this.colPPaymentPaid.AppearanceCell.Options.UseFont = true;
            this.colPPaymentPaid.AppearanceCell.Options.UseTextOptions = true;
            this.colPPaymentPaid.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPPaymentPaid.AppearanceHeader.Options.UseTextOptions = true;
            this.colPPaymentPaid.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPPaymentPaid.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
            this.colPPaymentPaid.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colPPaymentPaid.Caption = "Ən son ödənən məbləğ";
            this.colPPaymentPaid.DisplayFormat.FormatString = "C2";
            this.colPPaymentPaid.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colPPaymentPaid.FieldName = "OdenenMebleg";
            this.colPPaymentPaid.Name = "colPPaymentPaid";
            this.colPPaymentPaid.OptionsColumn.AllowEdit = false;
            this.colPPaymentPaid.Visible = true;
            this.colPPaymentPaid.VisibleIndex = 9;
            this.colPPaymentPaid.Width = 119;
            // 
            // colPQaliq
            // 
            this.colPQaliq.AppearanceCell.Font = new System.Drawing.Font("Nunito", 12F);
            this.colPQaliq.AppearanceCell.Options.UseFont = true;
            this.colPQaliq.AppearanceCell.Options.UseTextOptions = true;
            this.colPQaliq.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPQaliq.AppearanceHeader.Options.UseTextOptions = true;
            this.colPQaliq.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPQaliq.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
            this.colPQaliq.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colPQaliq.Caption = "Qalıq";
            this.colPQaliq.DisplayFormat.FormatString = "C2";
            this.colPQaliq.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colPQaliq.FieldName = "Qaliq";
            this.colPQaliq.Name = "colPQaliq";
            this.colPQaliq.OptionsColumn.AllowEdit = false;
            this.colPQaliq.OptionsFilter.AllowAutoFilter = false;
            this.colPQaliq.OptionsFilter.AllowFilter = false;
            this.colPQaliq.Visible = true;
            this.colPQaliq.VisibleIndex = 10;
            this.colPQaliq.Width = 72;
            // 
            // colPAvans
            // 
            this.colPAvans.AppearanceCell.Font = new System.Drawing.Font("Nunito", 12F);
            this.colPAvans.AppearanceCell.Options.UseFont = true;
            this.colPAvans.AppearanceCell.Options.UseTextOptions = true;
            this.colPAvans.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPAvans.AppearanceHeader.Options.UseTextOptions = true;
            this.colPAvans.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPAvans.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
            this.colPAvans.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colPAvans.Caption = "Avans";
            this.colPAvans.DisplayFormat.FormatString = "C2";
            this.colPAvans.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colPAvans.FieldName = "Avans";
            this.colPAvans.Name = "colPAvans";
            this.colPAvans.OptionsColumn.AllowEdit = false;
            this.colPAvans.OptionsFilter.AllowAutoFilter = false;
            this.colPAvans.OptionsFilter.AllowFilter = false;
            this.colPAvans.Visible = true;
            this.colPAvans.VisibleIndex = 11;
            this.colPAvans.Width = 103;
            // 
            // colPStatus
            // 
            this.colPStatus.AppearanceCell.Font = new System.Drawing.Font("Nunito", 12F);
            this.colPStatus.AppearanceCell.Options.UseFont = true;
            this.colPStatus.AppearanceCell.Options.UseTextOptions = true;
            this.colPStatus.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPStatus.AppearanceHeader.Options.UseTextOptions = true;
            this.colPStatus.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPStatus.Caption = "Status";
            this.colPStatus.ColumnEdit = this.repositoryItemTextEdit4;
            this.colPStatus.FieldName = "Status";
            this.colPStatus.Name = "colPStatus";
            this.colPStatus.OptionsColumn.AllowEdit = false;
            this.colPStatus.OptionsFilter.AllowAutoFilter = false;
            this.colPStatus.OptionsFilter.AllowFilter = false;
            this.colPStatus.Visible = true;
            this.colPStatus.VisibleIndex = 12;
            this.colPStatus.Width = 161;
            // 
            // repositoryItemTextEdit4
            // 
            this.repositoryItemTextEdit4.AutoHeight = false;
            this.repositoryItemTextEdit4.Name = "repositoryItemTextEdit4";
            // 
            // colPComment
            // 
            this.colPComment.Caption = "Qeyd";
            this.colPComment.FieldName = "Comment";
            this.colPComment.Name = "colPComment";
            this.colPComment.OptionsColumn.AllowEdit = false;
            // 
            // bPaymentExport
            // 
            this.bPaymentExport.AllowFocus = false;
            this.bPaymentExport.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(172)))), ((int)(((byte)(132)))));
            this.bPaymentExport.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bPaymentExport.Appearance.Font = new System.Drawing.Font("Nunito", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bPaymentExport.Appearance.Options.UseBackColor = true;
            this.bPaymentExport.Appearance.Options.UseBorderColor = true;
            this.bPaymentExport.Appearance.Options.UseFont = true;
            this.bPaymentExport.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(131)))), ((int)(((byte)(131)))));
            this.bPaymentExport.AppearanceHovered.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(131)))), ((int)(((byte)(131)))));
            this.bPaymentExport.AppearanceHovered.Options.UseBackColor = true;
            this.bPaymentExport.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.bPaymentExport.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bPaymentExport.ImageOptions.SvgImage")));
            this.bPaymentExport.ImageOptions.SvgImageSize = new System.Drawing.Size(26, 26);
            this.bPaymentExport.Location = new System.Drawing.Point(963, 12);
            this.bPaymentExport.LookAndFeel.SkinName = "Office 2019 White";
            this.bPaymentExport.LookAndFeel.UseDefaultLookAndFeel = false;
            this.bPaymentExport.Name = "bPaymentExport";
            this.bPaymentExport.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.bPaymentExport.Size = new System.Drawing.Size(110, 36);
            this.bPaymentExport.TabIndex = 35;
            this.bPaymentExport.TabStop = false;
            this.bPaymentExport.Text = " Export";
            this.bPaymentExport.Click += new System.EventHandler(this.bPaymentExport_Click);
            // 
            // dropDownButton1
            // 
            this.dropDownButton1.DropDownArrowStyle = DevExpress.XtraEditors.DropDownArrowStyle.SplitButton;
            this.dropDownButton1.Location = new System.Drawing.Point(431, 86);
            this.dropDownButton1.Name = "dropDownButton1";
            this.dropDownButton1.Size = new System.Drawing.Size(160, 23);
            this.dropDownButton1.TabIndex = 36;
            this.dropDownButton1.Text = "dropDownButton1";
            // 
            // popupMenu1
            // 
            this.popupMenu1.Manager = this.barManager1;
            this.popupMenu1.Name = "popupMenu1";
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1085, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 734);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1085, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 734);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1085, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 734);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 734);
            this.Controls.Add(this.dropDownButton1);
            this.Controls.Add(this.bPaymentExport);
            this.Controls.Add(this.gridControlPayments);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPayments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPayments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlPayments;
        private DevExpress.XtraGrid.Views.Grid.GridView gridPayments;
        private DevExpress.XtraGrid.Columns.GridColumn colPNo;
        private DevExpress.XtraGrid.Columns.GridColumn colPPaymentType;
        private DevExpress.XtraGrid.Columns.GridColumn colPContractNo;
        private DevExpress.XtraGrid.Columns.GridColumn colPQaimeNo;
        private DevExpress.XtraGrid.Columns.GridColumn colPVoen;
        private DevExpress.XtraGrid.Columns.GridColumn colPCustomer;
        private DevExpress.XtraGrid.Columns.GridColumn colPQaimeTarixi;
        private DevExpress.XtraGrid.Columns.GridColumn colPLogDate;
        private DevExpress.XtraGrid.Columns.GridColumn colPPayment;
        private DevExpress.XtraGrid.Columns.GridColumn colPPaymentPaid;
        private DevExpress.XtraGrid.Columns.GridColumn colPQaliq;
        private DevExpress.XtraGrid.Columns.GridColumn colPAvans;
        private DevExpress.XtraGrid.Columns.GridColumn colPStatus;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit4;
        private DevExpress.XtraGrid.Columns.GridColumn colPComment;
        private DevExpress.XtraEditors.SimpleButton bPaymentExport;
        private DevExpress.XtraEditors.DropDownButton dropDownButton1;
        private DevExpress.XtraBars.PopupMenu popupMenu1;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
    }
}