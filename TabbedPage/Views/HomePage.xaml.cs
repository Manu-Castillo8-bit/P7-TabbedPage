namespace TabbedPage.Views;

public partial class HomePage : ContentPage
{
    public HomePage()
    {
        InitializeComponent();
    }

    private async void OnButtonClicked(object sender, EventArgs e)
    {
        await DisplayAlert("Mensaje", "¡Bienvenido a TabbedPage!", "OK");
    }
}