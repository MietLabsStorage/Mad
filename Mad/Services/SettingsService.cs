using Mad.Database;
using Mad.Database.Models;

namespace Mad.Services
{
	public class SettingsService
	{
		private readonly DatabaseContext _databaseContext;
		private readonly Settings _settings;

        public string TgBotId => _settings.TgBotId;
		public string TgUserId => _settings.TgUserId;
		public string YaWetherKey => _settings.YaWeatherKey;

        public SettingsService(DatabaseContext databaseContext)
		{
			_databaseContext = databaseContext;
			_settings = databaseContext.Settings.FirstOrDefault();
			if (_settings is null)
			{
				_settings = new Settings();
				databaseContext.Add(_settings);
				databaseContext.SaveChanges();
			}
		}

		public async Task SaveSettingsAsync(string tgBotId, string tgUserId, string yaWeatherKey)
		{
			_settings.TgBotId = tgBotId;
			_settings.TgUserId = tgUserId;
			_settings.YaWeatherKey = yaWeatherKey;
			await _databaseContext.SaveChangesAsync();
		}
	}
}

