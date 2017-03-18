using Prism.Unity;
using MyFirstApp.Views;

namespace MyFirstApp
{
    public partial class App : PrismApplication
    {
        public App(IPlatformInitializer initializer = null) : base(initializer) { }

        protected override void OnInitialized()
        {
            InitializeComponent();

            NavigationService.NavigateAsync("ChatPage");
        }

        protected override void RegisterTypes()
        {
            Container.RegisterTypeForNavigation<MainPage>();
            Container.RegisterTypeForNavigation<MainMenuPage>();
            Container.RegisterTypeForNavigation<MapPage>();
            Container.RegisterTypeForNavigation<ChatPage>();

        }
    }
}
