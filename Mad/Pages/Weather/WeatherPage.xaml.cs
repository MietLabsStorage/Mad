namespace Mad.Pages.Weather;

public partial class WeatherPage : ContentPage
{
	public WeatherPage()
	{
		InitializeComponent();
	}

    async void Reload_Clicked(System.Object sender, System.EventArgs e)
    {
		var client = new HttpClient();
		client.DefaultRequestHeaders.Add("X-Yandex-API-Key", "KEY");

		var weatherInfoResponse = await client.GetAsync("https://api.weather.yandex.ru/v2/informers?lat=47&lon=56&lang=ru_RU");
        var weatherInfo = await weatherInfoResponse.Content.ReadAsStringAsync();
    }
}
