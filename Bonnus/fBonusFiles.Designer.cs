
namespace İNTEKO.Bonnus
{
    partial class fBonusFiles
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
            this.gridContract = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControlContract = new DevExpress.XtraGrid.GridControl();
            this.tName = new DevExpress.XtraEditors.TextEdit();
            this.bSave = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.tContractPath = new DevExpress.XtraEditors.TextEdit();
            this.labelControl21 = new DevExpress.XtraEditors.LabelControl();
            this.bFileBrowse = new DevExpress.XtraEditors.SimpleButton();
            this.pageShow = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.bDelete = new DevExpress.XtraEditors.SimpleButton();
            this.bOpen = new DevExpress.XtraEditors.SimpleButton();
            this.pageAdd = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.navigationFrame1 = new DevExpress.XtraBars.Navigation.NavigationFrame();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridContract)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlContract)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tContractPath.Properties)).BeginInit();
            this.pageShow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.pageAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navigationFrame1)).BeginInit();
            this.navigationFrame1.SuspendLayout();
            this.SuspendLayout();
            // 
            // repositoryItemTextEdit2
            // 
            this.repositoryItemTextEdit2.AutoHeight = false;
            this.repositoryItemTextEdit2.Name = "repositoryItemTextEdit2";
            // 
            // gridContract
            // 
            this.gridContract.Appearance.HeaderPanel.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Bold);
            this.gridContract.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridContract.Appearance.Row.Font = new System.Drawing.Font("Nunito", 14F);
            this.gridContract.Appearance.Row.Options.UseFont = true;
            this.gridContract.ColumnPanelRowHeight = 35;
            this.gridContract.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colName});
            this.gridContract.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.gridContract.GridControl = this.gridControlContract;
            this.gridContract.Name = "gridContract";
            this.gridContract.OptionsMenu.EnableColumnMenu = false;
            this.gridContract.OptionsMenu.EnableFooterMenu = false;
            this.gridContract.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridContract.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.gridContract.OptionsView.ShowGroupPanel = false;
            this.gridContract.OptionsView.ShowIndicator = false;
            this.gridContract.RowHeight = 35;
            // 
            // colName
            // 
            this.colName.Caption = "Fayl adı";
            this.colName.FieldName = "Elave2FileName";
            this.colName.Name = "colName";
            this.colName.OptionsColumn.AllowEdit = false;
            this.colName.OptionsColumn.AllowFocus = false;
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            // 
            // gridControlContract
            // 
            this.gridControlContract.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlContract.Location = new System.Drawing.Point(0, 80);
            this.gridControlContract.LookAndFeel.SkinName = "Visual Studio 2013 Light";
            this.gridControlContract.LookAndFeel.UseDefaultLookAndFeel = false;
            this.gridControlContract.MainView = this.gridContract;
            this.gridControlContract.Margin = new System.Windows.Forms.Padding(2);
            this.gridControlContract.Name = "gridControlContract";
            this.gridControlContract.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit2});
            this.gridControlContract.Size = new System.Drawing.Size(891, 488);
            this.gridControlContract.TabIndex = 21;
            this.gridControlContract.TabStop = false;
            this.gridControlContract.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridContract});
            // 
            // tName
            // 
            this.tName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tName.Location = new System.Drawing.Point(105, 16);
            this.tName.Name = "tName";
            this.tName.Properties.Appearance.Font = new System.Drawing.Font("Nunito", 12F);
            this.tName.Properties.Appearance.Options.UseFont = true;
            this.tName.Properties.Appearance.Options.UseTextOptions = true;
            this.tName.Properties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
            this.tName.Size = new System.Drawing.Size(557, 28);
            this.tName.TabIndex = 5;
            // 
            // bSave
            // 
            this.bSave.AllowFocus = false;
            this.bSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bSave.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bSave.Appearance.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSave.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(131)))), ((int)(((byte)(131)))));
            this.bSave.Appearance.Options.UseBorderColor = true;
            this.bSave.Appearance.Options.UseFont = true;
            this.bSave.Appearance.Options.UseForeColor = true;
            this.bSave.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(131)))), ((int)(((byte)(131)))));
            this.bSave.AppearanceHovered.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(131)))), ((int)(((byte)(131)))));
            this.bSave.AppearanceHovered.Options.UseBackColor = true;
            this.bSave.Location = new System.Drawing.Point(769, 17);
            this.bSave.LookAndFeel.SkinName = "Office 2019 White";
            this.bSave.LookAndFeel.UseDefaultLookAndFeel = false;
            this.bSave.Name = "bSave";
            this.bSave.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.bSave.Size = new System.Drawing.Size(117, 59);
            this.bSave.TabIndex = 4;
            this.bSave.TabStop = false;
            this.bSave.Text = "Yadda saxla";
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Nunito", 12F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(5, 19);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(21, 22);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Ad";
            // 
            // groupControl1
            // 
            this.groupControl1.Appearance.BackColor = System.Drawing.Color.White;
            this.groupControl1.Appearance.Options.UseBackColor = true;
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Nunito", 12F);
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.AppearanceCaption.Options.UseTextOptions = true;
            this.groupControl1.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.groupControl1.Controls.Add(this.tName);
            this.groupControl1.Controls.Add(this.tContractPath);
            this.groupControl1.Controls.Add(this.bSave);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.labelControl21);
            this.groupControl1.Controls.Add(this.bFileBrowse);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.LookAndFeel.SkinName = "Office 2019 White";
            this.groupControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(891, 80);
            this.groupControl1.TabIndex = 7;
            // 
            // tContractPath
            // 
            this.tContractPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tContractPath.Enabled = false;
            this.tContractPath.Location = new System.Drawing.Point(105, 48);
            this.tContractPath.Name = "tContractPath";
            this.tContractPath.Properties.Appearance.Font = new System.Drawing.Font("Nunito", 12F);
            this.tContractPath.Properties.Appearance.Options.UseFont = true;
            this.tContractPath.Properties.Appearance.Options.UseTextOptions = true;
            this.tContractPath.Properties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
            this.tContractPath.Size = new System.Drawing.Size(557, 28);
            this.tContractPath.TabIndex = 5;
            // 
            // labelControl21
            // 
            this.labelControl21.Appearance.Font = new System.Drawing.Font("Nunito", 12F);
            this.labelControl21.Appearance.Options.UseFont = true;
            this.labelControl21.Location = new System.Drawing.Point(5, 51);
            this.labelControl21.Name = "labelControl21";
            this.labelControl21.Size = new System.Drawing.Size(65, 22);
            this.labelControl21.TabIndex = 1;
            this.labelControl21.Text = "Fayl yolu";
            // 
            // bFileBrowse
            // 
            this.bFileBrowse.AllowFocus = false;
            this.bFileBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bFileBrowse.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bFileBrowse.Appearance.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bFileBrowse.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(131)))), ((int)(((byte)(131)))));
            this.bFileBrowse.Appearance.Options.UseBorderColor = true;
            this.bFileBrowse.Appearance.Options.UseFont = true;
            this.bFileBrowse.Appearance.Options.UseForeColor = true;
            this.bFileBrowse.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(131)))), ((int)(((byte)(131)))));
            this.bFileBrowse.AppearanceHovered.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(131)))), ((int)(((byte)(131)))));
            this.bFileBrowse.AppearanceHovered.Options.UseBackColor = true;
            this.bFileBrowse.Location = new System.Drawing.Point(668, 17);
            this.bFileBrowse.LookAndFeel.SkinName = "Office 2019 White";
            this.bFileBrowse.LookAndFeel.UseDefaultLookAndFeel = false;
            this.bFileBrowse.Name = "bFileBrowse";
            this.bFileBrowse.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.bFileBrowse.Size = new System.Drawing.Size(95, 59);
            this.bFileBrowse.TabIndex = 4;
            this.bFileBrowse.TabStop = false;
            this.bFileBrowse.Text = "Fayl seç";
            this.bFileBrowse.Click += new System.EventHandler(this.bFileBrowse_Click);
            // 
            // pageShow
            // 
            this.pageShow.Controls.Add(this.groupControl2);
            this.pageShow.Margin = new System.Windows.Forms.Padding(0);
            this.pageShow.Name = "pageShow";
            this.pageShow.Size = new System.Drawing.Size(891, 80);
            // 
            // groupControl2
            // 
            this.groupControl2.Appearance.BackColor = System.Drawing.Color.White;
            this.groupControl2.Appearance.Options.UseBackColor = true;
            this.groupControl2.AppearanceCaption.Font = new System.Drawing.Font("Nunito", 12F);
            this.groupControl2.AppearanceCaption.Options.UseFont = true;
            this.groupControl2.AppearanceCaption.Options.UseTextOptions = true;
            this.groupControl2.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.groupControl2.Controls.Add(this.bDelete);
            this.groupControl2.Controls.Add(this.bOpen);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            this.groupControl2.Location = new System.Drawing.Point(0, 0);
            this.groupControl2.LookAndFeel.SkinName = "Office 2019 White";
            this.groupControl2.LookAndFeel.UseDefaultLookAndFeel = false;
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(891, 80);
            this.groupControl2.TabIndex = 3;
            // 
            // bDelete
            // 
            this.bDelete.AllowFocus = false;
            this.bDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bDelete.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bDelete.Appearance.Font = new System.Drawing.Font("Nunito Black", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bDelete.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.bDelete.Appearance.Options.UseBorderColor = true;
            this.bDelete.Appearance.Options.UseFont = true;
            this.bDelete.Appearance.Options.UseForeColor = true;
            this.bDelete.Appearance.Options.UseTextOptions = true;
            this.bDelete.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bDelete.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
            this.bDelete.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.bDelete.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(131)))), ((int)(((byte)(131)))));
            this.bDelete.AppearanceHovered.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(131)))), ((int)(((byte)(131)))));
            this.bDelete.AppearanceHovered.Options.UseBackColor = true;
            this.bDelete.Location = new System.Drawing.Point(758, 14);
            this.bDelete.LookAndFeel.SkinName = "Office 2019 White";
            this.bDelete.LookAndFeel.UseDefaultLookAndFeel = false;
            this.bDelete.Name = "bDelete";
            this.bDelete.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.bDelete.Size = new System.Drawing.Size(121, 60);
            this.bDelete.TabIndex = 10;
            this.bDelete.TabStop = false;
            this.bDelete.Text = "SİL";
            this.bDelete.Click += new System.EventHandler(this.bDelete_Click);
            // 
            // bOpen
            // 
            this.bOpen.AllowFocus = false;
            this.bOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bOpen.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bOpen.Appearance.Font = new System.Drawing.Font("Nunito", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bOpen.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(131)))), ((int)(((byte)(131)))));
            this.bOpen.Appearance.Options.UseBorderColor = true;
            this.bOpen.Appearance.Options.UseFont = true;
            this.bOpen.Appearance.Options.UseForeColor = true;
            this.bOpen.Appearance.Options.UseTextOptions = true;
            this.bOpen.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bOpen.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
            this.bOpen.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.bOpen.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(131)))), ((int)(((byte)(131)))));
            this.bOpen.AppearanceHovered.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(131)))), ((int)(((byte)(131)))));
            this.bOpen.AppearanceHovered.Options.UseBackColor = true;
            this.bOpen.Location = new System.Drawing.Point(12, 14);
            this.bOpen.LookAndFeel.SkinName = "Office 2019 White";
            this.bOpen.LookAndFeel.UseDefaultLookAndFeel = false;
            this.bOpen.Name = "bOpen";
            this.bOpen.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.bOpen.Size = new System.Drawing.Size(121, 60);
            this.bOpen.TabIndex = 10;
            this.bOpen.TabStop = false;
            this.bOpen.Text = "Faylı aç";
            this.bOpen.Click += new System.EventHandler(this.bOpen_Click);
            // 
            // pageAdd
            // 
            this.pageAdd.Caption = "pageAdd";
            this.pageAdd.Controls.Add(this.groupControl1);
            this.pageAdd.Margin = new System.Windows.Forms.Padding(0);
            this.pageAdd.Name = "pageAdd";
            this.pageAdd.Size = new System.Drawing.Size(891, 80);
            // 
            // navigationFrame1
            // 
            this.navigationFrame1.Controls.Add(this.pageShow);
            this.navigationFrame1.Controls.Add(this.pageAdd);
            this.navigationFrame1.Dock = System.Windows.Forms.DockStyle.Top;
            this.navigationFrame1.Location = new System.Drawing.Point(0, 0);
            this.navigationFrame1.Margin = new System.Windows.Forms.Padding(0);
            this.navigationFrame1.Name = "navigationFrame1";
            this.navigationFrame1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.pageShow,
            this.pageAdd});
            this.navigationFrame1.SelectedPage = this.pageShow;
            this.navigationFrame1.Size = new System.Drawing.Size(891, 80);
            this.navigationFrame1.TabIndex = 20;
            this.navigationFrame1.Text = "navigationFrame1";
            this.navigationFrame1.TransitionAnimationProperties.FrameInterval = 6000;
            // 
            // fBonusFiles
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(891, 568);
            this.Controls.Add(this.gridControlContract);
            this.Controls.Add(this.navigationFrame1);
            this.Name = "fBonusFiles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fBonusFiles";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.fBonusFiles_FormClosed);
            this.Load += new System.EventHandler(this.fBonusFiles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridContract)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlContract)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tContractPath.Properties)).EndInit();
            this.pageShow.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.pageAdd.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.navigationFrame1)).EndInit();
            this.navigationFrame1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridContract;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.GridControl gridControlContract;
        private DevExpress.XtraEditors.TextEdit tName;
        public DevExpress.XtraEditors.SimpleButton bSave;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit tContractPath;
        private DevExpress.XtraEditors.LabelControl labelControl21;
        public DevExpress.XtraEditors.SimpleButton bFileBrowse;
        private DevExpress.XtraBars.Navigation.NavigationPage pageShow;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        public DevExpress.XtraEditors.SimpleButton bDelete;
        public DevExpress.XtraEditors.SimpleButton bOpen;
        private DevExpress.XtraBars.Navigation.NavigationPage pageAdd;
        private DevExpress.XtraBars.Navigation.NavigationFrame navigationFrame1;
    }
}