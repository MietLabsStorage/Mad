using Mad.Database;
using Mad.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mad.Pages.Settings
{
    internal class SettingsViewModel
    {
        private readonly SettingsService _settingsService;

        public SettingsViewModel(SettingsService settingsService)
        {
            _settingsService = settingsService;
        }

        public async Task SaveSettingsAsync(string tgBotId, string tgUserId, string yaWeatherKey)
        {
            await _settingsService.SaveSettingsAsync(tgBotId, tgUserId, yaWeatherKey);
        }

        public void InitSettingsFieldsAsync(Action<string> tgBotId, Action<string> tgUserId, Action<string> yaWeatherKey)
        {
            tgBotId(_settingsService.TgBotId);
            tgUserId(_settingsService.TgUserId);
            yaWeatherKey(_settingsService.YaWetherKey);
        }
    }
}
