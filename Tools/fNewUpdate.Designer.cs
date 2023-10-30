
namespace İNTEKO.Tools
{
    partial class fNewUpdate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fNewUpdate));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.picLogo = new DevExpress.XtraEditors.PictureEdit();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.bYes = new DevExpress.XtraEditors.SimpleButton();
            this.bNo = new DevExpress.XtraEditors.SimpleButton();
            this.lNewVersion = new DevExpress.XtraEditors.LabelControl();
            this.lOldVersion = new DevExpress.XtraEditors.LabelControl();
            this.toolsBorderRadius1 = new İNTEKO.UserControls.ToolsBorderRadius();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Nunito", 12F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(29, 148);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(248, 44);
            this.labelControl1.TabIndex = 14;
            this.labelControl1.Text = "Yeni versiyamız mövcuddur  😇 \r\nYükləməni indi etmək istəyirsiniz ?";
            // 
            // picLogo
            // 
            this.picLogo.EditValue = ((object)(resources.GetObject("picLogo.EditValue")));
            this.picLogo.Location = new System.Drawing.Point(-7, 2);
            this.picLogo.Name = "picLogo";
            this.picLogo.Properties.AllowFocused = false;
            this.picLogo.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.picLogo.Properties.Appearance.Options.UseBackColor = true;
            this.picLogo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.picLogo.Properties.NullText = " ";
            this.picLogo.Properties.ShowMenu = false;
            this.picLogo.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.picLogo.Size = new System.Drawing.Size(298, 85);
            this.picLogo.TabIndex = 12;
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(430, 0);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.AllowFocused = false;
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.ShowMenu = false;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.pictureEdit1.Size = new System.Drawing.Size(350, 380);
            this.pictureEdit1.TabIndex = 11;
            // 
            // bYes
            // 
            this.bYes.AllowFocus = false;
            this.bYes.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(191)))), ((int)(((byte)(107)))));
            this.bYes.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bYes.Appearance.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Bold);
            this.bYes.Appearance.Options.UseBackColor = true;
            this.bYes.Appearance.Options.UseBorderColor = true;
            this.bYes.Appearance.Options.UseFont = true;
            this.bYes.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(131)))), ((int)(((byte)(131)))));
            this.bYes.AppearanceHovered.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(131)))), ((int)(((byte)(131)))));
            this.bYes.AppearanceHovered.Options.UseBackColor = true;
            this.bYes.Location = new System.Drawing.Point(36, 210);
            this.bYes.LookAndFeel.SkinName = "The Bezier";
            this.bYes.LookAndFeel.UseDefaultLookAndFeel = false;
            this.bYes.Name = "bYes";
            this.bYes.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.bYes.Size = new System.Drawing.Size(108, 30);
            this.bYes.TabIndex = 26;
            this.bYes.TabStop = false;
            this.bYes.Text = "Bəli";
            this.bYes.Click += new System.EventHandler(this.bYes_Click);
            // 
            // bNo
            // 
            this.bNo.AllowFocus = false;
            this.bNo.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.bNo.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bNo.Appearance.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Bold);
            this.bNo.Appearance.Options.UseBackColor = true;
            this.bNo.Appearance.Options.UseBorderColor = true;
            this.bNo.Appearance.Options.UseFont = true;
            this.bNo.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(131)))), ((int)(((byte)(131)))));
            this.bNo.AppearanceHovered.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(131)))), ((int)(((byte)(131)))));
            this.bNo.AppearanceHovered.Options.UseBackColor = true;
            this.bNo.Location = new System.Drawing.Point(153, 210);
            this.bNo.LookAndFeel.SkinName = "The Bezier";
            this.bNo.LookAndFeel.UseDefaultLookAndFeel = false;
            this.bNo.Name = "bNo";
            this.bNo.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.bNo.Size = new System.Drawing.Size(108, 30);
            this.bNo.TabIndex = 26;
            this.bNo.TabStop = false;
            this.bNo.Text = "Xeyr";
            this.bNo.Click += new System.EventHandler(this.bNo_Click);
            // 
            // lNewVersion
            // 
            this.lNewVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lNewVersion.Appearance.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Bold);
            this.lNewVersion.Appearance.Options.UseFont = true;
            this.lNewVersion.Location = new System.Drawing.Point(29, 305);
            this.lNewVersion.Name = "lNewVersion";
            this.lNewVersion.Size = new System.Drawing.Size(100, 22);
            this.lNewVersion.TabIndex = 14;
            this.lNewVersion.Text = "Yeni versiya  :";
            // 
            // lOldVersion
            // 
            this.lOldVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lOldVersion.Appearance.Font = new System.Drawing.Font("Nunito", 12F);
            this.lOldVersion.Appearance.Options.UseFont = true;
            this.lOldVersion.Location = new System.Drawing.Point(28, 333);
            this.lOldVersion.Name = "lOldVersion";
            this.lOldVersion.Size = new System.Drawing.Size(101, 22);
            this.lOldVersion.TabIndex = 14;
            this.lOldVersion.Text = "İndiki versiya :";
            // 
            // toolsBorderRadius1
            // 
            this.toolsBorderRadius1.CornerRadius = 20;
            this.toolsBorderRadius1.TargetControl = this;
            // 
            // fNewUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(780, 380);
            this.Controls.Add(this.bNo);
            this.Controls.Add(this.bYes);
            this.Controls.Add(this.lOldVersion);
            this.Controls.Add(this.lNewVersion);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.pictureEdit1);
            this.Font = new System.Drawing.Font("Nunito", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fNewUpdate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mesaj";
            this.Load += new System.EventHandler(this.fNewUpdate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.PictureEdit picLogo;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private UserControls.ToolsBorderRadius toolsBorderRadius1;
        public DevExpress.XtraEditors.SimpleButton bNo;
        public DevExpress.XtraEditors.SimpleButton bYes;
        private DevExpress.XtraEditors.LabelControl lOldVersion;
        private DevExpress.XtraEditors.LabelControl lNewVersion;
    }
}