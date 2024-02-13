using Mad.Database;

namespace Mad.Pages.EditNote
{
    class EditNoteViewModel
    {
        private readonly DatabaseContext _databaseContext;

        public EditNoteViewModel(DatabaseContext databaseContext)
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
    }
}
