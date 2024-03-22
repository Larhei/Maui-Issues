using System.Diagnostics;

namespace VisualStateLeak;

public partial class NotLeakingPage : ContentPage
{
	public NotLeakingPage()
	{
		InitializeComponent();
	}

	~NotLeakingPage()
	{
		Debug.WriteLine("NotLeakingPage finalized.");
	}
}