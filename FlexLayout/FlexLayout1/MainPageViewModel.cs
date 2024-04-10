using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;

namespace FlexLayout1
{
	public partial class MainPageViewModel : ObservableObject
    {
        [ObservableProperty]
		private ObservableCollection<object> _sections = new ObservableCollection<object>();

        public MainPageViewModel()
		{
		}

		public async Task LoadDataAsync()
        {
            var sections = new List<object>();
            sections.Add(new Tags(0));
            sections.Add(new Item("Test"));
            sections.Add(new Item("Test"));
            sections.Add(new Item("Test"));
            sections.Add(new Item("Test"));
            sections.Add(new Tags(1));
            sections.Add(new Item("Test"));
            sections.Add(new Item("Test"));
            sections.Add(new Item("Test"));
            sections.Add(new Item("Test"));
            await MainThread.InvokeOnMainThreadAsync(() => LoadonUIThread(sections));
        }

        private async void LoadonUIThread(
            List<object> sections)
        {
            object? last = null;
            foreach (var section in sections)
            {
                var item = last as Item;
                if (item != null)
                {
                    MainThread.BeginInvokeOnMainThread(() => item.Show = true);
                }
                last = section;

                 MainThread.BeginInvokeOnMainThread(() => Sections.Add(last));

            }
           
        }
    }
}

