namespace Tuite.Views;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
		NavigationPage.SetHasNavigationBar(this,false);
	}
	//����ע��
    private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
		Navigation.PushAsync(new EnrollPage());
    }
}