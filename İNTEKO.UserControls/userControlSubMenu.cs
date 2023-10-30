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
    public partial class userControlSubMenu : DevExpress.XtraEditors.XtraUserControl
    {
        [Category("Action Buttons")]
        public event EventHandler SaveButton;
        [Category("Action Buttons")]
        public event EventHandler CloseButton;
        private Font _buttonFont = new Font("Nunito ExtraBold", 16, FontStyle.Bold);

        public Font ButtonFont
        {
            set
            {
                bSave.Font = value;
                bClose.Font = value;
                _buttonFont = value;
            }
        }


        public userControlSubMenu()
        {
            InitializeComponent();
        }

        private void bClose_Click(object sender, EventArgs e)
        {
            CloseButton?.Invoke(this, e);
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            SaveButton?.Invoke(this, e);
        }
    }
}
