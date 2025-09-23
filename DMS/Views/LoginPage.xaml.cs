namespace DMS.Views;

public partial class LoginPage : ContentPage
{
    public LoginPage()
    {
        InitializeComponent();
    }
    private async void OnForgotPasswordClicked(object sender, EventArgs e)
        => await DisplayAlert("Forgot Password", "Implement your flow here.", "OK");

    private async void OnRegisterClicked(object sender, EventArgs e)
        => await DisplayAlert("Register", "Navigate to your registration page.", "OK");

    private async void OnLoginClicked(object sender, EventArgs e)
    {
        if (usernameValidator.IsNotValid)
        {
            await DisplayAlert("User Name", "Please insert a user name", "OK");
            return;
        }
        if (passwordValidator.IsNotValid)
        {
            await DisplayAlert("Password", "Please insert a password to login.", "OK");
            return;
        }
        // Replace with real authentication logic
        //await DisplayAlert("Login", $"Username: {UsernameEntry.Text}", "OK");
        // await Shell.Current.GoToAsync($"//{nameof(ItemPage)}");

        //await Shell.Current.GoToAsync("//ItemPage");  // The route should match with the registered route name
        //Application.Current.MainPage = new ItemPage(_repository);
        Application.Current.MainPage = new AppShell();

    }
}