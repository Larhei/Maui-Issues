using System.Diagnostics;

namespace ListVirtualisation
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MyViewModel();
        }

        private void ListView_Scrolled(object sender, ScrolledEventArgs e)
        {
#if WINDOWS
            var nativView = ((ListView)sender).Handler.PlatformView as Microsoft.UI.Xaml.Controls.ListView;
            Debug.WriteLine($"Listview has {nativView.ItemsPanelRoot.Children.Count} items");
#endif
        }

        private void CollectionView_Scrolled(object sender, ItemsViewScrolledEventArgs e)
        {
#if WINDOWS
            var nativView = ((CollectionView)sender).Handler.PlatformView as Microsoft.UI.Xaml.Controls.ListView;
            Debug.WriteLine($"CollectionView has {nativView.ItemsPanelRoot.Children.Count} items");
#endif
        }
    }

}
