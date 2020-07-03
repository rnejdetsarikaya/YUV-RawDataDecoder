namespace RawDataDecoder
{
    partial class Player
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.exit = new System.Windows.Forms.Button();
            this.saveBmp = new System.Windows.Forms.Button();
            this.playPause = new System.Windows.Forms.Button();
            this.frameBox = new System.Windows.Forms.PictureBox();
            this.trackBar = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.fps = new System.Windows.Forms.NumericUpDown();
            this.saveAll = new System.Windows.Forms.CheckBox();
            this.loadingText = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.frameBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fps)).BeginInit();
            this.SuspendLayout();
            // 
            // exit
            // 
            this.exit.FlatAppearance.BorderSize = 0;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit.Location = new System.Drawing.Point(467, 3);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(55, 50);
            this.exit.TabIndex = 4;
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // saveBmp
            // 
            this.saveBmp.FlatAppearance.BorderSize = 0;
            this.saveBmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBmp.Location = new System.Drawing.Point(23, 3);
            this.saveBmp.Name = "saveBmp";
            this.saveBmp.Size = new System.Drawing.Size(55, 50);
            this.saveBmp.TabIndex = 5;
            this.saveBmp.UseVisualStyleBackColor = true;
            this.saveBmp.Click += new System.EventHandler(this.saveBmp_Click);
            // 
            // playPause
            // 
            this.playPause.FlatAppearance.BorderSize = 0;
            this.playPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playPause.Location = new System.Drawing.Point(241, 512);
            this.playPause.Name = "playPause";
            this.playPause.Size = new System.Drawing.Size(52, 50);
            this.playPause.TabIndex = 3;
            this.playPause.UseVisualStyleBackColor = true;
            this.playPause.Click += new System.EventHandler(this.button3_Click);
            // 
            // frameBox
            // 
            this.frameBox.Location = new System.Drawing.Point(23, 59);
            this.frameBox.Name = "frameBox";
            this.frameBox.Size = new System.Drawing.Size(499, 385);
            this.frameBox.TabIndex = 0;
            this.frameBox.TabStop = false;
            // 
            // trackBar
            // 
            this.trackBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackBar.LargeChange = 1;
            this.trackBar.Location = new System.Drawing.Point(23, 450);
            this.trackBar.Name = "trackBar";
            this.trackBar.Size = new System.Drawing.Size(499, 56);
            this.trackBar.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 494);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "FPS";
            // 
            // fps
            // 
            this.fps.Location = new System.Drawing.Point(84, 492);
            this.fps.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.fps.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.fps.Name = "fps";
            this.fps.Size = new System.Drawing.Size(47, 22);
            this.fps.TabIndex = 9;
            this.fps.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // saveAll
            // 
            this.saveAll.AutoSize = true;
            this.saveAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveAll.Location = new System.Drawing.Point(84, 18);
            this.saveAll.Name = "saveAll";
            this.saveAll.Size = new System.Drawing.Size(77, 21);
            this.saveAll.TabIndex = 10;
            this.saveAll.Text = "Save All";
            this.saveAll.UseVisualStyleBackColor = true;
            // 
            // loadingText
            // 
            this.loadingText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.loadingText.Location = new System.Drawing.Point(394, 552);
            this.loadingText.Name = "loadingText";
            this.loadingText.ReadOnly = true;
            this.loadingText.Size = new System.Drawing.Size(146, 15);
            this.loadingText.TabIndex = 11;
            this.loadingText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Player
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.loadingText);
            this.Controls.Add(this.saveAll);
            this.Controls.Add(this.fps);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBar);
            this.Controls.Add(this.saveBmp);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.playPause);
            this.Controls.Add(this.frameBox);
            this.Name = "Player";
            this.Size = new System.Drawing.Size(540, 570);
            this.Load += new System.EventHandler(this.Player_Load);
            ((System.ComponentModel.ISupportInitialize)(this.frameBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fps)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

 

        #endregion

        private System.Windows.Forms.PictureBox frameBox;
        private System.Windows.Forms.Button playPause;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button saveBmp;
        private System.Windows.Forms.TrackBar trackBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown fps;
        private System.Windows.Forms.CheckBox saveAll;
        private System.Windows.Forms.TextBox loadingText;
    }
}
