using Mad.Shared.YaWeather.Enums;

namespace Mad.Shared.YaWeather.Converters
{
    public static class SeasonConverter
    {
        public static Season Convert(string strSeason)
        {
            return strSeason switch
            {
                "summer" => Season.Summer,
                "autumn" => Season.Autumn,
                "winter" => Season.Winter,
                "spring" => Season.Spring,
                _ => Season.Null,
            };
        }
    }
}
