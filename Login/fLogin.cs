using DevExpress.XtraEditors;
using İNTEKO.Enums;
using İNTEKO.Helpers;
using İNTEKO.Tools;
using İNTEKO.UPDATE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace İNTEKO.Login
{
    public partial class fLogin : Form
    {
        IntekodbEntities db = new IntekodbEntities();
        public fLogin()
        {
            InitializeComponent();
        }

        private async void bLogin_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tPassword.Text))
            {
                var control = db.Users.FirstOrDefault(x => x.Username == cmbUsername.Text && x.Password == tPassword.Text);
                if (control != null)
                {
                    Cursor.Current = Cursors.WaitCursor;
                    fDashboard f = new fDashboard();
                    Properties.Settings.Default.UserID = control.User_ID;
                    Properties.Settings.Default.Save();
                    control.LastLoginDate = DateTime.Now;
                    await db.SaveChangesAsync();
                    f.Show();
                    Logger.Log("daxil oldu");
                    this.Hide();
                    if (!Directory.Exists(Application.StartupPath + "\\temp")) { Directory.CreateDirectory(Application.StartupPath + "\\temp"); }
                }
                else { ShowMessage.Message(AutoMessage.InvalidPasswordMessage, UserControls.MessageForm.enmType.Error); }
            }
            else { ShowMessage.Message(AutoMessage.InvalidPasswordMessage, UserControls.MessageForm.enmType.Error); }
        }

        private void fLogin_Load(object sender, EventArgs e)
        {
            lVersion.Text = Proccess.Versiya();
            Properties.Settings.Default.UserID = 0;
            Properties.Settings.Default.Save();
            var data = db.Users.AsNoTracking().Where(x => x.UserRole.Name == EnumsOperation.Roles.ADMİN.ToString()).ToList();
            FormHelpers.ControlLoad(data, cmbUsername, "Username");

            #region Update
            //using (WebClient web = new WebClient())
            //{
            //    try
            //    {
            //        if (!web.DownloadString("http://e-kassa.000webhostapp.com/inteko/inteko-soft/version").Contains(Application.ProductVersion))
            //        {
            //            fNewUpdate update = new fNewUpdate();
            //            update.ShowDialog();
            //            //Process.Start(@"D:\Hasan\PROJECTS\İNTEKO\bin\Debug\Update.exe");
            //            //Process.Start(Application.StartupPath + @"\Update.exe");
            //        }

            //    }
            //    catch (WebException)
            //    {
            //        MessageBox.Show("İnternet bağlantısı yoxdur", "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        Close();
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show(ex.Message);
            //        //using (EventLog eventLog = new EventLog("Application"))
            //        //{
            //        //    eventLog.Source = "İnteko Soft";
            //        //    eventLog.WriteEntry(ex.Message, EventLogEntryType.Error, 1000, 2607);
            //        //}
            //    }
            //}
            #endregion

        }

        private void tPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                bLogin_Click(null, null);
        }

        private void bExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
