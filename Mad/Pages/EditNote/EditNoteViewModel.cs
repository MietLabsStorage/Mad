using Mad.Database;
using Mad.Services;

namespace Mad.Pages.EditNote
{
    class EditNoteViewModel
    {
        private readonly DatabaseContext _databaseContext;
        private readonly SettingsService _settingsService;

        public EditNoteViewModel(DatabaseContext databaseContext, SettingsService settingsService)
        {
            _databaseContext = databaseContext;
            _settingsService = settingsService;
        }

        public async Task SaveNoteAsync(string title, string desription)
        {
            _databaseContext.Notes.Add(new Database.Models.Note
            {
                Title = title,
                Description = desription,
                CreateDateTime = DateTime.Now,
            });

            await _databaseContext.SaveChangesAsync();
        }

        public async Task SendToTgAsync(string title, string body)
        {
            if (!string.IsNullOrEmpty(_settingsService.TgBotId) && !string.IsNullOrEmpty(_settingsService.TgUserId))
            {
                // TODO: add regex for replace \r without \n to \r\n in body
                var text = $"<b>{title}</b>\r\n{body}";
                var url = $"https://api.telegram.org/bot{_settingsService.TgBotId}/sendMessage?chat_id={_settingsService.TgUserId}&text={text}&parse_mode=html";
                await new HttpClient().GetAsync(url);
                // TODO: process bad results
            }
            else
            {
                // TODO: print Exception
            }
        }
    }
}
