namespace Tuite.Views;

public partial class MessagePage : ContentPage
{
	private MessagePageModel messagePageModel;
    public MessagePage()
	{
		InitializeComponent();
        Task.Run(() => {
            messagePageModel = new MessagePageModel();
            this.BindingContext = messagePageModel;
        });
    }
    //消息被点击删除
    private void SwipeItem_Invoked(object sender, EventArgs e)
    {
        SwipeItem views = (SwipeItem)sender;
        MessageList EventInfo = (MessageList)views.BindingContext;

    }
    //消息列表被点击
    private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
        Navigation.PushAsync(new ChatPage());
    }
}