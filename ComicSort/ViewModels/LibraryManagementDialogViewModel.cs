using Prism.Commands;
using Prism.Mvvm;
using Prism.Services.Dialogs;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ComicSort.ViewModels
{
    public class LibraryManagementDialogViewModel : BindableBase, IDialogAware
    {

        private IDialogService _dialogService;
        public LibraryManagementDialogViewModel(IDialogService dialogService)
        {
            _dialogService = dialogService;
        }

        private DelegateCommand _newButtonCommand;
        public DelegateCommand NewButtonCommand =>
            _newButtonCommand ?? (_newButtonCommand = new DelegateCommand(ExecuteNewButtonCommand));

        void ExecuteNewButtonCommand()
        {
            _dialogService.ShowDialog("NewLibraryDialog", null, null);
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
