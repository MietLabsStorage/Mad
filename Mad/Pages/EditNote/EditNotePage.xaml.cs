namespace Mad.Pages.EditNote;

public partial class EditNotePage : ContentPage
{
    private readonly EditNoteViewModel _editNoteViewModel;
    public EditNotePage(bool isNew)
	{
		InitializeComponent();
		_editNoteViewModel = Application.Current.MainPage.Handler.MauiContext.Services.GetRequiredService<EditNoteViewModel>();

        Title = isNew
            ? "Создать заметку"
            : "Редактировать заметку";
    }

    private async void BackBtn_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }

    private async void SaveBtn_Clicked(object sender, EventArgs e)
    {
		await _editNoteViewModel.SaveNoteAsync(FormTitle.Text, FormDescription.Text);
        await Navigation.PopAsync();
    }

    async void SendToTg_Clicked(object sender, EventArgs e)
    {
        await _editNoteViewModel.SendToTgAsync(FormTitle.Text, FormDescription.Text);
    }
}