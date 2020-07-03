using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace RawDataDecoder
{
    static class ReadData
    {
        public static Player player { get; set; }
        static int framePos=0;
        static long pos = 0;
        static int count = 0;
        public static byte[] ReadAllBytes(int bufferSize,FileStream fs)
        {
            try
            {
                byte[] buffer = null;
                buffer = new byte[bufferSize];
                fs.Read(buffer, 0, bufferSize);
                framePos += bufferSize;
                return buffer;
            }
            catch(Exception e)
            {
                System.Windows.Forms.MessageBox.Show("Error :)"+e);
                return null;
            }

        }
        public static void readFrameData(int width, int height, double format, FileStream fs)
        {
            string path = "";
            byte[] frameData = new byte[(int)(width * height * format)];
            frameData = ReadAllBytes((int)(width * height * format), fs);
            //Array.Copy(data, pos, frameData, 0, frameData.Length);
            Bitmap image = Decode.getFrame(frameData, width, height); //Decode.getFrame(frameData, width, height);
            pos += frameData.Length;
            try
            {
                path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "frames"); //masaustunde frames adli dizinin pathi
                Directory.CreateDirectory(path); // yoksa bu dizini olustur
                path = Path.Combine(path,"frame"); //directoryde frame adli path
                image.Save(path + count + ".bmp", System.Drawing.Imaging.ImageFormat.Bmp); // desktop\framei.bmp
            }
            catch (Exception e)
            {

            }
            if (count == 0)
                player.setFrameBox(path + count + ".bmp");
            count++;
        }
        public static void read(string file, int width, int height, string format)
        {
            player.setLoadingText("Frames Loading...");
            pos = 0;
            count = 0;
            player.setPlayingStatus(true);
            switch (format)
            {
                case "YUV 4:4:4":
                    using (FileStream fs = new FileStream(file, FileMode.Open, FileAccess.Read))
                    {
                        Player.framesCount = (int)(fs.Length / (width * height * 3));
                        player.setBarMax();
                        while (fs.Length >= pos)
                        {
                            readFrameData(width, height, 3, fs);
                        }
                    }
                    break;

                case "YUV 4:2:2":
                    using (FileStream fs = new FileStream(file, FileMode.Open, FileAccess.Read))
                    {
                        Player.framesCount = (int)(fs.Length / (width * height * 2));
                        player.setBarMax();
                        while (fs.Length >= pos)
                        {
                            readFrameData(width, height, 2, fs);
                        }
                    }
                    break;
                //
                case "YUV 4:2:0":
                    using (FileStream fs = new FileStream(file, FileMode.Open, FileAccess.Read))
                    {
                        Player.framesCount = (int)(fs.Length / (width * height * 1.5));
                        player.setBarMax();
                        while (fs.Length >= pos)
                        {
                            readFrameData(width, height, 1.5, fs);
                        }
                    }
                    break;
            }
            player.setPlayingStatus(false);
            player.setLoadingText("Frames Loaded");
        }
    }
}
