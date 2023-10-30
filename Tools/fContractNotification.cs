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
    public partial class fContractNotification : Form
    {
        public fContractNotification()
        {
            InitializeComponent();
        }

        public string Operation
        {
            get { return lMessage.Text; }
            set
            {
                if (value == "Edit"){lMessage.Text = "Müqavilə əlavə etmədiniz.\nMüqaviləsiz davam edilsinmi ?"; }
                if (value == "Add"){lMessage.Text = "Müqavilə əlavə etmədiniz.\nMüqaviləsiz yeni müştəri yaradılsınmı ?";}
            }
        }

        public bool No = false;

        private void bYes_Click(object sender, EventArgs e)
        {
            No = true;
            Close();
        }

        private void bNo_Click(object sender, EventArgs e)
        {
            No = false;
            Close();
        }
    }
}
