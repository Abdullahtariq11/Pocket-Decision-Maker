namespace PocketDecisionMaker.App.Views;

public partial class LandingPage : ContentPage
{
	public LandingPage()
	{
		InitializeComponent();
	}
	private async void OnGetStarted(object sender, EventArgs e)
	{
		//To Navigate
		//await Navigation.PushAsync(new HomePage());

		//To set HomePage As New Main Page
		//Application.Current.MainPage=new NavigationPage(new HomePage());
		// Navigate to HomePage via Shell
    await Shell.Current.GoToAsync("//Home");
	}
}