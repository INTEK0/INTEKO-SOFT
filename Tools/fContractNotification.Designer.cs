
namespace İNTEKO.Tools
{
    partial class fContractNotification
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
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            this.bNo = new DevExpress.XtraEditors.SimpleButton();
            this.bYes = new DevExpress.XtraEditors.SimpleButton();
            this.lMessage = new DevExpress.XtraEditors.LabelControl();
            this.toolsBorderRadius1 = new İNTEKO.UserControls.ToolsBorderRadius();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tablePanel1
            // 
            this.tablePanel1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.tablePanel1.Appearance.Options.UseBackColor = true;
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 100F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 100F)});
            this.tablePanel1.Controls.Add(this.bNo);
            this.tablePanel1.Controls.Add(this.bYes);
            this.tablePanel1.Controls.Add(this.lMessage);
            this.tablePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel1.Location = new System.Drawing.Point(0, 0);
            this.tablePanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 94F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.tablePanel1.Size = new System.Drawing.Size(660, 172);
            this.tablePanel1.TabIndex = 1;
            // 
            // bNo
            // 
            this.bNo.AllowFocus = false;
            this.bNo.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(59)))), ((int)(((byte)(90)))));
            this.bNo.Appearance.Font = new System.Drawing.Font("Nunito", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bNo.Appearance.ForeColor = System.Drawing.Color.White;
            this.bNo.Appearance.Options.UseBackColor = true;
            this.bNo.Appearance.Options.UseFont = true;
            this.bNo.Appearance.Options.UseForeColor = true;
            this.bNo.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(131)))), ((int)(((byte)(131)))));
            this.bNo.AppearanceHovered.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(131)))), ((int)(((byte)(131)))));
            this.bNo.AppearanceHovered.Options.UseBackColor = true;
            this.tablePanel1.SetColumn(this.bNo, 1);
            this.bNo.Location = new System.Drawing.Point(360, 109);
            this.bNo.LookAndFeel.SkinName = "Office 2019 White";
            this.bNo.LookAndFeel.UseDefaultLookAndFeel = false;
            this.bNo.Margin = new System.Windows.Forms.Padding(30, 15, 30, 15);
            this.bNo.Name = "bNo";
            this.tablePanel1.SetRow(this.bNo, 1);
            this.bNo.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.bNo.Size = new System.Drawing.Size(270, 48);
            this.bNo.TabIndex = 3;
            this.bNo.TabStop = false;
            this.bNo.Text = "XEYR";
            this.bNo.Click += new System.EventHandler(this.bNo_Click);
            // 
            // bYes
            // 
            this.bYes.AllowFocus = false;
            this.bYes.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(191)))), ((int)(((byte)(107)))));
            this.bYes.Appearance.Font = new System.Drawing.Font("Nunito", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bYes.Appearance.ForeColor = System.Drawing.Color.White;
            this.bYes.Appearance.Options.UseBackColor = true;
            this.bYes.Appearance.Options.UseFont = true;
            this.bYes.Appearance.Options.UseForeColor = true;
            this.bYes.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(131)))), ((int)(((byte)(131)))));
            this.bYes.AppearanceHovered.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(131)))), ((int)(((byte)(131)))));
            this.bYes.AppearanceHovered.Options.UseBackColor = true;
            this.tablePanel1.SetColumn(this.bYes, 0);
            this.bYes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bYes.Location = new System.Drawing.Point(30, 109);
            this.bYes.LookAndFeel.SkinName = "Office 2019 White";
            this.bYes.LookAndFeel.UseDefaultLookAndFeel = false;
            this.bYes.Margin = new System.Windows.Forms.Padding(30, 15, 30, 15);
            this.bYes.Name = "bYes";
            this.tablePanel1.SetRow(this.bYes, 1);
            this.bYes.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.bYes.Size = new System.Drawing.Size(270, 48);
            this.bYes.TabIndex = 2;
            this.bYes.TabStop = false;
            this.bYes.Text = "BƏLİ";
            this.bYes.Click += new System.EventHandler(this.bYes_Click);
            // 
            // lMessage
            // 
            this.lMessage.Appearance.Font = new System.Drawing.Font("Nunito", 16F);
            this.lMessage.Appearance.Options.UseFont = true;
            this.lMessage.Appearance.Options.UseTextOptions = true;
            this.lMessage.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lMessage.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
            this.lMessage.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.lMessage.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.tablePanel1.SetColumn(this.lMessage, 0);
            this.tablePanel1.SetColumnSpan(this.lMessage, 2);
            this.lMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lMessage.Location = new System.Drawing.Point(3, 3);
            this.lMessage.Name = "lMessage";
            this.tablePanel1.SetRow(this.lMessage, 0);
            this.lMessage.Size = new System.Drawing.Size(654, 88);
            this.lMessage.TabIndex = 1;
            this.lMessage.Text = "Müqavilə əlavə etmədiniz. \r\nMüqaviləsiz yeni müştəri yaradılsınmı ?";
            // 
            // toolsBorderRadius1
            // 
            this.toolsBorderRadius1.CornerRadius = 25;
            this.toolsBorderRadius1.TargetControl = this;
            // 
            // fContractNotification
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(660, 172);
            this.Controls.Add(this.tablePanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fContractNotification";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mesaj";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        public DevExpress.XtraEditors.SimpleButton bNo;
        public DevExpress.XtraEditors.SimpleButton bYes;
        private DevExpress.XtraEditors.LabelControl lMessage;
        private UserControls.ToolsBorderRadius toolsBorderRadius1;
    }
}