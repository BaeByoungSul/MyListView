using MyListView.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyListView
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            TabbedPage tabbed  = new TabbedPage();

            tabbed.Children.Add(new BasicList() { Title = "BasicX", IconImageSource = "xaml.png" });
            tabbed.Children.Add(new UnevenRow() { Title = "UnevenRow", IconImageSource = "xaml.png" });
            tabbed.Children.Add(new ContextAction() { Title = "ContextX", IconImageSource = "xaml.png" });
            tabbed.Children.Add(new CustomCell() { Title = "CustomCell", IconImageSource = "xaml.png" });
            tabbed.Children.Add(new HeaderFooter() { Title = "Headerfooter", IconImageSource = "xaml.png" });

            MainPage = tabbed;  

            //MainPage = new MainPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
