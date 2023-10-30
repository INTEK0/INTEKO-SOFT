using System;
using System.Net;
using System.Windows.Forms;

namespace İNTEKO.Tools
{
    public partial class fNewUpdate : Form
    {
        public fNewUpdate()
        {
            InitializeComponent();
        }

        private void fNewUpdate_Load(object sender, EventArgs e)
        {
            lOldVersion.Text = "İndiki versiya : " + Application.ProductVersion;
            try
            {
                if (System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable() == true)
                {
                    using (WebClient web = new WebClient())
                    {
                        lNewVersion.Text = "Yeni versiya  : " + web.DownloadString("http://e-kassa.000webhostapp.com/inteko/inteko-soft/version").Trim();
                    }
                }
                else { lNewVersion.Text = "Yeni versiya  : Null"; }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void bNo_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bYes_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Application.StartupPath + @"\Update.exe");
        }
    }
}
