namespace MusicPlayer
{
    partial class PlaylistCell
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
            this.PlaylistName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // PlaylistName
            // 
            this.PlaylistName.Font = new System.Drawing.Font("Comfortaa", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PlaylistName.Location = new System.Drawing.Point(5, 5);
            this.PlaylistName.Name = "PlaylistName";
            this.PlaylistName.Size = new System.Drawing.Size(270, 40);
            this.PlaylistName.TabIndex = 0;
            this.PlaylistName.Text = "PlaylistName";
            this.PlaylistName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PlaylistName.Click += new System.EventHandler(this.PlaylistName_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(280, 50);
            this.panel1.TabIndex = 1;
            // 
            // PlaylistCell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.PlaylistName);
            this.Controls.Add(this.panel1);
            this.Name = "PlaylistCell";
            this.Size = new System.Drawing.Size(280, 50);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label PlaylistName;
        private System.Windows.Forms.Panel panel1;
    }
}
