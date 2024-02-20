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

        public async Task SendToTg(System.Object sender, System.EventArgs e)
        {
            if (!string.IsNullOrEmpty(_settingsService.TgBotId) && !string.IsNullOrEmpty(_settingsService.TgUserId))
            {
                await new HttpClient().GetAsync("https://api.telegram.org/botBOTID/sendMessage?chat_id=USERID&text=hello");
            }
            else
            {
                // TODO: print Exception
            }
        }
    }
}
