using KeyboardHookLibrary;

namespace ClipboardPlus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //KeyCodes https://docs.microsoft.com/en-us/windows/win32/inputdev/virtual-key-codes

            var khm = new KeyboardHookManager();

            khm.RegisterHotkey(KeyboardHookLibrary.ModifierKeys.Control |
            KeyboardHookLibrary.ModifierKeys.Shift, 0x43, () =>
            {
                MessageBox.Show("Ctrl+Shift+C detected");
            });
            khm.Start();
        }
    }
}