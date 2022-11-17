using System;
using Android.Graphics;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
namespace ShellNavigation
{
	public partial class ShellViewModel : ObservableObject
    {
    
		[RelayCommand(AllowConcurrentExecutions = false, CanExecute = nameof(CanNavigate))]
		private async Task Navigate(CancellationToken token)
        {
			await Shell.Current.GoToAsync("/TestPage");
		}

        private bool CanNavigate()
        {
            return true;
        }
    }
}

