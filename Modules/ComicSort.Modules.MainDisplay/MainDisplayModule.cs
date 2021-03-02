using ComicSort.Core;
using ComicSort.Modules.MainDisplay.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace ComicSort.Modules.MainDisplay
{
    public class MainDisplayModule : IModule
    {
        private readonly IRegionManager _regionManager;

        public MainDisplayModule(IRegionManager regionManager)
        {
            _regionManager = regionManager;
        }
        public void OnInitialized(IContainerProvider containerProvider)
        {
            _regionManager.RequestNavigate(RegionNames.MainDisplayRegion, "MainDisplayPanel");
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<MainDisplayPanel>();
        }
    }
}