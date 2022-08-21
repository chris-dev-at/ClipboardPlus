using System;
using System.Collections.Generic;
using KeyboardHookLibrary;

namespace ClipboardPlus
{
    public partial class EditorForm : Form
    {
        public EditorForm()
        {
            InitializeComponent();
        }

        #region Class Variables
        //Size Program is started with (used when hiding by Scale(0, 0))
        Size InitialSize;

        //KeboardHookManager Instance
        KeyboardHookManager khm = new KeyboardHookManager();
        Thread MenuThread;
        Thread TrayIconThread;
        public bool EditorOpen;

        #endregion

        /// <summary>
        /// When Form is loaded
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditorForm_Load(object sender, EventArgs e)
        {
            //Start TrayIcon
            TrayIconThread = new Thread(() =>
            {
                TrayIcon_Service form = new TrayIcon_Service();
                form.ShowDialog();
            });
            TrayIconThread.Start();

            InitialSize = Size;
            this.Size = new Size(0, 0);
            StartKeyhooker();

            //Close by default and hide in ALT + TAB Window;
            EditorOpen = false;

            //Look away please! Thanks :) (This is by no means efficient and never do this!!!)
            new Thread(() => { Invoke(new Action(delegate () { Thread.Sleep(1000); this.Hide(); })); }).Start();
        }


        #region Keybind Management

        /// <summary>
        /// Sets a Hook for a certain Keybind
        /// </summary>
        void StartKeyhooker()
        {
            /* KeyCodes https://docs.microsoft.com/en-us/windows/win32/inputdev/virtual-key-codes | https://www.codeproject.com/Articles/1273010/Global-Hotkeys-within-Desktop-Applications */

            //CTRL + SHIFT + C  ==> Open Editor & Change Clipboard
            khm.RegisterHotkey(KeyboardHookLibrary.ModifierKeys.Control |
            KeyboardHookLibrary.ModifierKeys.Shift, 0x43, () =>
            {
                Invoke(new Action(() => {
                    //If Editor is not open then open it
                    if (!EditorOpen)
                    { 
                        OpenEditor();
                    }
                    //If Editor is open then change the Clipboard
                    else
                        ChangeClipboard();
                }));
            });

            //CTRL + SHIFT + X  ==> Cancel Editor
            khm.RegisterHotkey(KeyboardHookLibrary.ModifierKeys.Control |
            KeyboardHookLibrary.ModifierKeys.Shift, 0x58, () =>
            {
                Invoke(new Action(() => { CancelClipboard(); }));
            });

            khm.Start();
        }

        /// <summary>
        /// Removes all Hooks
        /// </summary>
        void StopKeyhooker()
        {
            khm.UnregisterAll();
        }

        #endregion

        #region MenuButtons

        /// <summary>
        /// Executes when Change-Button is pressed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void change_btn_Click(object sender, EventArgs e)
        {
            ChangeClipboard();
        }
        /// <summary>
        /// Executes when Cancel-Button is pressed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cancel_btn_Click(object sender, EventArgs e)
        {
            CancelClipboard();   
        }
        /// <summary>
        /// Executes when Menu-Button is pressed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menu_btn_Click(object sender, EventArgs e)
        {
            OpenMenu();
        }

        #endregion

        #region ControlFunctions

        /// <summary>
        /// Reveals/Opens the Editor
        /// </summary>
        public void OpenEditor()
        {
            this.Size = InitialSize;
            this.Show();
            EditorOpen = true;
            richTextBox1.Clear();
            richTextBox1.Paste();
        }

        /// <summary>
        /// Closes/Hides the Editor
        /// </summary>
        public void CloseEditor()
        {
            EditorOpen = false;
            this.Size = new Size(0, 0);
            this.Hide();
        }

        /// <summary>
        /// Changes the Clipboard Content
        /// </summary>
        public void ChangeClipboard()
        {
            //If there is no Text in richTextBox then you cant copy it and the clipboard stays the same
            if (richTextBox1.TextLength == 0)
                Clipboard.Clear();
            else
            {
                richTextBox1.SelectAll();
                richTextBox1.Copy();
            }
            CloseEditor();
        }

        /// <summary>
        /// Cancels the Editor
        /// </summary>
        public void CancelClipboard()
        {
            CloseEditor();
        }

        /// <summary>
        /// Opens the Menu
        /// </summary>
        public void OpenMenu()
        {
            //prevents multiple instances of Menu to run
            if (MenuThread == null || !MenuThread.IsAlive)
            {
                this.TopMost = false;
                //Create new Thread to not Halt the EditorForm
                MenuThread = new Thread(() =>
                {
                    MenuForm menu = new MenuForm();
                    menu.ShowDialog();
                    //Try Catch if Application is exitted
                    try {  Invoke(new Action(() => { this.TopMost = true; })); } catch { }               
                    return;
                });
                MenuThread.SetApartmentState(ApartmentState.STA);
                MenuThread.Start();
            }
        }

        #endregion

        #region WindowMoveScript

        //Window-Drag Variables
        private bool _dragging = false;
        private Point _offset;
        private Point _start_point = new Point(0, 0);

        //Event Voids
        private void EditorForm_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;
            _start_point = new Point(e.X, e.Y);
        }
        private void EditorForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._start_point.X, p.Y - this._start_point.Y);
            }
        }
        private void EditorForm_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }

        #endregion

    }
}
