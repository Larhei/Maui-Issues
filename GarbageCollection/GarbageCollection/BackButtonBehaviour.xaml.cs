namespace GarbageCollection;

public partial class BackButtonBehaviour : ContentPage
{
	public BackButtonBehaviour()
	{
		InitializeComponent();
		BindingContext = new TestPageViewModel();
	}
}