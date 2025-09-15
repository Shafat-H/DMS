using DMS.Views;

namespace DMS
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemPage), typeof(ItemPage));
            Routing.RegisterRoute(nameof(ItemAddPage), typeof(ItemAddPage));
            Routing.RegisterRoute(nameof(ItemEditPage), typeof(ItemEditPage));
        }
    }
}
