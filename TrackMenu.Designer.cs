namespace MusicPlayer
{
    partial class TrackMenu
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
            this.showTheTrackInExplorer = new System.Windows.Forms.Label();
            this.deleteTrack = new System.Windows.Forms.Label();
            this.addTrack = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // showTheTrackInExplorer
            // 
            this.showTheTrackInExplorer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.showTheTrackInExplorer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showTheTrackInExplorer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.showTheTrackInExplorer.Font = new System.Drawing.Font("Comfortaa", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.showTheTrackInExplorer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.showTheTrackInExplorer.Location = new System.Drawing.Point(0, 67);
            this.showTheTrackInExplorer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.showTheTrackInExplorer.Name = "showTheTrackInExplorer";
            this.showTheTrackInExplorer.Size = new System.Drawing.Size(230, 33);
            this.showTheTrackInExplorer.TabIndex = 19;
            this.showTheTrackInExplorer.Text = "Показать в папке";
            this.showTheTrackInExplorer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.showTheTrackInExplorer.Click += new System.EventHandler(this.showTheTrackInExplorer_Click);
            // 
            // deleteTrack
            // 
            this.deleteTrack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.deleteTrack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteTrack.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.deleteTrack.Font = new System.Drawing.Font("Comfortaa", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteTrack.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.deleteTrack.Location = new System.Drawing.Point(0, 34);
            this.deleteTrack.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.deleteTrack.Name = "deleteTrack";
            this.deleteTrack.Size = new System.Drawing.Size(230, 33);
            this.deleteTrack.TabIndex = 17;
            this.deleteTrack.Text = "Удалить из списка";
            this.deleteTrack.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deleteTrack.Click += new System.EventHandler(this.DeleteTrack_Click);
            // 
            // addTrack
            // 
            this.addTrack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.addTrack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addTrack.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.addTrack.Font = new System.Drawing.Font("Comfortaa", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addTrack.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.addTrack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addTrack.Location = new System.Drawing.Point(0, 1);
            this.addTrack.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.addTrack.Name = "addTrack";
            this.addTrack.Size = new System.Drawing.Size(230, 33);
            this.addTrack.TabIndex = 16;
            this.addTrack.Text = "Добавить файл";
            this.addTrack.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addTrack.Click += new System.EventHandler(this.AddTrack_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.addTrack);
            this.panel1.Controls.Add(this.deleteTrack);
            this.panel1.Controls.Add(this.showTheTrackInExplorer);
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 100);
            this.panel1.TabIndex = 21;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.OpenFileDialog1_FileOk);
            // 
            // TrackMenu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TrackMenu";
            this.Size = new System.Drawing.Size(240, 110);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label showTheTrackInExplorer;
        private System.Windows.Forms.Label deleteTrack;
        private System.Windows.Forms.Label addTrack;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}
