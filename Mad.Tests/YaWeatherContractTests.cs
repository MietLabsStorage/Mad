using Mad.Shared.YaWeather;

namespace Mad.Tests
{
    public class YaWeatherContractTests
    {
        public const string Json = "{\"now\":1709975273,\"now_dt\":\"2024-03-09T09:07:53.977720Z\",\"info\":{\"url\":\"https://yandex.ru/pogoda/121511?lat=37\\u0026lon=56\",\"lat\":37,\"lon\":56},\"fact\":{\"obs_time\":1709975273,\"temp\":12,\"feels_like\":8,\"icon\":\"bkn_d\",\"condition\":\"cloudy\",\"wind_speed\":3.3,\"wind_dir\":\"se\",\"pressure_mm\":649,\"pressure_pa\":865,\"humidity\":44,\"daytime\":\"d\",\"polar\":false,\"season\":\"spring\",\"wind_gust\":5.2},\"forecast\":{\"date\":\"2024-03-09\",\"date_ts\":1709929800,\"week\":10,\"sunrise\":\"06:05\",\"sunset\":\"17:47\",\"moon_code\":7,\"moon_text\":\"moon-code-7\",\"parts\":[{\"part_name\":\"evening\",\"temp_min\":4,\"temp_avg\":5,\"temp_max\":5,\"wind_speed\":7.1,\"wind_gust\":11.1,\"wind_dir\":\"n\",\"pressure_mm\":648,\"pressure_pa\":864,\"humidity\":75,\"prec_mm\":0,\"prec_prob\":0,\"prec_period\":240,\"icon\":\"bkn_n\",\"condition\":\"cloudy\",\"feels_like\":-2,\"daytime\":\"n\",\"polar\":false},{\"part_name\":\"night\",\"temp_min\":-1,\"temp_avg\":1,\"temp_max\":3,\"wind_speed\":3.1,\"wind_gust\":5.2,\"wind_dir\":\"n\",\"pressure_mm\":647,\"pressure_pa\":862,\"humidity\":82,\"prec_mm\":0,\"prec_prob\":0,\"prec_period\":480,\"icon\":\"skc_n\",\"condition\":\"clear\",\"feels_like\":-3,\"daytime\":\"n\",\"polar\":false}]}}\r\n";

        [Fact]
        public void TestParse_InputJson_ParsedObject()
        {
            var weatherInfo = YaWeatherContract.Parse(Json);

            Assert.NotNull(weatherInfo);
        }
    }
}