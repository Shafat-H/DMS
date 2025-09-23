using DMS.UseCases.Interface;
using DMS.Views;

namespace DMS
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            Application.Current.UserAppTheme = AppTheme.Light;
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            //return new Window(new AppShell());
            return new Window(new LoginPage());
        }
    }
}