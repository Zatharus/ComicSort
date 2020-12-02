using Ookii.Dialogs.Wpf;
using System;
using System.Collections.Generic;
using System.Text;

namespace ComicSort.ExtensionMethods
{
    public static class BrowseFolder
    {
        public static string OpenBrowseFolder()
        {
            var browseDialog = new VistaFolderBrowserDialog();
            browseDialog.ShowDialog();
            var fullPath = browseDialog.SelectedPath;
            return fullPath;
        }
    }
}
