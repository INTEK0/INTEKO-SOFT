using DevExpress.Export;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraPrinting;
using İNTEKO.Tools;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace İNTEKO.Helpers
{
    public static class FormHelpers
    {
        static FormHelpers()
        {
            MessageBoxManager.Yes = "Bəli";
            MessageBoxManager.No = "Xeyr";
            MessageBoxManager.OK = "Ok";
            MessageBoxManager.Retry = "Yenidən yoxla";
            MessageBoxManager.Cancel = "Ləğv et";
        }

        public static void ControlLoad<T>(T data, Control control, string displayMember = "Name", string valueMember = "Id") where T : class
        {
            if (control is ComboBox)
            {
                var ctrl = control as ComboBox;
                ctrl.DisplayMember = displayMember;
                ctrl.ValueMember = valueMember;
                ctrl.DataSource = data;
            }
            else if (control is GridControl)
            {
                var grid = control as GridControl;
                grid.DataSource = data;
            }
        }

        public static void GridViewContainsLoad(string column, string query, GridView control)
        {
            Cursor.Current = Cursors.WaitCursor;
            control.ActiveFilter.Clear();
            control.ActiveFilterString = $"Contains([{column}], '{query}')";
            control.RefreshData();
            Cursor.Current = Cursors.Default;
        }

        /// <summary>
        /// Gridə göndərilən sütunun foreColor-unu qırmızı yaxud yaşıl edirik. 
        /// </summary>
        /// <param name="column">Hansı sütunda əməliyyat aparılacaqsa onu seçirik</param>
        /// <param name="value1">Yaşıl rəngdə yazılmasını istədiyimiz dəyəri göndəririk string formatında</param>
        /// <param name="value2">Qırmızı rəngdə yazılmasını istədiyimi dəyəri göndəririk string formatında</param>
        /// <param name="eventArgs">Gridin RowCellCtyle eventi göndərilir</param>
        /// <param name="grid">Hansı grid üzərində dəyişiklik olunacaqsa o grid göndərilir</param>
        public static void GridViewStatusDisplayColor(GridColumn column, string value1, string value2, RowCellStyleEventArgs eventArgs, GridView grid)
        {
            if (eventArgs.Column == column)
            {
                if (eventArgs.CellValue != null)
                {
                    if (eventArgs.CellValue.ToString() == value1)
                    {
                        eventArgs.Appearance.ForeColor = Color.Green;
                        eventArgs.Appearance.FontStyleDelta = FontStyle.Bold;
                    }
                    else if (eventArgs.CellValue.ToString() == value2)
                    {
                        eventArgs.Appearance.ForeColor = ColorTranslator.FromHtml("#e74c3c");
                        eventArgs.Appearance.FontStyleDelta = FontStyle.Bold;
                    }
                }
            }
        }

        public static bool ManualDialogResult(string _message, string _title, MessageBoxButtons _button, MessageBoxIcon _icon)
        {
            MessageBoxManager.Register();
            if (MessageBox.Show(_message, _title, _button, _icon) == DialogResult.Yes)
            {
                MessageBoxManager.Unregister();
                return true;
            }
            MessageBoxManager.Unregister();
            return false;
        }

        public static void ManualMessageBox(string _message, string _title, MessageBoxButtons _button, MessageBoxIcon _icon)
        {
            MessageBoxManager.Register();
            MessageBox.Show(_message, _title, _button, _icon);
            MessageBoxManager.Unregister();
        }

        public static void ExportExcelGridData(string filename, GridView gridView)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (gridView.RowCount is 0)
            {
                ShowMessage.Message(AutoMessage.NotFoundData,UserControls.MessageForm.enmType.Info);
                return;
            }
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "Excel faylı|*.xlsx";
            saveFile.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            saveFile.OverwritePrompt = true; //varsa soruşmadan üstünə yazması üçün false olaraq qalmalıdır
            saveFile.FileName = filename + "_" + DateTime.Now.ToShortDateString() + ".xlsx";
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                gridView.ExportToXlsx(saveFile.FileName, new XlsxExportOptionsEx
                {
                    ExportType = ExportType.WYSIWYG
                });
            }
            Cursor.Current = Cursors.Default;
        }
    }
}