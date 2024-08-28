using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrollToNullPointer
{
    public partial class MyViewModel : ObservableObject
    {
        [ObservableProperty]
        public ObservableCollection<string> _items = new ObservableCollection<string>();
        private IDispatcher _dispatcher;
        private Action<object> _scrollAction;

        public MyViewModel(IDispatcher dispatcher, Action<object> scrollAction)
        {
            _dispatcher = dispatcher;
            _scrollAction = scrollAction;
            Task.Run(() => AddAsync());
        }

        private async Task AddAsync()
        {
            while (true)
            {
                await Task.Delay(50);
                var item = Items.Count.ToString();
                _dispatcher.Dispatch(() => {
                    Items.Add(item);
                    _scrollAction(item);
                });
            }
        }
    }
}
