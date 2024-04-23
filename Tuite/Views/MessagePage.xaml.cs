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
    //��Ϣ�����ɾ��
    private void SwipeItem_Invoked(object sender, EventArgs e)
    {
        SwipeItem views = (SwipeItem)sender;
        MessageList EventInfo = (MessageList)views.BindingContext;

    }
    //��Ϣ�б����
    private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
        Navigation.PushAsync(new ChatPage());
    }
}