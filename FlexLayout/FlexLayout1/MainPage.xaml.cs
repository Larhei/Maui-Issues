namespace FlexLayout1;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        BindingContext = new MainPageViewModel();
    }

    public MainPageViewModel? ViewModel
    {
        get
        {
            return BindingContext as MainPageViewModel;
        }
    }

    protected override void OnNavigatedTo(NavigatedToEventArgs args)
    {
        base.OnNavigatedTo(args);

        if (ViewModel == null)
        {
            return;
        }

        Task.Run(ViewModel.LoadDataAsync);

    }

}


