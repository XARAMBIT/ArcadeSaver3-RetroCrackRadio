using System;
using System.Windows.Forms;

namespace ArcadeSaver
{
    public partial class BlankSaverScreen : Form
    {

        private System.Drawing.Point mouseLocation;
        private bool previewMode = false;

        public BlankSaverScreen(System.Drawing.Rectangle Bounds)
        {
            InitializeComponent();
            this.Bounds = Bounds;
        }

        private void BlankSaverScreen_Load(object sender, EventArgs e)
        {
            Cursor.Hide();
            TopMost = true;
        }

        private void BlankSaverScreen_MouseMove(object sender, MouseEventArgs e)
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

        private void BlankSaverScreen_KeyUp(object sender, KeyEventArgs e)
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

        private void BlankSaverScreen_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
