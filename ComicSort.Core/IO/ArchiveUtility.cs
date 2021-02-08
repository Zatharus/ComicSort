using ComicSort.Core.ImageHandling;
using SharpCompress.Archives;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ComicSort.Core.IO
{
    public class ArchiveUtility
    {
        public void ReadArchive(string fileName)
        {
            using (MemoryStream memoryStream = new MemoryStream())
            {
                using (var archive = ArchiveFactory.Open(fileName))
                {
                    foreach (IArchiveEntry entry in archive.Entries)
                    {
                        if (!entry.IsDirectory && entry.Key != "ComicInfo.xml")
                        {
                            memoryStream.Position = 0;
                            entry.WriteTo(memoryStream);
                            var buffer = memoryStream.ToArray();
                            ImageCreation.CreateBitmapImageFromByteArray(buffer);
                        }
                        else
                        {

                        }
                    }
                }
            }
            
        }
    }
}
