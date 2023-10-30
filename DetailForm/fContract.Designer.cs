
namespace İNTEKO.DetailForm
{
    partial class fContract
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
            this.tContractPath = new DevExpress.XtraEditors.TextEdit();
            this.labelControl21 = new DevExpress.XtraEditors.LabelControl();
            this.bFileBrowse = new DevExpress.XtraEditors.SimpleButton();
            this.bSave = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.tContractPath.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tContractPath
            // 
            this.tContractPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tContractPath.Enabled = false;
            this.tContractPath.Location = new System.Drawing.Point(12, 40);
            this.tContractPath.Name = "tContractPath";
            this.tContractPath.Properties.Appearance.Font = new System.Drawing.Font("Nunito", 12F);
            this.tContractPath.Properties.Appearance.Options.UseFont = true;
            this.tContractPath.Properties.Appearance.Options.UseTextOptions = true;
            this.tContractPath.Properties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
            this.tContractPath.Size = new System.Drawing.Size(380, 28);
            this.tContractPath.TabIndex = 7;
            // 
            // labelControl21
            // 
            this.labelControl21.Appearance.Font = new System.Drawing.Font("Nunito", 12F);
            this.labelControl21.Appearance.Options.UseFont = true;
            this.labelControl21.Location = new System.Drawing.Point(12, 12);
            this.labelControl21.Name = "labelControl21";
            this.labelControl21.Size = new System.Drawing.Size(65, 22);
            this.labelControl21.TabIndex = 6;
            this.labelControl21.Text = "Fayl yolu";
            // 
            // bFileBrowse
            // 
            this.bFileBrowse.AllowFocus = false;
            this.bFileBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bFileBrowse.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bFileBrowse.Appearance.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bFileBrowse.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.bFileBrowse.Appearance.Options.UseBorderColor = true;
            this.bFileBrowse.Appearance.Options.UseFont = true;
            this.bFileBrowse.Appearance.Options.UseForeColor = true;
            this.bFileBrowse.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(131)))), ((int)(((byte)(131)))));
            this.bFileBrowse.AppearanceHovered.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(131)))), ((int)(((byte)(131)))));
            this.bFileBrowse.AppearanceHovered.Options.UseBackColor = true;
            this.bFileBrowse.Location = new System.Drawing.Point(398, 40);
            this.bFileBrowse.LookAndFeel.SkinName = "Office 2019 White";
            this.bFileBrowse.LookAndFeel.UseDefaultLookAndFeel = false;
            this.bFileBrowse.Name = "bFileBrowse";
            this.bFileBrowse.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.bFileBrowse.Size = new System.Drawing.Size(88, 28);
            this.bFileBrowse.TabIndex = 8;
            this.bFileBrowse.TabStop = false;
            this.bFileBrowse.Text = "Fayl seç";
            this.bFileBrowse.Click += new System.EventHandler(this.bFileBrowse_Click);
            // 
            // bSave
            // 
            this.bSave.AllowFocus = false;
            this.bSave.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bSave.Appearance.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSave.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.bSave.Appearance.Options.UseBorderColor = true;
            this.bSave.Appearance.Options.UseFont = true;
            this.bSave.Appearance.Options.UseForeColor = true;
            this.bSave.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(131)))), ((int)(((byte)(131)))));
            this.bSave.AppearanceHovered.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(131)))), ((int)(((byte)(131)))));
            this.bSave.AppearanceHovered.Options.UseBackColor = true;
            this.bSave.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bSave.Location = new System.Drawing.Point(0, 83);
            this.bSave.LookAndFeel.SkinName = "Office 2019 White";
            this.bSave.LookAndFeel.UseDefaultLookAndFeel = false;
            this.bSave.Name = "bSave";
            this.bSave.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.bSave.Size = new System.Drawing.Size(498, 35);
            this.bSave.TabIndex = 9;
            this.bSave.TabStop = false;
            this.bSave.Text = "Yadda saxla";
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // fContract
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(498, 118);
            this.Controls.Add(this.bSave);
            this.Controls.Add(this.bFileBrowse);
            this.Controls.Add(this.tContractPath);
            this.Controls.Add(this.labelControl21);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(500, 150);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(500, 150);
            this.Name = "fContract";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fContract";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.tContractPath.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit tContractPath;
        private DevExpress.XtraEditors.LabelControl labelControl21;
        public DevExpress.XtraEditors.SimpleButton bFileBrowse;
        public DevExpress.XtraEditors.SimpleButton bSave;
    }
}