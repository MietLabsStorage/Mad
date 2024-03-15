using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Mad.Shared.YaWeather
{
    public class YaWeatherContract
    {
        public static YaWeatherContract Parse(string json)
        {
            return JObject.Parse(json).ToObject<YaWeatherContract>();
        }

        /// <summary>
        /// Ссылки на источник данных
        /// </summary>
        [JsonProperty("YaRefs")]
        public YandexRefs YandexRefs => new YandexRefs();

        /// <summary>
        /// Время сервера в формате Unixtime
        /// </summary>
        [JsonProperty("now")]
        public long Now { get; set; }

        /// <summary>
        /// Время сервера в UTC
        /// </summary>
        [JsonProperty("now_dt")]
        public DateTime NowDt { get; set; }

        /// <summary>
        /// Объект информации о населенном пункте
        /// </summary>
        [JsonProperty("info")]
        public InfoContract Info { get; set; }

        /// <summary>
        /// Объект фактической информации о погоде
        /// </summary>
        [JsonProperty("fact")]
        public FactContract Fact { get; set; }

        /// <summary>
        /// Объект прогнозной информации о погоде
        /// </summary>
        [JsonProperty("forecast")]
        public ForecastContract Forecast { get; set; }
    }
}
