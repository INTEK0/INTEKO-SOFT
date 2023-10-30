﻿
namespace İNTEKO.UserControls
{
    partial class MessageForm
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
            this.components = new System.ComponentModel.Container();
            this.lMessage = new DevExpress.XtraEditors.LabelControl();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureImage = new DevExpress.XtraEditors.PictureEdit();
            this.toolsBorderRadius1 = new İNTEKO.UserControls.ToolsBorderRadius();
            ((System.ComponentModel.ISupportInitialize)(this.pictureImage.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lMessage
            // 
            this.lMessage.Appearance.Font = new System.Drawing.Font("Nunito", 12F);
            this.lMessage.Appearance.ForeColor = System.Drawing.Color.White;
            this.lMessage.Appearance.Options.UseFont = true;
            this.lMessage.Appearance.Options.UseForeColor = true;
            this.lMessage.Appearance.Options.UseTextOptions = true;
            this.lMessage.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.lMessage.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
            this.lMessage.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.lMessage.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lMessage.Location = new System.Drawing.Point(50, 0);
            this.lMessage.Name = "lMessage";
            this.lMessage.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lMessage.Size = new System.Drawing.Size(350, 80);
            this.lMessage.TabIndex = 0;
            this.lMessage.Text = "Message";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureImage
            // 
            this.pictureImage.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureImage.EditValue = global::İNTEKO.UserControls.Properties.Resources.x_bold;
            this.pictureImage.Location = new System.Drawing.Point(0, 0);
            this.pictureImage.Name = "pictureImage";
            this.pictureImage.Properties.AllowFocused = false;
            this.pictureImage.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureImage.Properties.Appearance.Font = new System.Drawing.Font("Nunito", 10F);
            this.pictureImage.Properties.Appearance.Options.UseBackColor = true;
            this.pictureImage.Properties.Appearance.Options.UseFont = true;
            this.pictureImage.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureImage.Properties.NullText = "NO IMAGE";
            this.pictureImage.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureImage.Properties.ShowMenu = false;
            this.pictureImage.Size = new System.Drawing.Size(50, 80);
            this.pictureImage.TabIndex = 1;
            // 
            // toolsBorderRadius1
            // 
            this.toolsBorderRadius1.CornerRadius = 15;
            this.toolsBorderRadius1.TargetControl = this;
            // 
            // MessageForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(400, 80);
            this.ControlBox = false;
            this.Controls.Add(this.lMessage);
            this.Controls.Add(this.pictureImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MessageForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.pictureImage.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lMessage;
        private System.Windows.Forms.Timer timer1;
        private DevExpress.XtraEditors.PictureEdit pictureImage;
        private ToolsBorderRadius toolsBorderRadius1;
    }
}