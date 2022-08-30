using System.Diagnostics;
using System.Runtime.InteropServices;

namespace ClipboardPlus
{
    internal static class Program
    {
        public static EditorForm editorForm;


        // Use DllImport to import the Win32 MessageBox function.
        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        public static extern int MessageBox(IntPtr hWnd, String text, String caption, uint type);


        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main(string[] args)
        {
            //prevent two applications starting
            if (Process.GetProcessesByName(Process.GetCurrentProcess().ProcessName).Length > 1)
                //Asking if old process should be closed or the new one should be closed
                if (MessageBox(new IntPtr(0), "Application already open!\nDo you want to close the old one?", "ClipboardPlus", 4) == 6)
                    //If Pressed Yes
                    foreach (Process p in Process.GetProcessesByName(Process.GetCurrentProcess().ProcessName))
                    {
                        //Kills every other process that is named ClipboardPlus
                        if (p.Id != Process.GetCurrentProcess().Id)
                            p.Kill();
                    }
                else
                    //If Pressed No
                    return;

            

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            editorForm = new EditorForm();

            Application.Run(editorForm);
        }
    }
}