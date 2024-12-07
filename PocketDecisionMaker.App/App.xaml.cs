using PocketDecisionMaker.App.Views;

namespace PocketDecisionMaker.App;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new AppShell();
		
	}
}
