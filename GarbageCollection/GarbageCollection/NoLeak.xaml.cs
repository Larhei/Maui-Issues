using System.Diagnostics;

namespace GarbageCollection;

public partial class NoLeak : ContentPage
{
    static int count = 0;
    private int id;
	public NoLeak()
	{
		InitializeComponent();
        count++;
        id = count;
        Debug.WriteLine($"Created instance of {GetType()}. Id is {id}.");
    }

    ~NoLeak()
    {
        Debug.WriteLine($"Called finalizer an instance of {GetType()}. Id is {id}.");
    }
}