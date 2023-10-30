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

namespace İNTEKO
{
    public partial class testtt : Form
    {
        IntekodbEntities db = new IntekodbEntities();

        public testtt()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = dlg.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFile(textBox1.Text);
            MessageBox.Show("Mission Completed");
        }

        void SaveFile(string filePath)
        {
            using (Stream stream = File.OpenRead(filePath))
            {
                byte[] buffer = new byte[stream.Length];
                stream.Read(buffer, 0, buffer.Length);

                var fi = new FileInfo(filePath);

                string extn = fi.Extension;
                string name = fi.Name;

                string query = "INSERT INTO Documents(Data, FileName, Extensions) VALUES(@Data, @FileName, @Extensions)";

                using (SqlConnection con = new SqlConnection(db.Database.Connection.ConnectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.Add("@Data", SqlDbType.VarBinary).Value = buffer;
                    cmd.Parameters.Add("@Extensions", SqlDbType.Char).Value = extn;
                    cmd.Parameters.Add("@FileName", SqlDbType.NVarChar).Value = name;
                    con.Open();
                    cmd.ExecuteNonQuery();
                }




                Documents documents = new Documents();
                documents.Data = (byte[])buffer;
                documents.Extensions = extn;
                documents.FileName = name;
                db.Documents.Add(documents);
                db.SaveChanges();
            }
            GridLoad();
        }

        private void testtt_Load(object sender, EventArgs e)
        {
            GridLoad();
        }

        void GridLoad()
        {
            using (SqlConnection con = new SqlConnection(db.Database.Connection.ConnectionString))
            {
                string query = "SELECT id,Extensions,FileName FROM Documents";
                SqlDataAdapter sqlData = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                sqlData.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    dataGridView1.DataSource = dt;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var selectedRow = dataGridView1.SelectedRows;
            foreach (var row in selectedRow)
            {
                int id = (int)((DataGridViewRow)row).Cells[0].Value;
                OpenFile(id);
            }
        }

        void OpenFile(int id)
        {
            using (SqlConnection con = new SqlConnection(db.Database.Connection.ConnectionString))
            {
                string query = "SELECT Data,Extensions,FileName FROM Documents WHERE id=@id";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                con.Open();
                var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    var name = reader["FileName"].ToString();
                    var data = (byte[])reader["Data"];
                    var extn = reader["Extensions"].ToString();

                    var newFileName = name.Replace(extn, DateTime.Now.ToString("ddMMyyyyhhmmss")) + extn;
                    File.WriteAllBytes(newFileName, data);
                    Process.Start(newFileName);
                }
            }
        }
    }
}
