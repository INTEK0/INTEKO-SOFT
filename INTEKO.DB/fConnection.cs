using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using İNTEKO.UserControls;

namespace INTEKO.DB
{
    public partial class fConnection : XtraForm
    {
        SqlConnectionStringBuilder connectionStringBuilder = new SqlConnectionStringBuilder();

        public fConnection()
        {
            InitializeComponent();
        }

        private void ConnectionCreate()
        {
            try
            {
                connectionStringBuilder.InitialCatalog = "master";
                connectionStringBuilder.DataSource = tServerName.Text;
                if (chWindows.Checked)
                    connectionStringBuilder.IntegratedSecurity = true;
                else
                {
                    connectionStringBuilder.UserID = tUsername.Text;
                    connectionStringBuilder.Password = tPassword.Text;
                    connectionStringBuilder.IntegratedSecurity = false;
                }
            }
            catch (Exception m)
            {
                MessageBox.Show(m.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chSql_CheckedChanged(object sender, EventArgs e)
        {
            if (chSql.Checked)
            {
                tUsername.Enabled = true;
                tPassword.Enabled = true;
            }
            else
            {
                tUsername.Enabled = false;
                tPassword.Enabled = false;
            }
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            ConnectionCreate();
            if (ConnectionStringInfo.Check(connectionStringBuilder.ConnectionString))
            {
                connectionStringBuilder.InitialCatalog = "İntekodb";
                ConnectionStringInfo.Set(connectionStringBuilder.ConnectionString);

                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                config.ConnectionStrings.ConnectionStrings["IntekodbEntities"].ConnectionString = "metadata=res://*/EntityModel.csdl|res://*/EntityModel.ssdl|res://*/EntityModel.msl;provider=System.Data.SqlClient;provider connection string=\"" + 
                    connectionStringBuilder.ConnectionString.Replace("Data Source", "Server").Replace("Initial Catalog", "Database") + ";MultipleActiveResultSets=True;App=EntityFramework\"";

                config.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("IntekodbEntities");

                ConnectionStringInfo.CreateDB(chCreateDB.Checked);

                Cursor.Current = Cursors.WaitCursor;
            }
            else { Tools.Message("Qoşulma mümkün olmadı", MessageForm.enmType.Error); }
        }

        private void bTest_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                ConnectionCreate();
                if (ConnectionStringInfo.Check(connectionStringBuilder.ConnectionString))

                    Tools.Message("Uğurlu Qoşulma", MessageForm.enmType.Success);
                else
                    Tools.Message("Qoşulma mümkün olmadı", MessageForm.enmType.Error);
            }
            catch (Exception m)
            {
                MessageBox.Show(m.Message);
            }
            Cursor.Current = Cursors.Default;
        }
    }
}