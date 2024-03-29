﻿using ComicSort.Modules.MainDisplay;
using ComicSort.Modules.MenuBar;
using ComicSort.Modules.ModuleName;
using ComicSort.Services;
using ComicSort.Services.Interfaces;
using ComicSort.ViewModels;
using ComicSort.Views;
using Prism.Ioc;
using Prism.Modularity;
using System;
using System.IO;
using System.Windows;

namespace ComicSort
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {

        
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();

            
        }

        
        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<IMessageService, MessageService>();
            containerRegistry.RegisterDialog<LibraryManagementDialog, LibraryManagementDialogViewModel>();
            containerRegistry.RegisterDialog<NewLibraryDialog, NewLibraryDialogViewModel>();
        }

        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            moduleCatalog.AddModule<ModuleNameModule>();
            moduleCatalog.AddModule<MainDisplayModule>();
            moduleCatalog.AddModule<MenuBarModule>();
        }

        protected override void OnExit(ExitEventArgs e)
        {

            base.OnExit(e); 
        }
    }
}
