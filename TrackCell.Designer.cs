namespace MusicPlayer
{
    partial class TrackCell
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.TrackNameLabel = new System.Windows.Forms.Label();
            this.MovePicture = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.MovePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // TrackNameLabel
            // 
            this.TrackNameLabel.Font = new System.Drawing.Font("Comfortaa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TrackNameLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.TrackNameLabel.Location = new System.Drawing.Point(2, 2);
            this.TrackNameLabel.Name = "TrackNameLabel";
            this.TrackNameLabel.Size = new System.Drawing.Size(610, 40);
            this.TrackNameLabel.TabIndex = 0;
            this.TrackNameLabel.Text = "TrackName";
            this.TrackNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TrackNameLabel.Click += new System.EventHandler(this.TrackNameLabel_Click);
            // 
            // MovePicture
            // 
            this.MovePicture.BackgroundImage = global::MusicPlayer.PNG.ThreeDots;
            this.MovePicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.MovePicture.InitialImage = global::MusicPlayer.PNG.ThreeDots;
            this.MovePicture.Location = new System.Drawing.Point(610, 2);
            this.MovePicture.Name = "MovePicture";
            this.MovePicture.Size = new System.Drawing.Size(20, 40);
            this.MovePicture.TabIndex = 1;
            this.MovePicture.TabStop = false;
            this.MovePicture.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MovePicture_MouseDown);
            this.MovePicture.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MovePicture_MouseMove);
            this.MovePicture.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MovePicture_MouseUp);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(632, 44);
            this.panel1.TabIndex = 2;
            // 
            // TrackCell
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Controls.Add(this.MovePicture);
            this.Controls.Add(this.TrackNameLabel);
            this.Controls.Add(this.panel1);
            this.Name = "TrackCell";
            this.Size = new System.Drawing.Size(632, 44);
            ((System.ComponentModel.ISupportInitialize)(this.MovePicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label TrackNameLabel;
        private System.Windows.Forms.PictureBox MovePicture;
        private System.Windows.Forms.Panel panel1;
    }
}
