
namespace İNTEKO.Bonnus
{
    partial class fSelectedCustomer
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
            this.gridControlCustomers = new DevExpress.XtraGrid.GridControl();
            this.gridCustomers = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCustName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustCompany = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustVoen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.toogleCustomerStatus = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toogleCustomerStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlCustomers
            // 
            this.gridControlCustomers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlCustomers.Location = new System.Drawing.Point(0, 0);
            this.gridControlCustomers.LookAndFeel.SkinName = "Visual Studio 2013 Light";
            this.gridControlCustomers.LookAndFeel.UseDefaultLookAndFeel = false;
            this.gridControlCustomers.MainView = this.gridCustomers;
            this.gridControlCustomers.Margin = new System.Windows.Forms.Padding(2);
            this.gridControlCustomers.Name = "gridControlCustomers";
            this.gridControlCustomers.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit2,
            this.toogleCustomerStatus});
            this.gridControlCustomers.Size = new System.Drawing.Size(780, 639);
            this.gridControlCustomers.TabIndex = 8;
            this.gridControlCustomers.TabStop = false;
            this.gridControlCustomers.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridCustomers});
            // 
            // gridCustomers
            // 
            this.gridCustomers.Appearance.HeaderPanel.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Bold);
            this.gridCustomers.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridCustomers.Appearance.Row.Font = new System.Drawing.Font("Nunito", 14F);
            this.gridCustomers.Appearance.Row.Options.UseFont = true;
            this.gridCustomers.Appearance.ViewCaption.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Bold);
            this.gridCustomers.Appearance.ViewCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.gridCustomers.Appearance.ViewCaption.Options.UseFont = true;
            this.gridCustomers.Appearance.ViewCaption.Options.UseForeColor = true;
            this.gridCustomers.ColumnPanelRowHeight = 35;
            this.gridCustomers.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCustName,
            this.colCustCompany,
            this.colCustVoen,
            this.colCustAddress});
            this.gridCustomers.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.gridCustomers.GridControl = this.gridControlCustomers;
            this.gridCustomers.Name = "gridCustomers";
            this.gridCustomers.OptionsMenu.EnableColumnMenu = false;
            this.gridCustomers.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridCustomers.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.gridCustomers.OptionsView.ShowAutoFilterRow = true;
            this.gridCustomers.OptionsView.ShowGroupPanel = false;
            this.gridCustomers.OptionsView.ShowIndicator = false;
            this.gridCustomers.OptionsView.ShowViewCaption = true;
            this.gridCustomers.RowHeight = 35;
            this.gridCustomers.ViewCaption = "MÜŞTƏRİLƏR";
            this.gridCustomers.DoubleClick += new System.EventHandler(this.gridCustomers_DoubleClick);
            // 
            // colCustName
            // 
            this.colCustName.AppearanceHeader.Options.UseTextOptions = true;
            this.colCustName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCustName.Caption = "Ad Soyad";
            this.colCustName.FieldName = "NameSurname";
            this.colCustName.Name = "colCustName";
            this.colCustName.OptionsColumn.AllowEdit = false;
            this.colCustName.Visible = true;
            this.colCustName.VisibleIndex = 0;
            // 
            // colCustCompany
            // 
            this.colCustCompany.AppearanceHeader.Options.UseTextOptions = true;
            this.colCustCompany.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCustCompany.Caption = "Obyekt Adı";
            this.colCustCompany.FieldName = "CompanyName";
            this.colCustCompany.Name = "colCustCompany";
            this.colCustCompany.OptionsColumn.AllowEdit = false;
            this.colCustCompany.Visible = true;
            this.colCustCompany.VisibleIndex = 1;
            // 
            // colCustVoen
            // 
            this.colCustVoen.AppearanceHeader.Options.UseTextOptions = true;
            this.colCustVoen.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCustVoen.Caption = "Vöen";
            this.colCustVoen.FieldName = "Voen";
            this.colCustVoen.Name = "colCustVoen";
            this.colCustVoen.OptionsColumn.AllowEdit = false;
            this.colCustVoen.Visible = true;
            this.colCustVoen.VisibleIndex = 2;
            // 
            // colCustAddress
            // 
            this.colCustAddress.AppearanceHeader.Options.UseTextOptions = true;
            this.colCustAddress.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCustAddress.Caption = "Ünvan";
            this.colCustAddress.FieldName = "Address";
            this.colCustAddress.Name = "colCustAddress";
            this.colCustAddress.OptionsColumn.AllowEdit = false;
            this.colCustAddress.Visible = true;
            this.colCustAddress.VisibleIndex = 3;
            // 
            // repositoryItemTextEdit2
            // 
            this.repositoryItemTextEdit2.AutoHeight = false;
            this.repositoryItemTextEdit2.Name = "repositoryItemTextEdit2";
            // 
            // toogleCustomerStatus
            // 
            this.toogleCustomerStatus.AutoHeight = false;
            this.toogleCustomerStatus.CheckBoxOptions.Style = DevExpress.XtraEditors.Controls.CheckBoxStyle.SvgToggle1;
            this.toogleCustomerStatus.CheckBoxOptions.SvgImageSize = new System.Drawing.Size(32, 32);
            this.toogleCustomerStatus.Name = "toogleCustomerStatus";
            // 
            // fSelectedCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(780, 639);
            this.Controls.Add(this.gridControlCustomers);
            this.LookAndFeel.SkinName = "Office 2019 White";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "fSelectedCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müştəri siyahısı";
            this.Load += new System.EventHandler(this.fSelectedCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toogleCustomerStatus)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlCustomers;
        private DevExpress.XtraGrid.Views.Grid.GridView gridCustomers;
        private DevExpress.XtraGrid.Columns.GridColumn colCustName;
        private DevExpress.XtraGrid.Columns.GridColumn colCustCompany;
        private DevExpress.XtraGrid.Columns.GridColumn colCustVoen;
        private DevExpress.XtraGrid.Columns.GridColumn colCustAddress;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit2;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit toogleCustomerStatus;
    }
}