namespace MusicPlayer
{
    partial class PlaylistMenu
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
            this.deletePlaylist = new System.Windows.Forms.Label();
            this.savePlaylistBtn = new System.Windows.Forms.Label();
            this.creatPlaylistBtn = new System.Windows.Forms.Label();
            this.RenamePlaylist = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // deletePlaylist
            // 
            this.deletePlaylist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.deletePlaylist.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deletePlaylist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deletePlaylist.Font = new System.Drawing.Font("Comfortaa", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deletePlaylist.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.deletePlaylist.Location = new System.Drawing.Point(4, 100);
            this.deletePlaylist.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.deletePlaylist.Name = "deletePlaylist";
            this.deletePlaylist.Size = new System.Drawing.Size(307, 33);
            this.deletePlaylist.TabIndex = 12;
            this.deletePlaylist.Text = "Удалить плейлист";
            this.deletePlaylist.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deletePlaylist.Click += new System.EventHandler(this.DeletePlaylist_Click);
            // 
            // savePlaylistBtn
            // 
            this.savePlaylistBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.savePlaylistBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.savePlaylistBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.savePlaylistBtn.Font = new System.Drawing.Font("Comfortaa", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.savePlaylistBtn.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.savePlaylistBtn.Location = new System.Drawing.Point(4, 34);
            this.savePlaylistBtn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.savePlaylistBtn.Name = "savePlaylistBtn";
            this.savePlaylistBtn.Size = new System.Drawing.Size(307, 33);
            this.savePlaylistBtn.TabIndex = 9;
            this.savePlaylistBtn.Text = "Сохранить плейлист";
            this.savePlaylistBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.savePlaylistBtn.Click += new System.EventHandler(this.SavePlaylistBtn_Click);
            // 
            // creatPlaylistBtn
            // 
            this.creatPlaylistBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.creatPlaylistBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.creatPlaylistBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.creatPlaylistBtn.Font = new System.Drawing.Font("Comfortaa", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.creatPlaylistBtn.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.creatPlaylistBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.creatPlaylistBtn.Location = new System.Drawing.Point(4, 1);
            this.creatPlaylistBtn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.creatPlaylistBtn.Name = "creatPlaylistBtn";
            this.creatPlaylistBtn.Size = new System.Drawing.Size(307, 33);
            this.creatPlaylistBtn.TabIndex = 10;
            this.creatPlaylistBtn.Text = "Создать плейлист";
            this.creatPlaylistBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.creatPlaylistBtn.Click += new System.EventHandler(this.CreatPlaylistBtn_Click);
            // 
            // RenamePlaylist
            // 
            this.RenamePlaylist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.RenamePlaylist.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RenamePlaylist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RenamePlaylist.Font = new System.Drawing.Font("Comfortaa", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RenamePlaylist.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.RenamePlaylist.Location = new System.Drawing.Point(4, 67);
            this.RenamePlaylist.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RenamePlaylist.Name = "RenamePlaylist";
            this.RenamePlaylist.Size = new System.Drawing.Size(307, 33);
            this.RenamePlaylist.TabIndex = 13;
            this.RenamePlaylist.Text = "Переименовать плейлист";
            this.RenamePlaylist.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RenamePlaylist.Click += new System.EventHandler(this.RenamePlaylist_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.RenamePlaylist);
            this.panel1.Controls.Add(this.creatPlaylistBtn);
            this.panel1.Controls.Add(this.savePlaylistBtn);
            this.panel1.Controls.Add(this.deletePlaylist);
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(315, 133);
            this.panel1.TabIndex = 16;
            // 
            // PlaylistMenu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PlaylistMenu";
            this.Size = new System.Drawing.Size(324, 142);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label deletePlaylist;
        private System.Windows.Forms.Label savePlaylistBtn;
        private System.Windows.Forms.Label creatPlaylistBtn;
        private System.Windows.Forms.Label RenamePlaylist;
        private System.Windows.Forms.Panel panel1;
    }
}
