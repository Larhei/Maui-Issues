using System;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using IntelliJ.Lang.Annotations;

namespace ShellNavigation
{
	public partial class TestPageViewModel : ObservableObject
    {
        private bool _isBusy;

        public bool IsBusy {
            get
            {
                return _isBusy;
            }

            set
            {
                if (SetProperty(ref _isBusy, value))
                {
                    NavigateCommand?.NotifyCanExecuteChanged();
                }
            }
        }

        [RelayCommand(AllowConcurrentExecutions = false, CanExecute = nameof(CanNavigate))]
        private async Task Navigate(CancellationToken token)
        {
           
            IsBusy = true;
            await Shell.Current.Navigation.PopToRootAsync(false);
            IsBusy = false;
        }

        private bool CanNavigate()
        {
            return true;
        }
    }
}

