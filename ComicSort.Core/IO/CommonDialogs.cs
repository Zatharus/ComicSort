using Microsoft.Win32;
using Ookii.Dialogs.Wpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComicSort.Core.IO
{
    public static class CommonDialogs
    {
        public static string ShowOpenFile()
        {
            string fileName = null;
            var openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();
            fileName = openFileDialog.FileName;

            return fileName;
        }

        public static string ShowFolderBrowserDialog()
        {
            string fullPath = null;
            var folderBrowserDialog = new VistaFolderBrowserDialog();
            folderBrowserDialog.ShowDialog();
            fullPath = folderBrowserDialog.SelectedPath;

            return fullPath;
        }
    }
}
