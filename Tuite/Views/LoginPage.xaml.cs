namespace Tuite.Views;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
		NavigationPage.SetHasNavigationBar(this,false);
	}
	//µ¥»÷×¢²á
    private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
		Navigation.PushAsync(new EnrollPage());
    }
}