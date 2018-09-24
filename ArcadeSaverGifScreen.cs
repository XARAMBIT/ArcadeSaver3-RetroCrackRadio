using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace ArcadeSaver
{
    public partial class ArcadeSaverGifScreen : Form
    {
        [DllImport("user32.dll")]
        static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);

        [DllImport("user32.dll")]
        static extern int SetWindowLong(IntPtr hWnd, int nIndex, IntPtr dwNewLong);

        [DllImport("user32.dll", SetLastError = true)]
        static extern int GetWindowLong(IntPtr hWnd, int nIndex);

        [DllImport("user32.dll")]
        static extern bool GetClientRect(IntPtr hWnd, out Rectangle lpRect);

        private System.Drawing.Point mouseLocation;
        private bool previewMode = false;
        private int rInt;
        private int rIntLast;

        public ArcadeSaverGifScreen(System.Drawing.Rectangle Bounds)
        {
            InitializeComponent();
            this.Bounds = Bounds;
        }

        public ArcadeSaverGifScreen(IntPtr PreviewWndHandle)
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

        private void TimerSwitchGame_Tick(object sender, EventArgs e)
        {
            Random r = new Random();
            do
            {
                rInt = r.Next(1, 23);
            } while (rInt == rIntLast);
            rIntLast = rInt;
            SelectNewGame(rInt);
            if (previewMode)
            {
                TimerSwitchGame.Interval = r.Next(15000, 30000);
            }
            else
            {
                TimerSwitchGame.Interval = r.Next(60000, 120000);
            }
        }

        private void ArcadePictureBox_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ArcadeSaverGifScreen_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Application.Exit();
            }
            else
            {
                Application.Exit();
            }
        }

        private void ArcadeSaverGifScreen_Load(object sender, EventArgs e)
        {
            Random r = new Random();
            rInt = r.Next(1, 23);
            SelectNewGame(rInt);
            TimerSwitchGame.Interval = r.Next(30000, 60000);
            if (!previewMode)
            {
                Cursor.Hide();
                TopMost = true;
            }
        }

        private void ArcadePictureBox_MouseMove(object sender, MouseEventArgs e)
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

        private void SelectNewGame(int game)
        {
            switch (game)
            {
                case 1:
                    ArcadePictureBox.Image = ArcadeSaver.Properties.Resources.bombjack;
                    break;
                case 2:
                    ArcadePictureBox.Image = ArcadeSaver.Properties.Resources.defenderg;
                    break;
                case 3:
                    ArcadePictureBox.Image = ArcadeSaver.Properties.Resources.dkong;
                    break;
                case 4:
                    ArcadePictureBox.Image = ArcadeSaver.Properties.Resources.dkongjre;
                    break;
                case 5:
                    ArcadePictureBox.Image = ArcadeSaver.Properties.Resources.galaxian;
                    break;
                case 6:
                    ArcadePictureBox.Image = ArcadeSaver.Properties.Resources.gyruss;
                    break;
                case 7:
                    ArcadePictureBox.Image = ArcadeSaver.Properties.Resources.invaders;
                    break;
                case 8:
                    ArcadePictureBox.Image = ArcadeSaver.Properties.Resources.invadpt2;
                    break;
                case 9:
                    ArcadePictureBox.Image = ArcadeSaver.Properties.Resources.joustr;
                    break;
                case 10:
                    ArcadePictureBox.Image = ArcadeSaver.Properties.Resources.missile1;
                    break;
                case 11:
                    ArcadePictureBox.Image = ArcadeSaver.Properties.Resources.mrdo;
                    break;
                case 12:
                    ArcadePictureBox.Image = ArcadeSaver.Properties.Resources.pacman;
                    break;
                case 13:
                    ArcadePictureBox.Image = ArcadeSaver.Properties.Resources.qbert;
                    break;
                case 14:
                    ArcadePictureBox.Image = ArcadeSaver.Properties.Resources.sinistar2;
                    break;
                case 15:
                    ArcadePictureBox.Image = ArcadeSaver.Properties.Resources.zaxxon;
                    break;
                case 16:
                    ArcadePictureBox.Image = ArcadeSaver.Properties.Resources.bublbobl;
                    break;
                case 17:
                    ArcadePictureBox.Image = ArcadeSaver.Properties.Resources.docastle;
                    break;
                case 18:
                    ArcadePictureBox.Image = ArcadeSaver.Properties.Resources.galaga3;
                    break;
                case 19:
                    ArcadePictureBox.Image = ArcadeSaver.Properties.Resources.gradius;
                    break;
                case 20:
                    ArcadePictureBox.Image = ArcadeSaver.Properties.Resources.hangon;
                    break;
                case 21:
                    ArcadePictureBox.Image = ArcadeSaver.Properties.Resources.mspacman;
                    break;
                case 22:
                    ArcadePictureBox.Image = ArcadeSaver.Properties.Resources.regulus;
                    break;
                case 23:
                    ArcadePictureBox.Image = ArcadeSaver.Properties.Resources.tapper;
                    break;
                default:
                    ArcadePictureBox.Image = ArcadeSaver.Properties.Resources.invaders;
                    break;
            }
        }
    }
}
