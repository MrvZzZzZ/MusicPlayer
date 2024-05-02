namespace MusicPlayer
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.createNewPlaylistButton = new System.Windows.Forms.Panel();
            this.playlistControl = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.volumeStateSlider = new Bunifu.UI.WinForms.BunifuHSlider();
            this.musicStateSlider = new Bunifu.UI.WinForms.BunifuHSlider();
            this.volumeStateBtn = new System.Windows.Forms.Button();
            this.EndTimeLabel = new System.Windows.Forms.Label();
            this.RunTimeLabel = new System.Windows.Forms.Label();
            this.RepeatButton = new System.Windows.Forms.Button();
            this.RandomButton = new System.Windows.Forms.Button();
            this.LastButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.PlayButton = new System.Windows.Forms.Button();
            this.player = new AxWMPLib.AxWindowsMediaPlayer();
            this.ActualTracks = new System.Windows.Forms.Panel();
            this.MusicControl = new System.Windows.Forms.Label();
            this.MovePanel = new System.Windows.Forms.Panel();
            this.ProgramName = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.panel6 = new System.Windows.Forms.Panel();
            this.trackName = new System.Windows.Forms.Label();
            this.ActualPLaylist = new System.Windows.Forms.Panel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.createNewPlaylistButton.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.MovePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // createNewPlaylistButton
            // 
            this.createNewPlaylistButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(219)))), ((int)(((byte)(209)))));
            this.createNewPlaylistButton.Controls.Add(this.playlistControl);
            this.createNewPlaylistButton.Location = new System.Drawing.Point(679, 443);
            this.createNewPlaylistButton.Margin = new System.Windows.Forms.Padding(2);
            this.createNewPlaylistButton.Name = "createNewPlaylistButton";
            this.createNewPlaylistButton.Size = new System.Drawing.Size(321, 47);
            this.createNewPlaylistButton.TabIndex = 3;
            // 
            // playlistControl
            // 
            this.playlistControl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.playlistControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.playlistControl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playlistControl.Font = new System.Drawing.Font("Comfortaa", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.playlistControl.Location = new System.Drawing.Point(0, 0);
            this.playlistControl.Name = "playlistControl";
            this.playlistControl.Size = new System.Drawing.Size(321, 47);
            this.playlistControl.TabIndex = 5;
            this.playlistControl.Text = "Управление плейлистами";
            this.playlistControl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.playlistControl.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PlaylistControl_MouseClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.volumeStateSlider);
            this.panel2.Controls.Add(this.musicStateSlider);
            this.panel2.Controls.Add(this.volumeStateBtn);
            this.panel2.Controls.Add(this.EndTimeLabel);
            this.panel2.Controls.Add(this.RunTimeLabel);
            this.panel2.Controls.Add(this.RepeatButton);
            this.panel2.Controls.Add(this.RandomButton);
            this.panel2.Controls.Add(this.LastButton);
            this.panel2.Controls.Add(this.NextButton);
            this.panel2.Controls.Add(this.PlayButton);
            this.panel2.Controls.Add(this.player);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 532);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1000, 118);
            this.panel2.TabIndex = 7;
            // 
            // volumeStateSlider
            // 
            this.volumeStateSlider.AllowCursorChanges = true;
            this.volumeStateSlider.AllowHomeEndKeysDetection = false;
            this.volumeStateSlider.AllowIncrementalClickMoves = true;
            this.volumeStateSlider.AllowMouseDownEffects = false;
            this.volumeStateSlider.AllowMouseHoverEffects = false;
            this.volumeStateSlider.AllowScrollingAnimations = true;
            this.volumeStateSlider.AllowScrollKeysDetection = true;
            this.volumeStateSlider.AllowScrollOptionsMenu = true;
            this.volumeStateSlider.AllowShrinkingOnFocusLost = false;
            this.volumeStateSlider.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.volumeStateSlider.BackColor = System.Drawing.Color.Transparent;
            this.volumeStateSlider.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("volumeStateSlider.BackgroundImage")));
            this.volumeStateSlider.BindingContainer = null;
            this.volumeStateSlider.BorderRadius = 2;
            this.volumeStateSlider.BorderThickness = 1;
            this.volumeStateSlider.Cursor = System.Windows.Forms.Cursors.Hand;
            this.volumeStateSlider.DrawThickBorder = false;
            this.volumeStateSlider.DurationBeforeShrink = 2000;
            this.volumeStateSlider.ElapsedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            this.volumeStateSlider.LargeChange = 10;
            this.volumeStateSlider.Location = new System.Drawing.Point(800, 57);
            this.volumeStateSlider.Margin = new System.Windows.Forms.Padding(4);
            this.volumeStateSlider.Maximum = 100;
            this.volumeStateSlider.Minimum = 0;
            this.volumeStateSlider.MinimumSize = new System.Drawing.Size(0, 31);
            this.volumeStateSlider.MinimumThumbLength = 18;
            this.volumeStateSlider.Name = "volumeStateSlider";
            this.volumeStateSlider.OnDisable.ScrollBarBorderColor = System.Drawing.Color.Silver;
            this.volumeStateSlider.OnDisable.ScrollBarColor = System.Drawing.Color.Transparent;
            this.volumeStateSlider.OnDisable.ThumbColor = System.Drawing.Color.Silver;
            this.volumeStateSlider.ScrollBarBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(158)))), ((int)(((byte)(0)))));
            this.volumeStateSlider.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(158)))), ((int)(((byte)(0)))));
            this.volumeStateSlider.ShrinkSizeLimit = 3;
            this.volumeStateSlider.Size = new System.Drawing.Size(120, 31);
            this.volumeStateSlider.SliderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(158)))), ((int)(((byte)(0)))));
            this.volumeStateSlider.SliderStyle = Bunifu.UI.WinForms.BunifuHSlider.SliderStyles.Thin;
            this.volumeStateSlider.SliderThumbStyle = Utilities.BunifuSlider.BunifuHScrollBar.SliderThumbStyles.Circular;
            this.volumeStateSlider.SmallChange = 1;
            this.volumeStateSlider.TabIndex = 12;
            this.volumeStateSlider.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(158)))), ((int)(((byte)(0)))));
            this.volumeStateSlider.ThumbFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            this.volumeStateSlider.ThumbLength = 18;
            this.volumeStateSlider.ThumbMargin = 1;
            this.volumeStateSlider.ThumbSize = Bunifu.UI.WinForms.BunifuHSlider.ThumbSizes.Medium;
            this.volumeStateSlider.ThumbStyle = Bunifu.UI.WinForms.BunifuHSlider.ThumbStyles.Outline;
            this.volumeStateSlider.Value = 50;
            this.volumeStateSlider.Scroll += new System.EventHandler<Utilities.BunifuSlider.BunifuHScrollBar.ScrollEventArgs>(this.VolumeStateSlider_Scroll);
            // 
            // musicStateSlider
            // 
            this.musicStateSlider.AllowCursorChanges = true;
            this.musicStateSlider.AllowHomeEndKeysDetection = false;
            this.musicStateSlider.AllowIncrementalClickMoves = true;
            this.musicStateSlider.AllowMouseDownEffects = false;
            this.musicStateSlider.AllowMouseHoverEffects = false;
            this.musicStateSlider.AllowScrollingAnimations = true;
            this.musicStateSlider.AllowScrollKeysDetection = true;
            this.musicStateSlider.AllowScrollOptionsMenu = true;
            this.musicStateSlider.AllowShrinkingOnFocusLost = false;
            this.musicStateSlider.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.musicStateSlider.BackColor = System.Drawing.Color.Transparent;
            this.musicStateSlider.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("musicStateSlider.BackgroundImage")));
            this.musicStateSlider.BindingContainer = null;
            this.musicStateSlider.BorderRadius = 2;
            this.musicStateSlider.BorderThickness = 1;
            this.musicStateSlider.Cursor = System.Windows.Forms.Cursors.Hand;
            this.musicStateSlider.DrawThickBorder = false;
            this.musicStateSlider.DurationBeforeShrink = 2000;
            this.musicStateSlider.ElapsedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            this.musicStateSlider.LargeChange = 10;
            this.musicStateSlider.Location = new System.Drawing.Point(100, 1);
            this.musicStateSlider.Margin = new System.Windows.Forms.Padding(4);
            this.musicStateSlider.Maximum = 100;
            this.musicStateSlider.Minimum = 0;
            this.musicStateSlider.MinimumSize = new System.Drawing.Size(0, 31);
            this.musicStateSlider.MinimumThumbLength = 18;
            this.musicStateSlider.Name = "musicStateSlider";
            this.musicStateSlider.OnDisable.ScrollBarBorderColor = System.Drawing.Color.Silver;
            this.musicStateSlider.OnDisable.ScrollBarColor = System.Drawing.Color.Transparent;
            this.musicStateSlider.OnDisable.ThumbColor = System.Drawing.Color.Silver;
            this.musicStateSlider.ScrollBarBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(158)))), ((int)(((byte)(0)))));
            this.musicStateSlider.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(158)))), ((int)(((byte)(0)))));
            this.musicStateSlider.ShrinkSizeLimit = 3;
            this.musicStateSlider.Size = new System.Drawing.Size(800, 35);
            this.musicStateSlider.SliderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(158)))), ((int)(((byte)(0)))));
            this.musicStateSlider.SliderStyle = Bunifu.UI.WinForms.BunifuHSlider.SliderStyles.Thin;
            this.musicStateSlider.SliderThumbStyle = Utilities.BunifuSlider.BunifuHScrollBar.SliderThumbStyles.Circular;
            this.musicStateSlider.SmallChange = 1;
            this.musicStateSlider.TabIndex = 6;
            this.musicStateSlider.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(158)))), ((int)(((byte)(0)))));
            this.musicStateSlider.ThumbFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            this.musicStateSlider.ThumbLength = 79;
            this.musicStateSlider.ThumbMargin = 1;
            this.musicStateSlider.ThumbSize = Bunifu.UI.WinForms.BunifuHSlider.ThumbSizes.Medium;
            this.musicStateSlider.ThumbStyle = Bunifu.UI.WinForms.BunifuHSlider.ThumbStyles.Outline;
            this.musicStateSlider.Value = 50;
            this.musicStateSlider.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MusicStateSlider_MouseDown);
            this.musicStateSlider.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MusicStateSlider_MouseUp);
            // 
            // volumeStateBtn
            // 
            this.volumeStateBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.volumeStateBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("volumeStateBtn.BackgroundImage")));
            this.volumeStateBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.volumeStateBtn.FlatAppearance.BorderSize = 0;
            this.volumeStateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.volumeStateBtn.Location = new System.Drawing.Point(750, 52);
            this.volumeStateBtn.Name = "volumeStateBtn";
            this.volumeStateBtn.Size = new System.Drawing.Size(40, 40);
            this.volumeStateBtn.TabIndex = 9;
            this.volumeStateBtn.UseVisualStyleBackColor = true;
            this.volumeStateBtn.Click += new System.EventHandler(this.VolumeStateBtn_Click);
            // 
            // EndTimeLabel
            // 
            this.EndTimeLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.EndTimeLabel.Font = new System.Drawing.Font("Comfortaa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EndTimeLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.EndTimeLabel.Location = new System.Drawing.Point(920, 1);
            this.EndTimeLabel.Name = "EndTimeLabel";
            this.EndTimeLabel.Size = new System.Drawing.Size(70, 33);
            this.EndTimeLabel.TabIndex = 8;
            this.EndTimeLabel.Text = "00:00";
            this.EndTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RunTimeLabel
            // 
            this.RunTimeLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.RunTimeLabel.Font = new System.Drawing.Font("Comfortaa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RunTimeLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RunTimeLabel.Location = new System.Drawing.Point(20, 1);
            this.RunTimeLabel.Name = "RunTimeLabel";
            this.RunTimeLabel.Size = new System.Drawing.Size(70, 33);
            this.RunTimeLabel.TabIndex = 7;
            this.RunTimeLabel.Text = "00:00";
            this.RunTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RepeatButton
            // 
            this.RepeatButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.RepeatButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.RepeatButton.BackgroundImage = global::MusicPlayer.PNG.repeatOff;
            this.RepeatButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.RepeatButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RepeatButton.FlatAppearance.BorderSize = 0;
            this.RepeatButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RepeatButton.ForeColor = System.Drawing.Color.White;
            this.RepeatButton.Location = new System.Drawing.Point(378, 51);
            this.RepeatButton.Name = "RepeatButton";
            this.RepeatButton.Size = new System.Drawing.Size(35, 35);
            this.RepeatButton.TabIndex = 4;
            this.RepeatButton.UseVisualStyleBackColor = false;
            this.RepeatButton.Click += new System.EventHandler(this.Repeat_Click);
            // 
            // RandomButton
            // 
            this.RandomButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.RandomButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.RandomButton.BackgroundImage = global::MusicPlayer.PNG.randomOff;
            this.RandomButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.RandomButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RandomButton.FlatAppearance.BorderSize = 0;
            this.RandomButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RandomButton.ForeColor = System.Drawing.Color.Black;
            this.RandomButton.Location = new System.Drawing.Point(587, 52);
            this.RandomButton.Name = "RandomButton";
            this.RandomButton.Size = new System.Drawing.Size(35, 35);
            this.RandomButton.TabIndex = 5;
            this.RandomButton.UseVisualStyleBackColor = false;
            this.RandomButton.Click += new System.EventHandler(this.RandomButton_Click);
            // 
            // LastButton
            // 
            this.LastButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.LastButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LastButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LastButton.BackgroundImage")));
            this.LastButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.LastButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LastButton.FlatAppearance.BorderSize = 0;
            this.LastButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LastButton.Location = new System.Drawing.Point(419, 42);
            this.LastButton.Name = "LastButton";
            this.LastButton.Size = new System.Drawing.Size(50, 50);
            this.LastButton.TabIndex = 3;
            this.LastButton.UseVisualStyleBackColor = false;
            this.LastButton.Click += new System.EventHandler(this.LastButton_Click);
            // 
            // NextButton
            // 
            this.NextButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.NextButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.NextButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("NextButton.BackgroundImage")));
            this.NextButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.NextButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NextButton.FlatAppearance.BorderSize = 0;
            this.NextButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NextButton.Location = new System.Drawing.Point(531, 42);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(50, 50);
            this.NextButton.TabIndex = 2;
            this.NextButton.UseVisualStyleBackColor = false;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // PlayButton
            // 
            this.PlayButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.PlayButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PlayButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PlayButton.BackgroundImage")));
            this.PlayButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PlayButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PlayButton.FlatAppearance.BorderSize = 0;
            this.PlayButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlayButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.PlayButton.Location = new System.Drawing.Point(475, 42);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(50, 50);
            this.PlayButton.TabIndex = 1;
            this.PlayButton.UseVisualStyleBackColor = false;
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // player
            // 
            this.player.Enabled = true;
            this.player.Location = new System.Drawing.Point(0, 0);
            this.player.Name = "player";
            this.player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("player.OcxState")));
            this.player.Size = new System.Drawing.Size(10, 10);
            this.player.TabIndex = 7;
            this.player.Visible = false;
            this.player.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.Player_PlayStateChange);
            // 
            // ActualTracks
            // 
            this.ActualTracks.AutoScroll = true;
            this.ActualTracks.BackColor = System.Drawing.Color.DimGray;
            this.ActualTracks.Location = new System.Drawing.Point(0, 35);
            this.ActualTracks.Name = "ActualTracks";
            this.ActualTracks.Size = new System.Drawing.Size(680, 407);
            this.ActualTracks.TabIndex = 8;
            // 
            // MusicControl
            // 
            this.MusicControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.MusicControl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MusicControl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MusicControl.Font = new System.Drawing.Font("Comfortaa", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MusicControl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.MusicControl.Location = new System.Drawing.Point(0, 443);
            this.MusicControl.Name = "MusicControl";
            this.MusicControl.Size = new System.Drawing.Size(680, 47);
            this.MusicControl.TabIndex = 6;
            this.MusicControl.Text = "Управление музыкой";
            this.MusicControl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MusicControl.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MusicControl_MouseClick);
            // 
            // MovePanel
            // 
            this.MovePanel.AutoScroll = true;
            this.MovePanel.Controls.Add(this.ProgramName);
            this.MovePanel.Controls.Add(this.ExitButton);
            this.MovePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MovePanel.Location = new System.Drawing.Point(0, 0);
            this.MovePanel.Name = "MovePanel";
            this.MovePanel.Size = new System.Drawing.Size(1000, 35);
            this.MovePanel.TabIndex = 9;
            this.MovePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MovePanel_MouseDown);
            this.MovePanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MovePanel_MouseMove);
            // 
            // ProgramName
            // 
            this.ProgramName.Font = new System.Drawing.Font("Comfortaa", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProgramName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ProgramName.Location = new System.Drawing.Point(1, 4);
            this.ProgramName.Name = "ProgramName";
            this.ProgramName.Size = new System.Drawing.Size(138, 28);
            this.ProgramName.TabIndex = 1;
            this.ProgramName.Text = "MusicPlayer";
            // 
            // ExitButton
            // 
            this.ExitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ExitButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ExitButton.BackgroundImage")));
            this.ExitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ExitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitButton.ForeColor = System.Drawing.Color.Black;
            this.ExitButton.Location = new System.Drawing.Point(965, 0);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(35, 35);
            this.ExitButton.TabIndex = 0;
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.trackName);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 493);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1000, 39);
            this.panel6.TabIndex = 10;
            // 
            // trackName
            // 
            this.trackName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.trackName.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.trackName.Font = new System.Drawing.Font("Comfortaa", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.trackName.ForeColor = System.Drawing.SystemColors.Control;
            this.trackName.Location = new System.Drawing.Point(0, -1);
            this.trackName.Name = "trackName";
            this.trackName.Size = new System.Drawing.Size(1000, 40);
            this.trackName.TabIndex = 14;
            this.trackName.Text = "Добро пожаловать!";
            this.trackName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ActualPLaylist
            // 
            this.ActualPLaylist.AutoScroll = true;
            this.ActualPLaylist.BackColor = System.Drawing.Color.Purple;
            this.ActualPLaylist.Location = new System.Drawing.Point(679, 35);
            this.ActualPLaylist.Name = "ActualPLaylist";
            this.ActualPLaylist.Size = new System.Drawing.Size(321, 407);
            this.ActualPLaylist.TabIndex = 6;
            // 
            // MainMenu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.ClientSize = new System.Drawing.Size(1000, 650);
            this.Controls.Add(this.MusicControl);
            this.Controls.Add(this.ActualPLaylist);
            this.Controls.Add(this.createNewPlaylistButton);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.MovePanel);
            this.Controls.Add(this.ActualTracks);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(1000, 650);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainMenu";
            this.createNewPlaylistButton.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.MovePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button PlayButton;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Button LastButton;
        private System.Windows.Forms.Button RepeatButton;
        private System.Windows.Forms.Button RandomButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel ActualTracks;
        private System.Windows.Forms.Panel MovePanel;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label ProgramName;
        private System.Windows.Forms.Label EndTimeLabel;
        private System.Windows.Forms.Label RunTimeLabel;
        private System.Windows.Forms.Button volumeStateBtn;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel createNewPlaylistButton;
        private Bunifu.UI.WinForms.BunifuHSlider musicStateSlider;
        private Bunifu.UI.WinForms.BunifuHSlider volumeStateSlider;
        private AxWMPLib.AxWindowsMediaPlayer player;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label trackName;
        private System.Windows.Forms.Label playlistControl;
        private System.Windows.Forms.Label MusicControl;
        private System.Windows.Forms.Panel ActualPLaylist;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}