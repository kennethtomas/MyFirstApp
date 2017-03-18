using Prism.Mvvm;
using System;

namespace MyFirstApp.Models
{
    public class MainMenuItem : BindableBase
    {
        public MainMenuItem()
        {

        }

        private string _title;
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        private string _iconFilename;
        public string IconFilename
        {
            get { return _iconFilename; }
            set { SetProperty(ref _iconFilename, value); }
        }

        private Type _pageType;
        public Type PageType
        {
            get { return _pageType; }
            set { SetProperty(ref _pageType, value); }
        }
    }
}
