namespace ArcadeSaver
{
    partial class ArcadeSaverVideoScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ArcadeSaverVideoScreen));
            this.ArcadeMediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.TimerVideoEnd = new System.Windows.Forms.Timer(this.components);
            this.ArcadeText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ArcadeMediaPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // ArcadeMediaPlayer
            // 
            this.ArcadeMediaPlayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ArcadeMediaPlayer.Enabled = true;
            this.ArcadeMediaPlayer.Location = new System.Drawing.Point(0, 0);
            this.ArcadeMediaPlayer.Name = "ArcadeMediaPlayer";
            this.ArcadeMediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("ArcadeMediaPlayer.OcxState")));
            this.ArcadeMediaPlayer.Size = new System.Drawing.Size(800, 450);
            this.ArcadeMediaPlayer.TabIndex = 0;
            this.ArcadeMediaPlayer.ClickEvent += new AxWMPLib._WMPOCXEvents_ClickEventHandler(this.ArcadeMediaPlayer_ClickEvent);
            this.ArcadeMediaPlayer.KeyPressEvent += new AxWMPLib._WMPOCXEvents_KeyPressEventHandler(this.ArcadeMediaPlayer_KeyPressEvent);
            this.ArcadeMediaPlayer.MouseMoveEvent += new AxWMPLib._WMPOCXEvents_MouseMoveEventHandler(this.ArcadeMediaPlayer_MouseMoveEvent);
            // 
            // TimerVideoEnd
            // 
            this.TimerVideoEnd.Interval = 1000;
            this.TimerVideoEnd.Tick += new System.EventHandler(this.TimerVideoEnd_Tick);
            // 
            // ArcadeText
            // 
            this.ArcadeText.AutoSize = true;
            this.ArcadeText.ForeColor = System.Drawing.Color.Yellow;
            this.ArcadeText.Location = new System.Drawing.Point(12, 12);
            this.ArcadeText.Name = "ArcadeText";
            this.ArcadeText.Size = new System.Drawing.Size(0, 13);
            this.ArcadeText.TabIndex = 1;
            // 
            // ArcadeSaverVideoScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ArcadeMediaPlayer);
            this.Controls.Add(this.ArcadeText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ArcadeSaverVideoScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Load += new System.EventHandler(this.ArcadeSaverVideoScreen_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ArcadeSaverVideoScreen_KeyDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ArcadeSaverVideoScreen_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.ArcadeMediaPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer TimerVideoEnd;
        private System.Windows.Forms.Label ArcadeText;
        private AxWMPLib.AxWindowsMediaPlayer ArcadeMediaPlayer;
    }
}