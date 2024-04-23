namespace Tuite.Views;
public partial class ChatPage : ContentPage
{
	public ChatPageModel model;
	public ChatPage()
	{
		InitializeComponent();
		Task.Run(() => { 
			model = new ChatPageModel();
			this.BindingContext = model;
            this.Title = "酷酷的小贤佬";
        });
	}
    //页面布局事件
    protected override void LayoutChildren(double x, double y, double width, double height)
    {
        base.LayoutChildren(x, y, width, height);
        CollectionView1.ScrollTo(model.Chat.Last(), position: ScrollToPosition.End);
    }
    //检测到正在滚动
    private void CollectionView1_Scrolled(object sender, ItemsViewScrolledEventArgs e)
    {
        if (e.FirstVisibleItemIndex == 0) 
        {
            //触发历史消息加载

        }
    }
    //点击发送消息
    private void Button_Clicked(object sender, EventArgs e)
    {

    }
}