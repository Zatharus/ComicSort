using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ComicSort.Core.IO
{
    public static class FileUtility
    {
        public static IEnumerable<string> GetFolders(string path, int levels)
        {
            if (SafeDirectoryExists(path))
            {
                foreach (var enumerateDirectory in Directory.EnumerateDirectories(path))
                {
                    var sub = enumerateDirectory;
                    yield return Path.Combine(path, sub);
                    if(levels > 0)
                    {
                        foreach (var folder in GetFolders(sub, levels - 1))
                            yield return folder;
                        sub = null;
                    }
                }
            }
        }

        public static bool SafeFileExists(string path)
        {
            try
            {
                return File.Exists(path);
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool SafeDirectoryExists(string path)
        {
            try
            {
                return Directory.Exists(path);
            }
            catch (Exception)
            {

                return false;
            }
        }

        public static FileInfo GetFileInfo(string file)
        {
            DateTime dateCreated;
            DateTime lastAccessed;
            string filePath = string.Empty;
            string fileName = string.Empty;

            FileInfo fi = new FileInfo(file);
            dateCreated = fi.CreationTime;
            lastAccessed = fi.LastAccessTime;
            filePath = fi.DirectoryName;
            fileName = fi.Name;

            return fi;
        }
    }
}
