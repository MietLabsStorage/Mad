namespace Mad.Pages.Settings;

public partial class SettingsPage : ContentPage
{
	public SettingsPage()
	{
		InitializeComponent();
	}

    async void BackBtn_Clicked(System.Object sender, System.EventArgs e)
    {
        await Navigation.PopAsync();
    }

    void SaveBtn_Clicked(System.Object sender, System.EventArgs e)
    {
    }
}
