using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ComicSort.Core.IO
{
    public static class ComicDatabaseUtility
    {
        public static string CreateDatabaseDirectory(string libraryPath, string libraryName)
        {
            var libraryFolder = Path.Combine(libraryPath, libraryName);
            if (!Directory.Exists(libraryFolder))
            {
                Directory.CreateDirectory(libraryFolder);
                Directory.SetCurrentDirectory(libraryFolder);
                return libraryFolder;
            }

            return null;
        }
    }
}
