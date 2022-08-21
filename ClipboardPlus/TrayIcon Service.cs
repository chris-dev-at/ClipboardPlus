using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClipboardPlus
{
    public partial class TrayIcon_Service : Form
    {
        public TrayIcon_Service()
        {
            InitializeComponent();
            //hide it
            this.Size = new Size(0, 0);
        }

        /// <summary>
        /// Main Function of TrayIcon_Service
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TrayIcon_Service_Load(object sender, EventArgs e)
        {
            //take the icon of the Executeable
            notifyIcon.Icon = Icon.ExtractAssociatedIcon("ClipboardPlus.exe");

            notifyIcon.Visible = true;
            notifyIcon.ContextMenuStrip = TrayIconContextStripMenu;
            //this.Hide(); 
        }


        #region MenuButtons

        private void notifyIcon_MouseClick(object sender, MouseEventArgs e)
        {
            //show the contextstrip right next to the mouse
            notifyIcon.ContextMenuStrip.Show(new Point(Cursor.Position.X + 1, Cursor.Position.Y + 1));
        }

        private void openEditorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Invoke(new Action(() => { Program.editorForm.OpenEditor(); }));
        }

        private void openMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Invoke(new Action(() => { Program.editorForm.OpenMenu(); }));
        }

        private void searchForUpdatesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Todo
            //Make Static Function for Searching for Updates and redirect to it here
        }

        private void githubPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", "https://github.com/chris-dev-at/ClipboardPlus");
        }

        private void christianWToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", "https://chris-dev.at");
        }

        private void mulhamTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", "https://taylouni.me");
        }

        private void exitProgrammToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion
    }
}
