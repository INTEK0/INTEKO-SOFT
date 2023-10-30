using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace İNTEKO.Tools
{
    public partial class fShutdown : DevExpress.XtraEditors.XtraForm
    {
        public fShutdown()
        {
            InitializeComponent();
        }

        IntekodbEntities db = new IntekodbEntities();

        public bool Exit = false;

        public bool Shutdown = false;

        public bool EndExit = false;

        private void bCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bExit_Click(object sender, EventArgs e)
        {
            Exit = true;
            Environment.Exit(0);
            Close();
        }

        private void bShutdown_Click(object sender, EventArgs e)
        {
            Shutdown = true;
            Close();
        }

        private void bEndDay_Click(object sender, EventArgs e)
        {
            EndExit = true;
            Close();
        }
    }
}