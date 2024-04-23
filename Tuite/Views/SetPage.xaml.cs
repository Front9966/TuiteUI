namespace Tuite.Views;

public partial class SetPage : ContentPage
{
	public SetPage()
	{
		InitializeComponent();
	}
	//修改资料被单击
    private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
        Navigation.PushAsync(new UpdataUserInfoPage());
    }
    //隐私政策被单击
    private void TapGestureRecognizer_Tapped_1(object sender, TappedEventArgs e)
    {
        Navigation.PushAsync(new AppInfoPage("隐私政策"));
    }
    //更新日志被单击
    private void TapGestureRecognizer_Tapped_2(object sender, TappedEventArgs e)
    {
        Navigation.PushAsync(new AppInfoPage("更新日志"));
    }
    //审核规则被单击
    private void TapGestureRecognizer_Tapped_3(object sender, TappedEventArgs e)
    {
        Navigation.PushAsync(new AppInfoPage("审核规则"));
    }
    //清理缓存被单击
    private void TapGestureRecognizer_Tapped_4(object sender, TappedEventArgs e)
    {
        Navigation.PushAsync(new AppInfoPage("清理缓存"));
    }
    //反馈中心被单击
    private void TapGestureRecognizer_Tapped_5(object sender, TappedEventArgs e)
    {
        Navigation.PushAsync(new AppInfoPage("反馈中心"));
    }
    //关于Tuite被单击
    private void TapGestureRecognizer_Tapped_6(object sender, TappedEventArgs e)
    {
        Navigation.PushAsync(new AppInfoPage("关于"));
    }
    //退出登录被单击
    private void Button_Clicked(object sender, EventArgs e)
    {

    }
}