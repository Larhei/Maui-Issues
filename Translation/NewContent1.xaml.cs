namespace MauiApp2;

public partial class NewContent1
{
	public NewContent1()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
		var button = sender as Button;
		await DisplayAlert("Klick", $"Klicked: {button?.Text}", "Ok");
    }
}