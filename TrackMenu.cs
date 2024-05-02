using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MusicPlayer
{
    partial class TrackMenu : UserControl
    {
        public MainMenu owner;

        public TrackMenu()
        {
            InitializeComponent();
            openFileDialog1.Filter = "Музыка (*.MP3;*.WAV;*.WMA;*.AVI;*.MPEG)|*.MP3;*.WAV;*.WMA;*.AVI;*.MPEG";
            openFileDialog1.Multiselect = true;
        }

        private void AddTrack_Click(object sender, EventArgs e)
        {
            this.Hide(); 
            this.Dispose(); 
            openFileDialog1.ShowDialog();
        }

        private void OpenFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            owner.AddNewTrackInList(openFileDialog1.FileNames);
        }

        private void DeleteTrack_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Dispose();
            owner.DeleteTheTrack();
        }

        private void showTheTrackInExplorer_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Dispose();
            owner.ShowInExplorer();
        }
    }
}
