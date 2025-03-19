using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToolApplication
{
    public partial class MainMenu : Form
    {
        private const int MaxClipboardEntries = 50;
        private List<string> clipboardHistory = new List<string>();
        private NotifyIcon trayIcon;
        private ContextMenuStrip trayMenu;
        private int copiedItemsCount = 0;

        public MainMenu()
        {
            InitializeComponent();
            ClipboardNotification.ClipboardUpdate += OnClipboardUpdate;
            UpdateStorageGroupBox();
        }

        private void OnClipboardUpdate(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText())
            {
                string text = Clipboard.GetText();
                if (!clipboardHistory.Contains(text))
                {
                    if (clipboardHistory.Count >= MaxClipboardEntries)
                    {
                        clipboardHistory.RemoveAt(clipboardHistory.Count - 1);
                        listBoxClipboard.Invoke((MethodInvoker)delegate
                        {
                            listBoxClipboard.Items.RemoveAt(listBoxClipboard.Items.Count - 1);
                        });
                    }
                    clipboardHistory.Insert(0, text);
                    listBoxClipboard.Invoke((MethodInvoker)delegate
                    {
                        listBoxClipboard.Items.Insert(0, text);
                    });
                    copiedItemsCount++;
                    UpdateStorageGroupBox();
                }
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            PasswordGen passwordGen = new PasswordGen();
            passwordGen.Show();
        }

        private void listBoxClipboard_DoubleClick(object sender, EventArgs e)
        {
            CopySelectedItemToClipboard();
        }

        private void CopySelectedItemToClipboard()
        {
            if (listBoxClipboard.SelectedItem != null)
            {
                Clipboard.SetText(listBoxClipboard.SelectedItem.ToString());
                MessageBox.Show("Text copied to clipboard!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void UpdateStorageGroupBox()
        {
            storagegroup_box.Text = $"Copied items: {copiedItemsCount}";
        }

        public static class ClipboardNotification
        {
            public static event EventHandler ClipboardUpdate;
            private static NotificationForm form = new NotificationForm();

            private class NotificationForm : Form
            {
                [DllImport("user32.dll")]
                private static extern bool AddClipboardFormatListener(IntPtr hWnd);

                private const int WM_CLIPBOARDUPDATE = 0x031D;

                public NotificationForm()
                {
                    AddClipboardFormatListener(this.Handle);
                }

                protected override void WndProc(ref Message m)
                {
                    if (m.Msg == WM_CLIPBOARDUPDATE)
                    {
                        ClipboardUpdate?.Invoke(null, EventArgs.Empty);
                    }
                    base.WndProc(ref m);
                }
            }
        }
    }
}
