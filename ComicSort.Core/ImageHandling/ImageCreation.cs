using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Media.Imaging;

namespace ComicSort.Core.ImageHandling
{
    public static class ImageCreation
    {
        public static BitmapImage CreateBitmapImageFromByteArray(byte[] bytearray)
        {
            var image = new BitmapImage();
            using (var stream = new MemoryStream(bytearray))
            {
                image.BeginInit();
                image.CacheOption = BitmapCacheOption.OnLoad;
                image.StreamSource = stream;
                image.EndInit();

            }
            return image;
        }
    }
}
