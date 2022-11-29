using CommunityToolkit.Mvvm.ComponentModel;

namespace BindingDoNothing
{
    public partial class MainPageViewModel : ObservableObject
    {
        [ObservableProperty]
        private string? _text = string.Empty;
    }
}
