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

namespace İNTEKO.UserControls
{
    public partial class userFooter_Save : DevExpress.XtraEditors.XtraUserControl
    {
        public userFooter_Save()
        {
            InitializeComponent();
        }

        private bool cancelvisible = true;

        private string Savebuttontext = "Yadda saxla";

        [Category("Action Buttons")]
        [Description("Yadda Saxla")]
        public event EventHandler SaveClick;

        [Category("Action Buttons")]
        [Description("Ləğv Et")]
        public event EventHandler CancelClick;

        public bool CancelVisible
        {
            get { return cancelvisible; }
            set
            {
                bCancel.Visible = value;
            }
        }

        public string SaveButtonText
        {
            get { return Savebuttontext; }
            set { bAdd.Text = value; }
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            SaveClick?.Invoke(this, e);
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            CancelClick?.Invoke(this, e);
        }
    }
}
