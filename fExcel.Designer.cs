
namespace İNTEKO
{
    partial class fExcel
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
            this.gridControlExcelData = new DevExpress.XtraGrid.GridControl();
            this.gridExcelData = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bBrowse = new DevExpress.XtraEditors.SimpleButton();
            this.cmbTable = new System.Windows.Forms.ComboBox();
            this.cmbSheet = new System.Windows.Forms.ComboBox();
            this.tFilePath = new DevExpress.XtraEditors.TextEdit();
            this.groupControl5 = new DevExpress.XtraEditors.GroupControl();
            this.bSave = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlExcelData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridExcelData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tFilePath.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).BeginInit();
            this.groupControl5.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControlExcelData
            // 
            this.gridControlExcelData.AllowRestoreSelectionAndFocusedRow = DevExpress.Utils.DefaultBoolean.False;
            this.gridControlExcelData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlExcelData.Location = new System.Drawing.Point(0, 95);
            this.gridControlExcelData.MainView = this.gridExcelData;
            this.gridControlExcelData.Name = "gridControlExcelData";
            this.gridControlExcelData.Size = new System.Drawing.Size(1258, 444);
            this.gridControlExcelData.TabIndex = 23;
            this.gridControlExcelData.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridExcelData});
            // 
            // gridExcelData
            // 
            this.gridExcelData.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(221)))), ((int)(((byte)(225)))));
            this.gridExcelData.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridExcelData.Appearance.HeaderPanel.Font = new System.Drawing.Font("Nunito", 16F, System.Drawing.FontStyle.Bold);
            this.gridExcelData.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridExcelData.Appearance.Row.Font = new System.Drawing.Font("Nunito", 16F);
            this.gridExcelData.Appearance.Row.Options.UseFont = true;
            this.gridExcelData.ColumnPanelRowHeight = 35;
            this.gridExcelData.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.gridExcelData.GridControl = this.gridControlExcelData;
            this.gridExcelData.Name = "gridExcelData";
            this.gridExcelData.OptionsBehavior.Editable = false;
            this.gridExcelData.OptionsMenu.EnableColumnMenu = false;
            this.gridExcelData.OptionsScrollAnnotations.ShowFocusedRow = DevExpress.Utils.DefaultBoolean.False;
            this.gridExcelData.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridExcelData.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.gridExcelData.OptionsView.ShowGroupPanel = false;
            this.gridExcelData.OptionsView.ShowIndicator = false;
            this.gridExcelData.RowHeight = 35;
            // 
            // bBrowse
            // 
            this.bBrowse.AllowFocus = false;
            this.bBrowse.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bBrowse.Appearance.Font = new System.Drawing.Font("Nunito", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bBrowse.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(131)))), ((int)(((byte)(131)))));
            this.bBrowse.Appearance.Options.UseBorderColor = true;
            this.bBrowse.Appearance.Options.UseFont = true;
            this.bBrowse.Appearance.Options.UseForeColor = true;
            this.bBrowse.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(131)))), ((int)(((byte)(131)))));
            this.bBrowse.AppearanceHovered.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(131)))), ((int)(((byte)(131)))));
            this.bBrowse.AppearanceHovered.Options.UseBackColor = true;
            this.bBrowse.Location = new System.Drawing.Point(398, 17);
            this.bBrowse.LookAndFeel.SkinName = "Office 2019 White";
            this.bBrowse.LookAndFeel.UseDefaultLookAndFeel = false;
            this.bBrowse.Name = "bBrowse";
            this.bBrowse.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.bBrowse.Size = new System.Drawing.Size(82, 28);
            this.bBrowse.TabIndex = 27;
            this.bBrowse.TabStop = false;
            this.bBrowse.Text = "...";
            this.bBrowse.Click += new System.EventHandler(this.bBrowse_Click);
            // 
            // cmbTable
            // 
            this.cmbTable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbTable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTable.Font = new System.Drawing.Font("Nunito", 12F);
            this.cmbTable.FormattingEnabled = true;
            this.cmbTable.Items.AddRange(new object[] {
            "Məhsullar",
            "Hesabatlar",
            "Hesabatlar(ətraflı)",
            "İstifadəçilər",
            "Masalar"});
            this.cmbTable.Location = new System.Drawing.Point(973, 20);
            this.cmbTable.MaxDropDownItems = 5;
            this.cmbTable.Name = "cmbTable";
            this.cmbTable.Size = new System.Drawing.Size(273, 30);
            this.cmbTable.TabIndex = 25;
            this.cmbTable.Visible = false;
            // 
            // cmbSheet
            // 
            this.cmbSheet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSheet.Font = new System.Drawing.Font("Nunito", 12F);
            this.cmbSheet.FormattingEnabled = true;
            this.cmbSheet.Location = new System.Drawing.Point(5, 51);
            this.cmbSheet.MaxDropDownItems = 5;
            this.cmbSheet.Name = "cmbSheet";
            this.cmbSheet.Size = new System.Drawing.Size(281, 30);
            this.cmbSheet.TabIndex = 26;
            this.cmbSheet.SelectedValueChanged += new System.EventHandler(this.cmbSheet_SelectedValueChanged);
            // 
            // tFilePath
            // 
            this.tFilePath.Location = new System.Drawing.Point(5, 17);
            this.tFilePath.Name = "tFilePath";
            this.tFilePath.Properties.Appearance.Font = new System.Drawing.Font("Nunito", 12F);
            this.tFilePath.Properties.Appearance.Options.UseFont = true;
            this.tFilePath.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.tFilePath.Properties.ReadOnly = true;
            this.tFilePath.Size = new System.Drawing.Size(387, 28);
            this.tFilePath.TabIndex = 24;
            // 
            // groupControl5
            // 
            this.groupControl5.AppearanceCaption.Font = new System.Drawing.Font("Nunito", 12F);
            this.groupControl5.AppearanceCaption.Options.UseFont = true;
            this.groupControl5.AppearanceCaption.Options.UseTextOptions = true;
            this.groupControl5.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.groupControl5.Controls.Add(this.bSave);
            this.groupControl5.Controls.Add(this.cmbTable);
            this.groupControl5.Controls.Add(this.bBrowse);
            this.groupControl5.Controls.Add(this.cmbSheet);
            this.groupControl5.Controls.Add(this.tFilePath);
            this.groupControl5.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl5.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            this.groupControl5.Location = new System.Drawing.Point(0, 0);
            this.groupControl5.LookAndFeel.SkinName = "Office 2019 White";
            this.groupControl5.LookAndFeel.UseDefaultLookAndFeel = false;
            this.groupControl5.Name = "groupControl5";
            this.groupControl5.Size = new System.Drawing.Size(1258, 95);
            this.groupControl5.TabIndex = 28;
            // 
            // bSave
            // 
            this.bSave.AllowFocus = false;
            this.bSave.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bSave.Appearance.Font = new System.Drawing.Font("Nunito", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSave.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(131)))), ((int)(((byte)(131)))));
            this.bSave.Appearance.Options.UseBorderColor = true;
            this.bSave.Appearance.Options.UseFont = true;
            this.bSave.Appearance.Options.UseForeColor = true;
            this.bSave.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(131)))), ((int)(((byte)(131)))));
            this.bSave.AppearanceHovered.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(131)))), ((int)(((byte)(131)))));
            this.bSave.AppearanceHovered.Options.UseBackColor = true;
            this.bSave.Location = new System.Drawing.Point(292, 51);
            this.bSave.LookAndFeel.SkinName = "Office 2019 White";
            this.bSave.LookAndFeel.UseDefaultLookAndFeel = false;
            this.bSave.Name = "bSave";
            this.bSave.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.bSave.Size = new System.Drawing.Size(100, 30);
            this.bSave.TabIndex = 0;
            this.bSave.TabStop = false;
            this.bSave.Text = "Yüklə";
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // fExcel
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1258, 539);
            this.Controls.Add(this.gridControlExcelData);
            this.Controls.Add(this.groupControl5);
            this.LookAndFeel.SkinName = "Office 2019 White";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "fExcel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fExcel";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.fExcel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlExcelData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridExcelData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tFilePath.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).EndInit();
            this.groupControl5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlExcelData;
        private DevExpress.XtraGrid.Views.Grid.GridView gridExcelData;
        public DevExpress.XtraEditors.SimpleButton bBrowse;
        private System.Windows.Forms.ComboBox cmbTable;
        private System.Windows.Forms.ComboBox cmbSheet;
        public DevExpress.XtraEditors.TextEdit tFilePath;
        private DevExpress.XtraEditors.GroupControl groupControl5;
        public DevExpress.XtraEditors.SimpleButton bSave;
    }
}