using Newtonsoft.Json;

namespace Mad.Shared.YaWeather
{
    public class InfoContract
    {
        /// <summary>
        /// Широта (в градусах)
        /// </summary>
        [JsonProperty("lat")]
        public double Lat { get; set; }

        /// <summary>
        /// Долгота (в градусах)
        /// </summary>
        [JsonProperty("lon")]
        public double Lon { get; set; }

        /// <summary>
        /// Страница населенного пункта на сайте Яндекс.Погода
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }
    }
}
