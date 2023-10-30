using İNTEKO.Bonnus;
using INTEKO.DB;
using İNTEKO.Definitions;
using İNTEKO.DetailForm;
using İNTEKO.Login;
using İNTEKO.NewCustomer;
using İNTEKO.PayHistory;
using İNTEKO.Setting;
using İNTEKO.Tools;
using İNTEKO.UPDATE;
using İNTEKO.User;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace İNTEKO
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            WebClient web = new WebClient();
            var culture = new CultureInfo("az-AZ");
            CultureInfo.DefaultThreadCurrentCulture = culture;
            CultureInfo.DefaultThreadCurrentUICulture = culture;
            CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator = ",";
            CultureInfo.CurrentCulture.NumberFormat.CurrencyGroupSeparator = ".";
            CultureInfo.CurrentCulture.NumberFormat.CurrencySymbol = "AZN"; //₼
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new fLogin());

            Mutex mutex = new Mutex(true, "{EA8637E3-0C2E-498B-9F2A-1800D9EABF91}");

            if (mutex.WaitOne(TimeSpan.Zero, true))
            {
                try
                {
                    if (!File.Exists($"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\\{Application.CompanyName}\\Config.dat"))
                    {
                        Application.Run(new fConnection());
                    }
                    else { Application.Run(new fLogin()); }
                }
                finally
                {
                    mutex.ReleaseMutex();
                }
            }
            else
            {
                MessageBox.Show("Tətbiq açıqdır..", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Environment.Exit(0);
            }
        }
    }
}
