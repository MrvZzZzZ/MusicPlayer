using NAudio.Wave;
using System;
using System.Drawing;
using System.Windows.Forms;
using AxWMPLib;
using WMPLib;
using System.Windows.Media;
using System.Runtime.Remoting.Channels;
using System.Xml.Linq;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Web.Configuration;
using Newtonsoft.Json.Linq;
using System.IO;
using Guna.UI2.WinForms;
using System.Web.UI;
using System.ServiceModel.Configuration;
using System.Linq;
using System.Diagnostics;

namespace MusicPlayer
{
    public partial class MainMenu : Form
    {
        public string PathOfPlaylistFiles
        {
            get;
            set;
        }

        private bool isPlaylistsLoaded = false;

        public MainMenu()
        {
            Playlists = new List<PlaylistCell>();
            Tracks = new List<TrackCell>();
            ShowingTracks = new List<TrackCell>();
            InitializeComponent();
            LoadThePlaylists();
            RunTimeLabel.Text = "00:00";
            EndTimeLabel.Text = "--/--";
            musicStateSlider.Value = 0;
        }

        public List<PlaylistCell> Playlists;
        private bool CheckExistFile(string file)
        {
            if (File.Exists(file)) return true;
            return false;
        }

        public void CreatNewPlaylist()
        {
            Playlists.Add(new PlaylistCell(this));

            if (Playlists.Count - 1 == 0)
            {
                Playlists[Playlists.Count - 1].Location = new Point(5, 5);
                Playlists[Playlists.Count - 1].ID = 1;
                Playlists[Playlists.Count - 1].SerialNum = 0;
            }
            else
            {
                Playlists[Playlists.Count - 1].Location = new Point(Playlists[Playlists.Count - 2].Location.X, Playlists[Playlists.Count - 2].Location.Y + Playlists[Playlists.Count - 1].Height + 5);
                Playlists[Playlists.Count - 1].ID = Playlists[Playlists.Count - 2].ID + 1;
                Playlists[Playlists.Count - 1].SerialNum = Playlists[Playlists.Count - 2].SerialNum + 1;
            }
            ActualPLaylist.Controls.Add(Playlists[Playlists.Count - 1]);
            if (isPlaylistsLoaded)
            {
                Playlists[Playlists.Count - 1].SelectedCell();
                SetNameThePlaylist();
            }
            ClearActualTrack();
        }

        public void DeleteThePlaylist()
        {
            for (int i = 0; i < Playlists.Count; i++)
                if (Playlists[i].isSelected)
                {
                    foreach (var PL in Playlists)
                    {
                        PL.Hide();
                        PL.SerialNum--;
                    }
                    if (Playlists[i].PathOfPlaylist != null) File.Delete(Playlists[i].PathOfPlaylist);
                    Playlists.RemoveAt(i);
                    for (int j = 0; j < Playlists.Count; j++)
                    {
                        if (j == 0) Playlists[j].Location = new Point(5, 5);
                        else Playlists[j].Location = new Point(Playlists[j - 1].Location.X, Playlists[j - 1].Location.Y + Playlists[j].Height + 5);
                        ActualPLaylist.Controls.Add(Playlists[j]);
                        Playlists[j].Show();
                    }
                    break;
                }
            ClearActualTrack();
        }

        public void DeleteTheTrack()
        {

            for (int i = 0; i < Playlists.Count; i++)
                if (Playlists[i].isSelected)
                {
                    for (int j = 0; j < Playlists[i].Tracks.Count; j++)
                        if (Playlists[i].Tracks[j].isSelected)
                        {
                            Playlists[i].Tracks.RemoveAt(j);
                            for (int k = j; k < Playlists[i].Tracks.Count; k++) Playlists[i].Tracks[k].Index--;
                            AddExistTracksInList(Playlists[i].Tracks);
                            player.Ctlcontrols.stop();
                            trackName.Text = "*Удалено*";
                            EndTimeLabel.Text = "--:--";
                            RunTimeLabel.Text = "--:--";
                            PlayingTrackIndex--;
                            PlayButton.BackgroundImage = PNG.pause;
                            break;
                        }
                    break;
                }

        }

        public void LoadThePlaylists()
        {
            string relativePath = "Playlists";
            PathOfPlaylistFiles = Path.Combine(Application.StartupPath, relativePath);
            if (Directory.Exists(PathOfPlaylistFiles))
            {
                string[] files = Directory.GetFiles(PathOfPlaylistFiles, "*.pllst");

                if (files.Length != 0)
                {
                    foreach (string file in files)
                    {
                        string[] newTracks = File.ReadAllLines(file);
                        CreatNewPlaylist();
                        int ID = Playlists.Count - 1;
                        Playlists[ID].PathOfPlaylist = file;
                        Playlists[ID].SetPlaylistName(file);
                        foreach (string Track in newTracks)
                        {
                            if (CheckExistFile(Track))
                            {
                                int numOfTrack = Playlists[ID].Tracks.Count;
                                Playlists[ID].Tracks.Add(new TrackCell(Track, numOfTrack)
                                {
                                    PC = Playlists[ID],
                                    owner = this,
                                });
                            }
                            else MessageBox.Show($"Внимание! По слудеющему пути не был найден файл!\nПуть: {file}");
                        }
                        //AddNewTrackInList(newTracks);

                    }
                    Tracks = ShowingTracks;
                }
                else MessageBox.Show("Внимание! Существующие плейлисты не найдены!");
            }
            else
            {
                Directory.CreateDirectory(PathOfPlaylistFiles);
                MessageBox.Show("Внимание! Существующие плейлисты не найдены!");
            }
            isPlaylistsLoaded = true;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Желаете сохранить плейлисты перед выходом?", "Всего доброго!", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                foreach (PlaylistCell PC1 in Playlists) PC1.SaveThePlaylist();
            }
            this.Close();
        }

        private bool isPlayButtonState = true;
        private void PlayButton_Click(object sender, EventArgs e)
        {
            if (Tracks.Count == 0 && ShowingTracks.Count == 0)
            {
                openFileDialog1.Filter = "Музыка (*.MP3;*.WAV;*.WMA;*.AVI;*.MPEG)|*.MP3;*.WAV;*.WMA;*.AVI;*.MPEG";
                openFileDialog1.Multiselect = true;
                openFileDialog1.ShowDialog();
                AddNewTrackInList(openFileDialog1.FileNames);
            }
            else if (!isPlaylistStarted)
            {
                if (Tracks.Count == 0) Tracks = ShowingTracks;
                isPlaylistStarted = true;
                PlayMusic(0);
            }
            else
            {
                if (isPlayButtonState)
                {
                    player.Ctlcontrols.pause();
                    PlayButton.BackgroundImage = PNG.pause;
                    isPlayButtonState = false;
                }
                else if (!isPlayButtonState)
                {
                    player.Ctlcontrols.play();
                    PlayButton.BackgroundImage = PNG.play;
                    isPlayButtonState = true;
                }
            }
        }

        private Point LastMovePanelPoint;
        private void MovePanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - LastMovePanelPoint.X;
                this.Top += e.Y - LastMovePanelPoint.Y;
            }
        }

        private void MovePanel_MouseDown(object sender, MouseEventArgs e)
        {
            LastMovePanelPoint = new Point(e.X, e.Y);
        }

        private bool isRepeat = false;
        private bool isRepeatOnce = false;
        private void Repeat_Click(object sender, EventArgs e)
        {
            if (!isRepeat && !isRepeatOnce)
            {
                RepeatButton.BackgroundImage = PNG.repeatOn;
                isRepeat = true;
            }
            else if (isRepeat && !isRepeatOnce)
            {
                RepeatButton.BackgroundImage = PNG.repeatOnce;
                isRepeatOnce = true;
            }
            else if (isRepeat && isRepeatOnce)
            {
                RepeatButton.BackgroundImage = PNG.repeatOff;
                isRepeat = false;
                isRepeatOnce = false;
            }
        }

        private bool isMusicMute = false;
        private void VolumeStateBtn_Click(object sender, EventArgs e)
        {
            if (!isMusicMute)
            {
                volumeStateBtn.BackgroundImage = PNG.volumeOff;
                player.settings.mute = true;
                isMusicMute = true;
            }
            else if (isMusicMute)
            {
                volumeStateBtn.BackgroundImage = PNG.volumeOn;
                player.settings.mute = false;
                isMusicMute = false;
            }
        }

        private void VolumeStateSlider_Scroll(object sender, Utilities.BunifuSlider.BunifuHScrollBar.ScrollEventArgs e)
        {
            player.settings.volume = volumeStateSlider.Value;
            if (volumeStateSlider.Value == 0)
            {
                volumeStateBtn.BackgroundImage = PNG.volumeOff;
                player.settings.mute = true;
                isMusicMute = true;
            }
            if (volumeStateSlider.Value != 0)
            {
                volumeStateBtn.BackgroundImage = PNG.volumeOn;
                player.settings.mute = false;
                isMusicMute = false;
            }

        }

        private bool isRandomState = false;
        private void RandomButton_Click(object sender, EventArgs e)
        {
            if (!isRandomState)
            {
                RandomButton.BackgroundImage = PNG.randomOn;
                isRandomState = true;
            }
            else if (isRandomState)
            {
                RandomButton.BackgroundImage = PNG.randomOff;
                isRandomState = false;
            }
        }

        public void ClearActualTrack()
        {
            foreach (var control in ShowingTracks) control.Hide();
        }

        public void ShowThePlaylistTracks(List<TrackCell> newTracks)
        {
            ClearActualTrack();
            ShowingTracks.Clear();
            for (int i = 0; i < newTracks.Count; i++)
            {
                ShowingTracks.Add(newTracks[i]);
                if (i != 0) ShowingTracks[i].Location = new Point(ShowingTracks[i - 1].Location.X, ShowingTracks[i - 1].Location.Y + ShowingTracks[i - 1].Height + 5);
                else ShowingTracks[i].Location = new Point(5, 5);
                ActualTracks.Controls.Add(ShowingTracks[i]);
                ShowingTracks[i].BringToFront();
                ShowingTracks[i].Show();
            }
        }

        public List<TrackCell> Tracks;
        public List<TrackCell> ShowingTracks;
        public int PlayingTrackIndex = 0;
        public void AddExistTracksInList(List<TrackCell> newTracks)
        {
            //Tracks.Clear();
            ShowThePlaylistTracks(newTracks);
            Tracks = newTracks;
        }

        public void AddNewTrackInList(string[] newTracks)
        {
            bool isPlaylistSelected = false;
            int ID = 0;
            foreach (PlaylistCell PC in Playlists)
            {
                if (PC.isSelected)
                {
                    isPlaylistSelected = true;
                    ID = PC.SerialNum;
                    break;
                }
            }
            if (!isPlaylistSelected)
            {
                CreatNewPlaylist();
                ID = Playlists[Playlists.Count - 1].SerialNum;
            }
            foreach (string file in newTracks)
            {
                if (CheckExistFile(file))
                {
                    int numOfTrack = Playlists[ID].Tracks.Count;
                    Playlists[ID].Tracks.Add(new TrackCell(file, numOfTrack)
                    {
                        PC = Playlists[ID],
                        owner = this,
                    });
                }
                else MessageBox.Show($"Внимание! По слудеющему пути не был найден файл!\nПуть: {file}");
            }
            ShowThePlaylistTracks(Playlists[ID].Tracks);
        }

        private bool isSliderScroll = false;
        private void Timer_Tick(object sender, EventArgs e)
        {
            if (!isSliderScroll)
            {
                RunTimeLabel.Text = player.Ctlcontrols.currentPositionString;
                musicStateSlider.Value = (int)player.Ctlcontrols.currentPosition;
            }
        }

        private void MusicStateSlider_MouseUp(object sender, MouseEventArgs e)
        {
            player.Ctlcontrols.currentPosition = musicStateSlider.Value;
            isSliderScroll = false;
        }

        private void MusicStateSlider_MouseDown(object sender, MouseEventArgs e)
        {
            isSliderScroll = true;
        }

        private bool isPlaylistStarted = false;
        private bool isMusicLoaded = false;
        public void PlayMusic(int idOfTrack)
        {
            isMusicLoaded = false;
            try
            {
                AudioFileReader audioFR = new AudioFileReader(Tracks[idOfTrack].Path);
                Tracks[idOfTrack].SelectedCell();
                if (audioFR.TotalTime.Seconds < 10) EndTimeLabel.Text = audioFR.TotalTime.Minutes.ToString() + ":0" + audioFR.TotalTime.Seconds.ToString();
                else EndTimeLabel.Text = audioFR.TotalTime.Minutes.ToString() + ":" + audioFR.TotalTime.Seconds.ToString();
                PlayButton.BackgroundImage = PNG.play;
                musicStateSlider.Maximum = (int)audioFR.TotalTime.TotalSeconds;
                player.URL = Tracks[idOfTrack].Path;
                PlayingTrackIndex = Tracks[idOfTrack].Index;
                trackName.Text = Tracks[idOfTrack].TrackNameText;
                player.Ctlcontrols.play();
                timer.Start();
            }
            catch
            {
                MessageBox.Show($"Ошибка! Данный файл открыть невозможно! Файл - {Tracks[idOfTrack].TrackNameText}");
                Tracks[idOfTrack].SelectedCell();
                DeleteTheTrack();
            };
            isMusicLoaded = true;
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            if (isRandomState) PlayMusic(GetRandomInt());
            else if (PlayingTrackIndex + 1 < Tracks.Count) PlayMusic(++PlayingTrackIndex);
            else if (isRepeat) PlayMusic(0);
        }

        private void LastButton_Click(object sender, EventArgs e)
        {
            if (isRandomState) PlayMusic(GetRandomInt());
            else if (PlayingTrackIndex - 1 >= 0) PlayMusic(--PlayingTrackIndex);
        }

        private void MusicControl_MouseClick(object sender, MouseEventArgs e)
        {
            TrackMenu tm = new TrackMenu
            {
                Location = new Point(e.X + MusicControl.Location.X - 20, e.Y + MusicControl.Location.Y - 37),
                owner = this
            };
            tm.MouseEnter += MusicMenu_MouseEnter;
            this.Controls.Add(tm);
            tm.BringToFront();
        }

        private void MusicMenu_MouseEnter(object sender, EventArgs e)
        {
            TrackMenu element = (TrackMenu)sender;
            this.Controls.Remove(element);
        }

        private void PlaylistControl_MouseClick(object sender, MouseEventArgs e)
        {
            PlaylistMenu pm = new PlaylistMenu()
            {
                owner = this,
                Location = new Point(e.X + ActualPLaylist.Location.X - 260, e.Y + ActualPLaylist.Location.Y + 330),
            };
            pm.MouseEnter += PlaylistMenu_MouseEnter;
            this.Controls.Add(pm);
            pm.BringToFront();
        }

        private void PlaylistMenu_MouseEnter(object sender, EventArgs e)
        {
            PlaylistMenu element = (PlaylistMenu)sender;
            this.Controls.Remove(element);
        }

        private void Player_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (e.newState == 8) PlayNextAuto();
            if (isMusicLoaded && e.newState == 10) player.Ctlcontrols.play();
        }

        private Random rnd = new Random();
        private int GetRandomInt()
        {
            int value = rnd.Next(0, Tracks.Count);
            if (value == PlayingTrackIndex) return GetRandomInt();
            else return value;
        }

        private void PlayNextAuto()
        {
            if (isRepeatOnce) PlayMusic(PlayingTrackIndex);
            else if (isRandomState) PlayMusic(GetRandomInt());
            else if (PlayingTrackIndex + 1 < Tracks.Count) PlayMusic(++PlayingTrackIndex);
            else if (isRepeat && PlayingTrackIndex + 1 == Tracks.Count) PlayMusic(0);
            else
            {
                isPlaylistStarted = false;
                EndTimeLabel.Text = "--:--";
                trackName.Text = "* Плейлист закончился *";
                PlayButton.BackgroundImage = PNG.pause;
            }
        }

        public void SetNameThePlaylist()
        {
            foreach (PlaylistCell PC in Playlists)
            {
                if (PC.isSelected)
                {
                    bool isPlaylistNameCorrect = true;
                    do
                    {

                        PC.PlaylistNameText = InputBox.Show("Введите название для нового плейлиста.", "Название плейлиста", "");


                        string forbiddenCharacters = "!@#$%^&*().";
                        foreach (char c in PC.PlaylistNameText)
                        {
                            if (forbiddenCharacters.Contains(c))
                            {
                                MessageBox.Show("Ошибка! Вы ввели запрещенный символ! Название не должно содержать запрещенный символы - \\!@#$%^&*().:/");
                                isPlaylistNameCorrect = false;
                                break;
                            }
                        }

                        foreach (PlaylistCell newPC in Playlists)
                        {
                            if (PC.PlaylistNameText == newPC.PlaylistNameText && PC.ID != newPC.ID)
                            {
                                string Time = DateTime.Now.ToString();
                                string currentTime = Time.Replace(":", "-");
                                PC.PlaylistNameText += " " + currentTime;
                            }
                        }


                    } while (!isPlaylistNameCorrect);
                    PC.SetPlaylistSetPlName();
                    break;
                }

            }
        }

        public void ShowInExplorer()
        {
            foreach (TrackCell TC in Tracks)
                if(TC.isSelected)
                {
                    string directoryPath = Path.GetDirectoryName(Tracks[PlayingTrackIndex].Path);
                    try
                    {
                        Process.Start(directoryPath);
                    }
                    catch
                    {
                        MessageBox.Show($"Внимание! По следующему пути не был найден файл!\nПуть: {directoryPath}");
                    }
                    break;
                }
        }


    }
}//Runtime.InteropServices.COMException: "Исключение из HRESULT: 0xC00D1054"

//-0(WMPLib.WMPPlayState.wmppsUndefined): Неопределенное состояние.
//-1(WMPLib.WMPPlayState.wmppsStopped): Воспроизведение остановлено.
//-2(WMPLib.WMPPlayState.wmppsPaused): Воспроизведение приостановлено.
//-3(WMPLib.WMPPlayState.wmppsPlaying): Воспроизведение активно.
//-4(WMPLib.WMPPlayState.wmppsScanForward): Быстрое перемещение вперед.
//- 5 (WMPLib.WMPPlayState.wmppsScanReverse): Быстрое перемещение назад.
//- 6 (WMPLib.WMPPlayState.wmppsBuffering): Воспроизведение приостановлено из-за буферизации.
//- 7 (WMPLib.WMPPlayState.wmppsWaiting): Ожидание выполнения операции.
//- 8 (WMPLib.WMPPlayState.wmppsMediaEnded): Воспроизведение текущего элемента завершено.
//- 9 (WMPLib.WMPPlayState.wmppsTransitioning): Происходит переход между элементами плейлиста.
//- 10 (WMPLib.WMPPlayState.wmppsReady): Плеер готов к воспроизведению.
//- 11 (WMPLib.WMPPlayState.wmppsReconnecting): Плеер пытается повторно подключиться к контенту.