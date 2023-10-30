
namespace İNTEKO.DetailForm
{
    partial class fTarif
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fTarif));
            this.toolbarFormControl1 = new DevExpress.XtraBars.ToolbarForm.ToolbarFormControl();
            this.toolbarFormManager1 = new DevExpress.XtraBars.ToolbarForm.ToolbarFormManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.gridControlTarif = new DevExpress.XtraGrid.GridControl();
            this.gridTarif = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCustomer = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVoen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colContractNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCompany = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMonth = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOldTarif = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNewTarif = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit5 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.tablePanel6 = new DevExpress.Utils.Layout.TablePanel();
            this.panelControl8 = new DevExpress.XtraEditors.PanelControl();
            this.bNewTarif = new DevExpress.XtraEditors.SimpleButton();
            this.bExport = new DevExpress.XtraEditors.SimpleButton();
            this.bLoad = new DevExpress.XtraEditors.SimpleButton();
            this.dateFinish = new DevExpress.XtraEditors.DateEdit();
            this.dateStart = new DevExpress.XtraEditors.DateEdit();
            ((System.ComponentModel.ISupportInitialize)(this.toolbarFormControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolbarFormManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlTarif)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridTarif)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel6)).BeginInit();
            this.tablePanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl8)).BeginInit();
            this.panelControl8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateFinish.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateFinish.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateStart.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateStart.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // toolbarFormControl1
            // 
            this.toolbarFormControl1.Location = new System.Drawing.Point(0, 0);
            this.toolbarFormControl1.Manager = this.toolbarFormManager1;
            this.toolbarFormControl1.Name = "toolbarFormControl1";
            this.toolbarFormControl1.Size = new System.Drawing.Size(1344, 31);
            this.toolbarFormControl1.TabIndex = 0;
            this.toolbarFormControl1.TabStop = false;
            this.toolbarFormControl1.ToolbarForm = this;
            // 
            // toolbarFormManager1
            // 
            this.toolbarFormManager1.DockControls.Add(this.barDockControlTop);
            this.toolbarFormManager1.DockControls.Add(this.barDockControlBottom);
            this.toolbarFormManager1.DockControls.Add(this.barDockControlLeft);
            this.toolbarFormManager1.DockControls.Add(this.barDockControlRight);
            this.toolbarFormManager1.Form = this;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 31);
            this.barDockControlTop.Manager = this.toolbarFormManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1344, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 816);
            this.barDockControlBottom.Manager = this.toolbarFormManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1344, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 31);
            this.barDockControlLeft.Manager = this.toolbarFormManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 785);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1344, 31);
            this.barDockControlRight.Manager = this.toolbarFormManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 785);
            // 
            // gridControlTarif
            // 
            this.gridControlTarif.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlTarif.Location = new System.Drawing.Point(0, 101);
            this.gridControlTarif.LookAndFeel.SkinName = "Visual Studio 2013 Light";
            this.gridControlTarif.LookAndFeel.UseDefaultLookAndFeel = false;
            this.gridControlTarif.MainView = this.gridTarif;
            this.gridControlTarif.Margin = new System.Windows.Forms.Padding(2);
            this.gridControlTarif.Name = "gridControlTarif";
            this.gridControlTarif.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit5});
            this.gridControlTarif.Size = new System.Drawing.Size(1344, 715);
            this.gridControlTarif.TabIndex = 13;
            this.gridControlTarif.TabStop = false;
            this.gridControlTarif.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridTarif});
            // 
            // gridTarif
            // 
            this.gridTarif.Appearance.HeaderPanel.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Bold);
            this.gridTarif.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridTarif.Appearance.Row.Font = new System.Drawing.Font("Nunito", 14F);
            this.gridTarif.Appearance.Row.Options.UseFont = true;
            this.gridTarif.ColumnPanelRowHeight = 35;
            this.gridTarif.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCustomer,
            this.colVoen,
            this.colContractNo,
            this.colCompany,
            this.colMonth,
            this.colOldTarif,
            this.colNewTarif,
            this.colDate});
            this.gridTarif.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.gridTarif.GridControl = this.gridControlTarif;
            this.gridTarif.Name = "gridTarif";
            this.gridTarif.OptionsBehavior.FocusLeaveOnTab = true;
            this.gridTarif.OptionsMenu.EnableColumnMenu = false;
            this.gridTarif.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridTarif.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.gridTarif.OptionsView.ShowGroupPanel = false;
            this.gridTarif.OptionsView.ShowIndicator = false;
            this.gridTarif.RowHeight = 35;
            // 
            // colCustomer
            // 
            this.colCustomer.AppearanceHeader.Options.UseTextOptions = true;
            this.colCustomer.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCustomer.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
            this.colCustomer.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colCustomer.Caption = "Ad Soyad";
            this.colCustomer.FieldName = "Customers.NameSurname";
            this.colCustomer.Name = "colCustomer";
            this.colCustomer.OptionsColumn.AllowEdit = false;
            this.colCustomer.Visible = true;
            this.colCustomer.VisibleIndex = 1;
            this.colCustomer.Width = 302;
            // 
            // colVoen
            // 
            this.colVoen.AppearanceCell.Options.UseTextOptions = true;
            this.colVoen.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colVoen.AppearanceHeader.Options.UseTextOptions = true;
            this.colVoen.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colVoen.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
            this.colVoen.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colVoen.Caption = "VÖEN";
            this.colVoen.FieldName = "Customers.Voen";
            this.colVoen.MaxWidth = 170;
            this.colVoen.MinWidth = 170;
            this.colVoen.Name = "colVoen";
            this.colVoen.OptionsColumn.AllowEdit = false;
            this.colVoen.Visible = true;
            this.colVoen.VisibleIndex = 3;
            this.colVoen.Width = 170;
            // 
            // colContractNo
            // 
            this.colContractNo.AppearanceCell.Options.UseTextOptions = true;
            this.colContractNo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colContractNo.AppearanceHeader.Options.UseTextOptions = true;
            this.colContractNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colContractNo.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
            this.colContractNo.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colContractNo.Caption = "Müqavilə №";
            this.colContractNo.FieldName = "Customers.ContractNo";
            this.colContractNo.Name = "colContractNo";
            this.colContractNo.OptionsColumn.AllowEdit = false;
            this.colContractNo.Visible = true;
            this.colContractNo.VisibleIndex = 0;
            this.colContractNo.Width = 128;
            // 
            // colCompany
            // 
            this.colCompany.AppearanceHeader.Options.UseTextOptions = true;
            this.colCompany.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCompany.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
            this.colCompany.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colCompany.Caption = "Obyekt adı";
            this.colCompany.FieldName = "Customers.CompanyName";
            this.colCompany.Name = "colCompany";
            this.colCompany.OptionsColumn.AllowEdit = false;
            this.colCompany.Visible = true;
            this.colCompany.VisibleIndex = 2;
            this.colCompany.Width = 312;
            // 
            // colMonth
            // 
            this.colMonth.AppearanceCell.Options.UseTextOptions = true;
            this.colMonth.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMonth.AppearanceHeader.Options.UseTextOptions = true;
            this.colMonth.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMonth.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
            this.colMonth.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colMonth.Caption = "Ay";
            this.colMonth.FieldName = "Month";
            this.colMonth.MaxWidth = 150;
            this.colMonth.MinWidth = 150;
            this.colMonth.Name = "colMonth";
            this.colMonth.OptionsColumn.AllowEdit = false;
            this.colMonth.Width = 150;
            // 
            // colOldTarif
            // 
            this.colOldTarif.AppearanceCell.Options.UseTextOptions = true;
            this.colOldTarif.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colOldTarif.AppearanceHeader.Options.UseTextOptions = true;
            this.colOldTarif.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colOldTarif.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
            this.colOldTarif.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colOldTarif.Caption = "Köhnə Tarif";
            this.colOldTarif.DisplayFormat.FormatString = "C2";
            this.colOldTarif.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colOldTarif.FieldName = "OldTarif";
            this.colOldTarif.MaxWidth = 150;
            this.colOldTarif.MinWidth = 150;
            this.colOldTarif.Name = "colOldTarif";
            this.colOldTarif.OptionsColumn.AllowEdit = false;
            this.colOldTarif.Visible = true;
            this.colOldTarif.VisibleIndex = 5;
            this.colOldTarif.Width = 150;
            // 
            // colNewTarif
            // 
            this.colNewTarif.AppearanceCell.Options.UseTextOptions = true;
            this.colNewTarif.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNewTarif.AppearanceHeader.Options.UseTextOptions = true;
            this.colNewTarif.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNewTarif.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
            this.colNewTarif.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colNewTarif.Caption = "Yeni Tarif";
            this.colNewTarif.DisplayFormat.FormatString = "C2";
            this.colNewTarif.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colNewTarif.FieldName = "NewTarif";
            this.colNewTarif.MaxWidth = 150;
            this.colNewTarif.MinWidth = 150;
            this.colNewTarif.Name = "colNewTarif";
            this.colNewTarif.OptionsColumn.AllowEdit = false;
            this.colNewTarif.Visible = true;
            this.colNewTarif.VisibleIndex = 6;
            this.colNewTarif.Width = 150;
            // 
            // colDate
            // 
            this.colDate.AppearanceCell.Options.UseTextOptions = true;
            this.colDate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDate.AppearanceHeader.Options.UseTextOptions = true;
            this.colDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDate.Caption = "Dəyişiklik tarixi";
            this.colDate.DisplayFormat.FormatString = "d";
            this.colDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colDate.FieldName = "EditDate";
            this.colDate.MaxWidth = 130;
            this.colDate.MinWidth = 130;
            this.colDate.Name = "colDate";
            this.colDate.OptionsColumn.AllowEdit = false;
            this.colDate.Visible = true;
            this.colDate.VisibleIndex = 4;
            this.colDate.Width = 130;
            // 
            // repositoryItemTextEdit5
            // 
            this.repositoryItemTextEdit5.AutoHeight = false;
            this.repositoryItemTextEdit5.Name = "repositoryItemTextEdit5";
            // 
            // tablePanel6
            // 
            this.tablePanel6.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 86.76F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 196F)});
            this.tablePanel6.Controls.Add(this.panelControl8);
            this.tablePanel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.tablePanel6.Location = new System.Drawing.Point(0, 31);
            this.tablePanel6.Name = "tablePanel6";
            this.tablePanel6.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 100F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 100F)});
            this.tablePanel6.ShowGrid = DevExpress.Utils.DefaultBoolean.False;
            this.tablePanel6.Size = new System.Drawing.Size(1344, 70);
            this.tablePanel6.TabIndex = 14;
            // 
            // panelControl8
            // 
            this.panelControl8.Appearance.BackColor = System.Drawing.Color.White;
            this.panelControl8.Appearance.Options.UseBackColor = true;
            this.panelControl8.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.tablePanel6.SetColumn(this.panelControl8, 0);
            this.tablePanel6.SetColumnSpan(this.panelControl8, 2);
            this.panelControl8.Controls.Add(this.bNewTarif);
            this.panelControl8.Controls.Add(this.bExport);
            this.panelControl8.Controls.Add(this.bLoad);
            this.panelControl8.Controls.Add(this.dateFinish);
            this.panelControl8.Controls.Add(this.dateStart);
            this.panelControl8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl8.Location = new System.Drawing.Point(2, 2);
            this.panelControl8.LookAndFeel.SkinName = "Office 2019 White";
            this.panelControl8.LookAndFeel.UseDefaultLookAndFeel = false;
            this.panelControl8.Margin = new System.Windows.Forms.Padding(2);
            this.panelControl8.Name = "panelControl8";
            this.tablePanel6.SetRow(this.panelControl8, 0);
            this.tablePanel6.SetRowSpan(this.panelControl8, 2);
            this.panelControl8.Size = new System.Drawing.Size(1340, 66);
            this.panelControl8.TabIndex = 29;
            // 
            // bNewTarif
            // 
            this.bNewTarif.AllowFocus = false;
            this.bNewTarif.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bNewTarif.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(172)))), ((int)(((byte)(132)))));
            this.bNewTarif.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bNewTarif.Appearance.Font = new System.Drawing.Font("Nunito", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bNewTarif.Appearance.Options.UseBackColor = true;
            this.bNewTarif.Appearance.Options.UseBorderColor = true;
            this.bNewTarif.Appearance.Options.UseFont = true;
            this.bNewTarif.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(131)))), ((int)(((byte)(131)))));
            this.bNewTarif.AppearanceHovered.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(131)))), ((int)(((byte)(131)))));
            this.bNewTarif.AppearanceHovered.Options.UseBackColor = true;
            this.bNewTarif.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.bNewTarif.Location = new System.Drawing.Point(1215, 16);
            this.bNewTarif.LookAndFeel.SkinName = "Office 2019 White";
            this.bNewTarif.LookAndFeel.UseDefaultLookAndFeel = false;
            this.bNewTarif.Name = "bNewTarif";
            this.bNewTarif.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.bNewTarif.Size = new System.Drawing.Size(115, 36);
            this.bNewTarif.TabIndex = 16;
            this.bNewTarif.TabStop = false;
            this.bNewTarif.Text = "Yeni tarif";
            this.bNewTarif.Click += new System.EventHandler(this.bNewTarif_Click);
            // 
            // bExport
            // 
            this.bExport.AllowFocus = false;
            this.bExport.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(172)))), ((int)(((byte)(132)))));
            this.bExport.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bExport.Appearance.Font = new System.Drawing.Font("Nunito", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bExport.Appearance.Options.UseBackColor = true;
            this.bExport.Appearance.Options.UseBorderColor = true;
            this.bExport.Appearance.Options.UseFont = true;
            this.bExport.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(131)))), ((int)(((byte)(131)))));
            this.bExport.AppearanceHovered.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(131)))), ((int)(((byte)(131)))));
            this.bExport.AppearanceHovered.Options.UseBackColor = true;
            this.bExport.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.bExport.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bExport.ImageOptions.SvgImage")));
            this.bExport.ImageOptions.SvgImageSize = new System.Drawing.Size(26, 26);
            this.bExport.Location = new System.Drawing.Point(658, 16);
            this.bExport.LookAndFeel.SkinName = "Office 2019 White";
            this.bExport.LookAndFeel.UseDefaultLookAndFeel = false;
            this.bExport.Name = "bExport";
            this.bExport.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.bExport.Size = new System.Drawing.Size(110, 36);
            this.bExport.TabIndex = 16;
            this.bExport.TabStop = false;
            this.bExport.Text = " Export";
            // 
            // bLoad
            // 
            this.bLoad.AllowFocus = false;
            this.bLoad.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(82)))), ((int)(((byte)(237)))));
            this.bLoad.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bLoad.Appearance.Font = new System.Drawing.Font("Nunito", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bLoad.Appearance.Options.UseBackColor = true;
            this.bLoad.Appearance.Options.UseBorderColor = true;
            this.bLoad.Appearance.Options.UseFont = true;
            this.bLoad.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(131)))), ((int)(((byte)(131)))));
            this.bLoad.AppearanceHovered.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(131)))), ((int)(((byte)(131)))));
            this.bLoad.AppearanceHovered.Options.UseBackColor = true;
            this.bLoad.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.bLoad.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bLoad.ImageOptions.SvgImage")));
            this.bLoad.ImageOptions.SvgImageSize = new System.Drawing.Size(26, 26);
            this.bLoad.Location = new System.Drawing.Point(542, 16);
            this.bLoad.LookAndFeel.SkinName = "Office 2019 White";
            this.bLoad.LookAndFeel.UseDefaultLookAndFeel = false;
            this.bLoad.Name = "bLoad";
            this.bLoad.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.bLoad.Size = new System.Drawing.Size(110, 36);
            this.bLoad.TabIndex = 16;
            this.bLoad.TabStop = false;
            this.bLoad.Text = " Yüklə";
            this.bLoad.Click += new System.EventHandler(this.bLoad_Click);
            // 
            // dateFinish
            // 
            this.dateFinish.EditValue = null;
            this.dateFinish.Location = new System.Drawing.Point(278, 16);
            this.dateFinish.Name = "dateFinish";
            this.dateFinish.Properties.AllowFocused = false;
            this.dateFinish.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.dateFinish.Properties.Appearance.Font = new System.Drawing.Font("Nunito", 16F);
            this.dateFinish.Properties.Appearance.Options.UseFont = true;
            this.dateFinish.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateFinish.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateFinish.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Fluent;
            this.dateFinish.Properties.LookAndFeel.SkinMaskColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dateFinish.Properties.LookAndFeel.SkinName = "The Bezier";
            this.dateFinish.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.dateFinish.Properties.ShowToday = false;
            this.dateFinish.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.dateFinish.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.False;
            this.dateFinish.Size = new System.Drawing.Size(258, 36);
            this.dateFinish.TabIndex = 15;
            this.dateFinish.TabStop = false;
            // 
            // dateStart
            // 
            this.dateStart.EditValue = null;
            this.dateStart.Location = new System.Drawing.Point(14, 16);
            this.dateStart.Name = "dateStart";
            this.dateStart.Properties.AllowFocused = false;
            this.dateStart.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.dateStart.Properties.Appearance.Font = new System.Drawing.Font("Nunito", 16F);
            this.dateStart.Properties.Appearance.Options.UseFont = true;
            this.dateStart.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateStart.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateStart.Properties.CalendarTimeProperties.Mask.EditMask = "d";
            this.dateStart.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Fluent;
            this.dateStart.Properties.LookAndFeel.SkinMaskColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dateStart.Properties.LookAndFeel.SkinName = "The Bezier";
            this.dateStart.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.dateStart.Properties.ShowToday = false;
            this.dateStart.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.dateStart.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.False;
            this.dateStart.Size = new System.Drawing.Size(258, 36);
            this.dateStart.TabIndex = 14;
            this.dateStart.TabStop = false;
            // 
            // fTarif
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1344, 816);
            this.Controls.Add(this.gridControlTarif);
            this.Controls.Add(this.tablePanel6);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Controls.Add(this.toolbarFormControl1);
            this.MinimumSize = new System.Drawing.Size(1346, 817);
            this.Name = "fTarif";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tarifləri";
            this.ToolbarFormControl = this.toolbarFormControl1;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.fTarif_Load);
            ((System.ComponentModel.ISupportInitialize)(this.toolbarFormControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolbarFormManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlTarif)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridTarif)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel6)).EndInit();
            this.tablePanel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl8)).EndInit();
            this.panelControl8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dateFinish.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateFinish.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateStart.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateStart.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.ToolbarForm.ToolbarFormControl toolbarFormControl1;
        private DevExpress.XtraBars.ToolbarForm.ToolbarFormManager toolbarFormManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraGrid.GridControl gridControlTarif;
        private DevExpress.XtraGrid.Views.Grid.GridView gridTarif;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit5;
        private DevExpress.Utils.Layout.TablePanel tablePanel6;
        private DevExpress.XtraEditors.PanelControl panelControl8;
        private DevExpress.XtraEditors.SimpleButton bExport;
        private DevExpress.XtraEditors.SimpleButton bLoad;
        private DevExpress.XtraEditors.DateEdit dateFinish;
        private DevExpress.XtraEditors.DateEdit dateStart;
        private DevExpress.XtraGrid.Columns.GridColumn colMonth;
        private DevExpress.XtraEditors.SimpleButton bNewTarif;
        private DevExpress.XtraGrid.Columns.GridColumn colOldTarif;
        private DevExpress.XtraGrid.Columns.GridColumn colNewTarif;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomer;
        private DevExpress.XtraGrid.Columns.GridColumn colVoen;
        private DevExpress.XtraGrid.Columns.GridColumn colContractNo;
        private DevExpress.XtraGrid.Columns.GridColumn colCompany;
        private DevExpress.XtraGrid.Columns.GridColumn colDate;
    }
}