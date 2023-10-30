using İNTEKO.UserControls;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INTEKO.DB
{
    public class ConnectionStringInfo
    {
        private static string FilePath = $"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\\{Application.CompanyName}\\Config.dat";

        // private static string connectionString = File.ReadAllText($"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\\{Application.CompanyName}\\Config.dat");

        public static string Get()
        {
            if (File.Exists(FilePath))
            {
                return File.ReadAllText(FilePath);
            }
            return null;
        }

        public static void Set(string connectionString)
        {
            if (!Directory.Exists($"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\\{Application.CompanyName}"))
            {
                Directory.CreateDirectory($"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\\{Application.CompanyName}");
            }
            File.WriteAllText(FilePath, connectionString);
        }

        public static bool Check(string connectionString = null)
        {
            SqlConnectionStringBuilder connectionStringBuilder = new SqlConnectionStringBuilder(connectionString ?? Get());
            connectionStringBuilder.InitialCatalog = "master";
            using (SqlConnection connection = new SqlConnection(connectionStringBuilder.ConnectionString))
            {
                try
                {
                    connection.Open();
                    return true;
                }
                catch (Exception)
                {
                    //Set(connectionString);
                    return false;
                }
            }
        }

        public static void CreateDB(bool control)
        {
            if (control == true)
            {
                try
                {
                    string connectionString = File.ReadAllText($"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\\{Application.CompanyName}\\Config.dat");

                    string DBName = "İntekodb";
                    SqlConnection con = new SqlConnection(connectionString.Replace("Initial Catalog=İntekodb", "Database=master"));
                    SqlCommand cmd = new SqlCommand("SELECT Count(name) FROM master.dbo.sysdatabases WHERE name=@prmDB", con);
                    cmd.Parameters.AddWithValue("@prmDB", DBName);
                    con.Open();
                    int result = (int)cmd.ExecuteScalar();
                    if (result != 0) { MessageBox.Show("Verilənlər bazası sistemdə mövcuddur", "İNTEKO", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                    else
                    {
                        cmd.CommandText = "Create Database " + DBName;
                        cmd.ExecuteNonQuery();
                        SqlQuery();
                        Procedure();
                    }
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public static async void SqlQuery()
        {
            try
            {
                string connectionString = File.ReadAllText($"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\\{Application.CompanyName}\\Config.dat");

                using (HttpClient client = new HttpClient())
                {
                    string url = "https://e-kassa.000webhostapp.com/inteko/SQL/CreateTableScript";

                    HttpResponseMessage ScriptData = await client.GetAsync(url);
                    if (ScriptData.IsSuccessStatusCode)
                    {
                        string responseData = await ScriptData.Content.ReadAsStringAsync();
                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            connection.Open();

                            using (SqlCommand command = new SqlCommand(responseData.Replace("GO", ""), connection))
                            {
                                command.ExecuteNonQuery();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Xəta: " + ScriptData.StatusCode, "Script");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Script");
            }
        }

        public static async void Procedure()
        {
            string connectionString = File.ReadAllText($"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\\{Application.CompanyName}\\Config.dat");
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    string url = "https://e-kassa.000webhostapp.com/inteko/SQL/ExpensesProcNo"; //Satış prosedur

                    HttpResponseMessage ExpensesProc = await client.GetAsync(url);
                    if (ExpensesProc.IsSuccessStatusCode)
                    {
                        string responseDataSales = await ExpensesProc.Content.ReadAsStringAsync();
                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            connection.Open();

                            //Xərclərin əməliyyat nömrəsinin prosedurunun yaradılması
                            using (SqlCommand command = new SqlCommand(responseDataSales.Replace("GO", ""), connection))
                                command.ExecuteNonQuery();
                        }
                        MessageBox.Show("Verilənlər bazası uğurla yaradıldı", "İNTEKO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Xəta: " + ExpensesProc.StatusCode, "Expenses Procedur");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Procedur");
            }
        }
    }
}
