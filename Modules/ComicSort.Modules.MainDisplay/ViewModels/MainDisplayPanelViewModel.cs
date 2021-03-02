using ComicSort.Core.Mvvm;
using ComicSort.Services.Interfaces;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ComicSort.Modules.MainDisplay.ViewModels
{
    public class MainDisplayPanelViewModel : RegionViewModelBase
    {
        public MainDisplayPanelViewModel(IRegionManager regionManager) :
            base(regionManager)
        {

        }

        public override void OnNavigatedTo(NavigationContext navigationContext)
        {
            
        }
    }
}
