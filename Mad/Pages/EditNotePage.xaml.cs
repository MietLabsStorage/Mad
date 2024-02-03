namespace Mad.Pages;

public partial class EditNotePage : ContentPage
{
	public EditNotePage(bool isNew)
	{
		InitializeComponent();

		Title = isNew
			? "Создание заметки"
			: "Редактирование заметки";
	}

    private async void BackBtn_Clicked(object sender, EventArgs e)
    {
		await Navigation.PopAsync();
    }

    private async void SaveBtn_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}