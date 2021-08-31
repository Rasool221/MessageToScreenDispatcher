using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MessageToScreenDispatcher
{
    public partial class Form1 : Form
    {
        private const int MONITOR_NAME = 1;
        private Form messageWindow = null;

        public Form1()
        {
            InitializeComponent();
            this.dispatchMessageToScreenButton.Enabled = false;
            this.terminateDispatchedWindowButton.Enabled = false;
            populateMonitorsList();
        }

        void populateMonitorsList()
        {
            this.Cursor = Cursors.WaitCursor;

            if (this.monitorsListBox.Items.Count > 0)
            {
                this.monitorsListBox.Items.Clear();
            }

            foreach (var screen in Screen.AllScreens)
            {
                string[] row = new string[2];
                row[0] = screen.Bounds.Width + ", " + screen.Bounds.Height;
                row[1] = screen.DeviceName;

                ListViewItem newRowItem = new ListViewItem(row);
                this.monitorsListBox.Items.Add(newRowItem);
            }

            this.Cursor = Cursors.Default;
        }

        private void refreshMonitorListButton_Click(object sender, EventArgs e)
        {
            populateMonitorsList();
            this.dispatchMessageToScreenButton.Enabled = false;
        }

        private void messageText_TextChanged(object sender, EventArgs e)
        {
            if (this.monitorsListBox.SelectedItems.Count > 0 && this.messageText.Text.Length > 0)
            {
                this.dispatchMessageToScreenButton.Enabled = true;
            }
            else
            {
                this.dispatchMessageToScreenButton.Enabled = false;
            }
        }

        private void dispatchMessageToScreenButton_Click(object sender, EventArgs e)
        {
            if (this.messageWindow != null)
            {
                MessageBox.Show("Error: Please ensure that you have terminated your last message");
                return;
            }

            if (this.monitorsListBox.SelectedItems.Count == 0 && this.messageText.Text.Length == 0)
            {
                MessageBox.Show("Error: Please ensure you have a monitor selected and text written.");
                return;
            }

            string selectedMonitorName = this.monitorsListBox.SelectedItems[0].SubItems[MONITOR_NAME].Text;

            foreach (var screen in Screen.AllScreens)
            {
                if (screen.DeviceName.Equals(selectedMonitorName))
                {
                    var messageWindow = new Form2();
                    messageWindow.SetBounds(screen.Bounds.X, screen.Bounds.Y, screen.Bounds.Width - 2, screen.Bounds.Height - 2);
                    messageWindow.MessageText = this.messageText.Text;
                    messageWindow.MessageLabel.Width = messageWindow.Width;
                    messageWindow.MessageLabel.Height = messageWindow.Height;
                    messageWindow.MessageLabel.Font = getCorrectSizedFont(messageWindow.MessageLabel, this.messageText.Text, screen.Bounds);
                    messageWindow.Show();
                    messageWindow.TopMost = true;
                    messageWindow.Location = screen.Bounds.Location;
                    this.messageWindow = messageWindow;
                    this.terminateDispatchedWindowButton.Enabled = true;
                    return;
                }
            }

            MessageBox.Show("Error: An unknown error has occured, please restart this program and try again.");
        }

        private Font getCorrectSizedFont(RichTextBox textBox, string messageText, Rectangle screenBounds)
        {
            int fontSize = 14;
            Font proposedFont = new Font("Arial", fontSize, FontStyle.Regular);

            using (Graphics graphics = textBox.CreateGraphics())
            {
                while (true)
                {
                    SizeF proposedTextSize = graphics.MeasureString(messageText, proposedFont);

                    if (screenBounds.Width > proposedTextSize.Width)
                    {
                        proposedFont.Dispose();
                        proposedFont = new Font("Arial", fontSize++, FontStyle.Regular);
                    }
                    else if (screenBounds.Width <= proposedTextSize.Width)
                    {
                        break;
                    }
                }
            }

            return proposedFont;
        }

        private void terminateDispatchedWindowButton_Click(object sender, EventArgs e)
        {
            if (this.messageWindow == null)
            {
                MessageBox.Show("Error: Couldn't locate the dispatched window, please close the window yourself using the Task Manager.");
                return;
            }

            this.messageWindow.Close();
            this.messageWindow = null;
            this.terminateDispatchedWindowButton.Enabled = false;
        }

        private void monitorsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.messageText.Text.Length > 0)
            {
                this.dispatchMessageToScreenButton.Enabled = true;
            }
        }
    }
}
