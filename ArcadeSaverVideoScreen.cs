using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;
using System.Linq;
using Microsoft.Win32;

namespace ArcadeSaver
{
    public partial class ArcadeSaverVideoScreen : Form
    {
        [DllImport("user32.dll")]
        static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);

        [DllImport("user32.dll")]
        static extern int SetWindowLong(IntPtr hWnd, int nIndex, IntPtr dwNewLong);

        [DllImport("user32.dll", SetLastError = true)]
        static extern int GetWindowLong(IntPtr hWnd, int nIndex);

        [DllImport("user32.dll")]
        static extern bool GetClientRect(IntPtr hWnd, out Rectangle lpRect);

        private Point mouseLocation;
        private Point mouseLocationPlayer;
        private bool mainScreen = true;
        private bool previewMode = false;
        private int rInt;
        private int rIntLast;
        private string videoFile;
        private int videoFileCount = 0;
        private string supportedExtensions = "*.avi,*.mp4";

        private int renderMode = (int)Registry.GetValue(@"HKEY_CURRENT_USER\SOFTWARE\ArcadeSaver3", "RenderMode", 0);
        private string videoFolder = (string)Registry.GetValue(@"HKEY_CURRENT_USER\SOFTWARE\ArcadeSaver3", "VideoFolder", "C:");
        private int audio = (int)Registry.GetValue(@"HKEY_CURRENT_USER\SOFTWARE\ArcadeSaver3", "Audio", 0);
        private int volume = (int)Registry.GetValue(@"HKEY_CURRENT_USER\SOFTWARE\ArcadeSaver3", "Volume", 5);

        public ArcadeSaverVideoScreen(System.Drawing.Rectangle Bounds, bool MainMonitor)
        {
            mainScreen = MainMonitor;
            InitializeComponent();
            this.Bounds = Bounds;
        }

        public ArcadeSaverVideoScreen(IntPtr PreviewWndHandle)
        {
            previewMode = true;
            InitializeComponent();

            // Set the preview window as the parent of this window
            SetParent(this.Handle, PreviewWndHandle);

            // Make this a child window so it will close when the parent dialog closes
            // GWL_STYLE = -16, WS_CHILD = 0x40000000
            SetWindowLong(this.Handle, -16, new IntPtr(GetWindowLong(this.Handle, -16) | 0x40000000));

            // Place our window inside the parent
            GetClientRect(PreviewWndHandle, out Rectangle ParentRect);
            Size = ParentRect.Size;
            Location = new Point(0, 0);
        }

        private void ArcadeSaverVideoScreen_Load(object sender, EventArgs e)
        {
            // setup audio
            switch (audio)
            {
                case 0:
                    ArcadeMediaPlayer.settings.volume = 0;
                    break;
                case 1:
                    if (mainScreen) ArcadeMediaPlayer.settings.volume = volume; else ArcadeMediaPlayer.settings.volume = 0;
                    break;
                case 2:
                    ArcadeMediaPlayer.settings.volume = volume;
                    break;
            }

            // count the number of supported video files ther is in the configured folder
            try
            {
                foreach (string supportedFile in Directory.GetFiles(videoFolder, "*.*", 
                    SearchOption.AllDirectories).Where(s => supportedExtensions.Contains(Path.GetExtension(s).ToLower())))
                {
                    videoFileCount = videoFileCount + 1;   
                }
            }
            catch (System.Exception excpt)
            {
                Console.WriteLine(excpt.Message);
                // hide media player to reveal error message
                ArcadeText.Text = "Error retrieving mp4 video filelist from folder " + videoFolder;
                ArcadeMediaPlayer.Visible = false;
                videoFileCount = 0;
            }

            // select first video to be played
            if (videoFileCount > 0)
            {
                SelectNewGame();
                TimerVideoEnd.Enabled = true;
            }
            else
            {
                ArcadeText.Text = "No avi or mp4 video files found in folder " + videoFolder;
                ArcadeMediaPlayer.Visible = false;
                TimerVideoEnd.Enabled = false;
            }

            if (!previewMode)
            {
                Cursor.Hide();
                TopMost = true;
            }
        }

        private void ArcadeMediaPlayer_ClickEvent(object sender, AxWMPLib._WMPOCXEvents_ClickEvent e)
        {
            if (!previewMode)
                Application.Exit();
        }

        private void ArcadeMediaPlayer_MouseMoveEvent(object sender, AxWMPLib._WMPOCXEvents_MouseMoveEvent e)
        {
            if (!mouseLocationPlayer.IsEmpty)
            {
                // Terminate if mouse is moved a significant distance
                if (Math.Abs(mouseLocationPlayer.X - e.fX) > 5 ||
                    Math.Abs(mouseLocationPlayer.Y - e.fY) > 5)
                    if (!previewMode)
                        Application.Exit();
            }
            // Update current mouse location
            mouseLocationPlayer.X = e.fX;
            mouseLocationPlayer.Y = e.fY;
        }

        private void ArcadeSaverVideoScreen_MouseMove(object sender, MouseEventArgs e)
        {
            if (!mouseLocation.IsEmpty)
            {
                // Terminate if mouse is moved a significant distance
                if (Math.Abs(mouseLocation.X - e.X) > 5 ||
                    Math.Abs(mouseLocation.Y - e.Y) > 5)
                    if (!previewMode)
                        Application.Exit();
            }
            // Update current mouse location
            mouseLocation = e.Location;
        }

        private void SelectNewGame()
        {
            Random r = new Random();
            do
            {
                rInt = r.Next(1, videoFileCount);
            } while ((rInt == rIntLast) && (videoFileCount != 1));
            rIntLast = rInt;

            int current = 0;
            try
            {
                foreach (string supportedFile in Directory.GetFiles(videoFolder, "*.*", 
                    SearchOption.AllDirectories).Where(s => supportedExtensions.Contains(Path.GetExtension(s).ToLower())))
                {
                    current = current + 1;
                    if (current == rInt)
                    {
                        videoFile = supportedFile;
                    }
                }
                ArcadeMediaPlayer.URL = videoFile;
            }
            catch (System.Exception excpt)
            {
                Console.WriteLine(excpt.Message);
            }
            return;
        }

        private void TimerVideoEnd_Tick(object sender, EventArgs e)
        {
            if (ArcadeMediaPlayer.playState != WMPLib.WMPPlayState.wmppsPlaying)
            {
                SelectNewGame();
            }
        }

        private void ArcadeMediaPlayer_KeyPressEvent(object sender, AxWMPLib._WMPOCXEvents_KeyPressEvent e)
        {
            if (!previewMode)
                Application.Exit();
        }

        private void ArcadeSaverVideoScreen_KeyDown(object sender, KeyEventArgs e)
        {
            if (!previewMode)
                Application.Exit();
        }
    }
}
