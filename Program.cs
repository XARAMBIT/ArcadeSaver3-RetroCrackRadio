using Microsoft.Win32;
using System;
using System.Windows.Forms;

namespace ArcadeSaver
{
    static class Program
    {

        static int renderMode;

        /// The main entry point for the application.
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // create registry keys if not present
            if (Registry.GetValue(@"HKEY_CURRENT_USER\SOFTWARE\ArcadeSaver3", "RenderMode", 0) == null)
            {
                Registry.SetValue(@"HKEY_CURRENT_USER\SOFTWARE\ArcadeSaver3", "RenderMode", 0, RegistryValueKind.DWord);
                Registry.SetValue(@"HKEY_CURRENT_USER\SOFTWARE\ArcadeSaver3", "VideoFolder", "C:", RegistryValueKind.String);
                Registry.SetValue(@"HKEY_CURRENT_USER\SOFTWARE\ArcadeSaver3", "Audio", 0, RegistryValueKind.DWord);
                Registry.SetValue(@"HKEY_CURRENT_USER\SOFTWARE\ArcadeSaver3", "Volume", 5, RegistryValueKind.DWord);
            }
            renderMode = (int)Registry.GetValue(@"HKEY_CURRENT_USER\SOFTWARE\ArcadeSaver3", "RenderMode", 0);

            if (args.Length > 0)
            {
                string firstArgument = args[0].ToLower().Trim();
                string secondArgument = null;

                // Handle cases where arguments are separated by colon.
                // Examples: /c:1234567 or /P:1234567
                if (firstArgument.Length > 2)
                {
                    secondArgument = firstArgument.Substring(3).Trim();
                    firstArgument = firstArgument.Substring(0, 2);
                }
                else if (args.Length > 1)
                    secondArgument = args[1];

                if (firstArgument == "/c")           // Configuration mode
                {
                    ArcadeSaverConfig configForm = new ArcadeSaverConfig();
                    configForm.ShowDialog();
                    return;
                }
                else if (firstArgument == "/p")      // Preview mode
                {
                    if (secondArgument == null)
                    {
                        MessageBox.Show("The expected window handle was not provided.",
                            "Arcade Saver 3", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                    // TODO screen scaling on preview for windows 10
                    // Computer\HKEY_CURRENT_USER\Control Panel\Desktop\WindowMetrics AppliedDPI, normally 96 (x1) or 168 (x2)
                    // scale = AppliedDPI / 96
                    IntPtr previewWndHandle = new IntPtr(long.Parse(secondArgument));
                    if (renderMode == 0)
                    {
                        Application.Run(new ArcadeSaverGifScreen(previewWndHandle));
                    }
                    else
                    {
                        Application.Run(new ArcadeSaverVideoScreen(previewWndHandle));
                    }
                }
                else if (firstArgument == "/s")      // Full-screen mode
                {
                    ShowScreenSaver();
                    Application.Run();
                }
                else    // Undefined argument
                {
                    MessageBox.Show("The command line argument \"" + firstArgument + "\" is not valid.",
                        "Arcade Saver 3", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else    // No arguments - treat like /s
            {
                ShowScreenSaver();
                Application.Run();
            }
        }

        static void ShowScreenSaver()
        {
            foreach (Screen screen in Screen.AllScreens)
            {
                if (screen.Primary)
                {
                    if (renderMode == 0)
                    {
                        ArcadeSaverGifScreen screensaver = new ArcadeSaverGifScreen(screen.Bounds);
                        screensaver.Show();
                    }
                    else
                    {
                        ArcadeSaverVideoScreen screensaver = new ArcadeSaverVideoScreen(screen.Bounds, true);
                        screensaver.Show();
                    }
                }
                if (!screen.Primary)
                {
                    //return;
                    if (renderMode == 0)
                    {
                        BlankSaverScreen screensaver = new BlankSaverScreen(screen.Bounds);
                        screensaver.Show();
                    }
                    else
                    {
                        ArcadeSaverVideoScreen screensaver = new ArcadeSaverVideoScreen(screen.Bounds, false);
                        screensaver.Show();
                    }
                }

            }
        }
    }
}
