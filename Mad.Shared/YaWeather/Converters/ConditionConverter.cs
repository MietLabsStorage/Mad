using Mad.Shared.YaWeather.Enums;

namespace Mad.Shared.YaWeather.Converters
{
    public static class ConditionConverter
    {
        public static Condition Convert(string strCondition)
        {
            return strCondition switch
            {
                "clear" => Condition.Clear,
                "partly-cloudy" => Condition.PartlyCloudly,
                "cloudy" => Condition.Cloudly,
                "overcast" => Condition.Overcast,
                "drizzle" => Condition.Drizzle,
                "light-rain" => Condition.LightRain,
                "rain" => Condition.Rain,
                "moderate-rain" => Condition.ModerateRain,
                "heavy-rain" => Condition.HeavyRain,
                "continuous-heavy-rain" => Condition.ContinuousHeavyRain,
                "showers" => Condition.Showers,
                "wet-snow" => Condition.WetSnow,
                "light-snow" => Condition.LightSnow,
                "snow" => Condition.Snow,
                "snow-showers" => Condition.SnowShowers,
                "hail" => Condition.Hail,
                "thunderstorm" => Condition.Thunderstorm,
                "thunderstorm-with-rain" => Condition.ThunderstormWithRain,
                "thunderstorm-with-hail" => Condition.ThunderstornWithHail,
                _ => Condition.Null
            };
        }
    }
}
