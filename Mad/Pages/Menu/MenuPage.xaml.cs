using Mad.Pages.EditNote;
using Mad.Pages.Settings;
using Mad.Pages.Weather;

namespace Mad.Pages.Menu;

public partial class MenuPage : ContentPage
{
	public MenuPage()
    {
        InitializeComponent();
        Title = "Menu";
    }

    public async void CreateNote_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new EditNotePage(true));
    }

    async void Settings_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new SettingsPage());
    }

    async void Weather_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new WeatherPage());
    }
}
