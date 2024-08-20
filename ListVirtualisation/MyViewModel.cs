using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListVirtualisation
{

    public partial class MyViewModel : ObservableObject
    {
        [ObservableProperty]
        ObservableCollection<string> _items = new ObservableCollection<string>() {
            
        };

        public MyViewModel() 
        {
            for (int i = 0; i < 1000; i++)
            {
                _items.Add(i.ToString());
            }
        }
    }
}
