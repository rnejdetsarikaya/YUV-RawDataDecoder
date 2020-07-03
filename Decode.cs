using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace RawDataDecoder
{
    static class Decode
    {
        public static Bitmap getFrame(byte[] data,int width, int height)
        {
            int a = 0;

            Bitmap img = new Bitmap(width, height);
            BitmapData imgData = img.LockBits(new Rectangle(0, 0, img.Width, img.Height), ImageLockMode.ReadWrite, img.PixelFormat);

            int bytesPerPixel = Bitmap.GetPixelFormatSize(img.PixelFormat) / 8; // pixel basina byte
            int byteCount = imgData.Stride * img.Height; // toplam byte
            byte[] pixelData = new byte[byteCount]; // pikselerin byte verisi
            IntPtr firstPixelPtr = imgData.Scan0; // ilk pikselin adresi
            Marshal.Copy(firstPixelPtr, pixelData, 0, pixelData.Length); // ilk pixelden son pixele butun bitmapin datasini pixeldataya at
            int heightInPixels = imgData.Height;
            int widthInBytes = imgData.Width * bytesPerPixel;

            for (int y = 0; y < heightInPixels; y++)
            {
                int currentLine = y * imgData.Stride;
                for (int x = 0; x < widthInBytes; x = x + bytesPerPixel)
                {
                    pixelData[currentLine + x] = data[a];
                    pixelData[currentLine + x + 1] = data[a];
                    pixelData[currentLine + x + 2] = data[a];
                    a++;
                }
            }

            // copy modified bytes back
            Marshal.Copy(pixelData, 0, firstPixelPtr, pixelData.Length);
            img.UnlockBits(imgData);

            return img;
        }
        
        
    }

}
