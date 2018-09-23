namespace ArcadeSaver
{
    partial class ArcadeSaverGifScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.TimerSwitchGame = new System.Windows.Forms.Timer(this.components);
            this.ArcadePictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ArcadePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // TimerSwitchGame
            // 
            this.TimerSwitchGame.Enabled = true;
            this.TimerSwitchGame.Interval = 30000;
            this.TimerSwitchGame.Tick += new System.EventHandler(this.TimerSwitchGame_Tick);
            // 
            // ArcadePictureBox
            // 
            this.ArcadePictureBox.BackColor = System.Drawing.Color.Black;
            this.ArcadePictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ArcadePictureBox.Image = global::ArcadeSaver.Properties.Resources.zaxxon;
            this.ArcadePictureBox.Location = new System.Drawing.Point(0, 0);
            this.ArcadePictureBox.Name = "ArcadePictureBox";
            this.ArcadePictureBox.Size = new System.Drawing.Size(735, 685);
            this.ArcadePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ArcadePictureBox.TabIndex = 2;
            this.ArcadePictureBox.TabStop = false;
            this.ArcadePictureBox.Click += new System.EventHandler(this.ArcadePictureBox_Click);
            this.ArcadePictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ArcadePictureBox_MouseMove);
            // 
            // ArcadeSaverScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(735, 685);
            this.Controls.Add(this.ArcadePictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ArcadeSaverScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Load += new System.EventHandler(this.ArcadeSaverGifScreen_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ArcadeSaverGifScreen_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.ArcadePictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox ArcadePictureBox;
        private System.Windows.Forms.Timer TimerSwitchGame;
    }
}

