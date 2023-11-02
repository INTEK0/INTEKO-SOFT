using DevExpress.XtraEditors;
using İNTEKO.Helpers;
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

namespace İNTEKO.DetailForm
{
    public partial class fExtraContracts : FormBase
    {
        public fExtraContracts()
        {
            InitializeComponent();
        }
        public Customers CustomerID { get; set; }

        private void bContractAdd_Click(object sender, EventArgs e)
        {
            navigationFrame1.SelectedPage = pageAdd;
        }

        private void bBack_Click(object sender, EventArgs e)
        {
            navigationFrame1.SelectedPage = pageMain;
            tContractPath.Text = null;
            tName.Text = null;
        }

        private void bFileBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK) { tContractPath.Text = dlg.FileName; }
        }

        private string Control()
        {
            if (String.IsNullOrEmpty(tName.Text)) { return "Adı daxil edin"; }
            if (String.IsNullOrEmpty(tContractPath.Text)) { return "Fayl seçimi edilmədi"; }
            return null;
        }


        void GridFill()
        {
            using (var db = new IntekodbEntities())
            {
                gridControlContract.DataSource = db.Contracts.Where(x => x.CustomerID == CustomerID.Id).ToList();
                gridContract.RefreshData();
            }
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            if (Control() != null) { Message(Control(), UserControls.MessageForm.enmType.Warning); return; }
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

                        Contracts contracts = new Contracts();
                        contracts.CustomerID = CustomerID.Id;
                        contracts.Elave2Data = (byte[])data;
                        contracts.Elave2FileExtensions = extn;
                        contracts.Elave2FileName = tName.Text.Trim();
                        db.Contracts.Add(contracts);
                        db.SaveChanges();
                        Message("Sənəd uğurla bazaya əlavə edildi", UserControls.MessageForm.enmType.Success);
                        Logger.Log("");
                        GridFill();
                        bBack_Click(null, null);
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void fExtraContracts_Load(object sender, EventArgs e)
        {
            GridFill();
        }

        private void bOpen_Click(object sender, EventArgs e)
        {
            if (gridContract.GetFocusedRow() == null)
            {
                Message(AutoMessage.NoSelection, UserControls.MessageForm.enmType.Info);
                return;
            }
            int id = Convert.ToInt32(gridContract.GetFocusedRowCellValue("Id").ToString());
            OpenFile(id);
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

        void OpenFile(int id)
        {
            using (var db = new IntekodbEntities())
            {
                using (SqlConnection con = new SqlConnection(db.Database.Connection.ConnectionString))
                {
                    string query = "SELECT Elave2Data,Elave2FileExtensions,Elave2FileName FROM Contracts WHERE Id=@id";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                    con.Open();
                    var reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        var name = reader["Elave2FileName"].ToString();
                        var data = (byte[])reader["Elave2Data"];
                        var extn = reader["Elave2FileExtensions"].ToString();

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
                Message(AutoMessage.NoSelection, UserControls.MessageForm.enmType.Info);
                return;
            }
            using (var db = new IntekodbEntities())
            {
                string contractName = gridContract.GetFocusedRowCellValue("Elave2FileName").ToString();

                if (MessageBox.Show("Seçmiş olduğunuz " + contractName + " sənədini bazadan qalıcı olaraq silmək istədiyinizə əminsiniz ?", "Sənəd silmə", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var delete = db.Contracts.Where(x => x.CustomerID == CustomerID.Id).FirstOrDefault();
                    db.Contracts.Remove(delete);
                    db.SaveChanges();
                    Message(contractName + " sənədi silindi",UserControls.MessageForm.enmType.Success);
                    GridFill();
                }
            }
        }

        private void fExtraContracts_FormClosed(object sender, FormClosedEventArgs e)
        {
            FolderControl();
            using (var db = new IntekodbEntities()) { db.Dispose(); }
        }
    }
}