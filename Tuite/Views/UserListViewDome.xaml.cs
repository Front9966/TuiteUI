namespace Tuite.Views;
public partial class UserListViewDome : ContentView
{
	public delegate void UserClicked(UserListInfo info);
	public event UserClicked Event_UserClicked;
	public event UserClicked Event_UserButtonClicked;
	public UserListViewDome()
	{
		InitializeComponent();
	}
	//用户被单击
    private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
		Grid a = (Grid)sender;
		UserListInfo b = (UserListInfo)a.BindingContext;
		Event_UserClicked(b);
    }
	//按钮被单击
    private void TapGestureRecognizer_Tapped_1(object sender, TappedEventArgs e)
    {
        Grid a = (Grid)sender;
        UserListInfo b = (UserListInfo)a.BindingContext;
        Event_UserButtonClicked(b);
    }
}