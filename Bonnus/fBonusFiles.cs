using DevExpress.XtraEditors;
using İNTEKO.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace İNTEKO.Bonnus
{
    public partial class fBonusFiles : FormBase
    {
        public fBonusFiles()
        {
            InitializeComponent();
            this.Text = Proccess.Versiya();
        }

        public string Operation { get; set; }

        public int _ID { get; set; }

        private string Control()
        {
            if (String.IsNullOrEmpty(tName.Text)) { return "Adı daxil edin"; }
            if (String.IsNullOrEmpty(tContractPath.Text)) { return "Fayl seçimi edilmədi"; }
            return null;
        }

        void FolderControl()
        {
            if (!Directory.Exists(Application.StartupPath + "\\temp"))
                Directory.CreateDirectory(Application.StartupPath + "\\temp");
            else
            {
                Directory.Delete(Application.StartupPath + "\\temp", true);
                Directory.CreateDirectory(Application.StartupPath + "\\temp");
            }
        }

        private void fBonusFiles_Load(object sender, EventArgs e)
        {
            if (Operation == "Show")
            {
                navigationFrame1.SelectedPage = pageShow;
                GridFill();
            }
            else
            {
                navigationFrame1.SelectedPage = pageAdd;
                GridFill();
            }
        }

        void GridFill()
        {
            using (var db = new IntekodbEntities())
            {
                gridControlContract.DataSource = db.BonusFiles.Where(x => x.Bonus_ID == _ID).ToList();
                gridContract.RefreshData();
            }
        }

        private void bOpen_Click(object sender, EventArgs e)
        {
            if (gridContract.GetFocusedRow() == null)
            {
                Message("Seçim edilmədi", UserControls.MessageForm.enmType.Info);
                return;
            }
            int id = Convert.ToInt32(gridContract.GetFocusedRowCellValue("Id").ToString());
            OpenFile(id);
        }

        void OpenFile(int id)
        {
            using (var db = new IntekodbEntities())
            {
                using (SqlConnection con = new SqlConnection(db.Database.Connection.ConnectionString))
                {
                    string query = "SELECT FileName,FileData FROM BonusFiles WHERE Id=@id";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                    con.Open();
                    var reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        var name = reader["FileName"].ToString();
                        var data = (byte[])reader["FileData"];
                        var extn = reader["FileExtensions"].ToString();

                        var newFileName = name.Replace(extn, DateTime.Now.ToString("ddMMyyyyhhmmss")) + extn;
                        //Directory.CreateDirectory(Application.StartupPath + "\\temp");
                        File.WriteAllBytes(Application.StartupPath + "\\temp\\" + newFileName, data);
                        Process.Start(Application.StartupPath + "\\temp\\" + newFileName);
                    }
                    reader.Close();
                }
            }
        }

        private void bDelete_Click(object sender, EventArgs e)
        {
            if (gridContract.GetFocusedRow() == null)
            {
                Message("Seçim edilmədi", UserControls.MessageForm.enmType.Info);
                return;
            }
            using (var db = new IntekodbEntities())
            {
                string contractName = gridContract.GetFocusedRowCellValue("Elave2FileName").ToString();

                if (MessageBox.Show("Seçmiş olduğunuz " + contractName + " sənədini bazadan qalıcı olaraq silmək istədiyinizə əminsiniz ?", "Sənəd silmə", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var delete = db.BonusFiles.Where(x => x.Bonus_ID == _ID).FirstOrDefault();
                    db.BonusFiles.Remove(delete);
                    db.SaveChanges();
                    Message(contractName + " sənədi silindi", UserControls.MessageForm.enmType.Success);
                    GridFill();
                }
            }
        }

        private void bFileBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK) { tContractPath.Text = dlg.FileName; }
            else { return; }
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            if (Control() != null) { Message(Control(), UserControls.MessageForm.enmType.Warning); return; }

            //fCreateBonus f = (fCreateBonus)Application.OpenForms["fCreateBonus"];
            //f.FileName = tName.Text.Trim();
            //f.FilePath = tContractPath.Text.Trim();
            //this.Close();
            try
            {
                using (var db = new IntekodbEntities())
                {
                    using (Stream Elavestream = File.OpenRead(tContractPath.Text))
                    {
                        byte[] data = new byte[Elavestream.Length];
                        Elavestream.Read(data, 0, data.Length);
                        var fi = new FileInfo(tContractPath.Text);
                        string extn = fi.Extension;

                        BonusFiles bonusFiles = new BonusFiles();
                        bonusFiles.Bonus_ID = _ID;
                        bonusFiles.FileData = (byte[])data;
                        bonusFiles.FileName = tName.Text.Trim();
                        bonusFiles.FileExtensions = extn;
                        bonusFiles.Status = false;
                        db.BonusFiles.Add(bonusFiles);
                        db.SaveChanges();
                        Message("Sənəd uğurla bazaya əlavə edildi", UserControls.MessageForm.enmType.Success);
                        GridFill();
                    }
                }
            }
            catch (Exception ex) { /*MessageBox.Show(ex.Message);*/ throw ex; }
        }

        private void fBonusFiles_FormClosed(object sender, FormClosedEventArgs e)
        {
            FolderControl();
            using (var db = new IntekodbEntities()) { db.Dispose(); }
        }
    }
}