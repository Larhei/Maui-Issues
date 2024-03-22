using System.Diagnostics;

namespace VisualStateLeak;

public partial class LeakingPage : ContentPage
{
	public LeakingPage()
	{
		InitializeComponent();
	}

    ~LeakingPage()
    {
        Debug.WriteLine("LeakingPage finalized.");
    }
}