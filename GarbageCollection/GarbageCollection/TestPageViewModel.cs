using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.ComponentModel;

namespace GarbageCollection
{
	public partial class TestPageViewModel : ObservableObject
    {
        [RelayCommand()]
        private async void Navigate()
        {
           await Shell.Current.Navigation.PopToRootAsync(false);
        }

    }
}

