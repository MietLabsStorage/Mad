using Mad.Pages.EditNote;

namespace Mad.Pages.Settings;

public partial class SettingsPage : ContentPage
{
    private readonly SettingsViewModel _settingsViewModel;

    public SettingsPage()
	{
        InitializeComponent();
        _settingsViewModel = Application.Current.MainPage.Handler.MauiContext.Services.GetRequiredService<SettingsViewModel>();
        _settingsViewModel.InitSettingsFieldsAsync(x => TgBotId.Text = x, x => TgUserId.Text = x, x => YaWeatherKey.Text = x);
	}

    async void BackBtn_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }

    async void SaveBtn_Clicked(object sender, EventArgs e)
    {
        await _settingsViewModel.SaveSettingsAsync(TgBotId.Text, TgUserId.Text, YaWeatherKey.Text);
    }
}
