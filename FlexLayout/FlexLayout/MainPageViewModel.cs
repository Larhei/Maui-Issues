using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using static System.Net.Mime.MediaTypeNames;

namespace FlexLayout
{
	public partial class MainPageViewModel : ObservableObject
    {

        private readonly object _lockObject = new object();

        [ObservableProperty]
		private ObservableCollection<object> _sections = new ObservableCollection<object>();
		Random r = new Random(Guid.NewGuid().GetHashCode());

        public MainPageViewModel()
		{
		}

		public async Task LoadDataAsync()
        {
            var sections = new List<object>();
			
            
            sections.Add(new Tags(0));
            sections.Add(new Tags(1));
           
            await MainThread.InvokeOnMainThreadAsync(() => LoadonUIThread(sections));
        }

        private async void LoadonUIThread(
            List<object> sections)
        {
            foreach (var section in sections)
            {
                await Task.Delay(2000);
                Sections.Add(section);
            }
        }
    }
}

