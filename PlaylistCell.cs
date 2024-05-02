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

namespace MusicPlayer
{
    public partial class PlaylistCell : UserControl
    {
        public string PathOfPlaylist
        { get; set; }
        public string PlaylistNameText
        {  get; set; }
        public MainMenu Owner
        { get; set; }

        public int ID
        { get; set; }

        public int SerialNum
        { get; set; }

        public bool isSelected = false;

        public List<TrackCell> Tracks;

        public int SelectedTrackID
        { get; set; }

        static void AutoSizeFont(Label label, string text, Size labelSize)
        {
            int fontSize = 14; 
            Font font = new Font(label.Font.FontFamily, fontSize);

            while (TextRenderer.MeasureText(text, font).Width > labelSize.Width)
            {
                fontSize--;
                font = new Font(label.Font.FontFamily, fontSize);
            }

            label.Font = font;
        }

        public void SetPlaylistSetPlName()
        {
            PlaylistName.Text = PlaylistNameText;
            AutoSizeFont(PlaylistName, PlaylistName.Text, PlaylistName.Size);
        }

        public void SetPlaylistName(string PathOfPlaylist)
        {
            int indexFirst = PathOfPlaylist.LastIndexOf("\\");
            int indexSecond = PathOfPlaylist.LastIndexOf(".");
            int length = indexSecond - indexFirst;
            if (length > 0) PlaylistNameText = PathOfPlaylist.Substring(indexFirst + 1, length - 1);
            PlaylistName.Text = PlaylistNameText;
            AutoSizeFont(PlaylistName, PlaylistName.Text, PlaylistName.Size);
        }

        public PlaylistCell(MainMenu newOwner)
        {
            InitializeComponent();
            Tracks = new List<TrackCell>();
            Owner = newOwner;
        }

        public void UnselectCell()
        {
            this.isSelected = false;
            this.panel1.BackColor = Color.FromArgb(255, 192, 255);
        }

        public void SelectedCell()
        {
            if (this.Parent != null)
            {
                foreach (var control in this.Parent.Controls)
                {
                    if (control is PlaylistCell PC)
                    {
                        PC.isSelected = false;
                        PC.panel1.BackColor = Color.FromArgb(255, 192, 255);
                    }
                }
            }
            panel1.BackColor = Color.FromArgb(0, 238, 0);
            isSelected = true;
        }

        private void PlaylistName_Click(object sender, EventArgs e)
        {
            if(!isSelected)
            {
                SelectedCell();
                Owner.ShowThePlaylistTracks(Tracks);
            }
        }

        public void SaveThePlaylist()
        {
            string[] tmp = new string[Tracks.Count];
            for(int i = 0;i < Tracks.Count;i++) tmp[i] = Tracks[i].Path;
            string pathToSave = Path.Combine(Owner.PathOfPlaylistFiles, PlaylistNameText + ".pllst");
            try
            {
                File.WriteAllLines(pathToSave, tmp);
            }
            catch 
            {
                MessageBox.Show($"Ошибка: Не удалось сохранить плейлист! Путь сохранения - {Owner.PathOfPlaylistFiles}") ;
            }
        }
    }
}
