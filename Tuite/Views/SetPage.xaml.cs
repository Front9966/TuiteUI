namespace Tuite.Views;

public partial class SetPage : ContentPage
{
	public SetPage()
	{
		InitializeComponent();
	}
	//�޸����ϱ�����
    private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
        Navigation.PushAsync(new UpdataUserInfoPage());
    }
    //��˽���߱�����
    private void TapGestureRecognizer_Tapped_1(object sender, TappedEventArgs e)
    {
        Navigation.PushAsync(new AppInfoPage("��˽����"));
    }
    //������־������
    private void TapGestureRecognizer_Tapped_2(object sender, TappedEventArgs e)
    {
        Navigation.PushAsync(new AppInfoPage("������־"));
    }
    //��˹��򱻵���
    private void TapGestureRecognizer_Tapped_3(object sender, TappedEventArgs e)
    {
        Navigation.PushAsync(new AppInfoPage("��˹���"));
    }
    //�����汻����
    private void TapGestureRecognizer_Tapped_4(object sender, TappedEventArgs e)
    {
        Navigation.PushAsync(new AppInfoPage("������"));
    }
    //�������ı�����
    private void TapGestureRecognizer_Tapped_5(object sender, TappedEventArgs e)
    {
        Navigation.PushAsync(new AppInfoPage("��������"));
    }
    //����Tuite������
    private void TapGestureRecognizer_Tapped_6(object sender, TappedEventArgs e)
    {
        Navigation.PushAsync(new AppInfoPage("����"));
    }
    //�˳���¼������
    private void Button_Clicked(object sender, EventArgs e)
    {

    }
}