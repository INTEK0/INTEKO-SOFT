using DevExpress.XtraEditors;
using İNTEKO.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace İNTEKO.Comments
{
    public partial class fComments : FormBase
    {
        public fComments()
        {
            InitializeComponent();
        }

        IntekodbEntities db = new IntekodbEntities();

        private void cmbType_SelectedValueChanged(object sender, EventArgs e)
        {

            if (cmbType.Text == "KASSA")
            {
                labelControl1.Text = "Problemin adı";
                labelControl2.Text = "Problemin həlli";
                panelControl4.Visible = true;
            }
            else if (cmbType.Text == "MPOS")
            {
                labelControl1.Text = "Problemin adı";
                labelControl2.Text = "Problemin həlli";
                panelControl4.Visible = true;
            }
            else if (cmbType.Text == "QEYD")
            {
                labelControl1.Text = "Başlıq";
                labelControl2.Text = "Qeyd";
                panelControl4.Visible = false;
            }
        }

        private string Control()
        {
            if (String.IsNullOrEmpty(tHeader.Text)) { return "Başlığı qeyd etmədiniz"; }
            if (String.IsNullOrEmpty(tComment.Text)) { return "Problemin həllini qeyd etmədiniz"; }
            return null;
        }

        private void userFooter_Save1_SaveClick(object sender, EventArgs e)
        {
            if (Control() != null) { Message(Control(), UserControls.MessageForm.enmType.Warning); return; }
            try
            {
                if (cmbType.Text == "KASSA")
                {
                    Problems problems = new Problems();
                    problems.Name = tHeader.Text.Trim();
                    problems.Comment = tComment.Text.Trim();
                    problems.Type = "KASSA";
                    if (!String.IsNullOrEmpty(tFilePath.Text))
                    {
                        using (Stream stream = File.OpenRead(tFilePath.Text))
                        {
                            byte[] data = new byte[stream.Length];
                            stream.Read(data, 0, data.Length);
                            var fi = new FileInfo(tFilePath.Text);
                            string extn = fi.Extension;
                            string name = fi.Name;
                            problems.Video = (byte[])data;
                            problems.FileName = name;
                            problems.FileExtensions = extn;
                        }
                    }
                    db.Problems.Add(problems);
                    db.SaveChanges();
                }
                else if (cmbType.Text == "MPOS")
                {
                    Problems problems = new Problems();
                    problems.Name = tHeader.Text.Trim();
                    problems.Comment = tComment.Text.Trim();
                    problems.Type = "MPOS";
                    if (!String.IsNullOrEmpty(tFilePath.Text))
                    {
                        using (Stream stream = File.OpenRead(tFilePath.Text))
                        {
                            byte[] data = new byte[stream.Length];
                            stream.Read(data, 0, data.Length);
                            var fi = new FileInfo(tFilePath.Text);
                            string extn = fi.Extension;
                            string name = fi.Name;
                            problems.Video = (byte[])data;
                            problems.FileName = name;
                            problems.FileExtensions = extn;
                        }
                    }
                    db.Problems.Add(problems);
                    db.SaveChanges();
                }
                else if (cmbType.Text == "QEYD")
                {
                    Problems problems = new Problems();
                    problems.Name = tHeader.Text.Trim();
                    problems.Comment = tComment.Text.Trim();
                    problems.Type = "QEYD";
                    db.Problems.Add(problems);
                    db.SaveChanges();
                }
                Message("Qeydiniz uğurla əlavə edildi", UserControls.MessageForm.enmType.Success);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);return;
            }
            tHeader.Text = null;
            tComment.Text = null;
            tFilePath.Text = null;
        }

        private void fComments_Load(object sender, EventArgs e)
        {
            cmbType.Text = "KASSA";
        }

        private void bUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK) { tFilePath.Text = open.FileName; open.Title = "Fayl seçin"; }
        }

        private void fComments_FormClosed(object sender, FormClosedEventArgs e)
        {
            //fDashboard dashboard = (fDashboard)Application.OpenForms["fDashboard"];
            //dashboard.xtraTabControl1.SelectedTabPageIndex = 0;
            //dashboard.SSSLoad();
        }
    }
}