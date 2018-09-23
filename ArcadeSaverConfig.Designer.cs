namespace ArcadeSaver
{
    partial class ArcadeSaverConfig
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ArcadeSaverConfig));
            this.SaverMode = new System.Windows.Forms.GroupBox();
            this.DirectorySelect = new System.Windows.Forms.Button();
            this.Directory = new System.Windows.Forms.TextBox();
            this.ModeVideo = new System.Windows.Forms.RadioButton();
            this.ModeGif = new System.Windows.Forms.RadioButton();
            this.AudioOptions = new System.Windows.Forms.GroupBox();
            this.VolumeLabel = new System.Windows.Forms.Label();
            this.Volume = new System.Windows.Forms.NumericUpDown();
            this.AudioAll = new System.Windows.Forms.RadioButton();
            this.AudioSingle = new System.Windows.Forms.RadioButton();
            this.AudioOff = new System.Windows.Forms.RadioButton();
            this.FolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.OK = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.IconGalaxian = new System.Windows.Forms.PictureBox();
            this.VersionNo = new System.Windows.Forms.Label();
            this.SaverMode.SuspendLayout();
            this.AudioOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Volume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconGalaxian)).BeginInit();
            this.SuspendLayout();
            // 
            // SaverMode
            // 
            this.SaverMode.Controls.Add(this.DirectorySelect);
            this.SaverMode.Controls.Add(this.Directory);
            this.SaverMode.Controls.Add(this.ModeVideo);
            this.SaverMode.Controls.Add(this.ModeGif);
            this.SaverMode.Location = new System.Drawing.Point(12, 12);
            this.SaverMode.Name = "SaverMode";
            this.SaverMode.Size = new System.Drawing.Size(366, 108);
            this.SaverMode.TabIndex = 0;
            this.SaverMode.TabStop = false;
            this.SaverMode.Text = "Screen Saver Mode";
            // 
            // DirectorySelect
            // 
            this.DirectorySelect.Enabled = false;
            this.DirectorySelect.Location = new System.Drawing.Point(323, 71);
            this.DirectorySelect.Name = "DirectorySelect";
            this.DirectorySelect.Size = new System.Drawing.Size(24, 20);
            this.DirectorySelect.TabIndex = 3;
            this.DirectorySelect.Text = "...";
            this.DirectorySelect.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.DirectorySelect.UseVisualStyleBackColor = true;
            this.DirectorySelect.Click += new System.EventHandler(this.DirectorySelect_Click);
            // 
            // Directory
            // 
            this.Directory.BackColor = System.Drawing.SystemColors.Window;
            this.Directory.Enabled = false;
            this.Directory.Location = new System.Drawing.Point(21, 71);
            this.Directory.Name = "Directory";
            this.Directory.ReadOnly = true;
            this.Directory.Size = new System.Drawing.Size(295, 20);
            this.Directory.TabIndex = 2;
            // 
            // ModeVideo
            // 
            this.ModeVideo.AutoSize = true;
            this.ModeVideo.Location = new System.Drawing.Point(21, 48);
            this.ModeVideo.Name = "ModeVideo";
            this.ModeVideo.Size = new System.Drawing.Size(202, 17);
            this.ModeVideo.TabIndex = 1;
            this.ModeVideo.Text = "Loop videos from a folder (avi or mp4)";
            this.ModeVideo.UseVisualStyleBackColor = true;
            this.ModeVideo.CheckedChanged += new System.EventHandler(this.ModeVideo_CheckedChanged);
            // 
            // ModeGif
            // 
            this.ModeGif.AutoSize = true;
            this.ModeGif.Checked = true;
            this.ModeGif.Location = new System.Drawing.Point(21, 25);
            this.ModeGif.Name = "ModeGif";
            this.ModeGif.Size = new System.Drawing.Size(254, 17);
            this.ModeGif.TabIndex = 0;
            this.ModeGif.TabStop = true;
            this.ModeGif.Text = "Loop internal arcade game animations (no audio)";
            this.ModeGif.UseVisualStyleBackColor = true;
            this.ModeGif.CheckedChanged += new System.EventHandler(this.ModeGif_CheckedChanged);
            // 
            // AudioOptions
            // 
            this.AudioOptions.Controls.Add(this.VolumeLabel);
            this.AudioOptions.Controls.Add(this.Volume);
            this.AudioOptions.Controls.Add(this.AudioAll);
            this.AudioOptions.Controls.Add(this.AudioSingle);
            this.AudioOptions.Controls.Add(this.AudioOff);
            this.AudioOptions.Enabled = false;
            this.AudioOptions.Location = new System.Drawing.Point(16, 134);
            this.AudioOptions.Name = "AudioOptions";
            this.AudioOptions.Size = new System.Drawing.Size(271, 92);
            this.AudioOptions.TabIndex = 3;
            this.AudioOptions.TabStop = false;
            this.AudioOptions.Text = "Audio Options";
            // 
            // VolumeLabel
            // 
            this.VolumeLabel.AutoSize = true;
            this.VolumeLabel.Location = new System.Drawing.Point(215, 42);
            this.VolumeLabel.Name = "VolumeLabel";
            this.VolumeLabel.Size = new System.Drawing.Size(42, 13);
            this.VolumeLabel.TabIndex = 4;
            this.VolumeLabel.Text = "Volume";
            // 
            // Volume
            // 
            this.Volume.Location = new System.Drawing.Point(209, 58);
            this.Volume.Name = "Volume";
            this.Volume.Size = new System.Drawing.Size(45, 20);
            this.Volume.TabIndex = 3;
            this.Volume.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // AudioAll
            // 
            this.AudioAll.AutoSize = true;
            this.AudioAll.Location = new System.Drawing.Point(17, 65);
            this.AudioAll.Name = "AudioAll";
            this.AudioAll.Size = new System.Drawing.Size(167, 17);
            this.AudioAll.TabIndex = 2;
            this.AudioAll.Text = "Play audio on multiple screens";
            this.AudioAll.UseVisualStyleBackColor = true;
            // 
            // AudioSingle
            // 
            this.AudioSingle.AutoSize = true;
            this.AudioSingle.Location = new System.Drawing.Point(17, 42);
            this.AudioSingle.Name = "AudioSingle";
            this.AudioSingle.Size = new System.Drawing.Size(171, 17);
            this.AudioSingle.TabIndex = 1;
            this.AudioSingle.Text = "Play audio on main screen only";
            this.AudioSingle.UseVisualStyleBackColor = true;
            // 
            // AudioOff
            // 
            this.AudioOff.AutoSize = true;
            this.AudioOff.Checked = true;
            this.AudioOff.Location = new System.Drawing.Point(17, 19);
            this.AudioOff.Name = "AudioOff";
            this.AudioOff.Size = new System.Drawing.Size(68, 17);
            this.AudioOff.TabIndex = 0;
            this.AudioOff.TabStop = true;
            this.AudioOff.Text = "No audio";
            this.AudioOff.UseVisualStyleBackColor = true;
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(182, 245);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(92, 27);
            this.OK.TabIndex = 4;
            this.OK.Text = "&OK";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(286, 245);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(92, 27);
            this.Cancel.TabIndex = 5;
            this.Cancel.Text = "&Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // IconGalaxian
            // 
            this.IconGalaxian.Image = global::ArcadeSaver.Properties.Resources._ic_galaxian_0;
            this.IconGalaxian.Location = new System.Drawing.Point(302, 154);
            this.IconGalaxian.Name = "IconGalaxian";
            this.IconGalaxian.Size = new System.Drawing.Size(64, 64);
            this.IconGalaxian.TabIndex = 6;
            this.IconGalaxian.TabStop = false;
            // 
            // VersionNo
            // 
            this.VersionNo.AutoSize = true;
            this.VersionNo.Location = new System.Drawing.Point(13, 259);
            this.VersionNo.Name = "VersionNo";
            this.VersionNo.Size = new System.Drawing.Size(66, 13);
            this.VersionNo.TabIndex = 7;
            this.VersionNo.Text = "Version 1.1b";
            // 
            // ArcadeSaverConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 284);
            this.Controls.Add(this.VersionNo);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.AudioOptions);
            this.Controls.Add(this.SaverMode);
            this.Controls.Add(this.IconGalaxian);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ArcadeSaverConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Arcade Saver 3";
            this.Load += new System.EventHandler(this.ArcadeSaverConfig_Load);
            this.SaverMode.ResumeLayout(false);
            this.SaverMode.PerformLayout();
            this.AudioOptions.ResumeLayout(false);
            this.AudioOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Volume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconGalaxian)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox SaverMode;
        private System.Windows.Forms.RadioButton ModeVideo;
        private System.Windows.Forms.RadioButton ModeGif;
        private System.Windows.Forms.Button DirectorySelect;
        private System.Windows.Forms.TextBox Directory;
        private System.Windows.Forms.GroupBox AudioOptions;
        private System.Windows.Forms.Label VolumeLabel;
        private System.Windows.Forms.NumericUpDown Volume;
        private System.Windows.Forms.RadioButton AudioAll;
        private System.Windows.Forms.RadioButton AudioSingle;
        private System.Windows.Forms.RadioButton AudioOff;
        private System.Windows.Forms.FolderBrowserDialog FolderBrowserDialog;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.PictureBox IconGalaxian;
        private System.Windows.Forms.Label VersionNo;
    }
}