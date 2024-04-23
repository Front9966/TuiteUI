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
    //�����ҵ��ղ�
    private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
        Navigation.PushAsync(new ListPage("����","�ղ�","�ҵ��ղ�"));
    }
    //������ʷ���
    private void TapGestureRecognizer_Tapped1(object sender, TappedEventArgs e)
    {
        Navigation.PushAsync(new ListPage("����","���","��ʷ���"));
    }
    //�����ҵ�����
    private void TapGestureRecognizer_Tapped3(object sender, TappedEventArgs e)
    {
        Navigation.PushAsync(new ListPage("����", "�ҵ�","�ҵ�����"));
    }
    //������ע
    private void TapGestureRecognizer_Tapped4(object sender, TappedEventArgs e)
    {
        Navigation.PushAsync(new ListPage("�û�", "��ע","��ע�û�"));
    }
    //������˿
    private void TapGestureRecognizer_Tapped5(object sender, TappedEventArgs e)
    {
        Navigation.PushAsync(new ListPage("�û�", "��˿", "��˿�û�"));
    }
    public int a = 0;
    //���û�ҳ��
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
    //������˿
    private void TapGestureRecognizer_Tapped7(object sender, TappedEventArgs e)
    {
        Navigation.PushAsync(new ListPage("����", "����", "�ҵ�����"));
    }
    //������ҳ��
    private void TapGestureRecognizer_Tapped8(object sender, TappedEventArgs e)
    {
        Navigation.PushAsync(new SetPage());
    }
}