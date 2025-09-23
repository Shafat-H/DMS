using DMS.View_MVVM;
using DMS.Views;

namespace DMS
{
    public partial class AppShell : Shell
    {
        //public Command<string> NavigateCommand { get; }

        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(DashboardPage), typeof(DashboardPage));
            Routing.RegisterRoute(nameof(ItemPage), typeof(ItemPage));
            Routing.RegisterRoute(nameof(ItemAddPage), typeof(ItemAddPage));
            Routing.RegisterRoute(nameof(ItemEditPage), typeof(ItemEditPage));
            Routing.RegisterRoute(nameof(LoginPage), typeof(LoginPage));
            Routing.RegisterRoute(nameof(Item_MVVM_Page), typeof(Item_MVVM_Page));

            //NavigateCommand = new Command<string>(async (pageName) =>
            //{
            //    switch (pageName)
            //    {
            //        case "ItemPage":
            //            await Shell.Current.GoToAsync("ItemPage");
            //            break;
            //            // Add more cases for other pages
            //    }
            //});
        }

        private void MenuItem_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new LoginPage();
        }
    }
}
