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

namespace İNTEKO.Definitions
{
    public partial class fDefinitions : FormBase
    {
        IntekodbEntities db = new IntekodbEntities();

        UserRole role = new UserRole();

        public string Mode { get; set; }

        public fDefinitions(string _mode)
        {
            InitializeComponent();
            Mode = _mode;
        }

        private void fDefinitions_Load(object sender, EventArgs e)
        {
            GridDataFill();
            this.Text = Proccess.Versiya();
        }

        private void gridRole_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (Mode == "Role")
            {
                if (e.Column == colAdd)
                {
                    if (e.Value != null || e.DisplayText != "")
                    {
                        if ((bool)e.Value) { e.DisplayText = "✔️"; }
                        else { e.DisplayText = "❌  "; }
                    }

                }
                if (e.Column == colDuzelis)
                {
                    if (e.Value != null || e.DisplayText != "")
                    {
                        if ((bool)e.Value) { e.DisplayText = "✔️"; }
                        else { e.DisplayText = "❌  "; }
                    }

                }
                if (e.Column == colSilme)
                {
                    if (e.Value != null || e.DisplayText != "")
                    {
                        if ((bool)e.Value) { e.DisplayText = "✔️"; }
                        else { e.DisplayText = "❌  "; }
                    }

                }
                if (e.Column == colAdmin)
                {
                    if (e.Value != null || e.DisplayText != "")
                    {
                        if ((bool)e.Value) { e.DisplayText = "✔️"; }
                        else { e.DisplayText = "❌  "; }
                    }
                }
            }
        }

        private void gridRole_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            if (Mode == "Role")
            {
                if (e.Column.FieldName == "Adds")
                {
                    if (e.CellValue != null && e.CellValue is bool value)
                    {
                        if (value == true)
                        {
                            e.Appearance.ForeColor = Color.Green;
                            e.Appearance.FontStyleDelta = FontStyle.Bold;
                        }
                        else
                        {
                            e.Appearance.ForeColor = Color.Red;
                            e.Appearance.FontStyleDelta = FontStyle.Bold;
                        }
                    }
                }
                if (e.Column.FieldName == EnumsOperation.Operation.Edit.ToString())
                {
                    if (e.CellValue != null && e.CellValue is bool value)
                    {
                        if (value == true)
                        {
                            e.Appearance.ForeColor = Color.Green;
                            e.Appearance.FontStyleDelta = FontStyle.Bold;
                        }
                        else
                        {
                            e.Appearance.ForeColor = Color.Red;
                            e.Appearance.FontStyleDelta = FontStyle.Bold;
                        }
                    }
                }
                if (e.Column.FieldName == EnumsOperation.Operation.Remove.ToString())
                {
                    if (e.CellValue != null && e.CellValue is bool value)
                    {
                        if (value == true)
                        {
                            e.Appearance.ForeColor = Color.Green;
                            e.Appearance.FontStyleDelta = FontStyle.Bold;
                        }
                        else
                        {
                            e.Appearance.ForeColor = Color.Red;
                            e.Appearance.FontStyleDelta = FontStyle.Bold;
                        }
                    }
                }
                if (e.Column.FieldName == EnumsOperation.Operation.Show.ToString())
                {
                    if (e.CellValue != null && e.CellValue is bool value)
                    {
                        if (value == true)
                        {
                            e.Appearance.ForeColor = Color.Green;
                            e.Appearance.FontStyleDelta = FontStyle.Bold;
                        }
                        else
                        {
                            e.Appearance.ForeColor = Color.Red;
                            e.Appearance.FontStyleDelta = FontStyle.Bold;
                        }
                    }
                }
            }
        }

        void Clear()
        {
            tName.Text = null;
            toggleAdd.IsOn = false;
            toggleEdit.IsOn = false;
            toggleRemove.IsOn = false;
            toggleAdmin.IsOn = false;
            bSave.Text = EnumsOperation.ButtonTextName.Save.GetDescription();
            GridDataFill();
        }

        private void bDelete_Click(object sender, EventArgs e)
        {
            var row = gridRole.GetFocusedRow();
            if (row == null)
            {
                Message(AutoMessage.NoSelection, UserControls.MessageForm.enmType.Info);
                return;
            }
            else
            {
                role = (UserRole)row;
                db.UserRole.Remove(role);
                db.SaveChanges();
                Message(AutoMessage.DeleteMessage, UserControls.MessageForm.enmType.Success);
            }
        }

        private void bEdit_Click(object sender, EventArgs e)
        {
            var row = gridRole.GetFocusedRow();
            if (row == null)
            {
                Message(AutoMessage.NoSelection, UserControls.MessageForm.enmType.Info);
                return;
            }
            else
            {
                role = (UserRole)row;
                tName.Text = role.Name;
                toggleAdd.IsOn = (bool)role.Adds;
                toggleEdit.IsOn = (bool)role.Edit;
                toggleRemove.IsOn = (bool)role.Remove;
                toggleAdmin.IsOn = (bool)role.LogsData;
                bSave.Text = EnumsOperation.ButtonTextName.Edit.GetDescription();
            }
        }

        public int categoryID { get; set; }

        private void bSave_Click(object sender, EventArgs e)
        {
            if (Mode == "Role")
            {
                if (bSave.Text == EnumsOperation.ButtonTextName.Save.GetDescription())
                {
                    UserRole role = new UserRole();
                    role.Name = tName.Text;
                    role.Adds = toggleAdd.IsOn;
                    role.Edit = toggleEdit.IsOn;
                    role.Remove = toggleRemove.IsOn;
                    role.Show = false;
                    role.LogsData = false;
                    db.UserRole.Add(role);
                    db.SaveChanges();
                    Logger.Log($"Yeni istifadəçi rolu yaradıldı. {tName.Text}");
                    Message(AutoMessage.AddMessage, UserControls.MessageForm.enmType.Success);
                    Clear();
                }
                else
                {
                    var editRole = db.UserRole.Where(x => x.Id == role.Id).FirstOrDefault();
                    editRole.Name = tName.Text;
                    editRole.Adds = toggleAdd.IsOn;
                    editRole.Edit = toggleEdit.IsOn;
                    editRole.Remove = toggleRemove.IsOn;
                    editRole.Show = true;
                    editRole.LogsData = toggleAdmin.IsOn;
                    db.SaveChanges();
                    Logger.Log($"İstifadəçidə düzəliş edildi  id:  {editRole.Id}");
                    Message(AutoMessage.EditSaveChange, UserControls.MessageForm.enmType.Success);
                    Close();
                }
            }
            else if (Mode == "Category")
            {
                if (bSave.Text == EnumsOperation.ButtonTextName.Save.GetDescription())
                {
                    Category c = new Category();
                    c.CategoryName = tName.Text.Trim();
                    db.Category.Add(c);
                    db.SaveChanges();
                    Logger.Log($"Yeni kateqoriya əlavə edildi.  {tName.Text}");
                    Clear();
                }
                else
                {
                    var category = db.Category.FirstOrDefault(x => x.Id == categoryID);
                    category.CategoryName = tName.Text.Trim();
                    db.SaveChanges();
                    Logger.Log($"Kateqoriyalarda düzəliş edildi  id:  {category.Id}");
                    Message(AutoMessage.EditSaveChange, UserControls.MessageForm.enmType.Success);
                    Clear();
                }
            }
        }

        private void bCategoryEdit_Click(object sender, EventArgs e)
        {
            var row = gridRole.GetFocusedRow();
            if (row == null)
            {
                Message(AutoMessage.NoSelection, UserControls.MessageForm.enmType.Info);
                return;
            }
            else
            {
                Category c = new Category();
                c = (Category)row;
                tName.Text = c.CategoryName;
                categoryID = c.Id;
                bSave.Text = EnumsOperation.ButtonTextName.Edit.GetDescription();
            }
        }

        void GridDataFill()
        {
            switch (Mode)
            {
                case "Category":
                    gridControlRole.DataSource = db.Category.OrderBy(x => x.Id).ToList();
                    groupControl6.Visible = false;
                    groupControl1.Size = new Size(828, 60);
                    colAdd.Visible = false;
                    colEdit.Visible = false;
                    colAdmin.Visible = false;
                    colDuzelis.Visible = false;
                    colEdit.Visible = false;
                    colName.Visible = false;
                    colSilme.Visible = false;
                    colRemove.Visible = false;
                    colCName.Visible = true; //CategoryName column
                    colCEdit.Visible = true; //CategoryEdit column
                    labelControl1.Text = "Kateqoriya adı :";
                    tName.Size = new Size(536, 32);
                    tName.Location = new Point(152, 16);
                    break;
                case "Role":
                    gridControlRole.DataSource = db.UserRole.OrderBy(x => x.Id).ToList();
                    groupControl6.Visible = true;
                    groupControl1.Size = new Size(828, 170);
                    break;
            }
        }

        private void fDefinitions_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Mode == "Category")
            {
                fExpenses ex = (fExpenses)Application.OpenForms["fExpenses"];
                ex.cmbDoldur();
            }
        }
    }
}