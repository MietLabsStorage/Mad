using System.Text;
using System.Text.Json;

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

    async void SendToTg_Clicked(System.Object sender, System.EventArgs e)
    {
        await new HttpClient().GetAsync("https://api.telegram.org/botBOTID/sendMessage?chat_id=USERID&text=hello");
    }
}