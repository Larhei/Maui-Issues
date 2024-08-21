namespace ScrollToNullPointer
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MyViewModel(this.Dispatcher, PART_Scroll_ChildAdded);
        }

        private void PART_Scroll_ChildAdded(object item)
        {
            Dispatcher.Dispatch(() => PART_Scroll.ScrollTo(item, ScrollToPosition.MakeVisible, true));
        }
    }

}
