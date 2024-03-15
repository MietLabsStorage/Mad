using Newtonsoft.Json;

namespace Mad.Shared.YaWeather
{
    public class ForecastContract
    {
        /// <summary>
        /// Дата прогноза в формате ГГГГ-ММ-ДД
        /// </summary>
        [JsonProperty("date")]
        public DateTime Date { get; set; }

        /// <summary>
        /// Дата прогноза в формате Unixtime
        /// </summary>
        [JsonProperty("date_ts")]
        public long DateTs { get; set; }

        /// <summary>
        /// Порядковый номер недели
        /// </summary>
        [JsonProperty("week")]
        public int Week { get; set; }

        /// <summary>
        /// Время восхода Солнца, локальное время (может отсутствовать для полярных регионов)
        /// </summary>
        [JsonProperty("sunrise")]
        public DateTime Sunrise { get; set; }

        /// <summary>
        /// Время заката Солнца, локальное время (может отсутствовать для полярных регионов)
        /// </summary>
        [JsonProperty("sunset")]
        public DateTime Sunset { get; set; }

        /// <summary>
        /// Код фазы Луны
        /// </summary>
        [JsonProperty("moon_code")]
        public int MoonCode { get; set; }

        /// <summary>
        /// Текстовый код для фазы Луны
        /// </summary>
        [JsonProperty("moon_text")]
        public string MoonText { get; set; }

        /// <summary>
        /// Прогнозы по времени суток
        /// </summary>
        [JsonProperty("parts")]
        public IEnumerable<PartContract> Parts { get; set; }
    }
}
