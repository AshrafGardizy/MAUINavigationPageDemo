using MauiPages.Pages;
using MauiPages.Pages.NavigationPagesDemo;
namespace MauiPages
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new NavigationPage(new NavContentPage1());
            var navigationPage = new NavigationPage(new NavContentPage1());
            navigationPage.BarBackgroundColor = Colors.Firebrick;
            navigationPage.BarTextColor = Colors.Black;
            navigationPage.Title = "Home";
            MainPage = navigationPage;
        }
    }
}
