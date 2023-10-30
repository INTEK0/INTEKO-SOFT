
namespace İNTEKO.PayHistory
{
    partial class fPaymenHistory
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
            this.groupControlLeft = new DevExpress.XtraEditors.GroupControl();
            this.bSearch = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.dateFinish = new DevExpress.XtraEditors.DateEdit();
            this.dateStart = new DevExpress.XtraEditors.DateEdit();
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.bPrint = new DevExpress.XtraEditors.SimpleButton();
            this.groupControlRight = new DevExpress.XtraEditors.GroupControl();
            this.cmbMonth = new System.Windows.Forms.ComboBox();
            this.gridControlHistory = new DevExpress.XtraGrid.GridControl();
            this.gridHistory = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colQaimeNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPaymentTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPaymentPaid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAvans = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPaymentType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlLeft)).BeginInit();
            this.groupControlLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateFinish.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateFinish.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateStart.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateStart.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlRight)).BeginInit();
            this.groupControlRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControlLeft
            // 
            this.groupControlLeft.AppearanceCaption.Font = new System.Drawing.Font("Nunito", 12F);
            this.groupControlLeft.AppearanceCaption.Options.UseFont = true;
            this.groupControlLeft.AppearanceCaption.Options.UseTextOptions = true;
            this.groupControlLeft.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.tablePanel1.SetColumn(this.groupControlLeft, 0);
            this.groupControlLeft.Controls.Add(this.bSearch);
            this.groupControlLeft.Controls.Add(this.labelControl6);
            this.groupControlLeft.Controls.Add(this.dateFinish);
            this.groupControlLeft.Controls.Add(this.dateStart);
            this.groupControlLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControlLeft.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            this.groupControlLeft.Location = new System.Drawing.Point(0, 0);
            this.groupControlLeft.LookAndFeel.SkinName = "Office 2019 White";
            this.groupControlLeft.LookAndFeel.UseDefaultLookAndFeel = false;
            this.groupControlLeft.Margin = new System.Windows.Forms.Padding(0);
            this.groupControlLeft.MaximumSize = new System.Drawing.Size(621, 70);
            this.groupControlLeft.Name = "groupControlLeft";
            this.tablePanel1.SetRow(this.groupControlLeft, 0);
            this.groupControlLeft.Size = new System.Drawing.Size(621, 70);
            this.groupControlLeft.TabIndex = 16;
            this.groupControlLeft.Text = "Tarix aralığı ilə axtar";
            // 
            // bSearch
            // 
            this.bSearch.AllowFocus = false;
            this.bSearch.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.bSearch.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bSearch.Appearance.Font = new System.Drawing.Font("Nunito", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSearch.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(131)))), ((int)(((byte)(131)))));
            this.bSearch.Appearance.Options.UseBorderColor = true;
            this.bSearch.Appearance.Options.UseFont = true;
            this.bSearch.Appearance.Options.UseForeColor = true;
            this.bSearch.Appearance.Options.UseTextOptions = true;
            this.bSearch.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bSearch.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
            this.bSearch.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.bSearch.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(131)))), ((int)(((byte)(131)))));
            this.bSearch.AppearanceHovered.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(131)))), ((int)(((byte)(131)))));
            this.bSearch.AppearanceHovered.Options.UseBackColor = true;
            this.bSearch.Location = new System.Drawing.Point(497, 26);
            this.bSearch.LookAndFeel.SkinName = "Office 2019 White";
            this.bSearch.LookAndFeel.UseDefaultLookAndFeel = false;
            this.bSearch.Name = "bSearch";
            this.bSearch.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.bSearch.Size = new System.Drawing.Size(110, 32);
            this.bSearch.TabIndex = 19;
            this.bSearch.TabStop = false;
            this.bSearch.Text = "Axtar";
            this.bSearch.Click += new System.EventHandler(this.bSearch_Click);
            // 
            // labelControl6
            // 
            this.labelControl6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Nunito", 14F);
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(247, 29);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(8, 26);
            this.labelControl6.TabIndex = 18;
            this.labelControl6.Text = "-";
            // 
            // dateFinish
            // 
            this.dateFinish.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateFinish.EditValue = null;
            this.dateFinish.Location = new System.Drawing.Point(277, 26);
            this.dateFinish.Name = "dateFinish";
            this.dateFinish.Properties.AllowFocused = false;
            this.dateFinish.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.dateFinish.Properties.Appearance.Font = new System.Drawing.Font("Nunito", 14F);
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
            this.dateFinish.Size = new System.Drawing.Size(210, 32);
            this.dateFinish.TabIndex = 18;
            // 
            // dateStart
            // 
            this.dateStart.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateStart.EditValue = null;
            this.dateStart.Location = new System.Drawing.Point(12, 26);
            this.dateStart.Name = "dateStart";
            this.dateStart.Properties.AllowFocused = false;
            this.dateStart.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.dateStart.Properties.Appearance.Font = new System.Drawing.Font("Nunito", 14F);
            this.dateStart.Properties.Appearance.Options.UseFont = true;
            this.dateStart.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateStart.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateStart.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Fluent;
            this.dateStart.Properties.LookAndFeel.SkinMaskColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dateStart.Properties.LookAndFeel.SkinName = "The Bezier";
            this.dateStart.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.dateStart.Properties.ShowToday = false;
            this.dateStart.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.dateStart.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.False;
            this.dateStart.Size = new System.Drawing.Size(210, 32);
            this.dateStart.TabIndex = 18;
            // 
            // tablePanel1
            // 
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 621.8F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 18.64F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 40.56F)});
            this.tablePanel1.Controls.Add(this.panelControl1);
            this.tablePanel1.Controls.Add(this.groupControlLeft);
            this.tablePanel1.Controls.Add(this.groupControlRight);
            this.tablePanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tablePanel1.Location = new System.Drawing.Point(0, 0);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.tablePanel1.Size = new System.Drawing.Size(1348, 70);
            this.tablePanel1.TabIndex = 17;
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.tablePanel1.SetColumn(this.panelControl1, 2);
            this.panelControl1.Controls.Add(this.bPrint);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(850, 0);
            this.panelControl1.LookAndFeel.SkinName = "Office 2019 White";
            this.panelControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.panelControl1.Margin = new System.Windows.Forms.Padding(0);
            this.panelControl1.Name = "panelControl1";
            this.tablePanel1.SetRow(this.panelControl1, 0);
            this.panelControl1.Size = new System.Drawing.Size(498, 70);
            this.panelControl1.TabIndex = 17;
            // 
            // bPrint
            // 
            this.bPrint.AllowFocus = false;
            this.bPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bPrint.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bPrint.Appearance.Font = new System.Drawing.Font("Nunito", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bPrint.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(131)))), ((int)(((byte)(131)))));
            this.bPrint.Appearance.Options.UseBorderColor = true;
            this.bPrint.Appearance.Options.UseFont = true;
            this.bPrint.Appearance.Options.UseForeColor = true;
            this.bPrint.Appearance.Options.UseTextOptions = true;
            this.bPrint.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bPrint.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
            this.bPrint.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.bPrint.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(131)))), ((int)(((byte)(131)))));
            this.bPrint.AppearanceHovered.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(131)))), ((int)(((byte)(131)))));
            this.bPrint.AppearanceHovered.Options.UseBackColor = true;
            this.bPrint.Location = new System.Drawing.Point(371, 5);
            this.bPrint.LookAndFeel.SkinName = "Office 2019 White";
            this.bPrint.LookAndFeel.UseDefaultLookAndFeel = false;
            this.bPrint.Name = "bPrint";
            this.bPrint.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.bPrint.Size = new System.Drawing.Size(121, 60);
            this.bPrint.TabIndex = 19;
            this.bPrint.TabStop = false;
            this.bPrint.Text = "Çap et";
            // 
            // groupControlRight
            // 
            this.groupControlRight.AppearanceCaption.Font = new System.Drawing.Font("Nunito", 12F);
            this.groupControlRight.AppearanceCaption.Options.UseFont = true;
            this.groupControlRight.AppearanceCaption.Options.UseTextOptions = true;
            this.groupControlRight.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.tablePanel1.SetColumn(this.groupControlRight, 1);
            this.groupControlRight.Controls.Add(this.cmbMonth);
            this.groupControlRight.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupControlRight.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            this.groupControlRight.Location = new System.Drawing.Point(622, 0);
            this.groupControlRight.LookAndFeel.SkinName = "Office 2019 White";
            this.groupControlRight.LookAndFeel.UseDefaultLookAndFeel = false;
            this.groupControlRight.Margin = new System.Windows.Forms.Padding(0);
            this.groupControlRight.Name = "groupControlRight";
            this.tablePanel1.SetRow(this.groupControlRight, 0);
            this.groupControlRight.Size = new System.Drawing.Size(227, 70);
            this.groupControlRight.TabIndex = 16;
            this.groupControlRight.Text = "Aya görə axtar";
            this.groupControlRight.Visible = false;
            // 
            // cmbMonth
            // 
            this.cmbMonth.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMonth.Font = new System.Drawing.Font("Nunito", 14F);
            this.cmbMonth.FormattingEnabled = true;
            this.cmbMonth.Location = new System.Drawing.Point(18, 26);
            this.cmbMonth.Name = "cmbMonth";
            this.cmbMonth.Size = new System.Drawing.Size(194, 34);
            this.cmbMonth.TabIndex = 18;
            this.cmbMonth.TabStop = false;
            // 
            // gridControlHistory
            // 
            this.gridControlHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlHistory.Location = new System.Drawing.Point(0, 70);
            this.gridControlHistory.LookAndFeel.SkinName = "Visual Studio 2013 Light";
            this.gridControlHistory.LookAndFeel.UseDefaultLookAndFeel = false;
            this.gridControlHistory.MainView = this.gridHistory;
            this.gridControlHistory.Margin = new System.Windows.Forms.Padding(2);
            this.gridControlHistory.Name = "gridControlHistory";
            this.gridControlHistory.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit2});
            this.gridControlHistory.Size = new System.Drawing.Size(1348, 748);
            this.gridControlHistory.TabIndex = 18;
            this.gridControlHistory.TabStop = false;
            this.gridControlHistory.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridHistory});
            // 
            // gridHistory
            // 
            this.gridHistory.Appearance.HeaderPanel.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Bold);
            this.gridHistory.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridHistory.Appearance.Row.Font = new System.Drawing.Font("Nunito", 14F);
            this.gridHistory.Appearance.Row.Options.UseFont = true;
            this.gridHistory.Appearance.ViewCaption.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Bold);
            this.gridHistory.Appearance.ViewCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gridHistory.Appearance.ViewCaption.Options.UseFont = true;
            this.gridHistory.Appearance.ViewCaption.Options.UseForeColor = true;
            this.gridHistory.Appearance.ViewCaption.Options.UseTextOptions = true;
            this.gridHistory.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridHistory.Appearance.ViewCaption.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
            this.gridHistory.ColumnPanelRowHeight = 35;
            this.gridHistory.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colQaimeNo,
            this.colPaymentTotal,
            this.colPaymentPaid,
            this.colAvans,
            this.colPaymentType,
            this.colDate});
            this.gridHistory.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.gridHistory.GridControl = this.gridControlHistory;
            this.gridHistory.Name = "gridHistory";
            this.gridHistory.OptionsMenu.EnableColumnMenu = false;
            this.gridHistory.OptionsMenu.EnableFooterMenu = false;
            this.gridHistory.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridHistory.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.gridHistory.OptionsView.ShowFooter = true;
            this.gridHistory.OptionsView.ShowGroupPanel = false;
            this.gridHistory.OptionsView.ShowIndicator = false;
            this.gridHistory.OptionsView.ShowViewCaption = true;
            this.gridHistory.RowHeight = 35;
            this.gridHistory.ViewCaption = " ";
            // 
            // colQaimeNo
            // 
            this.colQaimeNo.AppearanceCell.Options.UseTextOptions = true;
            this.colQaimeNo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colQaimeNo.AppearanceHeader.Options.UseTextOptions = true;
            this.colQaimeNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colQaimeNo.Caption = "Qaimə №";
            this.colQaimeNo.FieldName = "QaimeNo";
            this.colQaimeNo.MaxWidth = 120;
            this.colQaimeNo.MinWidth = 120;
            this.colQaimeNo.Name = "colQaimeNo";
            this.colQaimeNo.OptionsColumn.AllowEdit = false;
            this.colQaimeNo.Visible = true;
            this.colQaimeNo.VisibleIndex = 0;
            this.colQaimeNo.Width = 120;
            // 
            // colPaymentTotal
            // 
            this.colPaymentTotal.AppearanceCell.Options.UseTextOptions = true;
            this.colPaymentTotal.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPaymentTotal.AppearanceHeader.Options.UseTextOptions = true;
            this.colPaymentTotal.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPaymentTotal.Caption = "Ödənəcək məbləğ";
            this.colPaymentTotal.DisplayFormat.FormatString = "C2";
            this.colPaymentTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colPaymentTotal.FieldName = "OdenecekMebleg";
            this.colPaymentTotal.Name = "colPaymentTotal";
            this.colPaymentTotal.OptionsColumn.AllowEdit = false;
            this.colPaymentTotal.Visible = true;
            this.colPaymentTotal.VisibleIndex = 1;
            this.colPaymentTotal.Width = 243;
            // 
            // colPaymentPaid
            // 
            this.colPaymentPaid.AppearanceCell.Options.UseTextOptions = true;
            this.colPaymentPaid.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPaymentPaid.AppearanceHeader.Options.UseTextOptions = true;
            this.colPaymentPaid.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPaymentPaid.Caption = "Son ödənən məbləğ";
            this.colPaymentPaid.DisplayFormat.FormatString = "C2";
            this.colPaymentPaid.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colPaymentPaid.FieldName = "OdenenMebleg";
            this.colPaymentPaid.Name = "colPaymentPaid";
            this.colPaymentPaid.OptionsColumn.AllowEdit = false;
            this.colPaymentPaid.Visible = true;
            this.colPaymentPaid.VisibleIndex = 2;
            this.colPaymentPaid.Width = 243;
            // 
            // colAvans
            // 
            this.colAvans.AppearanceCell.Options.UseTextOptions = true;
            this.colAvans.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAvans.AppearanceHeader.Options.UseTextOptions = true;
            this.colAvans.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAvans.Caption = "Avans";
            this.colAvans.DisplayFormat.FormatString = "C2";
            this.colAvans.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colAvans.FieldName = "Avans";
            this.colAvans.Name = "colAvans";
            this.colAvans.OptionsColumn.AllowEdit = false;
            this.colAvans.Visible = true;
            this.colAvans.VisibleIndex = 3;
            this.colAvans.Width = 243;
            // 
            // colPaymentType
            // 
            this.colPaymentType.AppearanceCell.Options.UseTextOptions = true;
            this.colPaymentType.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPaymentType.AppearanceHeader.Options.UseTextOptions = true;
            this.colPaymentType.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPaymentType.Caption = "Ödəniş növü";
            this.colPaymentType.FieldName = "PaymentType.PaymentName";
            this.colPaymentType.Name = "colPaymentType";
            this.colPaymentType.OptionsColumn.AllowEdit = false;
            this.colPaymentType.Visible = true;
            this.colPaymentType.VisibleIndex = 4;
            this.colPaymentType.Width = 267;
            // 
            // colDate
            // 
            this.colDate.AppearanceCell.Options.UseTextOptions = true;
            this.colDate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDate.AppearanceHeader.Options.UseTextOptions = true;
            this.colDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDate.Caption = "Tarix";
            this.colDate.DisplayFormat.FormatString = "d";
            this.colDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colDate.FieldName = "Date";
            this.colDate.Name = "colDate";
            this.colDate.OptionsColumn.AllowEdit = false;
            this.colDate.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "Date", "{0}")});
            this.colDate.Visible = true;
            this.colDate.VisibleIndex = 5;
            this.colDate.Width = 226;
            // 
            // repositoryItemTextEdit2
            // 
            this.repositoryItemTextEdit2.AutoHeight = false;
            this.repositoryItemTextEdit2.Name = "repositoryItemTextEdit2";
            // 
            // fPaymenHistory
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1348, 818);
            this.Controls.Add(this.gridControlHistory);
            this.Controls.Add(this.tablePanel1);
            this.LookAndFeel.SkinName = "Office 2019 White";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "fPaymenHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ödəniş keçmişi";
            this.Load += new System.EventHandler(this.fPaymenHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControlLeft)).EndInit();
            this.groupControlLeft.ResumeLayout(false);
            this.groupControlLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateFinish.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateFinish.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateStart.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateStart.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControlRight)).EndInit();
            this.groupControlRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControlLeft;
        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private DevExpress.XtraEditors.GroupControl groupControlRight;
        private DevExpress.XtraEditors.DateEdit dateFinish;
        private DevExpress.XtraEditors.DateEdit dateStart;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private System.Windows.Forms.ComboBox cmbMonth;
        private DevExpress.XtraGrid.GridControl gridControlHistory;
        private DevExpress.XtraGrid.Views.Grid.GridView gridHistory;
        private DevExpress.XtraGrid.Columns.GridColumn colQaimeNo;
        private DevExpress.XtraGrid.Columns.GridColumn colPaymentTotal;
        private DevExpress.XtraGrid.Columns.GridColumn colPaymentPaid;
        private DevExpress.XtraGrid.Columns.GridColumn colAvans;
        private DevExpress.XtraGrid.Columns.GridColumn colPaymentType;
        private DevExpress.XtraGrid.Columns.GridColumn colDate;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit2;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        public DevExpress.XtraEditors.SimpleButton bPrint;
        public DevExpress.XtraEditors.SimpleButton bSearch;
    }
}