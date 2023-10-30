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

namespace İNTEKO.DetailForm
{
    public partial class fContract : DevExpress.XtraEditors.XtraForm
    {
        public fContract()
        {
            InitializeComponent();
            this.Text = "Müqavilə əlavəsi - " + Proccess.Versiya();
        }

        IntekodbEntities db = new IntekodbEntities();

        public int CusomerID { get; set; }

        private void bFileBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
                tContractPath.Text = dlg.FileName;
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tContractPath.Text)) { MessageBox.Show("Fayl əlavə edilmədi", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
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
                        string name = fi.Name;

                        var customer = db.Customers.Where(x => x.Id == CusomerID).FirstOrDefault();
                        customer.ContractFileName = name;
                        customer.ContractData = (byte[])data;
                        customer.FileExtensions = extn;
                        db.SaveChanges();
                        XtraMessageBox.Show("Müqavilə əlavə edildi", "Mesaj",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        Close();
                        //contracts.Elave2Data = 
                        //contracts.Elave2FileExtensions = extn;
                        //contracts.Elave2FileName = tName.Text.Trim();
                        //db.Contracts.Add(contracts);
                        //db.SaveChanges();
                        //ShowMessage.Message("Sənəd uğurla bazaya əlavə edildi", UserControls.MessageForm.enmType.Success);
                        //GridFill();
                        //bBack_Click(null, null);
                    }
                }
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}