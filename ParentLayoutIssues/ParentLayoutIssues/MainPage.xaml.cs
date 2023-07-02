namespace ParentLayoutIssues;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

    async void Button_Clicked(System.Object sender, System.EventArgs e)
    {
        await Shell.Current.GoToAsync("//Issue1");
    }

}


