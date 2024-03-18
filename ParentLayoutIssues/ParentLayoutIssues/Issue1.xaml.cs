namespace ParentLayoutIssues;

public partial class Issue1 : ContentPage
{
	public Issue1()
	{
		InitializeComponent();
	}

    async void Button_Clicked(System.Object sender, System.EventArgs e)
    {
        await Shell.Current.GoToAsync("//Issue2");
    }
}
