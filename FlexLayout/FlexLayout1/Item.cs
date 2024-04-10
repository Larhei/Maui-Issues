using CommunityToolkit.Mvvm.ComponentModel;

namespace FlexLayout1
{
	public partial class Item : ObservableObject
	{
		[ObservableProperty]
		private bool _show = false;

        [ObservableProperty]
        private string _header = "Header";

        public Item(string v)
        {
            Header = v;
        }
    }
}

