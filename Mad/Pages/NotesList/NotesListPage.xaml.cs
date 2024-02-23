using Mad.Database.Models;

namespace Mad.Pages.NotesList;

public partial class NotesListPage : ContentPage
{
    private readonly NotesListViewModel _notesListViewModel;
    public IEnumerable<Note> Notes { get; }

	public NotesListPage()
	{
		InitializeComponent();
        _notesListViewModel = Application.Current.MainPage.Handler.MauiContext.Services.GetRequiredService<NotesListViewModel>();
        Notes = _notesListViewModel.LoadNotes();
        foreach (var note in Notes)
        {
            FlexLayout.Children.Add(new Button() { Text = note.Title, HeightRequest = 100 });
        }
    }

    private async void Back_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}