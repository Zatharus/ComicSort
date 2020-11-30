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
        public LibraryManagementDialogViewModel()
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
