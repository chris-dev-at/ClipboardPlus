using Microsoft.Win32;
using System.Diagnostics;

namespace ClipboardPlus
{
    public partial class MenuForm : Form
    {
        //RunOnStartup Variables
        public bool RunOnStartup;
        private static readonly string StartupKey = "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run";
        private static readonly string StartupValue = Process.GetCurrentProcess().ProcessName;
        RegistryKey startupKey;

        public MenuForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Set RegistryKey
            startupKey = Registry.CurrentUser.OpenSubKey(StartupKey, true);
            
            //Check if Value Exists
            if(startupKey.GetValue(StartupValue) == null)
                RunOnStartup = false;
            else
                RunOnStartup = true;
            
            UpdateStartupButton();
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Updates Display of the Startup Button
        /// </summary>
        private void UpdateStartupButton()
        {
            if (RunOnStartup)
            {
                RunOnStartup_btn.Text = "Remove Startup Hook";
                startupKey.SetValue(StartupValue, Application.ExecutablePath.ToString() + " -autostarted");
            }
            else
            {
                RunOnStartup_btn.Text = "Set Startup Hook";
            }
        }
        private void RunOnStartup_btn_Click(object sender, EventArgs e)
        {
            RunOnStartup = !RunOnStartup;
            if (!RunOnStartup)
            {
                startupKey.DeleteValue(StartupValue);
            }
            UpdateStartupButton();
        }
    }
}