using Microsoft.Extensions.DependencyInjection;

namespace TabbedPage
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
                   MainPage = new MainPage();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
         
        }
    }
}