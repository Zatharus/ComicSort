using ComicSort.Core.IO;
using ComicSort.Data.Models;
using ComicSort.Services.Interfaces;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Services.Dialogs;

namespace ComicSort.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private string _title = "ComicSort";
        private readonly IDialogService _dialogService;
        

        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public string Test { get; set; }



        public MainWindowViewModel(IDialogService dialogService)
        {
            _dialogService = dialogService;
           
           
        }
    }
}
