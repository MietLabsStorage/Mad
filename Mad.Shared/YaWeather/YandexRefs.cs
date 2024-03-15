using Newtonsoft.Json;
namespace Mad.Shared.YaWeather
{
    public class YandexRefs
    {
        [JsonProperty("YaSource")]
        public string Source => "По данным сервиса Яндекс.Погода";

        [JsonProperty("YaSourceRef")]
        public string SourceRef => "yandex.ru/pogoda";
    }
}
