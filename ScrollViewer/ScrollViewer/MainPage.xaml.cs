namespace ScrollViewer;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
		this.BindingContext = new MainPageViewModel();
	}

	private MainPageViewModel ViewModel
    {
		get
		{
			return this.BindingContext as MainPageViewModel;

        }
	}

    void ContentPage_Loaded(object sender, System.EventArgs e)
    {
		ViewModel.LoadData(Dispatcher);

    }
}


