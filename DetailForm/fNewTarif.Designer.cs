
namespace İNTEKO.DetailForm
{
    partial class fNewTarif
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
            this.groupFooter = new DevExpress.XtraEditors.GroupControl();
            this.bSave = new DevExpress.XtraEditors.SimpleButton();
            this.tOldTarif = new DevExpress.XtraEditors.TextEdit();
            this.tNewTarif = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.tContractNo = new DevExpress.XtraEditors.TextEdit();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.dateEdit = new DevExpress.XtraEditors.DateEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupFooter)).BeginInit();
            this.groupFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tOldTarif.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tNewTarif.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tContractNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupFooter
            // 
            this.groupFooter.AppearanceCaption.Font = new System.Drawing.Font("Nunito", 12F);
            this.groupFooter.AppearanceCaption.Options.UseFont = true;
            this.groupFooter.AppearanceCaption.Options.UseTextOptions = true;
            this.groupFooter.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.groupFooter.Controls.Add(this.bSave);
            this.groupFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupFooter.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            this.groupFooter.Location = new System.Drawing.Point(0, 196);
            this.groupFooter.LookAndFeel.SkinName = "Office 2019 White";
            this.groupFooter.LookAndFeel.UseDefaultLookAndFeel = false;
            this.groupFooter.Name = "groupFooter";
            this.groupFooter.Size = new System.Drawing.Size(565, 62);
            this.groupFooter.TabIndex = 7;
            // 
            // bSave
            // 
            this.bSave.AllowFocus = false;
            this.bSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bSave.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bSave.Appearance.Font = new System.Drawing.Font("Nunito", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSave.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(131)))), ((int)(((byte)(131)))));
            this.bSave.Appearance.Options.UseBorderColor = true;
            this.bSave.Appearance.Options.UseFont = true;
            this.bSave.Appearance.Options.UseForeColor = true;
            this.bSave.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(131)))), ((int)(((byte)(131)))));
            this.bSave.AppearanceHovered.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(131)))), ((int)(((byte)(131)))));
            this.bSave.AppearanceHovered.Options.UseBackColor = true;
            this.bSave.Location = new System.Drawing.Point(402, 17);
            this.bSave.LookAndFeel.SkinName = "Office 2019 White";
            this.bSave.LookAndFeel.UseDefaultLookAndFeel = false;
            this.bSave.Name = "bSave";
            this.bSave.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.bSave.Size = new System.Drawing.Size(151, 39);
            this.bSave.TabIndex = 0;
            this.bSave.TabStop = false;
            this.bSave.Text = "Yadda Saxla";
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // tOldTarif
            // 
            this.tOldTarif.EditValue = "";
            this.tOldTarif.Location = new System.Drawing.Point(298, 33);
            this.tOldTarif.Name = "tOldTarif";
            this.tOldTarif.Properties.Appearance.Font = new System.Drawing.Font("Nunito", 14F);
            this.tOldTarif.Properties.Appearance.Options.UseFont = true;
            this.tOldTarif.Properties.Appearance.Options.UseTextOptions = true;
            this.tOldTarif.Properties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
            this.tOldTarif.Properties.DisplayFormat.FormatString = "N2";
            this.tOldTarif.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.tOldTarif.Properties.Mask.EditMask = "c";
            this.tOldTarif.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.tOldTarif.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.tOldTarif.Size = new System.Drawing.Size(239, 32);
            this.tOldTarif.TabIndex = 0;
            this.tOldTarif.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ReqemYazdirma);
            // 
            // tNewTarif
            // 
            this.tNewTarif.EditValue = "";
            this.tNewTarif.Location = new System.Drawing.Point(298, 71);
            this.tNewTarif.Name = "tNewTarif";
            this.tNewTarif.Properties.Appearance.Font = new System.Drawing.Font("Nunito", 14F);
            this.tNewTarif.Properties.Appearance.Options.UseFont = true;
            this.tNewTarif.Properties.Appearance.Options.UseTextOptions = true;
            this.tNewTarif.Properties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
            this.tNewTarif.Properties.DisplayFormat.FormatString = "N2";
            this.tNewTarif.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.tNewTarif.Properties.Mask.EditMask = "c";
            this.tNewTarif.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.tNewTarif.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.tNewTarif.Size = new System.Drawing.Size(239, 32);
            this.tNewTarif.TabIndex = 1;
            this.tNewTarif.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ReqemYazdirma);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Nunito", 14F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(18, 36);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(99, 26);
            this.labelControl3.TabIndex = 9;
            this.labelControl3.Text = "Köhnə Tarif";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Nunito", 14F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(18, 74);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(80, 26);
            this.labelControl1.TabIndex = 9;
            this.labelControl1.Text = "Yeni Tarif";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Nunito", 14F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(18, 112);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(130, 26);
            this.labelControl2.TabIndex = 9;
            this.labelControl2.Text = "Dəyişiklik Tarixi";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Nunito", 14F);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(18, 150);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(103, 26);
            this.labelControl4.TabIndex = 9;
            this.labelControl4.Text = "Müqavilə №";
            // 
            // tContractNo
            // 
            this.tContractNo.Location = new System.Drawing.Point(298, 147);
            this.tContractNo.Name = "tContractNo";
            this.tContractNo.Properties.Appearance.Font = new System.Drawing.Font("Nunito", 14F);
            this.tContractNo.Properties.Appearance.Options.UseFont = true;
            this.tContractNo.Properties.Appearance.Options.UseTextOptions = true;
            this.tContractNo.Properties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
            this.tContractNo.Properties.ReadOnly = true;
            this.tContractNo.Size = new System.Drawing.Size(239, 32);
            this.tContractNo.TabIndex = 3;
            // 
            // groupControl3
            // 
            this.groupControl3.AppearanceCaption.Font = new System.Drawing.Font("Nunito", 12F);
            this.groupControl3.AppearanceCaption.Options.UseFont = true;
            this.groupControl3.AppearanceCaption.Options.UseTextOptions = true;
            this.groupControl3.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.groupControl3.Controls.Add(this.dateEdit);
            this.groupControl3.Controls.Add(this.tContractNo);
            this.groupControl3.Controls.Add(this.tOldTarif);
            this.groupControl3.Controls.Add(this.labelControl4);
            this.groupControl3.Controls.Add(this.tNewTarif);
            this.groupControl3.Controls.Add(this.labelControl1);
            this.groupControl3.Controls.Add(this.labelControl3);
            this.groupControl3.Controls.Add(this.labelControl2);
            this.groupControl3.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            this.groupControl3.Location = new System.Drawing.Point(9, 5);
            this.groupControl3.LookAndFeel.SkinName = "Office 2019 White";
            this.groupControl3.LookAndFeel.UseDefaultLookAndFeel = false;
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(548, 190);
            this.groupControl3.TabIndex = 11;
            this.groupControl3.Text = "Yeni qiymətləndirmə";
            // 
            // dateEdit
            // 
            this.dateEdit.EditValue = null;
            this.dateEdit.Location = new System.Drawing.Point(298, 109);
            this.dateEdit.Name = "dateEdit";
            this.dateEdit.Properties.AllowFocused = false;
            this.dateEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.dateEdit.Properties.Appearance.Font = new System.Drawing.Font("Nunito", 14F);
            this.dateEdit.Properties.Appearance.Options.UseFont = true;
            this.dateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit.Properties.LookAndFeel.SkinMaskColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dateEdit.Properties.LookAndFeel.SkinName = "The Bezier";
            this.dateEdit.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.dateEdit.Properties.ShowToday = false;
            this.dateEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.dateEdit.Size = new System.Drawing.Size(239, 32);
            this.dateEdit.TabIndex = 2;
            this.dateEdit.TabStop = false;
            // 
            // fNewTarif
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(565, 258);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupFooter);
            this.LookAndFeel.SkinName = "Office 2019 White";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(567, 290);
            this.MinimumSize = new System.Drawing.Size(567, 290);
            this.Name = "fNewTarif";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yeni qiymətləndirmə";
            this.Load += new System.EventHandler(this.fNewTarif_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupFooter)).EndInit();
            this.groupFooter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tOldTarif.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tNewTarif.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tContractNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public DevExpress.XtraEditors.GroupControl groupFooter;
        public DevExpress.XtraEditors.SimpleButton bSave;
        private DevExpress.XtraEditors.TextEdit tOldTarif;
        private DevExpress.XtraEditors.TextEdit tNewTarif;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit tContractNo;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.DateEdit dateEdit;
    }
}