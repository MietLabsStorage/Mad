namespace Mad.Pages;

public partial class EditNotePage : ContentPage
{
	public EditNotePage(bool isNew)
	{
		InitializeComponent();

		Title = isNew
			? "�������� �������"
			: "�������������� �������";
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