using ComicSort.Core.IO;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Services.Dialogs;

namespace ComicSort.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private string _title = "ComicSort";
        private IDialogService _dialogService;
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        private DelegateCommand _libraryManagementCommand;
        public DelegateCommand LibraryManagementCommand =>
            _libraryManagementCommand ?? (_libraryManagementCommand = new DelegateCommand(ExecuteLibraryManagementCommand));

        void ExecuteLibraryManagementCommand()
        {
            
            _dialogService.ShowDialog("LibraryManagementDialog", null, null);
        }

        public MainWindowViewModel(IDialogService dialogService)
        {
            _dialogService = dialogService;
            
        }
    }
}
