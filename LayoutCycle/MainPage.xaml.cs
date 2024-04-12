

namespace LayoutCycle
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnNavigating(object sender, WebNavigatingEventArgs e)
        {
            DisplayAlert("Navigating","GO","Ok");
        }

        private void OnNavigated(object sender, WebNavigatedEventArgs e)
        {
            DisplayAlert("Navigated", "Done", "Ok");
        }

        private void OnLoaded(object sender, EventArgs e)
        {
            DisplayAlert("Loaded", "Done", "Ok");
        }
    }
}
