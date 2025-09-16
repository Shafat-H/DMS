using DMS.UseCases.Interface;

namespace DMS.Views;

public partial class DashboardPage : ContentPage
{
    public DashboardPage()
    {
        InitializeComponent();
    }
    private async void OnForgotPasswordClicked(object sender, EventArgs e)
        => await DisplayAlert("Forgot Password", "Implement your flow here.", "OK");

    private async void OnRegisterClicked(object sender, EventArgs e)
        => await DisplayAlert("Register", "Navigate to your registration page.", "OK");

    private async void OnLoginClicked(object sender, EventArgs e)
    {
        // Replace with real authentication logic
        //await DisplayAlert("Login", $"Username: {UsernameEntry.Text}", "OK");
        // await Shell.Current.GoToAsync($"//{nameof(ItemPage)}");

        //await Shell.Current.GoToAsync("//ItemPage");  // The route should match with the registered route name
        //Application.Current.MainPage = new ItemPage(_repository);
        Application.Current.MainPage = new AppShell();

    }
}