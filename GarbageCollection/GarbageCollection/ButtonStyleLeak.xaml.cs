using System.Diagnostics;

namespace GarbageCollection;

public partial class ButtonStyleLeak : ContentPage
{
    static int count = 0;
    private int id;
    public ButtonStyleLeak()
	{
		InitializeComponent();
        count++;
        id = count;
        Debug.WriteLine($"Created instance of {GetType()}. Id is {id}.");
    }

    ~ButtonStyleLeak()
    {
        Debug.WriteLine($"Called finalizer an instance of {GetType()}. Id is {id}.");
    }
}