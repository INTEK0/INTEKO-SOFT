using İNTEKO.UserControls.Properties;
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
    public partial class MessageForm : Form
    {
        private int x, y;

        public MessageForm()
        {
            InitializeComponent();
            this.ShowInTaskbar = false;
        }

        public enum enmAction
        {
            wait,
            start,
            close
        }

        public enum enmType
        {
            Success,
            Warning,
            Error,
            Info
        }

        private MessageForm.enmAction action;

        private void timer1_Tick(object sender, EventArgs e)
        {
            switch (this.action)
            {
                case enmAction.wait:
                    timer1.Interval = 5000;
                    action = enmAction.close;
                    break;
                case MessageForm.enmAction.start:
                    this.timer1.Interval = 1;
                    this.Opacity += 0.1;
                    if (this.x < this.Location.X) { this.Left--; }
                    else
                    {
                        if (this.Opacity == 1.0) { action = MessageForm.enmAction.wait; }
                    }
                    break;
                case enmAction.close:
                    timer1.Interval = 1;
                    this.Opacity -= 0.1;
                    this.Left -= 3;
                    if (base.Opacity == 0.0) { base.Close(); }
                    break;
            }
        }

        public void showAlert(string msg, enmType type)
        {
            this.Opacity = 0.0;
            this.StartPosition = FormStartPosition.Manual;
            string fname;

            for (int i = 1; i < 10; i++)
            {
                fname = "alert" + i.ToString();
                MessageForm frm = (MessageForm)Application.OpenForms[fname];

                if (frm == null)
                {
                    this.Name = fname;
                    this.x = Screen.PrimaryScreen.WorkingArea.Width - this.Width + 15;
                    this.y = Screen.PrimaryScreen.WorkingArea.Height - this.Height * i - 5 * i;
                    this.Location = new Point(this.x, this.y);
                    break;
                }

            }
            this.x = Screen.PrimaryScreen.WorkingArea.Width - base.Width - 5;

            switch (type)
            {
                case enmType.Success:
                    this.pictureImage.SvgImage = Resources.check_bold;
                    this.BackColor = Color.SeaGreen;
                    break;
                case enmType.Error:
                    this.pictureImage.SvgImage = Resources.x_bold;
                    this.BackColor = Color.DarkRed;
                    break;
                case enmType.Info:
                    this.pictureImage.SvgImage = Resources.info_bold;
                    this.BackColor = Color.RoyalBlue;
                    break;
                case enmType.Warning:
                    this.pictureImage.SvgImage = Resources.warning_bold;
                    this.BackColor = Color.DarkOrange;
                    break;
            }


            this.lMessage.Text = msg;

            this.Show();
            this.action = enmAction.start;
            this.timer1.Interval = 1;
            this.timer1.Start();
        }
    }
}
