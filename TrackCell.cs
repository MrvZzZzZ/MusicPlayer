using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace MusicPlayer
{
    public partial class TrackCell : UserControl
    {
        public MainMenu owner;
        public PlaylistCell PC;

        public bool isSelected = false;
        public string TrackNameText
        {
            get;
            set;
        }
        public string Path
        {
            get;
            set;
        }
        public int Index
        {
            get;
            set;
        }

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

        public void SetTrackName(string TrackName)
        {
            int indexFirst = TrackName.LastIndexOf("\\");
            int indexSecond = TrackName.LastIndexOf(".");
            int length = indexSecond - indexFirst;
            if (length > 0) TrackNameText = TrackName.Substring(indexFirst + 1, length - 1);
            TrackNameLabel.Text = TrackNameText;
            AutoSizeFont(TrackNameLabel, TrackNameLabel.Text, TrackNameLabel.Size);
        }
        public TrackCell(string Track, int ID)
        {
            InitializeComponent();
            Path = Track;
            Index = ID;
            SetTrackName(Track);
        }

        public void UnselectCell()
        {
            this.isSelected = false;
            this.panel1.BackColor = Color.FromArgb(70, 70, 70);
        }

        public void SelectedCell()
        {
            if (this.Parent != null)
            {
                foreach (var control in this.Parent.Controls)
                {
                    if (control is TrackCell TC)
                    {
                        TC.isSelected = false;
                        TC.panel1.BackColor = Color.FromArgb(70, 70, 70);
                    }
                }
            }
            panel1.BackColor = Color.FromArgb(0, 238, 0);
            isSelected = true;
        }

        private void TrackNameLabel_Click(object sender, EventArgs e)
        {
            if (owner.Tracks.Contains(this)) owner.PlayMusic(Index);
            else
            {
                owner.AddExistTracksInList(PC.Tracks);
                owner.PlayMusic(Index);
            }
        }

        private void MovePicture_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                Point newLocation = this.Location;
                newLocation.X += e.X - mouseOffset.X;
                newLocation.Y += e.Y - mouseOffset.Y;
                this.Location = newLocation;
            }
        }

        private bool isDragging = false;
        private Point mouseOffset;
        private Point LastPoint;
        private void MovePicture_MouseDown(object sender, MouseEventArgs e)
        {
            LastPoint = this.Location;
            isDragging = true;
            mouseOffset = new Point(e.X, e.Y);
        }

        private void MovePicture_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
            Rectangle rect1 = this.Bounds;
            bool isSwap = false;
            foreach (TrackCell TC in owner.ShowingTracks)
            {
                Rectangle rect2 = TC.Bounds;
                if(rect1.IntersectsWith(rect2) && this.Index != TC.Index)
                {
                    Point tmpLocation = TC.Location;
                    TC.Location = LastPoint;
                    this.Location = tmpLocation;

                    (PC.Tracks[this.Index], PC.Tracks[TC.Index]) = (PC.Tracks[TC.Index], PC.Tracks[this.Index]);
                    (this.Index, TC.Index) = (TC.Index, this.Index);

                    owner.Tracks = PC.Tracks;
                    if(owner.PlayingTrackIndex == TC.Index) owner.PlayingTrackIndex = this.Index;

                    isSwap = true;
                    break;
                }
            }
            if(!isSwap) this.Location = LastPoint;
        }

    }

}