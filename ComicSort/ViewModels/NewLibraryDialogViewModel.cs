using ComicSort.Core.IO;
using ComicSort.Core.Mvvm;
using ComicSort.Data.Models;
using ComicSort.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Prism.Commands;
using Prism.Services.Dialogs;
using System;
using System.Collections.Generic;
using System.IO;

namespace ComicSort.ViewModels
{
    public class NewLibraryDialogViewModel : ViewModelBase, IDialogAware
    {
        public NewLibraryDialogViewModel()
        {

        }

        public FileInfo FileInfo { get; set; }

        private string _libraryName;
        public string LibraryName
        {
            get { return _libraryName; }
            set { SetProperty(ref _libraryName, value); }
        }

        private string _libraryPath;
        public string LibraryPath
        {
            get { return _libraryPath; }
            set { SetProperty(ref _libraryPath, value); }
        }

        private DelegateCommand _browseCommand;
        public DelegateCommand BrowseCommand =>
            _browseCommand ?? (_browseCommand = new DelegateCommand(ExecuteBrowseCommand));

        void ExecuteBrowseCommand()
        {
            LibraryPath = CommonDialogs.ShowFolderBrowserDialog();
        }

        private DelegateCommand _okCommand;
        public DelegateCommand OKCommand =>
            _okCommand ?? (_okCommand = new DelegateCommand(ExecuteOKCommand));

        void ExecuteOKCommand()
        {
            var dbcontext = new ComicDatabaseDBContext();
            var libraryFile = dbcontext.CreateConnectionString(_libraryName, LibraryPath);
            dbcontext.Database.EnsureCreated();
            FileInfo = FileUtility.GetFileInfo(libraryFile);

            RequestClose?.Invoke(new DialogResult(ButtonResult.OK));

        }

        private DelegateCommand _cancelCommand;
        public DelegateCommand CancelCommand =>
            _cancelCommand ?? (_cancelCommand = new DelegateCommand(ExecuteCancelCommand));

        void ExecuteCancelCommand()
        {
            RequestClose?.Invoke(new DialogResult(ButtonResult.Cancel));
        }

        public string Title => "Create New library";

        public event Action<IDialogResult> RequestClose;

        public bool CanCloseDialog()
        {
            return true;
        }

        public void OnDialogClosed()
        {
            
        }

        public void OnDialogOpened(IDialogParameters parameters)
        {
            
        }

        
    }
}
