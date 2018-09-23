using Microsoft.Win32;
using System;
using System.Windows.Forms;

namespace ArcadeSaver
{
    public partial class ArcadeSaverConfig : Form
    {
        public ArcadeSaverConfig()
        {
            InitializeComponent();
        }

        private void DirectorySelect_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog.Description = "Select the Folder Containing Video Files";
            FolderBrowserDialog.ShowNewFolderButton = false;
            FolderBrowserDialog.RootFolder = Environment.SpecialFolder.MyComputer;
            DialogResult result = FolderBrowserDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                Directory.Text = FolderBrowserDialog.SelectedPath;
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ArcadeSaverConfig_Load(object sender, EventArgs e)
        {
            int mode = (int)Registry.GetValue(@"HKEY_CURRENT_USER\SOFTWARE\ArcadeSaver3", "RenderMode", 0);
            string videoFolder = (string)Registry.GetValue(@"HKEY_CURRENT_USER\SOFTWARE\ArcadeSaver3", "VideoFolder", "");
            int audio = (int)Registry.GetValue(@"HKEY_CURRENT_USER\SOFTWARE\ArcadeSaver3", "Audio", 0);
            int volume = (int)Registry.GetValue(@"HKEY_CURRENT_USER\SOFTWARE\ArcadeSaver3", "Volume", 5);
            if (mode == 1) {
                ModeVideo.Checked = true;
                Directory.Enabled = true;
                DirectorySelect.Enabled = true;
                AudioOptions.Enabled = true;
            }
            Directory.Text = videoFolder;
            if (audio == 1) AudioSingle.Checked = true; else if (audio == 2) AudioAll.Checked = true;
            Volume.Value = volume;
        }

        private void OK_Click(object sender, EventArgs e)
        {
            int mode; if (ModeGif.Checked) mode = 0; else mode = 1;
            int audio; if (AudioOff.Checked) audio = 0; else if (AudioSingle.Checked) audio = 1; else audio = 2;
            Registry.SetValue(@"HKEY_CURRENT_USER\SOFTWARE\ArcadeSaver3", "RenderMode", mode, RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_CURRENT_USER\SOFTWARE\ArcadeSaver3", "VideoFolder", Directory.Text, RegistryValueKind.String);
            Registry.SetValue(@"HKEY_CURRENT_USER\SOFTWARE\ArcadeSaver3", "Audio", audio, RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_CURRENT_USER\SOFTWARE\ArcadeSaver3", "Volume", Volume.Value, RegistryValueKind.DWord);
            Close();
        }

        private void ModeVideo_CheckedChanged(object sender, EventArgs e)
        {
            Directory.Enabled = true;
            DirectorySelect.Enabled = true;
            AudioOptions.Enabled = true;
        }

        private void ModeGif_CheckedChanged(object sender, EventArgs e)
        {
            Directory.Enabled = false;
            DirectorySelect.Enabled = false;
            AudioOptions.Enabled = false;
        }
    }
}
