using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Web;

namespace WhatsApp_Direct
{
    public partial class MainForm : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        string watermark = "Mobile Number";
        public MainForm()
        {
            InitializeComponent();
            MbNo.ForeColor = Color.Gray;
            MbNo.Text = watermark;
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Mode.Checked = Properties.Settings.Default.WebMode;
            MsgEnabled.Checked = Properties.Settings.Default.MsgEnabled;
        }

        private void MinimiseBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void TitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }

        private void MbNo_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                Call();
            }
        }

        private void GO_Click(object sender, EventArgs e)
        {
            Call();
        }

        private void Call()
        {
            WASend.CallWA(Mode.Checked, Code.Text, MbNo.Text, MsgEnabled.Enabled, MsgBox.Text);
        }

        private void Title_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }

        private void MbNo_Leave(object sender, EventArgs e)
        {
            if (MbNo.Text.Length == 0)
            {
                MbNo.Text = watermark;
                MbNo.ForeColor = Color.Gray;
            }
        }

        private void MbNo_Enter(object sender, EventArgs e)
        {
            if (MbNo.Text == watermark)
            {
                MbNo.Text = string.Empty;
                MbNo.ForeColor = Color.White;
            }
        }

        private void msgEnabled_CheckedChanged(object sender, EventArgs e)
        {
            switch (MsgEnabled.Checked)
            {
                case true:
                    this.Height = 240;
                    MsgBox.Enabled = true;
                    groupBox2.Text = "Direct";
                    MsgEnabled.ImageIndex = 1;
                    break;
                case false:
                    this.Height = 110;
                    MsgBox.Enabled = false;
                    groupBox2.Text = string.Empty;
                    MsgEnabled.ImageIndex = 0;
                    break;
            }
            Properties.Settings.Default.MsgEnabled = MsgEnabled.Checked;
            Properties.Settings.Default.Save();
        }

        private void Mode_CheckedChanged(object sender, EventArgs e)
        {
            switch (Mode.Checked)
            {
                case true:
                    Mode.ImageIndex = 1;
                    break;
                case false:
                    Mode.ImageIndex = 0;
                    break;
            }
            Properties.Settings.Default.WebMode = Mode.Checked;
            Properties.Settings.Default.Save();
        }
    }
}
