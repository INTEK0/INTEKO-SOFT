using İNTEKO.Helpers;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Mail;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace İNTEKO.Tools
{
    public static class Proccess
    {
        public static void Backup()
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                if (!Directory.Exists(Application.StartupPath + @"\Backup\"))
                    Directory.CreateDirectory(Application.StartupPath + @"\Backup\");
                else
                {
                    Directory.Delete(Application.StartupPath + @"\Backup\", true);
                    Directory.CreateDirectory(Application.StartupPath + @"\Backup\");
                }


                SaveFileDialog save = new SaveFileDialog();
                save.FileName = "İnteko_backup_" + DateTime.Now.ToShortDateString() + ".bak";
                if (File.Exists(save.FileName))
                {
                    File.Delete(save.FileName);
                }
                var filepath = Application.StartupPath + @"\Backup\" + save.FileName;
                using (var db = new IntekodbEntities())
                {
                    var query = @"BACKUP DATABASE İntekodb TO DISK='" + filepath + "'";
                    db.Database.ExecuteSqlCommand(TransactionalBehavior.DoNotEnsureTransaction, query);
                }
                SendEmail(filepath);
                Cursor.Current = Cursors.Default;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private static void SendEmail(string filePath)
        {
            string fromEmail = "applicationkassa@gmail.com";
            //string toEmail = "info@inteko.az";
            string toEmail2 = "web.hesen@gmail.com";
            string subject = "Backup";
            string body = "<html><body><p>Merhaba,</p><p>Aşağıdaki dosyayı gönderiyorum:</p><p>{0}</p></body></html>";


            MailMessage message = new MailMessage(fromEmail, toEmail2, subject, string.Format(body, Path.GetFileName(filePath)));
            message.IsBodyHtml = true;

            Attachment attachment = new Attachment(filePath);
            message.Attachments.Add(attachment);

            SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
            client.EnableSsl = true;
            client.UseDefaultCredentials = false;
            client.Credentials = new NetworkCredential("applicationkassa@gmail.com", "vjaoxeobsoxoqtfx");

            client.Send(message);
        }

        public static bool UsersControl(Users id)
        {
            #region Detail


            return false;
            #endregion
        }

        public static string Versiya()
        {
            string version = " V" + Application.ProductVersion.ToString();
            return version;
        }

        public static bool IsInternetAvailable()
        {
            try
            {
                IPHostEntry hostEntry = Dns.GetHostEntry("www.google.com");
                return true;
            }
            catch (SocketException)
            {
                FormHelpers.ManualMessageBox(AutoMessage.NetworkErrorMessage,"Xəta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

    }
}


//TSuotRtPi1&2