﻿using System;
using System.Collections.Generic;
using KeyboardHookLibrary;

namespace ClipboardPlus
{
    public partial class EditorForm : Form
    {
        public EditorForm()
        {
            InitializeComponent();

            //Remove ControlBoxes and Icons
            this.FormBorderStyle = FormBorderStyle.None;
            this.ControlBox = false;
            this.ShowIcon = false;
            //Hide in Taskbar
            this.ShowInTaskbar = false;
            //Always on Top of other Applications
            this.TopMost = true;
        }

        #region Class Variables
        //Size Program is started with (used when hiding by Scale(0, 0))
        Size InitialSize;

        //KeboardHookManager Instance
        KeyboardHookManager khm = new KeyboardHookManager();

        #endregion

        /// <summary>
        /// When Form is loaded
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditorForm_Load(object sender, EventArgs e)
        {
            InitialSize = Size;
            this.Size = new Size(0, 0);
            StartKeyhooker();
        }

        #region Keybind Management

        /// <summary>
        /// Sets a Hook for a certain Keybind
        /// </summary>
        void StartKeyhooker()
        {
            /* KeyCodes https://docs.microsoft.com/en-us/windows/win32/inputdev/virtual-key-codes | https://www.codeproject.com/Articles/1273010/Global-Hotkeys-within-Desktop-Applications */

            khm.RegisterHotkey(KeyboardHookLibrary.ModifierKeys.Control |
            KeyboardHookLibrary.ModifierKeys.Shift, 0x43, () =>
            {
                Invoke(new Action(() => { this.Size = InitialSize; OpenEditor(); }));
            });

            khm.RegisterHotkey(KeyboardHookLibrary.ModifierKeys.Control |
            KeyboardHookLibrary.ModifierKeys.Shift, 0x56, () =>
            {
                Invoke(new Action(() => { this.Size = new Size(0, 0); }));
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
            richTextBox1.SelectAll();
            richTextBox1.Copy();
            CloseForm();   
        }
        /// <summary>
        /// Executes when Cancel-Button is pressed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cancel_btn_Click(object sender, EventArgs e)
        {
            CloseForm();   
        }
        /// <summary>
        /// Executes when Menu-Button is pressed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menu_btn_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(() => {
                MenuForm menu = new MenuForm();
                menu.ShowDialog();
            });
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
        }

        #endregion

        #region ControlFunctions

        /// <summary>
        /// Executes when Editor is opened
        /// </summary>
        void OpenEditor()
        {
            richTextBox1.Clear();
            richTextBox1.Paste();
        }

        /// <summary>
        /// Executes when Editor is closed
        /// </summary>
        void CloseForm()
        {
            this.Size = new Size(0, 0);
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
