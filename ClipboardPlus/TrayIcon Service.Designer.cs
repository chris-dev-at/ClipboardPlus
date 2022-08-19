namespace ClipboardPlus
{
    partial class TrayIcon_Service
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrayIcon_Service));
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.TrayIconContextStripMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openEditorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchForUpdatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.githubPageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creditsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.christianWToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mulhamTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitProgrammToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TrayIconContextStripMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon
            // 
            this.notifyIcon.Text = "ClipboardPlus";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseClick);
            // 
            // TrayIconContextStripMenu
            // 
            this.TrayIconContextStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openEditorToolStripMenuItem,
            this.openMenuToolStripMenuItem,
            this.moreToolStripMenuItem,
            this.exitProgrammToolStripMenuItem});
            this.TrayIconContextStripMenu.Name = "TrayIconContextStripMenu";
            this.TrayIconContextStripMenu.Size = new System.Drawing.Size(191, 92);
            // 
            // openEditorToolStripMenuItem
            // 
            this.openEditorToolStripMenuItem.Name = "openEditorToolStripMenuItem";
            this.openEditorToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.openEditorToolStripMenuItem.Text = "Open Editor";
            this.openEditorToolStripMenuItem.Click += new System.EventHandler(this.openEditorToolStripMenuItem_Click);
            // 
            // openMenuToolStripMenuItem
            // 
            this.openMenuToolStripMenuItem.Name = "openMenuToolStripMenuItem";
            this.openMenuToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.openMenuToolStripMenuItem.Text = "Open Settings (Menu)";
            this.openMenuToolStripMenuItem.Click += new System.EventHandler(this.openMenuToolStripMenuItem_Click);
            // 
            // moreToolStripMenuItem
            // 
            this.moreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchForUpdatesToolStripMenuItem,
            this.githubPageToolStripMenuItem,
            this.creditsToolStripMenuItem});
            this.moreToolStripMenuItem.Name = "moreToolStripMenuItem";
            this.moreToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.moreToolStripMenuItem.Text = "More";
            // 
            // searchForUpdatesToolStripMenuItem
            // 
            this.searchForUpdatesToolStripMenuItem.Name = "searchForUpdatesToolStripMenuItem";
            this.searchForUpdatesToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.searchForUpdatesToolStripMenuItem.Text = "Search for Updates";
            this.searchForUpdatesToolStripMenuItem.Click += new System.EventHandler(this.searchForUpdatesToolStripMenuItem_Click);
            // 
            // githubPageToolStripMenuItem
            // 
            this.githubPageToolStripMenuItem.Name = "githubPageToolStripMenuItem";
            this.githubPageToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.githubPageToolStripMenuItem.Text = "Github Page";
            this.githubPageToolStripMenuItem.Click += new System.EventHandler(this.githubPageToolStripMenuItem_Click);
            // 
            // creditsToolStripMenuItem
            // 
            this.creditsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.christianWToolStripMenuItem,
            this.mulhamTToolStripMenuItem});
            this.creditsToolStripMenuItem.Name = "creditsToolStripMenuItem";
            this.creditsToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.creditsToolStripMenuItem.Text = "Credits";
            // 
            // christianWToolStripMenuItem
            // 
            this.christianWToolStripMenuItem.Name = "christianWToolStripMenuItem";
            this.christianWToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.christianWToolStripMenuItem.Text = "Christian W.";
            this.christianWToolStripMenuItem.Click += new System.EventHandler(this.christianWToolStripMenuItem_Click);
            // 
            // mulhamTToolStripMenuItem
            // 
            this.mulhamTToolStripMenuItem.Name = "mulhamTToolStripMenuItem";
            this.mulhamTToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.mulhamTToolStripMenuItem.Text = "Mulham T.";
            this.mulhamTToolStripMenuItem.Click += new System.EventHandler(this.mulhamTToolStripMenuItem_Click);
            // 
            // exitProgrammToolStripMenuItem
            // 
            this.exitProgrammToolStripMenuItem.Name = "exitProgrammToolStripMenuItem";
            this.exitProgrammToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.exitProgrammToolStripMenuItem.Text = "Exit Program";
            this.exitProgrammToolStripMenuItem.Click += new System.EventHandler(this.exitProgrammToolStripMenuItem_Click);
            // 
            // TrayIcon_Service
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 416);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TrayIcon_Service";
            this.ShowIcon = true;
            this.ShowInTaskbar = false;
            this.Text = "TrayIcon_Service";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.TrayIcon_Service_Load);
            this.TrayIconContextStripMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private NotifyIcon notifyIcon;
        private ContextMenuStrip TrayIconContextStripMenu;
        private ToolStripMenuItem openEditorToolStripMenuItem;
        private ToolStripMenuItem openMenuToolStripMenuItem;
        private ToolStripMenuItem moreToolStripMenuItem;
        private ToolStripMenuItem searchForUpdatesToolStripMenuItem;
        private ToolStripMenuItem githubPageToolStripMenuItem;
        private ToolStripMenuItem creditsToolStripMenuItem;
        private ToolStripMenuItem christianWToolStripMenuItem;
        private ToolStripMenuItem mulhamTToolStripMenuItem;
        private ToolStripMenuItem exitProgrammToolStripMenuItem;
    }
}