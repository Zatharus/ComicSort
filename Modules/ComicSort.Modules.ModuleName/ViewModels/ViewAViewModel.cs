using ComicSort.Core.Mvvm;
using ComicSort.Services.Interfaces;
using Prism.Regions;
using System;
using System.IO;

namespace ComicSort.Modules.ModuleName.ViewModels
{
    public class ViewAViewModel : RegionViewModelBase
    {
        private string _message;
        public string Message
        {
            get { return _message; }
            set { SetProperty(ref _message, value); }
        }

        public ViewAViewModel(IRegionManager regionManager, IMessageService messageService) :
            base(regionManager)
        {
            Message = messageService.GetMessage();
        }

        public override void OnNavigatedTo(NavigationContext navigationContext)
        {
            string folder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\ComicSort");

            if (!Directory.Exists(folder))
            {
                Directory.CreateDirectory(folder);
            }
        }
    }
}
