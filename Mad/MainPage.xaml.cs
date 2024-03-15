using Mad.Pages.Menu;

namespace Mad;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
//		DeviceDisplay.Current.MainDisplayInfoChanged += (sender, e) =>
//		{
//			Shell.Current.DisplayAlert("Orientation", DeviceDisplay.Current.MainDisplayInfo.Orientation.ToString(), "Ok");
////f ANDROID
//			//var activity = ActivityStateManager.Default.GetCurrentActivity();
//            //activity.RequestedOrientation = DeviceDisplay.Current.MainDisplayInfo.Orientation == DisplayOrientation.Landscape ? ScreenOrientation.Landscape : ScreenOrientation.Portrait;
////ndif
//        };
	}

	private async void OnCounterClicked(object sender, EventArgs e)
	{
		count++;

		if (count == 1)
			CounterBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";

		await Navigation.PushAsync(new MenuPage());
	}
}


