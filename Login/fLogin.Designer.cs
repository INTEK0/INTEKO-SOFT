
namespace İNTEKO.Login
{
    partial class fLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fLogin));
            this.toolsBorderRadius1 = new İNTEKO.UserControls.ToolsBorderRadius();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.tPassword = new DevExpress.XtraEditors.TextEdit();
            this.bLogin = new DevExpress.XtraEditors.SimpleButton();
            this.cmbUsername = new System.Windows.Forms.ComboBox();
            this.labelControl15 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            this.lVersion = new DevExpress.XtraEditors.LabelControl();
            this.bExit = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolsBorderRadius1
            // 
            this.toolsBorderRadius1.CornerRadius = 40;
            this.toolsBorderRadius1.TargetControl = this;
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(0, 0);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.AllowFocused = false;
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.Padding = new System.Windows.Forms.Padding(0, 35, 0, 0);
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.ShowMenu = false;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.pictureEdit1.Size = new System.Drawing.Size(393, 98);
            this.pictureEdit1.TabIndex = 0;
            // 
            // tPassword
            // 
            this.tPassword.Location = new System.Drawing.Point(24, 247);
            this.tPassword.Name = "tPassword";
            this.tPassword.Properties.Appearance.Font = new System.Drawing.Font("Nunito", 18F);
            this.tPassword.Properties.Appearance.Options.UseFont = true;
            this.tPassword.Properties.UseSystemPasswordChar = true;
            this.tPassword.Size = new System.Drawing.Size(344, 40);
            this.tPassword.TabIndex = 24;
            this.tPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tPassword_KeyDown);
            // 
            // bLogin
            // 
            this.bLogin.AllowFocus = false;
            this.bLogin.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.bLogin.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bLogin.Appearance.Font = new System.Drawing.Font("Nunito", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bLogin.Appearance.Options.UseBackColor = true;
            this.bLogin.Appearance.Options.UseBorderColor = true;
            this.bLogin.Appearance.Options.UseFont = true;
            this.bLogin.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(131)))), ((int)(((byte)(131)))));
            this.bLogin.AppearanceHovered.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(131)))), ((int)(((byte)(131)))));
            this.bLogin.AppearanceHovered.Options.UseBackColor = true;
            this.bLogin.Location = new System.Drawing.Point(24, 301);
            this.bLogin.LookAndFeel.SkinName = "DevExpress Style";
            this.bLogin.LookAndFeel.UseDefaultLookAndFeel = false;
            this.bLogin.Name = "bLogin";
            this.bLogin.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.bLogin.Size = new System.Drawing.Size(344, 46);
            this.bLogin.TabIndex = 25;
            this.bLogin.TabStop = false;
            this.bLogin.Text = "DAXİL OL";
            this.bLogin.Click += new System.EventHandler(this.bLogin_Click);
            // 
            // cmbUsername
            // 
            this.cmbUsername.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUsername.Font = new System.Drawing.Font("Nunito", 18F);
            this.cmbUsername.FormattingEnabled = true;
            this.cmbUsername.Location = new System.Drawing.Point(24, 168);
            this.cmbUsername.Name = "cmbUsername";
            this.cmbUsername.Size = new System.Drawing.Size(344, 41);
            this.cmbUsername.TabIndex = 26;
            this.cmbUsername.TabStop = false;
            // 
            // labelControl15
            // 
            this.labelControl15.Appearance.Font = new System.Drawing.Font("Nunito", 14F);
            this.labelControl15.Appearance.Options.UseFont = true;
            this.labelControl15.Location = new System.Drawing.Point(24, 136);
            this.labelControl15.Name = "labelControl15";
            this.labelControl15.Size = new System.Drawing.Size(105, 26);
            this.labelControl15.TabIndex = 27;
            this.labelControl15.Text = "İstifadəçi adı";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Nunito", 14F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(24, 215);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(39, 26);
            this.labelControl1.TabIndex = 27;
            this.labelControl1.Text = "Şifrə";
            // 
            // separatorControl1
            // 
            this.separatorControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.separatorControl1.Location = new System.Drawing.Point(0, 98);
            this.separatorControl1.Name = "separatorControl1";
            this.separatorControl1.Padding = new System.Windows.Forms.Padding(0);
            this.separatorControl1.Size = new System.Drawing.Size(393, 26);
            this.separatorControl1.TabIndex = 28;
            // 
            // lVersion
            // 
            this.lVersion.Appearance.Font = new System.Drawing.Font("Nunito", 14F);
            this.lVersion.Appearance.Options.UseFont = true;
            this.lVersion.Appearance.Options.UseTextOptions = true;
            this.lVersion.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lVersion.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lVersion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lVersion.Location = new System.Drawing.Point(0, 425);
            this.lVersion.Name = "lVersion";
            this.lVersion.Size = new System.Drawing.Size(393, 36);
            this.lVersion.TabIndex = 27;
            this.lVersion.Text = "V";
            // 
            // bExit
            // 
            this.bExit.AllowFocus = false;
            this.bExit.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(65)))), ((int)(((byte)(24)))));
            this.bExit.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bExit.Appearance.Font = new System.Drawing.Font("Nunito", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bExit.Appearance.Options.UseBackColor = true;
            this.bExit.Appearance.Options.UseBorderColor = true;
            this.bExit.Appearance.Options.UseFont = true;
            this.bExit.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(131)))), ((int)(((byte)(131)))));
            this.bExit.AppearanceHovered.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(131)))), ((int)(((byte)(131)))));
            this.bExit.AppearanceHovered.Options.UseBackColor = true;
            this.bExit.Location = new System.Drawing.Point(24, 353);
            this.bExit.LookAndFeel.SkinName = "DevExpress Style";
            this.bExit.LookAndFeel.UseDefaultLookAndFeel = false;
            this.bExit.Name = "bExit";
            this.bExit.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.bExit.Size = new System.Drawing.Size(344, 46);
            this.bExit.TabIndex = 25;
            this.bExit.TabStop = false;
            this.bExit.Text = "ÇIXIŞ";
            this.bExit.Click += new System.EventHandler(this.bExit_Click);
            // 
            // fLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(393, 461);
            this.Controls.Add(this.separatorControl1);
            this.Controls.Add(this.lVersion);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.labelControl15);
            this.Controls.Add(this.cmbUsername);
            this.Controls.Add(this.bExit);
            this.Controls.Add(this.bLogin);
            this.Controls.Add(this.tPassword);
            this.Controls.Add(this.pictureEdit1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş";
            this.Load += new System.EventHandler(this.fLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.ToolsBorderRadius toolsBorderRadius1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.TextEdit tPassword;
        public DevExpress.XtraEditors.SimpleButton bLogin;
        private System.Windows.Forms.ComboBox cmbUsername;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl15;
        private DevExpress.XtraEditors.SeparatorControl separatorControl1;
        private DevExpress.XtraEditors.LabelControl lVersion;
        public DevExpress.XtraEditors.SimpleButton bExit;
    }
}