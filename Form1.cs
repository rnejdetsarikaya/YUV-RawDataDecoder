using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RawDataDecoder
{
    public partial class Form1 : Form
    {
        public static Thread thread;
        Player player = new Player();
        Size _size;
        String filePath = "fileNotFound";
        public Form1()
        {
            InitializeComponent();
            MaximizeBox = false;
            settings.Visible = false;
            player.Visible = false;
            Controls.Add(player);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            openFile.Image = Properties.Resources.file;
            play.Image = Properties.Resources.fileplay;
            settingsButton.Image = Properties.Resources.cog;
            _size = Size;
        }

        //settings
         private void button1_Click(object sender, EventArgs e)
        {
            settings.Visible = !settings.Visible;
            settings.BringToFront();
        }

        //playFile
        private void button2_Click(object sender, EventArgs e)
        {
            ReadData.player = this.player;
            if (!filePath.Equals("fileNotFound"))
            {
                player.Dock = DockStyle.Fill;
                player.Visible = true;
                Size = new Size(430, 500); //player icin form yeniden boyutlandirildi
                player.setFromSize(_size);
                player.BringToFront();
                foreach (Control control in Controls)
                {
                    if (!control.Name.Equals("Player"))
                        control.Enabled = false;
                }
                int width, height;
                width = settings.getWidth();
                height = settings.getHeight();
                string format = settings.getFormat();
                thread = new Thread(() => read(width,height,format));
                player.setThread(thread);
                thread.Start();
            }
            else
                MessageBox.Show("File Not Found!");

        }

        private void read(int widgt,int height,string format)
        {
            ReadData.read(filePath,widgt, height,format);
        }

        //openFile
        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "YUV File |*.yuv";
            file.RestoreDirectory = true;
            file.CheckFileExists = false;
            file.Title = "Please Select a YUV File...";

            if (file.ShowDialog() == DialogResult.OK)//dosya seçilidiyse
            {
                filePath = file.FileName;
                path.Text = filePath;
            }
        }


    }
}