using Mad.Shared.YaWeather;

namespace Mad.Pages.Weather;

public partial class WeatherPage : ContentPage
{
    private readonly WeatherViewModel _weatherViewModel;
    public YaWeatherContract WeatherContract { get; set; }

    public WeatherPage()
	{
		InitializeComponent();
        _weatherViewModel = Application.Current.MainPage.Handler.MauiContext.Services.GetRequiredService<WeatherViewModel>();
        w1.Text = WeatherContract?.Fact?.Temp.ToString();
        w2.Text = WeatherContract?.Forecast?.Parts.First().TempAvg.ToString();
        w3.Text = WeatherContract?.Forecast?.Parts.Last().TempAvg.ToString();
    }

    async void Reload_Clicked(object sender, EventArgs e)
    {
        WeatherContract = await _weatherViewModel.LoadWeatherAsync();
        w1.Text = WeatherContract?.Fact?.Temp.ToString();
        w2.Text = WeatherContract?.Forecast?.Parts.First().TempAvg.ToString();
        w3.Text = WeatherContract?.Forecast?.Parts.Last().TempAvg.ToString();
    }

    async void BackBtn_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}
