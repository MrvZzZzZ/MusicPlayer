using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Guna.UI2.WinForms;

namespace MusicPlayer
{
    public partial class PlaylistMenu : UserControl
    {
        public MainMenu owner;
        public PlaylistMenu()
        {
            InitializeComponent();
        }

        private void CreatPlaylistBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Dispose();
            owner.CreatNewPlaylist();
            //string PathOfPlaylist= Path.Combine(owner.PathOfPlaylistFiles, relativePath);
            //File.Create();
        }

        private void SavePlaylistBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Dispose();
            for (int i = 0; i < owner.Playlists.Count; i++)
            {
                if (owner.Playlists[i].isSelected) owner.Playlists[i].SaveThePlaylist();
            }

        }

        private void DeletePlaylist_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Dispose();
            owner.DeleteThePlaylist();
        }

        private void RenamePlaylist_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Dispose();
            owner.SetNameThePlaylist();
        }
    }
}
