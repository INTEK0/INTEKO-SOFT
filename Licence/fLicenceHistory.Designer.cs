
namespace İNTEKO.Licence
{
    partial class fLicenceHistory
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
            this.repositoryItemTextEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.groupControlLeft = new DevExpress.XtraEditors.GroupControl();
            this.bSearch = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.dateFinish = new DevExpress.XtraEditors.DateEdit();
            this.dateStart = new DevExpress.XtraEditors.DateEdit();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.bPrint = new DevExpress.XtraEditors.SimpleButton();
            this.gridLicence = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCompany = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTarix = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUser = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControlLicence = new DevExpress.XtraGrid.GridControl();
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlLeft)).BeginInit();
            this.groupControlLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateFinish.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateFinish.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateStart.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateStart.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridLicence)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlLicence)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // repositoryItemTextEdit2
            // 
            this.repositoryItemTextEdit2.AutoHeight = false;
            this.repositoryItemTextEdit2.Name = "repositoryItemTextEdit2";
            // 
            // groupControlLeft
            // 
            this.groupControlLeft.AppearanceCaption.Font = new System.Drawing.Font("Nunito", 12F);
            this.groupControlLeft.AppearanceCaption.Options.UseFont = true;
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
            this.bPrint.Visible = false;
            // 
            // gridLicence
            // 
            this.gridLicence.Appearance.HeaderPanel.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Bold);
            this.gridLicence.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridLicence.Appearance.Row.Font = new System.Drawing.Font("Nunito", 14F);
            this.gridLicence.Appearance.Row.Options.UseFont = true;
            this.gridLicence.ColumnPanelRowHeight = 35;
            this.gridLicence.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCompany,
            this.gridColumn2,
            this.colDescription,
            this.colTarix,
            this.colUser,
            this.gridColumn1});
            this.gridLicence.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.gridLicence.GridControl = this.gridControlLicence;
            this.gridLicence.Name = "gridLicence";
            this.gridLicence.OptionsMenu.EnableColumnMenu = false;
            this.gridLicence.OptionsMenu.EnableFooterMenu = false;
            this.gridLicence.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLicence.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.gridLicence.OptionsView.ShowFooter = true;
            this.gridLicence.OptionsView.ShowGroupPanel = false;
            this.gridLicence.OptionsView.ShowIndicator = false;
            this.gridLicence.RowHeight = 35;
            this.gridLicence.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridLicence_RowCellStyle);
            // 
            // colCompany
            // 
            this.colCompany.Caption = "Müştəri adı";
            this.colCompany.FieldName = "Customers.CompanyName";
            this.colCompany.Name = "colCompany";
            this.colCompany.Visible = true;
            this.colCompany.VisibleIndex = 0;
            this.colCompany.Width = 437;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Lisenziya açarı";
            this.gridColumn2.FieldName = "LicenceKey";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.Width = 371;
            // 
            // colDescription
            // 
            this.colDescription.Caption = "Qeyd";
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.OptionsColumn.AllowEdit = false;
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 1;
            this.colDescription.Width = 215;
            // 
            // colTarix
            // 
            this.colTarix.AppearanceCell.Options.UseTextOptions = true;
            this.colTarix.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTarix.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
            this.colTarix.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colTarix.AppearanceHeader.Options.UseTextOptions = true;
            this.colTarix.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTarix.Caption = "Tarix";
            this.colTarix.DisplayFormat.FormatString = "d";
            this.colTarix.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colTarix.FieldName = "Tarix";
            this.colTarix.MaxWidth = 200;
            this.colTarix.MinWidth = 100;
            this.colTarix.Name = "colTarix";
            this.colTarix.OptionsColumn.AllowEdit = false;
            this.colTarix.Visible = true;
            this.colTarix.VisibleIndex = 3;
            this.colTarix.Width = 200;
            // 
            // colUser
            // 
            this.colUser.AppearanceCell.Options.UseTextOptions = true;
            this.colUser.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colUser.AppearanceHeader.Options.UseTextOptions = true;
            this.colUser.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colUser.Caption = "İstifadəçi";
            this.colUser.FieldName = "Users.NameSurname";
            this.colUser.Name = "colUser";
            this.colUser.OptionsColumn.AllowEdit = false;
            this.colUser.Visible = true;
            this.colUser.VisibleIndex = 2;
            this.colUser.Width = 394;
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn1.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
            this.gridColumn1.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridColumn1.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn1.Caption = "Saat";
            this.gridColumn1.DisplayFormat.FormatString = "t";
            this.gridColumn1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gridColumn1.FieldName = "Tarix";
            this.gridColumn1.MaxWidth = 100;
            this.gridColumn1.MinWidth = 100;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 4;
            this.gridColumn1.Width = 100;
            // 
            // gridControlLicence
            // 
            this.gridControlLicence.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlLicence.Location = new System.Drawing.Point(0, 70);
            this.gridControlLicence.LookAndFeel.SkinName = "Visual Studio 2013 Light";
            this.gridControlLicence.LookAndFeel.UseDefaultLookAndFeel = false;
            this.gridControlLicence.MainView = this.gridLicence;
            this.gridControlLicence.Margin = new System.Windows.Forms.Padding(2);
            this.gridControlLicence.Name = "gridControlLicence";
            this.gridControlLicence.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit2});
            this.gridControlLicence.Size = new System.Drawing.Size(1348, 748);
            this.gridControlLicence.TabIndex = 20;
            this.gridControlLicence.TabStop = false;
            this.gridControlLicence.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridLicence});
            // 
            // tablePanel1
            // 
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 621.8F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 18.64F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 40.56F)});
            this.tablePanel1.Controls.Add(this.panelControl1);
            this.tablePanel1.Controls.Add(this.groupControlLeft);
            this.tablePanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tablePanel1.Location = new System.Drawing.Point(0, 0);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.tablePanel1.Size = new System.Drawing.Size(1348, 70);
            this.tablePanel1.TabIndex = 19;
            // 
            // fLicenceHistory
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1348, 818);
            this.Controls.Add(this.gridControlLicence);
            this.Controls.Add(this.tablePanel1);
            this.LookAndFeel.SkinName = "Office 2019 White";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "fLicenceHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.fLicenceHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlLeft)).EndInit();
            this.groupControlLeft.ResumeLayout(false);
            this.groupControlLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateFinish.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateFinish.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateStart.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateStart.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridLicence)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlLicence)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit2;
        private DevExpress.XtraEditors.GroupControl groupControlLeft;
        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        public DevExpress.XtraEditors.SimpleButton bPrint;
        public DevExpress.XtraEditors.SimpleButton bSearch;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.DateEdit dateFinish;
        private DevExpress.XtraEditors.DateEdit dateStart;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLicence;
        private DevExpress.XtraGrid.GridControl gridControlLicence;
        private DevExpress.XtraGrid.Columns.GridColumn colTarix;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn colCompany;
        private DevExpress.XtraGrid.Columns.GridColumn colUser;
    }
}