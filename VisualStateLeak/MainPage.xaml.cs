namespace VisualStateLeak
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCollectClicked(object sender, EventArgs e)
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        private async void OnLeakClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//LeakingPage");
        }

        private async void OnDontLeakClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//NotLeakingPage");
        }
    }
}