
namespace İNTEKO
{
    partial class fExpenses
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.bNewCategory = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.tHeader = new DevExpress.XtraEditors.TextEdit();
            this.dateTarix = new DevExpress.XtraEditors.DateEdit();
            this.cmbPaymentType = new System.Windows.Forms.ComboBox();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.tComment = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.userFooter_Save1 = new İNTEKO.UserControls.userFooter_Save();
            this.lStatus = new DevExpress.XtraEditors.LabelControl();
            this.lProccesNo = new DevExpress.XtraEditors.LabelControl();
            this.tTotal = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tHeader.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTarix.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTarix.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tComment.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTotal.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Appearance.BackColor = System.Drawing.Color.White;
            this.groupControl1.Appearance.Options.UseBackColor = true;
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.AppearanceCaption.Options.UseTextOptions = true;
            this.groupControl1.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.groupControl1.Controls.Add(this.tTotal);
            this.groupControl1.Controls.Add(this.bNewCategory);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.tHeader);
            this.groupControl1.Controls.Add(this.dateTarix);
            this.groupControl1.Controls.Add(this.cmbPaymentType);
            this.groupControl1.Controls.Add(this.cmbCategory);
            this.groupControl1.Controls.Add(this.tComment);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            this.groupControl1.Location = new System.Drawing.Point(5, 26);
            this.groupControl1.LookAndFeel.SkinName = "Office 2019 White";
            this.groupControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.ShowCaption = false;
            this.groupControl1.Size = new System.Drawing.Size(686, 295);
            this.groupControl1.TabIndex = 33;
            this.groupControl1.Text = "XƏRCLƏR";
            // 
            // bNewCategory
            // 
            this.bNewCategory.AllowFocus = false;
            this.bNewCategory.Appearance.BorderColor = System.Drawing.SystemColors.Window;
            this.bNewCategory.Appearance.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bNewCategory.Appearance.Options.UseBorderColor = true;
            this.bNewCategory.Appearance.Options.UseFont = true;
            this.bNewCategory.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(131)))), ((int)(((byte)(131)))));
            this.bNewCategory.AppearanceHovered.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(131)))), ((int)(((byte)(131)))));
            this.bNewCategory.AppearanceHovered.Options.UseBackColor = true;
            this.bNewCategory.Location = new System.Drawing.Point(541, 50);
            this.bNewCategory.LookAndFeel.SkinName = "Office 2019 White";
            this.bNewCategory.LookAndFeel.UseDefaultLookAndFeel = false;
            this.bNewCategory.Margin = new System.Windows.Forms.Padding(0);
            this.bNewCategory.Name = "bNewCategory";
            this.bNewCategory.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.bNewCategory.Size = new System.Drawing.Size(140, 30);
            this.bNewCategory.TabIndex = 31;
            this.bNewCategory.TabStop = false;
            this.bNewCategory.Text = "Yeni kateqoriya";
            this.bNewCategory.Click += new System.EventHandler(this.bNewCategory_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Nunito", 12F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(8, 18);
            this.labelControl2.LookAndFeel.SkinName = "DevExpress Style";
            this.labelControl2.LookAndFeel.UseDefaultLookAndFeel = false;
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(45, 22);
            this.labelControl2.TabIndex = 30;
            this.labelControl2.Text = "Başlıq";
            // 
            // tHeader
            // 
            this.tHeader.Location = new System.Drawing.Point(186, 12);
            this.tHeader.Name = "tHeader";
            this.tHeader.Properties.Appearance.Font = new System.Drawing.Font("Nunito", 14F);
            this.tHeader.Properties.Appearance.Options.UseFont = true;
            this.tHeader.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tHeader.Properties.LookAndFeel.SkinName = "Office 2019 White";
            this.tHeader.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.tHeader.Size = new System.Drawing.Size(495, 32);
            this.tHeader.TabIndex = 0;
            // 
            // dateTarix
            // 
            this.dateTarix.EditValue = null;
            this.dateTarix.Location = new System.Drawing.Point(186, 124);
            this.dateTarix.Name = "dateTarix";
            this.dateTarix.Properties.AllowFocused = false;
            this.dateTarix.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.dateTarix.Properties.Appearance.Font = new System.Drawing.Font("Nunito", 14F);
            this.dateTarix.Properties.Appearance.Options.UseFont = true;
            this.dateTarix.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateTarix.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateTarix.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Fluent;
            this.dateTarix.Properties.LookAndFeel.SkinMaskColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dateTarix.Properties.LookAndFeel.SkinName = "The Bezier";
            this.dateTarix.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.dateTarix.Properties.ShowToday = false;
            this.dateTarix.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.dateTarix.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.False;
            this.dateTarix.Size = new System.Drawing.Size(495, 32);
            this.dateTarix.TabIndex = 4;
            // 
            // cmbPaymentType
            // 
            this.cmbPaymentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPaymentType.Font = new System.Drawing.Font("Nunito", 13F);
            this.cmbPaymentType.FormattingEnabled = true;
            this.cmbPaymentType.Location = new System.Drawing.Point(541, 87);
            this.cmbPaymentType.Name = "cmbPaymentType";
            this.cmbPaymentType.Size = new System.Drawing.Size(140, 31);
            this.cmbPaymentType.TabIndex = 3;
            this.cmbPaymentType.TabStop = false;
            // 
            // cmbCategory
            // 
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.Font = new System.Drawing.Font("Nunito", 12F);
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(186, 50);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(349, 30);
            this.cmbCategory.TabIndex = 1;
            this.cmbCategory.TabStop = false;
            // 
            // tComment
            // 
            this.tComment.Location = new System.Drawing.Point(186, 162);
            this.tComment.Name = "tComment";
            this.tComment.Properties.Appearance.Font = new System.Drawing.Font("Nunito", 14F);
            this.tComment.Properties.Appearance.Options.UseFont = true;
            this.tComment.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tComment.Size = new System.Drawing.Size(495, 123);
            this.tComment.TabIndex = 5;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Nunito", 12F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(8, 92);
            this.labelControl3.LookAndFeel.SkinName = "DevExpress Style";
            this.labelControl3.LookAndFeel.UseDefaultLookAndFeel = false;
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(55, 22);
            this.labelControl3.TabIndex = 26;
            this.labelControl3.Text = "Məbləğ";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Nunito", 12F);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(8, 55);
            this.labelControl4.LookAndFeel.SkinName = "DevExpress Style";
            this.labelControl4.LookAndFeel.UseDefaultLookAndFeel = false;
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(77, 22);
            this.labelControl4.TabIndex = 26;
            this.labelControl4.Text = "Kateqoriya";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Nunito", 12F);
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(8, 130);
            this.labelControl9.LookAndFeel.SkinName = "DevExpress Style";
            this.labelControl9.LookAndFeel.UseDefaultLookAndFeel = false;
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(36, 22);
            this.labelControl9.TabIndex = 26;
            this.labelControl9.Text = "Tarix";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Nunito", 12F);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(8, 213);
            this.labelControl5.LookAndFeel.SkinName = "DevExpress Style";
            this.labelControl5.LookAndFeel.UseDefaultLookAndFeel = false;
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(38, 22);
            this.labelControl5.TabIndex = 26;
            this.labelControl5.Text = "Qeyd";
            // 
            // userFooter_Save1
            // 
            this.userFooter_Save1.Appearance.BackColor = System.Drawing.Color.White;
            this.userFooter_Save1.Appearance.Options.UseBackColor = true;
            this.userFooter_Save1.CancelVisible = true;
            this.userFooter_Save1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.userFooter_Save1.Location = new System.Drawing.Point(0, 340);
            this.userFooter_Save1.Name = "userFooter_Save1";
            this.userFooter_Save1.SaveButtonText = "Yadda saxla";
            this.userFooter_Save1.Size = new System.Drawing.Size(698, 53);
            this.userFooter_Save1.TabIndex = 34;
            this.userFooter_Save1.SaveClick += new System.EventHandler(this.userFooter_Save1_SaveClick);
            // 
            // lStatus
            // 
            this.lStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lStatus.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.lStatus.Appearance.Font = new System.Drawing.Font("Nunito", 14F, System.Drawing.FontStyle.Bold);
            this.lStatus.Appearance.ForeColor = System.Drawing.Color.White;
            this.lStatus.Appearance.Options.UseBackColor = true;
            this.lStatus.Appearance.Options.UseFont = true;
            this.lStatus.Appearance.Options.UseForeColor = true;
            this.lStatus.Location = new System.Drawing.Point(12, 355);
            this.lStatus.LookAndFeel.SkinName = "DevExpress Style";
            this.lStatus.LookAndFeel.UseDefaultLookAndFeel = false;
            this.lStatus.Name = "lStatus";
            this.lStatus.Size = new System.Drawing.Size(102, 26);
            this.lStatus.TabIndex = 36;
            this.lStatus.Text = " ÖDƏNİLİB ";
            this.lStatus.Visible = false;
            // 
            // lProccesNo
            // 
            this.lProccesNo.Appearance.Font = new System.Drawing.Font("Nunito", 12F);
            this.lProccesNo.Appearance.Options.UseFont = true;
            this.lProccesNo.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lProccesNo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lProccesNo.Location = new System.Drawing.Point(0, 0);
            this.lProccesNo.LookAndFeel.SkinName = "DevExpress Style";
            this.lProccesNo.LookAndFeel.UseDefaultLookAndFeel = false;
            this.lProccesNo.Name = "lProccesNo";
            this.lProccesNo.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lProccesNo.Size = new System.Drawing.Size(698, 20);
            this.lProccesNo.TabIndex = 26;
            this.lProccesNo.Text = "Əməliyyat № :";
            // 
            // tTotal
            // 
            this.tTotal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tTotal.EditValue = "";
            this.tTotal.Location = new System.Drawing.Point(186, 86);
            this.tTotal.Name = "tTotal";
            this.tTotal.Properties.Appearance.Font = new System.Drawing.Font("Nunito", 14F);
            this.tTotal.Properties.Appearance.Options.UseFont = true;
            this.tTotal.Properties.Appearance.Options.UseTextOptions = true;
            this.tTotal.Properties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
            this.tTotal.Properties.DisplayFormat.FormatString = "N2";
            this.tTotal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.tTotal.Properties.Mask.EditMask = "c";
            this.tTotal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.tTotal.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.tTotal.Size = new System.Drawing.Size(349, 32);
            this.tTotal.TabIndex = 32;
            // 
            // fExpenses
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(698, 393);
            this.Controls.Add(this.lStatus);
            this.Controls.Add(this.userFooter_Save1);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.lProccesNo);
            this.LookAndFeel.SkinName = "Office 2019 White";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(700, 425);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(700, 425);
            this.Name = "fExpenses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.fExpenses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tHeader.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTarix.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTarix.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tComment.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTotal.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.MemoEdit tComment;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.DateEdit dateTarix;
        private System.Windows.Forms.ComboBox cmbCategory;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit tHeader;
        private System.Windows.Forms.ComboBox cmbPaymentType;
        public DevExpress.XtraEditors.SimpleButton bNewCategory;
        private UserControls.userFooter_Save userFooter_Save1;
        private DevExpress.XtraEditors.LabelControl lStatus;
        private DevExpress.XtraEditors.LabelControl lProccesNo;
        private DevExpress.XtraEditors.TextEdit tTotal;
    }
}