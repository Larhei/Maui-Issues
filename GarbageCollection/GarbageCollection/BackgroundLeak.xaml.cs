using System.Diagnostics;

namespace GarbageCollection;

public partial class BackgroundLeak : ContentPage
{
    static int count = 0;
    private int id;
    public BackgroundLeak()
	{
		InitializeComponent();
        count++;
        id = count;
        Debug.WriteLine($"Created instance of {GetType()}. Id is {id}.");
    }

    ~BackgroundLeak()
    {
        Debug.WriteLine($"Called finalizer an instance of {GetType()}. Id is {id}.");
    }
}