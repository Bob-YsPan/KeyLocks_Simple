using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace KeyLocks_Simple
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        public static extern short GetKeyState(int keyCode);

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;

        // Refrence: https://stackoverflow.com/questions/13477228/moving-window-by-click-drag-on-a-control
        // Allow Drag Drop On Control
        [DllImport("User32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        public Form1()
        {
            InitializeComponent();
        }

        // 更新KeyLED狀態，有變化才更新UI
        byte Last_keyCde = 0;
        private void UpdateStat()
        {
            byte keyCde = 0;
            bool CapsLock = (((ushort)GetKeyState(0x14)) & 0xffff) != 0;
            bool NumLock = (((ushort)GetKeyState(0x90)) & 0xffff) != 0;
            bool ScrollLock = (((ushort)GetKeyState(0x91)) & 0xffff) != 0;
            // Unix Permission Like Keycode status
            if (CapsLock)
            {
                if(CapsLock)
                {
                    keyCde += 2;
                }
            }
            if (NumLock)
            {
                if (NumLock)
                {
                    keyCde += 4;
                }
            }
            if (ScrollLock)
            {
                if (ScrollLock)
                {
                    keyCde += 1;
                }
            }
            // 當按鍵狀態有改變的時候，才變動icon，節省系統資源
            if(Last_keyCde != keyCde)
            {
                switch (keyCde)
                {
                    case 0:
                        notifyIcon.Icon = new Icon(Properties.Resources.Ixxx, new Size(128, 128));
                        stat_picBox.BackgroundImage = Properties.Resources.Bxxx;
                        break;
                    case 1:
                        notifyIcon.Icon = new Icon(Properties.Resources.IxxS, new Size(128, 128));
                        stat_picBox.BackgroundImage = Properties.Resources.BxxS;
                        break;
                    case 2:
                        notifyIcon.Icon = new Icon(Properties.Resources.IxAx, new Size(128, 128));
                        stat_picBox.BackgroundImage = Properties.Resources.BxAx;
                        break;
                    case 3:
                        notifyIcon.Icon = new Icon(Properties.Resources.IxAS, new Size(128, 128));
                        stat_picBox.BackgroundImage = Properties.Resources.BxAS;
                        break;
                    case 4:
                        notifyIcon.Icon = new Icon(Properties.Resources.I1xx, new Size(128, 128));
                        stat_picBox.BackgroundImage = Properties.Resources.B1xx;
                        break;
                    case 5:
                        notifyIcon.Icon = new Icon(Properties.Resources.I1xS, new Size(128, 128));
                        stat_picBox.BackgroundImage = Properties.Resources.B1xS;
                        break;
                    case 6:
                        notifyIcon.Icon = new Icon(Properties.Resources.I1Ax, new Size(128, 128));
                        stat_picBox.BackgroundImage = Properties.Resources.B1Ax;
                        break;
                    case 7:
                        notifyIcon.Icon = new Icon(Properties.Resources.I1AS, new Size(128, 128));
                        stat_picBox.BackgroundImage = Properties.Resources.B1AS;
                        break;
                }
                GC.Collect();
            }
            Last_keyCde = keyCde;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            notifyIcon.Icon = new Icon(Properties.Resources.Ixxx, new Size(128, 128));
        }

        private void notifyIcon_DoubleClick(object sender, EventArgs e)
        {
            // 按兩下Notify Icon顯示懸浮窗
            hide_Item.Text = "Hide to Tray";
            this.Show();
            GC.Collect();
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            // 當收到最小化指令隱藏視窗
            if (this.WindowState == FormWindowState.Minimized)
            {
                hide_Item.Text = "Show window";
                this.Hide();
                GC.Collect();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            UpdateStat();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            this.Hide();
            hide_Item.Text = "Show window";
            GC.Collect();
        }

        private void exit_Item_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button.Equals(MouseButtons.Right))
            {
                contextMenuStrip.Show(Cursor.Position);
            }
            else if(e.Button.Equals(MouseButtons.Left))
            {
                if (e.Button == MouseButtons.Left)
                {
                    ReleaseCapture();
                    SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
                }
            }
            GC.Collect();
        }

        private void hide_Item_Click(object sender, EventArgs e)
        {
            if(this.Visible)
            {
                hide_Item.Text = "Show window";
                this.Hide();
            }
            else
            {
                hide_Item.Text = "Hide to Tray";
                this.Show();
            }
            GC.Collect();
        }

        private void about_Item_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Simple Keyboard LED By Bob Pan.\nVersion V1.1 2022/03/21"
                , "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
            GC.Collect();
        }
    }
}
