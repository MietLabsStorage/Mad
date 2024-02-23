using Mad.Database;
using Mad.Database.Models;
using Microsoft.EntityFrameworkCore;

namespace Mad.Pages.NotesList
{
    internal class NotesListViewModel
    {
        private readonly DatabaseContext _databaseContext;

        public NotesListViewModel(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        public IEnumerable<Note> LoadNotes()
        {
            return _databaseContext.Notes.OrderByDescending(x => x.CreateDateTime).ToList();
        }
    }
}
