using Mad.Shared.YaWeather.Enums;

namespace Mad.Shared.YaWeather.Converters
{
    public static class DaytimeConverter
    {
        public static Daytime Convert(string strDaytime)
        {
            return strDaytime switch
            {
                "d" => Daytime.Day,
                "n" => Daytime.Night,
                _ => Daytime.Null,
            };
        }
    }
}
