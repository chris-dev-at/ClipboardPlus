using KeyboardHookLibrary;

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
    }
}