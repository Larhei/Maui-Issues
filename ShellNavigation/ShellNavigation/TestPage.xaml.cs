namespace ShellNavigation;

public partial class TestPage : ContentPage
{
	public TestPage()
	{
		InitializeComponent();
		BindingContext = new TestPageViewModel();
	}
}
