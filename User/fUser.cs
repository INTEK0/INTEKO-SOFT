using DevExpress.XtraEditors;
using İNTEKO.Enums;
using İNTEKO.Helpers;
using İNTEKO.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace İNTEKO.User
{
    public partial class fUser :FormBase
    {
        IntekodbEntities db = new IntekodbEntities();

        public short ID { get; set; }

        private EnumsOperation.Operation Operation;

        public fUser(EnumsOperation.Operation _operation)
        {
            InitializeComponent();
            Operation = _operation;
            var data = db.UserRole.OrderBy(x => x.Id).ToList();
            FormHelpers.ControlLoad(data,cmbUserRole);
        }

        private string Control()
        {
            if (String.IsNullOrEmpty(tNameSurname.Text)) { return "Ad soyadı daxil edin"; }
            if (String.IsNullOrEmpty(cmbUserRole.Text)) { return "İstifadəçi növünü seçin"; }
            return null;
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            if (Operation == EnumsOperation.Operation.Add)
            {
                if (Control() != null) { Message(Control(), UserControls.MessageForm.enmType.Warning); return; }
                Users users = new Users();
                users.NameSurname = tNameSurname.Text;
                users.Username = tUsername.Text;
                users.Password = tPassword.Text;
                users.UserRole = (UserRole)cmbUserRole.SelectedItem;
                db.Users.Add(users);
                db.SaveChanges();
                Message("Yeni istifadəçi yaradıldı", UserControls.MessageForm.enmType.Success);
                Close();
            }
            else if (Operation == EnumsOperation.Operation.Edit)
            {
                var editUser = db.Users.FirstOrDefault(x => x.User_ID == ID);
                editUser.NameSurname = tNameSurname.Text;
                editUser.UserRole = (UserRole)cmbUserRole.SelectedItem;
                if (!String.IsNullOrEmpty(tPassword.Text))
                {
                    editUser.Password = tPassword.Text;
                }
                db.SaveChanges();
                Message(AutoMessage.EditSaveChange, UserControls.MessageForm.enmType.Success);
                Close();
            }
        }

        private void cmbUserRole_SelectedValueChanged(object sender, EventArgs e)
        {
            switch (cmbUserRole.Text)
            {
                case "ADMİN":
                    tUsername.Enabled = true;
                    tPassword.Enabled = true; break;
                case "QURAŞDIRICI":
                    tUsername.Enabled = false;
                    tPassword.Enabled = false;
                    tUsername.Text = null;
                    tPassword.Text = null;
                    break;
                default:
                    tUsername.Enabled = true;
                    tPassword.Enabled = true; break;
            }
        }

        private void fUser_Load(object sender, EventArgs e)
        {
            if (Operation == EnumsOperation.Operation.Edit)
            {
                bSave.Text = EnumsOperation.ButtonTextName.Edit.GetDescription();
                tUsername.Enabled = false;
                var user = db.Users.FirstOrDefault(x => x.User_ID == ID);
                tUsername.Text = user.Username;
                tNameSurname.Text = user.NameSurname;
                cmbUserRole.Text = user.UserRole.Name;
            }
            else if (Operation == EnumsOperation.Operation.Add)
            {
                bSave.Text = EnumsOperation.ButtonTextName.Add.GetDescription();
            }
        }
    }
}