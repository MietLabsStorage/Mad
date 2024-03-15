using Mad.Shared.YaWeather.Converters;
using Mad.Shared.YaWeather.Enums;
using Newtonsoft.Json;

namespace Mad.Shared.YaWeather
{
    public class PartContract
    {
        /// <summary>
        /// Название времени суток
        /// </summary>
        [JsonProperty("part_name")]
        public string PartName { get; set; }

        /// <summary>
        /// Минимальная температура для времени суток (°C)
        /// </summary>
        [JsonProperty("temp_min")]
        public int TempMin { get; set; }

        /// <summary>
        /// Максимальная температура для времени суток (°C)
        /// </summary>
        [JsonProperty("temp_max")]
        public int TempMax { get; set; }

        /// <summary>
        /// Средняя температура для времени суток (°C)
        /// </summary>
        [JsonProperty("temp_avg")]
        public int TempAvg { get; set; }

        /// <summary>
        /// Ощущаемая температура (°C)
        /// </summary>
        [JsonProperty("feels_like")]
        public int FeelsLike { get; set; }

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
        /// Прогнозируемое количество осадков (в мм)
        /// </summary>
        [JsonProperty("prec_mm")]
        public int PrecMm { get; set; }

        /// <summary>
        /// Прогнозируемый период осадков (в минутах)
        /// </summary>
        [JsonProperty("prec_period")]
        public int PrecPeriod { get; set; }

        /// <summary>
        /// Вероятность выпадения осадков
        /// </summary>
        [JsonProperty("prec_prob")]
        public int PrecProb { get; set; }
    }
}
