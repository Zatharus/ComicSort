using ComicSort.Core.IO;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Services.Dialogs;

namespace ComicSort.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private string _title = "ComicSort";
        
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        

        public MainWindowViewModel()
        {
            
            
        }
    }
}
