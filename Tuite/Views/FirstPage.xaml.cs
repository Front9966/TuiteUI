using System;
using System.Threading;
namespace Tuite.Views;
public partial class FirstPage : ContentPage
{
    //��ͼģ��󶨶���
    FirstPageModel FirstPageModel { get; set; }
    Timer timer;
    public FirstPage()
	{
        InitializeComponent();
        Task.Run(() =>
        {
            //����Bind����
            FirstPageModel = new FirstPageModel();
            this.BindingContext = FirstPageModel;
            //��ģ��View�¼�
            textClassifyViewDome.textClassify_Event += Tapped;
            postInfoViewDome.Event_HeadImageClicked += Event_PostHeadImageClicked;
            postInfoViewDome.Event_Load += Event_PostLoad;
            postInfoViewDome.Event_PostClicked += Event_PostClicked;
        });

    }
    //ҳ����ʾ�¼�
    protected override void OnAppearing()
    {
        base.OnAppearing();
        timer = new Timer(TimerCallBack, null, 5000, 4000);
    }
    //ҳ����ʧ�¼�
    protected override void OnDisappearing()
    {
        base.OnDisappearing();
        timer.Dispose();
    }
    public int index = 0;
    //��ʼ���ִ���ֲ�ͼѭ������
    public void TimerCallBack(object sender)
    {
        int lengths = FirstPageModel.ad_List.Count;
        if (index == lengths - 1)
        {
            index = 0;
            Ad_CarouselView.CurrentItem = FirstPageModel.ad_List[index];
        }
        else
        {
            Ad_CarouselView.CurrentItem = FirstPageModel.ad_List[++index];
        }
    }
    //���ڿ�ʼ����������¼�
    protected override void LayoutChildren(double x, double y, double width, double height)
    {
        base.LayoutChildren(x, y, width, height);
        RefreshView1.HeightRequest = this.Height - Grid2.Height - 10;
    }
    //�ֲ�ͼ�����¼�
    private async void ImageButton_Clicked(object sender, EventArgs e)
    {
        int index = Ad_CarouselView.Position;
        await Launcher.OpenAsync(FirstPageModel.ad_List[index].URL);
    }
    //��ݰ�鱻�����¼�
    private void ImageButton_Clicked_1(object sender, EventArgs e)
    {
        ImageButton imageButton = (ImageButton)sender;
        //classify �� �����İ����Ϣ����
        Classify classify = (Classify)imageButton.BindingContext;
        //�����￪ʼ��ת��ݰ��

    }
    //�����򵥻�
    private async void Tap_Tapped(object sender, TappedEventArgs e)
    {
        await Navigation.PushAsync(new SearchPage());
    }
    //�����ǩ�����
    private void Tapped(TextClassInfo info) 
    {
        
    }
    //֪ͨ���ݱ�����
    private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {

    }
    //����ͷ�񱻵���
    private void Event_PostHeadImageClicked(PostInfo info)
    {
        
    }
    //���Ӽ��ظ���
    private void Event_PostLoad()
    {
        
    }
    //���ӱ�����
    private void Event_PostClicked(PostInfo info)
    {
        Navigation.PushAsync(new PostContentPage());
    }
}