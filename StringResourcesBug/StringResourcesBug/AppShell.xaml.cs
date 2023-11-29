namespace StringResourcesBug;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		var x = StringResourcesBug.Resources.Strings.Resource.Test;
	}
}

