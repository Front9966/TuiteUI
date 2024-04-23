namespace Tuite.Views;
public partial class CommentViewDome : ContentView
{
    public delegate void CommentEventType(CommentInfo info);
    public event CommentEventType Event_CommentClicked;
    public CommentViewDome()
	{
        InitializeComponent();
    }
    //»Ø¸´±»µ¥»÷
    private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
        Grid a = (Grid)sender;
        CommentInfo b = (CommentInfo)a.BindingContext;
        Event_CommentClicked(b);
    }
}