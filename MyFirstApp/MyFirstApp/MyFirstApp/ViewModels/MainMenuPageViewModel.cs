using MyFirstApp.Models;
using MyFirstApp.Views;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;

namespace MyFirstApp.ViewModels
{
    public class MainMenuPageViewModel : BindableBase, INavigationAware
    {

        private ObservableCollection<MainMenuItem> _mainMenuList;
        public ObservableCollection<MainMenuItem> MainMenuList
        {
            get { return _mainMenuList; }
            set { SetProperty(ref _mainMenuList, value); }
        }

        private string _Test;
        public string Test
        {
            get { return _Test; }
            set { SetProperty(ref _Test, value); }
        }

        public MainMenuPageViewModel()
        {
            // Initialize main menu list
            _mainMenuList = new ObservableCollection<MainMenuItem>();

            // Add new main menu items to list
            _mainMenuList.Add(new MainMenuItem {
                Title = "Map",
                IconFilename = "icon_map.png",
                PageType = typeof(MapPage)
            });

            Test = "dsadsadddd";
        }
        
        public void OnNavigatedFrom(NavigationParameters parameters)
        {

        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {

        }
    }
}
