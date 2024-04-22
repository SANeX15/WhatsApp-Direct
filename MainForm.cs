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
            Mode.SelectedIndex = Properties.Settings.Default.Mode;
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
            WASend.CallWA(Mode.SelectedIndex, Code.Text, MbNo.Text, MsgEnabled.Enabled, MsgBox.Text);
            
        }
        private void Mode_SelectedIndexChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Mode = Mode.SelectedIndex;
            Properties.Settings.Default.Save();
        }
        private void Title_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }
        private void MsgBoxEnabled()
        {
            switch (MsgEnabled.Checked)
            {
                case true:
                    this.Height = 360;
                    MsgBox.Enabled = true;
                    groupBox2.Text = "Direct";
                    break;
                case false:
                    this.Height = 180;
                    MsgBox.Enabled = false;
                    groupBox2.Text = string.Empty;
                    break;
            }
            Properties.Settings.Default.MsgEnabled = MsgEnabled.Checked;
            Properties.Settings.Default.Save();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            MsgBoxEnabled();
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
    }
}
