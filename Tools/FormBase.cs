using DevExpress.XtraEditors;
using İNTEKO.UserControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İNTEKO.Tools
{
    public class FormBase:XtraForm
    {
        public static void Message(string msg, MessageForm.enmType type)
        {
            MessageForm frm = new MessageForm();
            frm.showAlert(msg, type);
            return;
        }
    }
}
