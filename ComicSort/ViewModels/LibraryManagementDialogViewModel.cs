using ComicSort.Data.Models;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Services.Dialogs;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;

namespace ComicSort.ViewModels
{
    public class LibraryManagementDialogViewModel : BindableBase, IDialogAware
    {

        private IDialogService _dialogService;

        public LibraryManagementDialogViewModel()
        {
            
        }

        private string _libraryFile;
        public string LibraryFile
        {
            get { return _libraryFile; }
            set { SetProperty(ref _libraryFile, value); }
        }

        public ObservableCollection<Libraries> Library { get; set; }

        public NewLibraryDialogViewModel ViewModel { get; set; }

        public LibraryManagementDialogViewModel(IDialogService dialogService)
        {
            _dialogService = dialogService;

            if (ViewModel != null)
                Library.Add(new Libraries() { LibraryPath = ViewModel.LibraryPath });
            else return;


        }

        private DelegateCommand _newButtonCommand;
        public DelegateCommand NewButtonCommand =>
            _newButtonCommand ?? (_newButtonCommand = new DelegateCommand(ExecuteNewButtonCommand));

        void ExecuteNewButtonCommand()
        {
            _dialogService.ShowDialog("NewLibraryDialog", null, null);
        }

        private DelegateCommand _cancelCommand;
        public DelegateCommand CancelCommand =>
            _cancelCommand ?? (_cancelCommand = new DelegateCommand(ExecuteCancelCommand));

        void ExecuteCancelCommand()
        {
            RequestClose?.Invoke(new DialogResult(ButtonResult.Cancel));
        }

        private DelegateCommand _deleteCommand;
        public DelegateCommand DeleteCommand =>
            _deleteCommand ?? (_deleteCommand = new DelegateCommand(ExecuteDeleteCommand));

        void ExecuteDeleteCommand()
        {

        }

        private DelegateCommand _okCommand;
        public DelegateCommand OKCommand =>
            _okCommand ?? (_okCommand = new DelegateCommand(ExecuteOKCommand));

        void ExecuteOKCommand()
        {

        }

        public string Title => "Library Management";

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
