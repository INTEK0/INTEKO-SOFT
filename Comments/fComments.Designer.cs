
namespace İNTEKO.Comments
{
    partial class fComments
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.tHeader = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.tComment = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.userFooter_Save1 = new İNTEKO.UserControls.userFooter_Save();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.tFilePath = new DevExpress.XtraEditors.TextEdit();
            this.bUpload = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tHeader.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tComment.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tFilePath.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.labelControl7);
            this.panelControl1.Controls.Add(this.cmbType);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(728, 50);
            this.panelControl1.TabIndex = 0;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Calibri", 14F);
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Appearance.Options.UseTextOptions = true;
            this.labelControl7.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl7.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
            this.labelControl7.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.labelControl7.Location = new System.Drawing.Point(9, 15);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(0);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(129, 23);
            this.labelControl7.TabIndex = 9;
            this.labelControl7.Text = "Əməliyyat növü :";
            // 
            // cmbType
            // 
            this.cmbType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbType.Font = new System.Drawing.Font("Nunito", 14F);
            this.cmbType.FormattingEnabled = true;
            this.cmbType.IntegralHeight = false;
            this.cmbType.Items.AddRange(new object[] {
            "KASSA",
            "MPOS",
            "QEYD"});
            this.cmbType.Location = new System.Drawing.Point(370, 9);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(346, 34);
            this.cmbType.TabIndex = 7;
            this.cmbType.TabStop = false;
            this.cmbType.SelectedValueChanged += new System.EventHandler(this.cmbType_SelectedValueChanged);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.tHeader);
            this.panelControl2.Controls.Add(this.labelControl1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(0, 50);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(728, 240);
            this.panelControl2.TabIndex = 0;
            // 
            // tHeader
            // 
            this.tHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tHeader.Location = new System.Drawing.Point(2, 38);
            this.tHeader.Name = "tHeader";
            this.tHeader.Properties.Appearance.Font = new System.Drawing.Font("Nunito", 14F);
            this.tHeader.Properties.Appearance.Options.UseFont = true;
            this.tHeader.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.tHeader.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tHeader.Size = new System.Drawing.Size(724, 200);
            this.tHeader.TabIndex = 10;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Calibri", 14F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl1.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
            this.labelControl1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelControl1.Location = new System.Drawing.Point(2, 2);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(0);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(724, 36);
            this.labelControl1.TabIndex = 9;
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.tComment);
            this.panelControl3.Controls.Add(this.labelControl2);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl3.Location = new System.Drawing.Point(0, 290);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(728, 270);
            this.panelControl3.TabIndex = 1;
            // 
            // tComment
            // 
            this.tComment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tComment.Location = new System.Drawing.Point(2, 38);
            this.tComment.Margin = new System.Windows.Forms.Padding(0);
            this.tComment.Name = "tComment";
            this.tComment.Properties.Appearance.Font = new System.Drawing.Font("Nunito", 14F);
            this.tComment.Properties.Appearance.Options.UseFont = true;
            this.tComment.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.tComment.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tComment.Size = new System.Drawing.Size(724, 230);
            this.tComment.TabIndex = 10;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Calibri", 14F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseTextOptions = true;
            this.labelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl2.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
            this.labelControl2.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelControl2.Location = new System.Drawing.Point(2, 2);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(0);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(724, 36);
            this.labelControl2.TabIndex = 9;
            // 
            // userFooter_Save1
            // 
            this.userFooter_Save1.Appearance.BackColor = System.Drawing.Color.White;
            this.userFooter_Save1.Appearance.Options.UseBackColor = true;
            this.userFooter_Save1.CancelVisible = true;
            this.userFooter_Save1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.userFooter_Save1.Location = new System.Drawing.Point(0, 675);
            this.userFooter_Save1.Name = "userFooter_Save1";
            this.userFooter_Save1.SaveButtonText = "Yadda saxla";
            this.userFooter_Save1.Size = new System.Drawing.Size(728, 53);
            this.userFooter_Save1.TabIndex = 2;
            this.userFooter_Save1.SaveClick += new System.EventHandler(this.userFooter_Save1_SaveClick);
            // 
            // panelControl4
            // 
            this.panelControl4.Controls.Add(this.labelControl3);
            this.panelControl4.Controls.Add(this.tFilePath);
            this.panelControl4.Controls.Add(this.bUpload);
            this.panelControl4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl4.Location = new System.Drawing.Point(0, 560);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(728, 86);
            this.panelControl4.TabIndex = 1;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Calibri", 12F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseTextOptions = true;
            this.labelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl3.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
            this.labelControl3.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.labelControl3.Location = new System.Drawing.Point(12, 9);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(0);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(69, 19);
            this.labelControl3.TabIndex = 9;
            this.labelControl3.Text = "Faylın yolu";
            // 
            // tFilePath
            // 
            this.tFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tFilePath.Location = new System.Drawing.Point(12, 31);
            this.tFilePath.Name = "tFilePath";
            this.tFilePath.Properties.AllowFocused = false;
            this.tFilePath.Properties.Appearance.Font = new System.Drawing.Font("Nunito", 14F);
            this.tFilePath.Properties.Appearance.Options.UseFont = true;
            this.tFilePath.Properties.Appearance.Options.UseTextOptions = true;
            this.tFilePath.Properties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
            this.tFilePath.Properties.ReadOnly = true;
            this.tFilePath.Size = new System.Drawing.Size(524, 32);
            this.tFilePath.TabIndex = 12;
            this.tFilePath.TabStop = false;
            // 
            // bUpload
            // 
            this.bUpload.AllowFocus = false;
            this.bUpload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bUpload.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bUpload.Appearance.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Bold);
            this.bUpload.Appearance.ForeColor = System.Drawing.Color.Black;
            this.bUpload.Appearance.Options.UseBorderColor = true;
            this.bUpload.Appearance.Options.UseFont = true;
            this.bUpload.Appearance.Options.UseForeColor = true;
            this.bUpload.Appearance.Options.UseTextOptions = true;
            this.bUpload.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bUpload.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
            this.bUpload.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.bUpload.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(131)))), ((int)(((byte)(131)))));
            this.bUpload.AppearanceHovered.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(131)))), ((int)(((byte)(131)))));
            this.bUpload.AppearanceHovered.Options.UseBackColor = true;
            this.bUpload.Location = new System.Drawing.Point(558, 31);
            this.bUpload.LookAndFeel.SkinName = "Office 2019 White";
            this.bUpload.LookAndFeel.UseDefaultLookAndFeel = false;
            this.bUpload.Name = "bUpload";
            this.bUpload.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.bUpload.Size = new System.Drawing.Size(158, 32);
            this.bUpload.TabIndex = 11;
            this.bUpload.TabStop = false;
            this.bUpload.Text = "Fayl yüklə";
            this.bUpload.Click += new System.EventHandler(this.bUpload_Click);
            // 
            // fComments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(728, 728);
            this.Controls.Add(this.panelControl4);
            this.Controls.Add(this.panelControl3);
            this.Controls.Add(this.userFooter_Save1);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.LookAndFeel.SkinName = "Office 2019 White";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(730, 760);
            this.MinimumSize = new System.Drawing.Size(730, 760);
            this.Name = "fComments";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.fComments_FormClosed);
            this.Load += new System.EventHandler(this.fComments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tHeader.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tComment.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            this.panelControl4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tFilePath.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.MemoEdit tHeader;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.ComboBox cmbType;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.MemoEdit tComment;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private UserControls.userFooter_Save userFooter_Save1;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private DevExpress.XtraEditors.SimpleButton bUpload;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit tFilePath;
    }
}