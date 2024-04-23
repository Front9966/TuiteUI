namespace Tuite.Views;

public partial class HomePage : ContentPage
{
	private HomePageModel _model;
	public HomePage()
	{
		InitializeComponent();
		Task.Run(() => {
            _model = new HomePageModel();
            this.BindingContext = _model;
        });
    }
    //单击我的收藏
    private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
        Navigation.PushAsync(new ListPage("帖子","收藏","我的收藏"));
    }
    //单击历史浏览
    private void TapGestureRecognizer_Tapped1(object sender, TappedEventArgs e)
    {
        Navigation.PushAsync(new ListPage("帖子","浏览","历史浏览"));
    }
    //单击我的帖子
    private void TapGestureRecognizer_Tapped3(object sender, TappedEventArgs e)
    {
        Navigation.PushAsync(new ListPage("帖子", "我的","我的帖子"));
    }
    //单击关注
    private void TapGestureRecognizer_Tapped4(object sender, TappedEventArgs e)
    {
        Navigation.PushAsync(new ListPage("用户", "关注","关注用户"));
    }
    //单击粉丝
    private void TapGestureRecognizer_Tapped5(object sender, TappedEventArgs e)
    {
        Navigation.PushAsync(new ListPage("用户", "粉丝", "粉丝用户"));
    }
    public int a = 0;
    //打开用户页面
    private void TapGestureRecognizer_Tapped6(object sender, TappedEventArgs e)
    {
        //Navigation.PushAsync(new UserPage(12));
        if (a == 0)
        {
            Navigation.PushAsync(new LoginPage());
            a = 1;
        }
        else if (a == 1) 
        {
            Navigation.PushAsync(new UserPage(12));
            a = 0;
        }
    }
    //单击粉丝
    private void TapGestureRecognizer_Tapped7(object sender, TappedEventArgs e)
    {
        Navigation.PushAsync(new ListPage("评论", "评论", "我的评论"));
    }
    //打开设置页面
    private void TapGestureRecognizer_Tapped8(object sender, TappedEventArgs e)
    {
        Navigation.PushAsync(new SetPage());
    }
}