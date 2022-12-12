using System.Diagnostics;

namespace GarbageCollection;

public partial class MainPage : ContentPage
{
	int count = 0;
	CancellationTokenSource cts;

	public MainPage()
	{
		InitializeComponent();
	}

    protected override void OnNavigatedTo(NavigatedToEventArgs args)
    {
        base.OnNavigatedTo(args);
        cts = new CancellationTokenSource();
		Task.Run(async () =>
		{
			try
			{
				while (true)
				{
                    cts.Token.ThrowIfCancellationRequested();
                    await Task.Delay(2000);
                    await MainThread.InvokeOnMainThreadAsync(() =>
                    {
                        Debug.WriteLine("Force GC");
                        GC.Collect();
                        GC.WaitForPendingFinalizers();
                    });
                }
				
			}
			catch
			{
			}
		});
    }

    protected override void OnNavigatingFrom(NavigatingFromEventArgs args)
    {
		cts?.Dispose();
		cts = null;
        base.OnNavigatingFrom(args);
    }

    private void OnNoLeakClicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("/NoLeak");
    }

    private void OnLeakClicked(object sender, EventArgs e)
	{
		Shell.Current.GoToAsync("/BackgroundLeak");
	}

    private void OnLeak1Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("/ButtonStyleLeak");
    }

    private void OnLeak2Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("/BackButtonBehaviour");
    }
}

