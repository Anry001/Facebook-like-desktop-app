using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MyFilters
{
    public static class ImageFilters
    {
        private static Bitmap ApplyColorMatrix(Image i_SourceImage, ColorMatrix I_ColorMatrix)
        {
            Bitmap bmp32BppSource = GetArgbCopy(i_SourceImage);
            Bitmap bmp32BppDest = new Bitmap(bmp32BppSource.Width, bmp32BppSource.Height, PixelFormat.Format32bppArgb);

            using (Graphics graphics = Graphics.FromImage(bmp32BppDest))
            {
                ImageAttributes bmpAttributes = new ImageAttributes();

                bmpAttributes.SetColorMatrix(I_ColorMatrix);

                graphics.DrawImage(
                    bmp32BppSource,
                    new Rectangle(0, 0, bmp32BppSource.Width, bmp32BppSource.Height),
                    0,
                    0,
                    bmp32BppSource.Width,
                    bmp32BppSource.Height,
                    GraphicsUnit.Pixel,
                    bmpAttributes);
            }

            bmp32BppSource.Dispose();

            return bmp32BppDest;
        }

        private static Bitmap GetArgbCopy(Image I_SourceImage)
        {
            Bitmap bmpNew = new Bitmap(I_SourceImage.Width, I_SourceImage.Height, PixelFormat.Format32bppArgb);

            using (Graphics graphics = Graphics.FromImage(bmpNew))
            {
                graphics.DrawImage(I_SourceImage, new Rectangle(0, 0, bmpNew.Width, bmpNew.Height), new Rectangle(0, 0, bmpNew.Width, bmpNew.Height), GraphicsUnit.Pixel);
                graphics.Flush();
            }

            return bmpNew;
        }

        public static Bitmap DrawWithTransparency(this Image I_SourceImage)
        {
            ColorMatrix colorMatrix = new ColorMatrix(new float[][]
            {
                new float[] { 1, 0, 0, 0, 0 },
                new float[] { 0, 1, 0, 0, 0 },
                new float[] { 0, 0, 1, 0, 0 },
                new float[] { 0, 0, 0, 0.3f, 0 },
                new float[] { 0, 0, 0, 0, 1 }
            });

            return ApplyColorMatrix(I_SourceImage, colorMatrix);
        }

        public static Bitmap DrawAsGrayscale(this Image i_SourceImage)
        {
            ColorMatrix colorMatrix = new ColorMatrix(new float[][]
            {
                new float[] { .3f, .3f, .3f, 0, 0 },
                new float[] { .59f, .59f, .59f, 0, 0 },
                new float[] { .11f, .11f, .11f, 0, 0 },
                new float[] { 0, 0, 0, 1, 0 },
                new float[] { 0, 0, 0, 0, 1 }
            });

            return ApplyColorMatrix(i_SourceImage, colorMatrix);
        }

        public static Bitmap DrawAsSepiaTone(this Image I_SourceImage)
        {
            ColorMatrix colorMatrix = new ColorMatrix(new float[][]
            {
                new float[] { .393f, .349f, .272f, 0, 0 },
                new float[] { .769f, .686f, .534f, 0, 0 },
                new float[] { .189f, .168f, .131f, 0, 0 },
                new float[] { 0, 0, 0, 1, 0 },
                new float[] { 0, 0, 0, 0, 1 }
            });

            return ApplyColorMatrix(I_SourceImage, colorMatrix);
        }

        public static Bitmap DrawAsNegative(this Image sourceImage)
        {
            ColorMatrix colorMatrix = new ColorMatrix(new float[][]
            {
                new float[] { -1, 0, 0, 0, 0 },
                new float[] { 0, -1, 0, 0, 0 },
                new float[] { 0, 0, -1, 0, 0 },
                new float[] { 0, 0, 0, 1, 0 },
                new float[] { 1, 1, 1, 1, 1 }
            });

            return ApplyColorMatrix(sourceImage, colorMatrix);
        }
    }
}