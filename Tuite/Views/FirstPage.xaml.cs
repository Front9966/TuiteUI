using System;
using System.Threading;
namespace Tuite.Views;
public partial class FirstPage : ContentPage
{
    //视图模块绑定对象
    FirstPageModel FirstPageModel { get; set; }
    Timer timer;
    public FirstPage()
	{
        InitializeComponent();
        Task.Run(() =>
        {
            //进行Bind操作
            FirstPageModel = new FirstPageModel();
            this.BindingContext = FirstPageModel;
            //绑定模板View事件
            textClassifyViewDome.textClassify_Event += Tapped;
            postInfoViewDome.Event_HeadImageClicked += Event_PostHeadImageClicked;
            postInfoViewDome.Event_Load += Event_PostLoad;
            postInfoViewDome.Event_PostClicked += Event_PostClicked;
        });

    }
    //页面显示事件
    protected override void OnAppearing()
    {
        base.OnAppearing();
        timer = new Timer(TimerCallBack, null, 5000, 4000);
    }
    //页面消失事件
    protected override void OnDisappearing()
    {
        base.OnDisappearing();
        timer.Dispose();
    }
    public int index = 0;
    //开始间隔执行轮播图循环播放
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
    //窗口开始布局子组件事件
    protected override void LayoutChildren(double x, double y, double width, double height)
    {
        base.LayoutChildren(x, y, width, height);
        RefreshView1.HeightRequest = this.Height - Grid2.Height - 10;
    }
    //轮播图单击事件
    private async void ImageButton_Clicked(object sender, EventArgs e)
    {
        int index = Ad_CarouselView.Position;
        await Launcher.OpenAsync(FirstPageModel.ad_List[index].URL);
    }
    //快捷板块被单击事件
    private void ImageButton_Clicked_1(object sender, EventArgs e)
    {
        ImageButton imageButton = (ImageButton)sender;
        //classify ： 单击的板块信息内容
        Classify classify = (Classify)imageButton.BindingContext;
        //从这里开始跳转快捷板块

    }
    //搜索框单击
    private async void Tap_Tapped(object sender, TappedEventArgs e)
    {
        await Navigation.PushAsync(new SearchPage());
    }
    //分类标签被点击
    private void Tapped(TextClassInfo info) 
    {
        
    }
    //通知内容被单击
    private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {

    }
    //帖子头像被单击
    private void Event_PostHeadImageClicked(PostInfo info)
    {
        
    }
    //帖子加载更多
    private void Event_PostLoad()
    {
        
    }
    //帖子被单击
    private void Event_PostClicked(PostInfo info)
    {
        Navigation.PushAsync(new PostContentPage());
    }
}