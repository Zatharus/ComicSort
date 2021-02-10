using ComicSort.Core.Mvvm;
using Prism.Commands;
using Prism.Regions;
using Prism.Services.Dialogs;
using System.Windows;

namespace ComicSort.Modules.MenuBar.ViewModels
{
    public class MainMenuViewModel : RegionViewModelBase
    {
        public MainMenuViewModel(IRegionManager regionManager, IDialogService dialogService) :
            base(regionManager)
        {
            _dialogService = dialogService;
        }

        private DelegateCommand _libraryManagementCommand;
        private readonly IDialogService _dialogService;

        public DelegateCommand LibraryManagementCommand =>
            _libraryManagementCommand ?? (_libraryManagementCommand = new DelegateCommand(ExecuteLibraryManagementCommand));

        void ExecuteLibraryManagementCommand()
        {
            _dialogService.ShowDialog("LibraryManagementDialog", null, null);
        }

        private DelegateCommand _exitCommand;
        public DelegateCommand ExitCommand =>
            _exitCommand ?? (_exitCommand = new DelegateCommand(ExecuteExitCommand));

        void ExecuteExitCommand()
        {
            Application.Current.Shutdown();
        }
    }
}
