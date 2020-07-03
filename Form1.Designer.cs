namespace RawDataDecoder
{
    partial class Form1
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
            int a = 0;
            while (System.IO.File.Exists(@"C:\Users\NECOO\Desktop\RawDataDecoder\RawDataDecoder\bin\Debug\frame" + a + ".bmp"))
            {
                System.IO.File.Delete(@"C:\Users\NECOO\Desktop\RawDataDecoder\RawDataDecoder\bin\Debug\frame" + a + ".bmp");
                a++;
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFile = new System.Windows.Forms.Button();
            this.play = new System.Windows.Forms.Button();
            this.settingsButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.path = new System.Windows.Forms.TextBox();
            this.settings = new RawDataDecoder.Settings();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFile
            // 
            this.openFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openFile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.openFile.Location = new System.Drawing.Point(12, 60);
            this.openFile.Name = "openFile";
            this.openFile.Size = new System.Drawing.Size(133, 55);
            this.openFile.TabIndex = 2;
            this.openFile.Text = "Open File";
            this.openFile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.openFile.UseVisualStyleBackColor = true;
            this.openFile.Click += new System.EventHandler(this.button3_Click);
            // 
            // play
            // 
            this.play.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.play.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.play.Location = new System.Drawing.Point(12, 121);
            this.play.Name = "play";
            this.play.Size = new System.Drawing.Size(133, 55);
            this.play.TabIndex = 1;
            this.play.Text = "Play File";
            this.play.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.play.UseVisualStyleBackColor = true;
            this.play.Click += new System.EventHandler(this.button2_Click);
            // 
            // settingsButton
            // 
            this.settingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.settingsButton.Location = new System.Drawing.Point(12, 182);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(133, 55);
            this.settingsButton.TabIndex = 0;
            this.settingsButton.Text = "Settings";
            this.settingsButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.settingsButton.UseVisualStyleBackColor = true;
            this.settingsButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Location = new System.Drawing.Point(160, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 305);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel2.Location = new System.Drawing.Point(1, 273);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(481, 10);
            this.panel2.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel3.Location = new System.Drawing.Point(1, 22);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(481, 10);
            this.panel3.TabIndex = 4;
            // 
            // path
            // 
            this.path.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.path.Location = new System.Drawing.Point(176, 283);
            this.path.Name = "path";
            this.path.ReadOnly = true;
            this.path.Size = new System.Drawing.Size(303, 15);
            this.path.TabIndex = 5;
            // 
            // settings
            // 
            this.settings.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.settings.Location = new System.Drawing.Point(176, 38);
            this.settings.Name = "settings";
            this.settings.Size = new System.Drawing.Size(295, 229);
            this.settings.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 305);
            this.Controls.Add(this.path);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.settings);
            this.Controls.Add(this.openFile);
            this.Controls.Add(this.play);
            this.Controls.Add(this.settingsButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form1";
            this.Text = "RawDataDecoder";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.Button play;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button openFile;
        private Settings settings;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox path;
    }
}

