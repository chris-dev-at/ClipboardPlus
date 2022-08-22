using KeyboardHookLibrary;
using Microsoft.Win32;

namespace ClipboardPlus
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void startup_btn_CheckedChanged(object sender, EventArgs e)
        {
            if (startup_btn.Checked)
            {
                RegistryKey reg = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
                reg.SetValue("ClipboardPlus", Application.ExecutablePath.ToString());
            }
        }
    }
}