
namespace İNTEKO.UserControls
{
    partial class userControlSubMenu
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(userControlSubMenu));
            this.bClose = new DevExpress.XtraEditors.SimpleButton();
            this.bSave = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // bClose
            // 
            this.bClose.AllowFocus = false;
            this.bClose.Appearance.Font = new System.Drawing.Font("Nunito ExtraBold", 16F, System.Drawing.FontStyle.Bold);
            this.bClose.Appearance.Options.UseFont = true;
            this.bClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.bClose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bClose.ImageOptions.Image")));
            this.bClose.Location = new System.Drawing.Point(507, 0);
            this.bClose.Margin = new System.Windows.Forms.Padding(0);
            this.bClose.Name = "bClose";
            this.bClose.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.bClose.Size = new System.Drawing.Size(180, 80);
            this.bClose.TabIndex = 9;
            this.bClose.Text = "Bağla";
            this.bClose.Click += new System.EventHandler(this.bClose_Click);
            // 
            // bSave
            // 
            this.bSave.AllowFocus = false;
            this.bSave.Appearance.Font = new System.Drawing.Font("Nunito ExtraBold", 16F, System.Drawing.FontStyle.Bold);
            this.bSave.Appearance.Options.UseFont = true;
            this.bSave.Dock = System.Windows.Forms.DockStyle.Right;
            this.bSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bSave.ImageOptions.Image")));
            this.bSave.Location = new System.Drawing.Point(687, 0);
            this.bSave.Margin = new System.Windows.Forms.Padding(0);
            this.bSave.Name = "bSave";
            this.bSave.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.bSave.Size = new System.Drawing.Size(193, 80);
            this.bSave.TabIndex = 5;
            this.bSave.Text = "Yadda Saxla";
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // userControlSubMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bClose);
            this.Controls.Add(this.bSave);
            this.LookAndFeel.SkinName = "Office 2019 White";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "userControlSubMenu";
            this.Size = new System.Drawing.Size(880, 80);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton bClose;
        private DevExpress.XtraEditors.SimpleButton bSave;
    }
}
