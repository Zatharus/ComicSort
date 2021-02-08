using ComicSort.Core;
using ComicSort.Modules.MenuBar.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace ComicSort.Modules.MenuBar
{
    public class MenuBarModule : IModule
    {
        private readonly IRegionManager _regionManager;

        public MenuBarModule(IRegionManager regionManager)
        {
            _regionManager = regionManager;
        }
        public void OnInitialized(IContainerProvider containerProvider)
        {
            _regionManager.RegisterViewWithRegion(RegionNames.MenuRegion, typeof(MainMenu));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {

        }
    }
}