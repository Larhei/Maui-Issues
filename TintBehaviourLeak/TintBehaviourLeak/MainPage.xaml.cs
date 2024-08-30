using System.Diagnostics;

namespace TintBehaviourLeak;

public partial class MainPage : ContentPage
{
	int count = 0;
    private WeakReference _weakRef;

    public MainPage()
	{
		InitializeComponent();
		var x = new CommunityToolkit.Maui.Behaviors.IconTintColorBehavior() { TintColor = Colors.Red };
		_weakRef = new WeakReference(x);
        Test.Behaviors.Add(x);

    }

	private void OnCounterClicked(object sender, EventArgs e)
	{
		Test.Behaviors.Clear();
		GC.Collect();
		GC.WaitForPendingFinalizers();
        GC.Collect();
        GC.WaitForPendingFinalizers();
        GC.Collect();
        GC.WaitForPendingFinalizers();
        GC.Collect();
        GC.WaitForPendingFinalizers();
        GC.Collect();
        GC.WaitForPendingFinalizers();
        GC.Collect();
        GC.WaitForPendingFinalizers();
        GC.Collect();
        GC.WaitForPendingFinalizers();
        if (_weakRef.IsAlive)
        {
            Debug.WriteLine("Leak?");
        }
    }
}


