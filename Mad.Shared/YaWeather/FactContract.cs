using Mad.Shared.YaWeather.Converters;
using Mad.Shared.YaWeather.Enums;
using Newtonsoft.Json;

namespace Mad.Shared.YaWeather
{
    public class FactContract
    {
        /// <summary>
        /// Температура (°C)
        /// </summary>
        [JsonProperty("temp")]
        public int Temp { get; set; }

        /// <summary>
        /// Ощущаемая температура (°C)
        /// </summary>
        [JsonProperty("feels_like")]
        public int FeelsLike { get; set; }

        /// <summary>
        /// Температура воды (°C).
        /// Параметр возвращается для населенных пунктов, где данная информация актуальна
        /// </summary>
        [JsonProperty("temp_water")]
        public int TempWater { get; set; }

        /// <summary>
        /// Код иконки погоды.
        /// Иконка доступна по адресу https://yastatic.net/weather/i/icons/funky/dark/{значение_из_поля_icon}.svg
        /// </summary>
        [JsonProperty("icon")]
        public string Icon { get; set; }

        /// <summary>
        /// Код расшифровки погодного описания
        /// </summary>
        [JsonProperty("condition")]
        public string Condition { private get; set; }

        public Condition ConditionEnum => ConditionConverter.Convert(Condition);

        /// <summary>
        /// Скорость ветра (в м/с)
        /// </summary>
        [JsonProperty("wind_speed")]
        public double WindSpeed { get; set; }

        /// <summary>
        /// Скорость порывов ветра (в м/с)
        /// </summary>
        [JsonProperty("wind_gust")]
        public double WindGust { get; set; }

        /// <summary>
        /// Направление ветра
        /// </summary>
        [JsonProperty("wind_dir")]
        public string WindDir { private get; set; }

        public WindDir WindDirEnum => WindDirConverter.Convert(WindDir);

        /// <summary>
        /// Давление (в мм рт. ст.)
        /// </summary>
        [JsonProperty("pressure_mm")]
        public int PressureMm { get; set; }

        /// <summary>
        /// Давление (в гектопаскалях)
        /// </summary>
        [JsonProperty("pressure_pa")]
        public int PressurePa { get; set; }

        /// <summary>
        /// Влажность воздуха (в процентах)
        /// </summary>
        [JsonProperty("humidity")]
        public int Humidity { get; set; }

        /// <summary>
        /// Светлое или темное время суток
        /// </summary>
        [JsonProperty("daytime")]
        public string Daytime { private get; set; }

        public Daytime DaytimeEnum => DaytimeConverter.Convert(Daytime);

        /// <summary>
        /// Признак того, что время суток, указанное в поле daytime, является полярным
        /// </summary>
        [JsonProperty("polar")]
        public bool Polar { get; set; }

        /// <summary>
        /// Время года в данном населенном пункте
        /// </summary>
        [JsonProperty("season")]
        public string Season { private get; set; }

        public Season SeasonEnum => SeasonConverter.Convert(Season);

        /// <summary>
        /// Время замера погодных данных в формате Unixtime
        /// </summary>
        [JsonProperty("obs_time")]
        public long ObsTime { get; set; }
    }
}
