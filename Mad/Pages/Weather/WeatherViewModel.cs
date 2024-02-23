using Mad.Services;

namespace Mad.Pages.Weather
{
    internal class WeatherViewModel
    {
        private readonly SettingsService _settingsService;

        public WeatherViewModel(SettingsService settingsService)
        {
            _settingsService = settingsService;
        }

        public async Task LoadWeatherAsync()
        {
            var client = new HttpClient();
            client.DefaultRequestHeaders.Add("X-Yandex-API-Key", _settingsService.YaWetherKey);

            var weatherInfoResponse = await client.GetAsync("https://api.weather.yandex.ru/v2/informers?lat=37&lon=56&lang=ru_RU");
            var weatherInfo = await weatherInfoResponse.Content.ReadAsStringAsync();
        }
    }
}
