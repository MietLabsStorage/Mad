namespace Mad.Pages.Weather;

public partial class WeatherPage : ContentPage
{
    private readonly WeatherViewModel _weatherViewModel;

    public WeatherPage()
	{
		InitializeComponent();
        _weatherViewModel = Application.Current.MainPage.Handler.MauiContext.Services.GetRequiredService<WeatherViewModel>();
    }

    async void Reload_Clicked(object sender, EventArgs e)
    {
        await _weatherViewModel.LoadWeatherAsync();
    }
}
