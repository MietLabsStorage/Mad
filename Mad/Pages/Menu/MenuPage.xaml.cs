using Mad.Pages.Settings;

namespace Mad.Pages.Menu;

public partial class MenuPage : ContentPage
{
	public MenuPage()
    {
        InitializeComponent();

        Title = "Menu";
    }

    public async void CreateNote_Clicked(Object sender, EventArgs e)
    {
        await Navigation.PushAsync(new EditNotePage(true));
    }

    async void Settings_Clicked(System.Object sender, System.EventArgs e)
    {
        await Navigation.PushAsync(new SettingsPage());
    }

    void Notes_Clicked(System.Object sender, System.EventArgs e)
    {
    }
}
