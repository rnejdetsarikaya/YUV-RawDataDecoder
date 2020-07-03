using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;

namespace RawDataDecoder
{
    public partial class Player : UserControl
    {
        bool isPlaying = false;
        Thread thread;
        int framePos = 0;
        Size formSize;
        public static int trackBarMax;
        public static int framesCount;
        int framePosOnClick;
        string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "frames","frame");

        public Player()
        {
            InitializeComponent();
        }
        public void setLoadingText(string text)
        {
            loadingText.Invoke(new MethodInvoker(delegate ()
            {
                loadingText.Text = text;
            }));
        }
        public void setBarMax()
        {
            trackBar.Invoke(new MethodInvoker(delegate ()
            {
                trackBar.Maximum = framesCount;
            }));
        }
        public void setPlayingStatus(bool status)
        {
            isPlaying = status;
        }

        public void setFromSize(Size size)
        {
            formSize = size;
        }

        public bool getPlayingStatus()
        {
            return isPlaying;
        }

        public void setThread(Thread thread)
        {
            this.thread = thread;
        }

        public void setFrameBox(string path)
        {
            frameBox.ImageLocation = path;
        }

        public async void PlayFrames()
        {
            for (int i = framePos; i <= framesCount; i++)
            {
                if (isPlaying)
                {
                    frameBox.ImageLocation = path + i + ".bmp";
                    trackBar.Value = i;
                    frameBox.Refresh();
                    double perSecond = 1 / (double)fps.Value;
                    await Task.Delay((int)(perSecond*1000));
                }
                else
                {
                    playPause.Image = Properties.Resources.play;
                    framePos = i;
                    return;
                }
            }

            framePos = 0;
            isPlaying = false;
            playPause.Image = Properties.Resources.play;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            ParentForm.Size = formSize;
            this.Visible = false;
            if (thread != null)
                thread.Abort();

            foreach (Control control in ParentForm.Controls)
            {
                if (!control.Name.Equals("Player"))
                    control.Enabled = true;
            }
            framePos = 0;
            trackBar.Value = 0;
            int a = 0;

            while (File.Exists(path + a + ".bmp"))
            {
                File.Delete(path + a + ".bmp");
                a++;
            }

            isPlaying = false;

        }

        private void TrackBar_ValueChanged(object sender, EventArgs e)
        {
            if(File.Exists(path + trackBar.Value + ".bmp"))
            {
                framePos = trackBar.Value;
                frameBox.ImageLocation = path + trackBar.Value + ".bmp";
            }
            else
            {
                framePos = framePosOnClick;
                MessageBox.Show("This frame is not yet read");
            }

        }

        private void TrackBar_MouseDown(object sender, MouseEventArgs e)
        {
            framePosOnClick = framePos;
            isPlaying = false;
        }


        private void saveBmp_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Title = "Please select save path";
            save.Filter= "BMP File |*.bmp";
            save.FileName = "frame";
            if (save.ShowDialog() == DialogResult.OK)
            {
                if (saveAll.Checked)
                {
                    int index = 0;
                    while(index <= framesCount)
                        File.Copy(path + index + ".bmp", save.FileName.Substring(0,save.FileName.IndexOf('.')) + index++ + ".bmp");
                }
                else
                    frameBox.Image.Save(save.FileName, System.Drawing.Imaging.ImageFormat.Bmp);
            }
        }

        private void Player_Load(object sender, EventArgs e)
        {
            trackBar.ValueChanged += TrackBar_ValueChanged;
            trackBar.MouseDown += TrackBar_MouseDown;
            frameBox.SizeMode = PictureBoxSizeMode.StretchImage;
            playPause.Image = Properties.Resources.play;
            saveBmp.Image = Properties.Resources.save;
            exit.Image = Properties.Resources.exit;
        }


        //playPause
        private void button3_Click(object sender, EventArgs e)
        {
            isPlaying = !isPlaying;
            if (isPlaying)
            {
                playPause.Image = Properties.Resources.pause;
                PlayFrames();
            }
        }
    }
}
