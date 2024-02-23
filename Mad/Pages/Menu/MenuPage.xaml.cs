using Mad.Pages.EditNote;
using Mad.Pages.NotesList;
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

    public async void Settings_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new SettingsPage());
    }

    public async void Weather_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new WeatherPage());
    }

    public async void Notes_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new NotesListPage());
    }
}
