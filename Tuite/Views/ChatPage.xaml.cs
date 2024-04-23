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
            this.Title = "����С����";
        });
	}
    //ҳ�沼���¼�
    protected override void LayoutChildren(double x, double y, double width, double height)
    {
        base.LayoutChildren(x, y, width, height);
        CollectionView1.ScrollTo(model.Chat.Last(), position: ScrollToPosition.End);
    }
    //��⵽���ڹ���
    private void CollectionView1_Scrolled(object sender, ItemsViewScrolledEventArgs e)
    {
        if (e.FirstVisibleItemIndex == 0) 
        {
            //������ʷ��Ϣ����

        }
    }
    //���������Ϣ
    private void Button_Clicked(object sender, EventArgs e)
    {

    }
}