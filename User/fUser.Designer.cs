
namespace İNTEKO.User
{
    partial class fUser
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
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.cmbUserRole = new System.Windows.Forms.ComboBox();
            this.labelControl16 = new DevExpress.XtraEditors.LabelControl();
            this.tPassword = new DevExpress.XtraEditors.TextEdit();
            this.tUsername = new DevExpress.XtraEditors.TextEdit();
            this.tNameSurname = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl17 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl5 = new DevExpress.XtraEditors.GroupControl();
            this.bSave = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tUsername.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tNameSurname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).BeginInit();
            this.groupControl5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl3
            // 
            this.groupControl3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl3.Appearance.BackColor = System.Drawing.Color.White;
            this.groupControl3.Appearance.Options.UseBackColor = true;
            this.groupControl3.AppearanceCaption.Font = new System.Drawing.Font("Nunito", 12F);
            this.groupControl3.AppearanceCaption.Options.UseFont = true;
            this.groupControl3.AppearanceCaption.Options.UseTextOptions = true;
            this.groupControl3.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.groupControl3.Controls.Add(this.cmbUserRole);
            this.groupControl3.Controls.Add(this.labelControl16);
            this.groupControl3.Controls.Add(this.tPassword);
            this.groupControl3.Controls.Add(this.tUsername);
            this.groupControl3.Controls.Add(this.tNameSurname);
            this.groupControl3.Controls.Add(this.labelControl1);
            this.groupControl3.Controls.Add(this.labelControl9);
            this.groupControl3.Controls.Add(this.labelControl17);
            this.groupControl3.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            this.groupControl3.Location = new System.Drawing.Point(12, 0);
            this.groupControl3.LookAndFeel.SkinName = "Office 2019 White";
            this.groupControl3.LookAndFeel.UseDefaultLookAndFeel = false;
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(525, 192);
            this.groupControl3.TabIndex = 14;
            this.groupControl3.Text = "İstifadəçi məlumatları";
            // 
            // cmbUserRole
            // 
            this.cmbUserRole.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbUserRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUserRole.Font = new System.Drawing.Font("Nunito", 14F);
            this.cmbUserRole.FormattingEnabled = true;
            this.cmbUserRole.Location = new System.Drawing.Point(194, 33);
            this.cmbUserRole.Name = "cmbUserRole";
            this.cmbUserRole.Size = new System.Drawing.Size(322, 34);
            this.cmbUserRole.TabIndex = 1;
            this.cmbUserRole.TabStop = false;
            this.cmbUserRole.SelectedValueChanged += new System.EventHandler(this.cmbUserRole_SelectedValueChanged);
            // 
            // labelControl16
            // 
            this.labelControl16.Appearance.Font = new System.Drawing.Font("Nunito", 14F);
            this.labelControl16.Appearance.Options.UseFont = true;
            this.labelControl16.Location = new System.Drawing.Point(8, 76);
            this.labelControl16.Name = "labelControl16";
            this.labelControl16.Size = new System.Drawing.Size(105, 26);
            this.labelControl16.TabIndex = 0;
            this.labelControl16.Text = "İstifadəçi adı";
            // 
            // tPassword
            // 
            this.tPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tPassword.Location = new System.Drawing.Point(194, 149);
            this.tPassword.Name = "tPassword";
            this.tPassword.Properties.AllowFocused = false;
            this.tPassword.Properties.Appearance.Font = new System.Drawing.Font("Nunito", 14F);
            this.tPassword.Properties.Appearance.Options.UseFont = true;
            this.tPassword.Properties.Appearance.Options.UseTextOptions = true;
            this.tPassword.Properties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
            this.tPassword.Properties.MaxLength = 50;
            this.tPassword.Properties.UseSystemPasswordChar = true;
            this.tPassword.Size = new System.Drawing.Size(322, 32);
            this.tPassword.TabIndex = 3;
            // 
            // tUsername
            // 
            this.tUsername.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tUsername.Location = new System.Drawing.Point(194, 73);
            this.tUsername.Name = "tUsername";
            this.tUsername.Properties.AllowFocused = false;
            this.tUsername.Properties.Appearance.Font = new System.Drawing.Font("Nunito", 14F);
            this.tUsername.Properties.Appearance.Options.UseFont = true;
            this.tUsername.Properties.Appearance.Options.UseTextOptions = true;
            this.tUsername.Properties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
            this.tUsername.Properties.MaxLength = 20;
            this.tUsername.Size = new System.Drawing.Size(322, 32);
            this.tUsername.TabIndex = 0;
            // 
            // tNameSurname
            // 
            this.tNameSurname.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tNameSurname.Location = new System.Drawing.Point(194, 111);
            this.tNameSurname.Name = "tNameSurname";
            this.tNameSurname.Properties.AllowFocused = false;
            this.tNameSurname.Properties.Appearance.Font = new System.Drawing.Font("Nunito", 14F);
            this.tNameSurname.Properties.Appearance.Options.UseFont = true;
            this.tNameSurname.Properties.Appearance.Options.UseTextOptions = true;
            this.tNameSurname.Properties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
            this.tNameSurname.Properties.MaxLength = 50;
            this.tNameSurname.Size = new System.Drawing.Size(322, 32);
            this.tNameSurname.TabIndex = 2;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Nunito", 14F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(8, 152);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(39, 26);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Şifrə";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Nunito", 14F);
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(8, 114);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(84, 26);
            this.labelControl9.TabIndex = 0;
            this.labelControl9.Text = "Ad Soyad";
            // 
            // labelControl17
            // 
            this.labelControl17.Appearance.Font = new System.Drawing.Font("Nunito", 14F);
            this.labelControl17.Appearance.Options.UseFont = true;
            this.labelControl17.Location = new System.Drawing.Point(8, 37);
            this.labelControl17.Name = "labelControl17";
            this.labelControl17.Size = new System.Drawing.Size(123, 26);
            this.labelControl17.TabIndex = 0;
            this.labelControl17.Text = "İstifadəçi növü";
            // 
            // groupControl5
            // 
            this.groupControl5.AppearanceCaption.Font = new System.Drawing.Font("Nunito", 12F);
            this.groupControl5.AppearanceCaption.Options.UseFont = true;
            this.groupControl5.AppearanceCaption.Options.UseTextOptions = true;
            this.groupControl5.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.groupControl5.Controls.Add(this.bSave);
            this.groupControl5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl5.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            this.groupControl5.Location = new System.Drawing.Point(0, 197);
            this.groupControl5.LookAndFeel.SkinName = "Office 2019 White";
            this.groupControl5.LookAndFeel.UseDefaultLookAndFeel = false;
            this.groupControl5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 3);
            this.groupControl5.Name = "groupControl5";
            this.groupControl5.Size = new System.Drawing.Size(549, 72);
            this.groupControl5.TabIndex = 17;
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
            this.bSave.Location = new System.Drawing.Point(354, 17);
            this.bSave.LookAndFeel.SkinName = "Office 2019 White";
            this.bSave.LookAndFeel.UseDefaultLookAndFeel = false;
            this.bSave.Name = "bSave";
            this.bSave.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.bSave.Size = new System.Drawing.Size(187, 48);
            this.bSave.TabIndex = 0;
            this.bSave.TabStop = false;
            this.bSave.Text = "Yadda saxla";
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // fUser
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(549, 269);
            this.Controls.Add(this.groupControl5);
            this.Controls.Add(this.groupControl3);
            this.Font = new System.Drawing.Font("Nunito", 12F);
            this.LookAndFeel.SkinName = "Office 2019 White";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "fUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "İstifadəçi Məlumatları";
            this.Load += new System.EventHandler(this.fUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tUsername.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tNameSurname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).EndInit();
            this.groupControl5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl3;
        private System.Windows.Forms.ComboBox cmbUserRole;
        private DevExpress.XtraEditors.TextEdit tNameSurname;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl16;
        private DevExpress.XtraEditors.LabelControl labelControl17;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit tPassword;
        private DevExpress.XtraEditors.GroupControl groupControl5;
        private DevExpress.XtraEditors.SimpleButton bSave;
        private DevExpress.XtraEditors.TextEdit tUsername;
    }
}