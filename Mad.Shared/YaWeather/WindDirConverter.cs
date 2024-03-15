using Mad.Shared.YaWeather.Enums;

namespace Mad.Shared.YaWeather
{
    public static class WindDirConverter
    {
        public static WindDir Convert(string strWindDir)
        {
            return strWindDir switch
            {
                "nw" => WindDir.NordWest,
                "n" => WindDir.Nord,
                "ne" => WindDir.NordEast,
                "e" => WindDir.East,
                "se" => WindDir.SouthEast,
                "s" => WindDir.South,
                "sw" => WindDir.SourhWest,
                "w" => WindDir.West,
                "c" => WindDir.Calm,
                _ => WindDir.Null,
            };
        }
    }
}
