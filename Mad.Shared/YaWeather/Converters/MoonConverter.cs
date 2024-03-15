namespace Mad.Shared.YaWeather.Converters
{
    public static class MoonConverter
    {
        public static string Convert(int moonCode)
        {
            return Convert($"moon-code-{moonCode}");
        }

        public static string Convert(string moonText)
        {
            return moonText switch
            {
                "moon-code-0" => "полнолуние",
                "moon-code-1" => "убывающая луна",
                "moon-code-2" => "убывающая луна",
                "moon-code-3" => "убывающая луна",
                "moon-code-4" => "последняя четверть",
                "moon-code-5" => "убывающая луна",
                "moon-code-6" => "убывающая луна",
                "moon-code-7" => "убывающая луна",
                "moon-code-8" => "новолуние",
                "moon-code-9" => "растущая луна",
                "moon-code-10" => "растущая луна",
                "moon-code-11" => "растущая луна",
                "moon-code-12" => "первая четверть",
                "moon-code-13" => "растущая луна",
                "moon-code-14" => "растущая луна",
                "moon-code-15" => "растущая луна",
                _ => ""
            };
        }

    }
}
